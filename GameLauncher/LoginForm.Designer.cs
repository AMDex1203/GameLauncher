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
            this.CLOSEBUTTON = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.InputPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputUsername = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaElclipseLoginForm
            // 
            this.GunaElclipseLoginForm.BorderRadius = 10;
            this.GunaElclipseLoginForm.TargetControl = this;
            // 
            // CLOSEBUTTON
            // 
            this.CLOSEBUTTON.BackgroundImage = global::GameLauncher.Properties.Resources.close_offpoint;
            this.CLOSEBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLOSEBUTTON.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.CLOSEBUTTON.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CLOSEBUTTON.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CLOSEBUTTON.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CLOSEBUTTON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CLOSEBUTTON.FillColor = System.Drawing.Color.Transparent;
            this.CLOSEBUTTON.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSEBUTTON.ForeColor = System.Drawing.Color.White;
            this.CLOSEBUTTON.Location = new System.Drawing.Point(720, 12);
            this.CLOSEBUTTON.Name = "CLOSEBUTTON";
            this.CLOSEBUTTON.Size = new System.Drawing.Size(30, 30);
            this.CLOSEBUTTON.TabIndex = 3;
            this.CLOSEBUTTON.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.CLOSEBUTTON.Click += new System.EventHandler(this.ButtonCloseReact);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = global::GameLauncher.Properties.Resources.logo_type1;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(490, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(184, 184);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // InputPassword
            // 
            this.InputPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputPassword.DefaultText = "";
            this.InputPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputPassword.FillColor = System.Drawing.Color.Transparent;
            this.InputPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputPassword.ForeColor = System.Drawing.Color.White;
            this.InputPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputPassword.IconLeft = global::GameLauncher.Properties.Resources.pass_icon_2;
            this.InputPassword.Location = new System.Drawing.Point(463, 295);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '\0';
            this.InputPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.InputPassword.PlaceholderText = "";
            this.InputPassword.SelectedText = "";
            this.InputPassword.Size = new System.Drawing.Size(234, 35);
            this.InputPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputPassword.TabIndex = 1;
            this.InputPassword.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // InputUsername
            // 
            this.InputUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputUsername.DefaultText = "";
            this.InputUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputUsername.FillColor = System.Drawing.Color.Transparent;
            this.InputUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InputUsername.ForeColor = System.Drawing.Color.White;
            this.InputUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("InputUsername.IconLeft")));
            this.InputUsername.Location = new System.Drawing.Point(463, 231);
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.PasswordChar = '\0';
            this.InputUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.InputUsername.PlaceholderText = "";
            this.InputUsername.SelectedText = "";
            this.InputUsername.Size = new System.Drawing.Size(234, 35);
            this.InputUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputUsername.TabIndex = 0;
            this.InputUsername.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(762, 515);
            this.Controls.Add(this.CLOSEBUTTON);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox InputUsername;
        private Guna.UI2.WinForms.Guna2TextBox InputPassword;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button CLOSEBUTTON;
        private Guna.UI2.WinForms.Guna2Elipse GunaElclipseLoginForm;
    }
}