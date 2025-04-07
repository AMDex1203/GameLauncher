using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameLauncher
{
    public partial class VerificationForm : Form
    {
        private int loadingValue = 0;
        private Timer loadingTimer = new Timer();
        public VerificationForm()
        {
            InitializeComponent();
            
        }
        private async void VerificationForm_Load(object sender, EventArgs e)
        {
            FadedForm.Start();
            await Task.Delay(500);
            loadingTimer.Interval = 15; // interval 10 ms
            loadingTimer.Tick += LoadingTimer_Tick;
            loadingTimer.Start();
        }

        private void FadeinForm(object sender, EventArgs e)
        {
            Opacity += .2;
        }
        private async void LoadingTimer_Tick(object sender, EventArgs e)
        {
            loadingValue += 1;
            if (loadingValue >= 55)
            {
                loadingTimer.Interval = 50;
            }
            if (loadingValue >= 80)
            {
                loadingTimer.Interval = 100;
            }
            if (loadingValue >= 100)
            {
                loadingValue = 100;
                loadingTimer.Stop();
                await Task.Delay(1000);
                MainForm form2 = new MainForm();
                form2.Show();
                this.Close();
            }
            BarLoading.Value = loadingValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BarLoading.Minimum = 0;
            BarLoading.Maximum = 100;
        }
    }
}
