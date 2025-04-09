namespace GameLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormSide = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FadeInMainForm = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Home_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.IsiPesanProject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IntroProject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ImageChange_Box = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GameList_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ImageChanger = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ItemShopButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LogOutButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SettingButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HomeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AccountCenterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ListGameButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TOPUPButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.Home_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageChange_Box)).BeginInit();
            this.GameList_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormSide
            // 
            this.MainFormSide.BorderRadius = 10;
            this.MainFormSide.TargetControl = this;
            // 
            // FadeInMainForm
            // 
            this.FadeInMainForm.Enabled = true;
            this.FadeInMainForm.Tick += new System.EventHandler(this.FadeinMainForm);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Red;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1045, 40);
            this.guna2GradientPanel1.TabIndex = 10;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1003, 7);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 15;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // Home_Panel
            // 
            this.Home_Panel.Controls.Add(this.IsiPesanProject);
            this.Home_Panel.Controls.Add(this.IntroProject);
            this.Home_Panel.Controls.Add(this.guna2HtmlLabel1);
            this.Home_Panel.Controls.Add(this.ImageChange_Box);
            this.Home_Panel.FillColor = System.Drawing.Color.Black;
            this.Home_Panel.Location = new System.Drawing.Point(211, 46);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(822, 657);
            this.Home_Panel.TabIndex = 12;
            // 
            // IsiPesanProject
            // 
            this.IsiPesanProject.AutoSize = false;
            this.IsiPesanProject.BackColor = System.Drawing.Color.Transparent;
            this.IsiPesanProject.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsiPesanProject.ForeColor = System.Drawing.Color.White;
            this.IsiPesanProject.Location = new System.Drawing.Point(34, 365);
            this.IsiPesanProject.Name = "IsiPesanProject";
            this.IsiPesanProject.Size = new System.Drawing.Size(739, 197);
            this.IsiPesanProject.TabIndex = 3;
            this.IsiPesanProject.Text = resources.GetString("IsiPesanProject.Text");
            this.IsiPesanProject.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // IntroProject
            // 
            this.IntroProject.AutoSize = false;
            this.IntroProject.BackColor = System.Drawing.Color.Transparent;
            this.IntroProject.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroProject.ForeColor = System.Drawing.Color.White;
            this.IntroProject.Location = new System.Drawing.Point(68, 314);
            this.IntroProject.Name = "IntroProject";
            this.IntroProject.Size = new System.Drawing.Size(342, 45);
            this.IntroProject.TabIndex = 2;
            this.IntroProject.Text = "Selamat Datang Di Project Kami";
            this.IntroProject.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 263);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(217, 45);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "About Project";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // ImageChange_Box
            // 
            this.ImageChange_Box.BackColor = System.Drawing.Color.Transparent;
            this.ImageChange_Box.BorderRadius = 10;
            this.ImageChange_Box.Image = ((System.Drawing.Image)(resources.GetObject("ImageChange_Box.Image")));
            this.ImageChange_Box.ImageRotate = 0F;
            this.ImageChange_Box.Location = new System.Drawing.Point(10, 6);
            this.ImageChange_Box.Name = "ImageChange_Box";
            this.ImageChange_Box.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.ImageChange_Box.ShadowDecoration.Enabled = true;
            this.ImageChange_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.ImageChange_Box.Size = new System.Drawing.Size(800, 241);
            this.ImageChange_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageChange_Box.TabIndex = 0;
            this.ImageChange_Box.TabStop = false;
            // 
            // GameList_Panel
            // 
            this.GameList_Panel.BorderColor = System.Drawing.Color.Black;
            this.GameList_Panel.Controls.Add(this.guna2GradientButton1);
            this.GameList_Panel.Controls.Add(this.guna2PictureBox2);
            this.GameList_Panel.FillColor = System.Drawing.Color.Black;
            this.GameList_Panel.Location = new System.Drawing.Point(211, 49);
            this.GameList_Panel.Name = "GameList_Panel";
            this.GameList_Panel.Size = new System.Drawing.Size(819, 651);
            this.GameList_Panel.TabIndex = 5;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.Location = new System.Drawing.Point(117, 260);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(129, 45);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "RUN GAME";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BorderRadius = 10;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(34, 69);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.guna2PictureBox2.ShadowDecoration.Enabled = true;
            this.guna2PictureBox2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.guna2PictureBox2.Size = new System.Drawing.Size(300, 168);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // ImageChanger
            // 
            this.ImageChanger.Enabled = true;
            this.ImageChanger.Interval = 5000;
            this.ImageChanger.Tick += new System.EventHandler(this.ImageChager_Timer);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.IndicateFocus = true;
            this.guna2GradientButton3.Location = new System.Drawing.Point(12, 536);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(184, 45);
            this.guna2GradientButton3.TabIndex = 14;
            this.guna2GradientButton3.Text = "MOD OPTION\'S";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.Image")));
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.IndicateFocus = true;
            this.guna2GradientButton2.Location = new System.Drawing.Point(12, 485);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(184, 45);
            this.guna2GradientButton2.TabIndex = 13;
            this.guna2GradientButton2.Text = "GM OPTION\'S";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click_1);
            // 
            // ItemShopButton
            // 
            this.ItemShopButton.Animated = true;
            this.ItemShopButton.BorderRadius = 10;
            this.ItemShopButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ItemShopButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ItemShopButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ItemShopButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ItemShopButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ItemShopButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ItemShopButton.FillColor = System.Drawing.Color.Black;
            this.ItemShopButton.FillColor2 = System.Drawing.Color.Red;
            this.ItemShopButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ItemShopButton.ForeColor = System.Drawing.Color.White;
            this.ItemShopButton.Image = ((System.Drawing.Image)(resources.GetObject("ItemShopButton.Image")));
            this.ItemShopButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemShopButton.IndicateFocus = true;
            this.ItemShopButton.Location = new System.Drawing.Point(12, 309);
            this.ItemShopButton.Name = "ItemShopButton";
            this.ItemShopButton.Size = new System.Drawing.Size(184, 45);
            this.ItemShopButton.TabIndex = 11;
            this.ItemShopButton.Text = "ITEM SHOP";
            this.ItemShopButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemShopButton.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Animated = true;
            this.LogOutButton.BorderRadius = 10;
            this.LogOutButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.LogOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutButton.FillColor = System.Drawing.Color.Black;
            this.LogOutButton.FillColor2 = System.Drawing.Color.Red;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogOutButton.IndicateFocus = true;
            this.LogOutButton.Location = new System.Drawing.Point(12, 658);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(184, 45);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "LOG OUT";
            this.LogOutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogOutButton.TextOffset = new System.Drawing.Point(5, 0);
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Animated = true;
            this.SettingButton.BorderRadius = 10;
            this.SettingButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.SettingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingButton.FillColor = System.Drawing.Color.Black;
            this.SettingButton.FillColor2 = System.Drawing.Color.Red;
            this.SettingButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SettingButton.ForeColor = System.Drawing.Color.White;
            this.SettingButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingButton.Image")));
            this.SettingButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingButton.IndicateFocus = true;
            this.SettingButton.Location = new System.Drawing.Point(12, 607);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(184, 45);
            this.SettingButton.TabIndex = 8;
            this.SettingButton.Text = "SETTING";
            this.SettingButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingButton.TextOffset = new System.Drawing.Point(5, 0);
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Animated = true;
            this.HomeButton.BorderRadius = 10;
            this.HomeButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.Black;
            this.HomeButton.FillColor2 = System.Drawing.Color.Red;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.IndicateFocus = true;
            this.HomeButton.Location = new System.Drawing.Point(12, 207);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(184, 45);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "ABOUT PROJECT";
            this.HomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeButton.TextOffset = new System.Drawing.Point(5, 0);
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // AccountCenterButton
            // 
            this.AccountCenterButton.Animated = true;
            this.AccountCenterButton.BorderRadius = 10;
            this.AccountCenterButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.AccountCenterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AccountCenterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AccountCenterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AccountCenterButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AccountCenterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AccountCenterButton.FillColor = System.Drawing.Color.Black;
            this.AccountCenterButton.FillColor2 = System.Drawing.Color.Red;
            this.AccountCenterButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.AccountCenterButton.ForeColor = System.Drawing.Color.White;
            this.AccountCenterButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountCenterButton.Image")));
            this.AccountCenterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountCenterButton.IndicateFocus = true;
            this.AccountCenterButton.Location = new System.Drawing.Point(12, 411);
            this.AccountCenterButton.Name = "AccountCenterButton";
            this.AccountCenterButton.Size = new System.Drawing.Size(184, 45);
            this.AccountCenterButton.TabIndex = 7;
            this.AccountCenterButton.Text = "MY ACCOUNT";
            this.AccountCenterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountCenterButton.TextOffset = new System.Drawing.Point(5, 0);
            this.AccountCenterButton.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // ListGameButton
            // 
            this.ListGameButton.Animated = true;
            this.ListGameButton.BorderRadius = 10;
            this.ListGameButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ListGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ListGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ListGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ListGameButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ListGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ListGameButton.FillColor = System.Drawing.Color.Black;
            this.ListGameButton.FillColor2 = System.Drawing.Color.Red;
            this.ListGameButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ListGameButton.ForeColor = System.Drawing.Color.White;
            this.ListGameButton.Image = ((System.Drawing.Image)(resources.GetObject("ListGameButton.Image")));
            this.ListGameButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ListGameButton.IndicateFocus = true;
            this.ListGameButton.Location = new System.Drawing.Point(12, 258);
            this.ListGameButton.Name = "ListGameButton";
            this.ListGameButton.Size = new System.Drawing.Size(184, 45);
            this.ListGameButton.TabIndex = 5;
            this.ListGameButton.Text = "GAME LIST";
            this.ListGameButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ListGameButton.TextOffset = new System.Drawing.Point(5, 0);
            this.ListGameButton.Click += new System.EventHandler(this.GameListButton_Click);
            // 
            // TOPUPButton
            // 
            this.TOPUPButton.Animated = true;
            this.TOPUPButton.BorderRadius = 10;
            this.TOPUPButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.TOPUPButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TOPUPButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TOPUPButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TOPUPButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TOPUPButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TOPUPButton.FillColor = System.Drawing.Color.Black;
            this.TOPUPButton.FillColor2 = System.Drawing.Color.Red;
            this.TOPUPButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TOPUPButton.ForeColor = System.Drawing.Color.White;
            this.TOPUPButton.Image = ((System.Drawing.Image)(resources.GetObject("TOPUPButton.Image")));
            this.TOPUPButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TOPUPButton.IndicateFocus = true;
            this.TOPUPButton.Location = new System.Drawing.Point(12, 360);
            this.TOPUPButton.Name = "TOPUPButton";
            this.TOPUPButton.Size = new System.Drawing.Size(184, 45);
            this.TOPUPButton.TabIndex = 6;
            this.TOPUPButton.Text = "TOPUP CENTER";
            this.TOPUPButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TOPUPButton.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::GameLauncher.Properties.Resources.logo_type1;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 37);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(184, 141);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 715);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.ItemShopButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.AccountCenterButton);
            this.Controls.Add(this.ListGameButton);
            this.Controls.Add(this.TOPUPButton);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Home_Panel);
            this.Controls.Add(this.GameList_Panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.Home_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageChange_Box)).EndInit();
            this.GameList_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse MainFormSide;
        private System.Windows.Forms.Timer FadeInMainForm;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton LogOutButton;
        private Guna.UI2.WinForms.Guna2GradientButton SettingButton;
        private Guna.UI2.WinForms.Guna2GradientButton HomeButton;
        private Guna.UI2.WinForms.Guna2GradientButton AccountCenterButton;
        private Guna.UI2.WinForms.Guna2GradientButton ListGameButton;
        private Guna.UI2.WinForms.Guna2GradientButton TOPUPButton;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton ItemShopButton;
        private Guna.UI2.WinForms.Guna2Panel Home_Panel;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Panel GameList_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2PictureBox ImageChange_Box;
        private System.Windows.Forms.Timer ImageChanger;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel IntroProject;
        private Guna.UI2.WinForms.Guna2HtmlLabel IsiPesanProject;
    }
}