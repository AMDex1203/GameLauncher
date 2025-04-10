using GameLauncher.Side.Data;
using GameLauncher.Side.Host;
using GameLauncher.Side.Secure;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void RegisterButton_Click(object sender, EventArgs e)
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

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(reEnterPassword))
                {
                    MessageBox.Show("Semua Data harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (username.Length < 4 || username.Length > 16)
                {
                    MessageBox.Show("Username harus minimal 4 karakter dan maksimal 16 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password.Length < 4 || password.Length > 16)
                {
                    MessageBox.Show("Password harus minimal 4 karakter dan maksimal 16 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!email.Contains("@gmail.com") && !email.Contains("@yahoo.com"))
                {
                    MessageBox.Show("Email harus berupa @gmail.com atau @yahoo.com!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != reEnterPassword)
                {
                    MessageBox.Show("Password & Re Password tidak Sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (verif_human != code_verif_human)
                {
                    MessageBox.Show("Human Code Tidak Valid, Silahkan Isi Secara Tepat !!");
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
                            if (reader["login"].ToString() == username)
                            {
                                MessageBox.Show("Username Telah Digunakan Oleh Pengguna Lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (reader["email"].ToString() == email)
                            {
                                MessageBox.Show("Email Telah Digunakan Oleh Pengguna Lain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            return;
                        }
                    }
                }

                // Save To Database
                query = "INSERT INTO accounts_data (username, password, last_register, last_ip, email, last_hwid, secret_hint) VALUES (@username, @password, @last_register, @last_ip, @email, @last_hwid, @secret_hint)";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@last_ip", lastip);
                        command.Parameters.AddWithValue("@last_register", last_register);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@last_hwid", lasthwid);
                        command.Parameters.AddWithValue("@secret_hint", secret_hint);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Register Berhasil", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = InputUsername.Text;
                string password = InputPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_ID_OR_PASS, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Validations.ValidasiLoginV3(username, password))
                {
                    if (ProgramVersion != Connections.LauncherVersion)
                    {
                        MessageBox.Show(InternalLauncher.InternalSTRING.STR_UPDATE_FIRST, Connections.ProgramNAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        VerificationForm verificationForm = new VerificationForm();
                        verificationForm.Show();
                        this.Hide();
                    }
                        
                }
                else
                {
                    MessageBox.Show(InternalLauncher.InternalSTRING.STR_WRONG_ID_OR_PASS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex);
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
