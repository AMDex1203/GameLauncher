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
            this.MainFormSide = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CLOSEBUTTON = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // MainFormSide
            // 
            this.MainFormSide.BorderRadius = 10;
            this.MainFormSide.TargetControl = this;
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
            this.CLOSEBUTTON.Location = new System.Drawing.Point(1003, 3);
            this.CLOSEBUTTON.Name = "CLOSEBUTTON";
            this.CLOSEBUTTON.Size = new System.Drawing.Size(30, 30);
            this.CLOSEBUTTON.TabIndex = 0;
            this.CLOSEBUTTON.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.CLOSEBUTTON.Click += new System.EventHandler(this.ButtonCloseReact);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 715);
            this.Controls.Add(this.CLOSEBUTTON);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse MainFormSide;
        private Guna.UI2.WinForms.Guna2Button CLOSEBUTTON;
    }
}