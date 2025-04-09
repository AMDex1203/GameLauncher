using GameLauncher.Side.Host;
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
            Register_Panel.Hide();
            FadeInForm.Start();
            RandomCodeNumber();
            UpdateAllert.Visible = false;
            NotifyUpdate();
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            VerificationForm verificationForm = new VerificationForm();
            verificationForm.Show();
            this.Close();
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
