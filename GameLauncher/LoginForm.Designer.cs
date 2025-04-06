namespace GameLauncher
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.GunaElclipseLoginForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.InputPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.LoginButton_Click = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaElclipseLoginForm
            // 
            this.GunaElclipseLoginForm.BorderRadius = 10;
            this.GunaElclipseLoginForm.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = global::GameLauncher.Properties.Resources.logo_type1;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(470, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(184, 184);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // InputPassword
            // 
            this.InputPassword.BackColor = System.Drawing.Color.Transparent;
            this.InputPassword.BorderColor = System.Drawing.Color.White;
            this.InputPassword.BorderThickness = 2;
            this.InputPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputPassword.DefaultText = "";
            this.InputPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputPassword.FillColor = System.Drawing.Color.Transparent;
            this.InputPassword.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.InputPassword.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.InputPassword.ForeColor = System.Drawing.Color.White;
            this.InputPassword.HoverState.BorderColor = System.Drawing.Color.Red;
            this.InputPassword.IconLeft = global::GameLauncher.Properties.Resources.pass_icon_2;
            this.InputPassword.Location = new System.Drawing.Point(445, 289);
            this.InputPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '●';
            this.InputPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.InputPassword.PlaceholderText = "Password";
            this.InputPassword.SelectedText = "";
            this.InputPassword.Size = new System.Drawing.Size(234, 35);
            this.InputPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputPassword.TabIndex = 1;
            this.InputPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.InputPassword.UseSystemPasswordChar = true;
            // 
            // InputUsername
            // 
            this.InputUsername.BackColor = System.Drawing.Color.Transparent;
            this.InputUsername.BorderColor = System.Drawing.Color.White;
            this.InputUsername.BorderThickness = 2;
            this.InputUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputUsername.DefaultText = "";
            this.InputUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputUsername.FillColor = System.Drawing.Color.Transparent;
            this.InputUsername.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.InputUsername.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.InputUsername.ForeColor = System.Drawing.Color.White;
            this.InputUsername.HoverState.BorderColor = System.Drawing.Color.Red;
            this.InputUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("InputUsername.IconLeft")));
            this.InputUsername.Location = new System.Drawing.Point(445, 231);
            this.InputUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.PasswordChar = '\0';
            this.InputUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.InputUsername.PlaceholderText = "Username";
            this.InputUsername.SelectedText = "";
            this.InputUsername.Size = new System.Drawing.Size(234, 35);
            this.InputUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputUsername.TabIndex = 0;
            this.InputUsername.TextOffset = new System.Drawing.Point(5, 0);
            this.InputUsername.TextChanged += new System.EventHandler(this.InputUsername_TextChanged);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CheckBox1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox1.Location = new System.Drawing.Point(445, 335);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(162, 22);
            this.guna2CheckBox1.TabIndex = 4;
            this.guna2CheckBox1.Text = "Remember Username";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // LoginButton_Click
            // 
            this.LoginButton_Click.BorderRadius = 10;
            this.LoginButton_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton_Click.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton_Click.FillColor = System.Drawing.Color.Red;
            this.LoginButton_Click.FillColor2 = System.Drawing.Color.Black;
            this.LoginButton_Click.Font = new System.Drawing.Font("Calibri", 12F);
            this.LoginButton_Click.ForeColor = System.Drawing.Color.White;
            this.LoginButton_Click.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.LoginButton_Click.Location = new System.Drawing.Point(445, 371);
            this.LoginButton_Click.Name = "LoginButton_Click";
            this.LoginButton_Click.PressedColor = System.Drawing.Color.White;
            this.LoginButton_Click.PressedDepth = 40;
            this.LoginButton_Click.Size = new System.Drawing.Size(180, 36);
            this.LoginButton_Click.TabIndex = 5;
            this.LoginButton_Click.Text = "LOGIN";
            this.LoginButton_Click.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.LoginButton_Click.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseButton.CustomIconSize = 15F;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.IconColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(720, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Click += new System.EventHandler(this.ButtonCloseReact);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.CustomIconSize = 15F;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.IconColor = System.Drawing.Color.Red;
            this.MinimizeButton.Location = new System.Drawing.Point(687, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(762, 515);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoginButton_Click);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox InputUsername;
        private Guna.UI2.WinForms.Guna2TextBox InputPassword;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse GunaElclipseLoginForm;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton_Click;
        private Guna.UI2.WinForms.Guna2ControlBox CloseButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
    }
}