using GameLauncher.Side.Data;
using GameLauncher.Side.Host;
using GameLauncher.Side.Log;
using GameLauncher.Side.Secure;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class LoginForm : Form
    {
        string ProgramVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            STRINGView();
            Register_Panel.Hide();
            FadeInForm.Start();
            RandomCodeNumber();
            UpdateAllert.Visible = false;
            NotifyUpdate();
        }
        private void STRINGView()
        {
            LoginName.Text = InternalLauncher.InternalSTRING.STR_LOGIN_NAME;
            RegisterButton.Text = InternalLauncher.InternalSTRING.STR_REGISTER_TEXT;
            RegisterText.Text = InternalLauncher.InternalSTRING.STR_REGISTER_NAME;
            ForgotPasswordLink.Text = InternalLauncher.InternalSTRING.STR_FORGOT_PASS;
        }
        private void InputPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // 13 adalah kode ASCII untuk tombol Enter
            {
                LoginButton_Click(sender, e);
                e.Handled = true;
            }
        }
        private void NotifyUpdate()
        {
            if (ProgramVersion != Connections.LauncherVersion)
            {
                UpdateAllert.Visible = true;
                //MessageBox.Show("Update Launcher", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isBlinking = true;
                BlinkIcon.Interval = blinkInterval;
                BlinkIcon.Start();
            }
        }
        private bool isBlinking = false;
        private int blinkInterval = 500; // interval kedipan dalam milidetik

        private void StartBlinking()
        {
            isBlinking = true;
            BlinkIcon.Interval = blinkInterval;
            BlinkIcon.Start();
        }

        private void StopBlinking()
        {
            isBlinking = false;
            BlinkIcon.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isBlinking)
            {
                if (UpdateAllert.Image != null)
                {
                    UpdateAllert.Image.Dispose();
                    UpdateAllert.Image = null;
                }
                else
                {
                    UpdateAllert.Image = Properties.Resources.update_allert; // ganti dengan nama resource icon Anda
                }
            }
        }
        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox Input & String Output
                string username = RegisterUsername.Text.Trim();
                string password = RegisterPass.Text.Trim();
                string reEnterPassword = ReEnterPass.Text.Trim();
                string email = Enter_Email.Text.Trim();
                string verif_human = Enter_HumanCode.Text.Trim();
                string code_verif_human = STR_RANDOM.Text;
                string secret_hint = Enter_SecretHint.Text.Trim();


                string last_register = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string lastip = GetPublicIpAddress.GetPublicIpv4();
                string lasthwid = GetInfoClient.GetHwid();

                string encrypt_password = await Validations.GetHashedPassword(password);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(reEnterPassword))
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_DATA_MUST_FILL, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (username.Length < 4 || username.Length > 16)
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_ID_OR_PASS_LESS_4_WORD, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password.Length < 4 || password.Length > 16)
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_PASS_LESS_4_WORD, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!email.Contains("@gmail.com") && !email.Contains("@yahoo.com"))
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_EMAIL_INSERT, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enter_Email.Text = string.Empty;
                    return;
                }

                if (password != reEnterPassword)
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_REGISTER_PASS_NOT_SAME, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RegisterPass.Text = string.Empty;
                    ReEnterPass.Text = string.Empty;
                    return;
                }

                if (verif_human != code_verif_human)
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_HUMAN_VERIFICATION);
                    Enter_HumanCode.Text = string.Empty;
                    RandomCodeNumber();
                    return;
                }

                string connectionString = Database.HostDatabase.DatabaseConfig;
                string query = "SELECT * FROM accounts_data WHERE username = @username OR email = @email";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);

                        NpgsqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            if (reader["username"].ToString() == username)
                            {
                                MessageBox.Show(InternalLauncher.InternalSTRING.STR_USERNAME_ALREADY_EXIST, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                RegisterUsername.Text = string.Empty;
                            }
                            else if (reader["email"].ToString() == email)
                            {
                                MessageBox.Show(InternalLauncher.InternalSTRING.STR_EMAIL_ALREADY_EXIST, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Enter_Email.Text = string.Empty;
                            }
                            return;
                        }
                    }
                }
                // Save To Database accounts_data
                query = "INSERT INTO accounts_data (username, password, last_register, last_ip, email, last_hwid, secret_hint) VALUES (@username, @password, @last_register, @last_ip, @email, @last_hwid, @secret_hint)";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", encrypt_password);
                        command.Parameters.AddWithValue("@last_ip", lastip);
                        command.Parameters.AddWithValue("@last_register", last_register);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@last_hwid", lasthwid);
                        command.Parameters.AddWithValue("@secret_hint", secret_hint);
                        command.ExecuteNonQuery();
                    }
                }

                // Save To Database accounts
                string accountsConnectionString = Database.HostDatabase.DatabaseGamePanel1;
                query = "INSERT INTO accounts (login, password, lastip, email, hwid) VALUES (@login, @password, @lastip, @email)";
                using (NpgsqlConnection accountsConnection = new NpgsqlConnection(accountsConnectionString))
                {
                    accountsConnection.Open();
                    using (NpgsqlCommand accountsCommand = new NpgsqlCommand(query, accountsConnection))
                    {
                        accountsCommand.Parameters.AddWithValue("@login", username);
                        accountsCommand.Parameters.AddWithValue("@password", encrypt_password);
                        accountsCommand.Parameters.AddWithValue("@lastip", lastip);
                        accountsCommand.Parameters.AddWithValue("@email", email);
                        accountsCommand.Parameters.AddWithValue("@hwid", lasthwid);
                        accountsCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(InternalLauncher.InternalSTRING.STR_REGISTER_SUCCESS);
                RegisterUsername.Text = string.Empty;
                RegisterPass.Text = string.Empty;
                ReEnterPass.Text = string.Empty;
                Enter_Email.Text = string.Empty;
                Enter_HumanCode.Text = string.Empty;
                Enter_SecretHint.Text = string.Empty;

                RandomCodeNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void RegisterText_Click(object sender, EventArgs e)
        {
            Login_Panel.Hide();
            Register_Panel.Show();
        }
        private void RegisterClose_Click(object sender, EventArgs e)
        {
            Register_Panel.Hide();
            Login_Panel.Show();
        }
        private void ButtonCloseReact(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InputUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = InputUsername.Text;
                string password = InputPassword.Text;
                string hashedPassword = await Validations.GetHashedPassword(password);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_ID_OR_PASS, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Log("Password " + hashedPassword);
                    return;
                }
                if (Validations.ValidasiLoginV1(username, hashedPassword))
                {
                    if (ProgramVersion != Connections.LauncherVersion)
                    {
                        MessageBox.Show(InternalLauncher.InternalSTRING.STR_UPDATE_FIRST, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        await Validations.UpdateLastLogin(username);

                        // Simpan username dan password dalam file Secret.dll dengan enkripsi
                        string encryptedData = Encryptions.ChipperEncryption.Encrypt(username + ":" + hashedPassword, "amdex2025");
                        File.WriteAllText("Secret.dll", encryptedData);

                        VerificationForm verificationForm = new VerificationForm();
                        verificationForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_WRONG_ID_OR_PASS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Logger.Log("Login Failed : " + username + "| " + hashedPassword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex);
                //Logger.Log("Login Error : " + ex.Message);
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
        private void FadeinForm(object sender, EventArgs e)
        {
            Opacity += .2;
        }
        private void RandomCodeNumber()
        {
            Random random = new Random();
            string chars = "0123456789";
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                code += chars[random.Next(0, chars.Length)];
            }
            STR_RANDOM.Text = code;
        }
    }
}
