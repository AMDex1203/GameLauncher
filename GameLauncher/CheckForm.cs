using GameLauncher.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        private async void GetInfoSystem(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_LOADING;
                await Task.Delay(1000);
                STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_GET_SUPPORT_FILE;
                await Task.Delay(1000);
                STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_SUCCESS_CHECK;
                await Task.Delay(1000);
            });
            /*LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // atau this.Close();*/
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private static void GetInfoHost()
        {
            
        }
    }
}
