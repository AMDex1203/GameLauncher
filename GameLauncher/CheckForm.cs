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
            GetInfoSystem();
        }

        private async void GetInfoSystem()
        {
            STR_CHECK.Text = InternalLauncher.InternalSTRING.STR_LOADING;
        }



        private static void GetInfoHost()
        {
            
        }
    }
}
