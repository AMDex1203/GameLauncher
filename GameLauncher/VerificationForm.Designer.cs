namespace GameLauncher
{
    partial class VerificationForm
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
            this.BarLoading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FadedForm = new System.Windows.Forms.Timer(this.components);
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.STR_VALIDATION = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // BarLoading
            // 
            this.BarLoading.BackColor = System.Drawing.Color.Transparent;
            this.BarLoading.BorderRadius = 5;
            this.BarLoading.FillColor = System.Drawing.Color.Gray;
            this.BarLoading.Location = new System.Drawing.Point(12, 460);
            this.BarLoading.Name = "BarLoading";
            this.BarLoading.ProgressColor = System.Drawing.Color.Black;
            this.BarLoading.ProgressColor2 = System.Drawing.Color.Red;
            this.BarLoading.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BarLoading.ShadowDecoration.Enabled = true;
            this.BarLoading.Size = new System.Drawing.Size(738, 10);
            this.BarLoading.TabIndex = 0;
            this.BarLoading.Text = "BarLoading";
            this.BarLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FadedForm
            // 
            this.FadedForm.Tick += new System.EventHandler(this.FadeinForm);
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // STR_VALIDATION
            // 
            this.STR_VALIDATION.AutoSize = false;
            this.STR_VALIDATION.BackColor = System.Drawing.Color.Transparent;
            this.STR_VALIDATION.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR_VALIDATION.ForeColor = System.Drawing.Color.Red;
            this.STR_VALIDATION.Location = new System.Drawing.Point(12, 407);
            this.STR_VALIDATION.Name = "STR_VALIDATION";
            this.STR_VALIDATION.Size = new System.Drawing.Size(157, 47);
            this.STR_VALIDATION.TabIndex = 1;
            this.STR_VALIDATION.Text = "Loading...";
            this.STR_VALIDATION.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // VerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(762, 515);
            this.Controls.Add(this.STR_VALIDATION);
            this.Controls.Add(this.BarLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerificationForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificationForm";
            this.Load += new System.EventHandler(this.VerificationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar BarLoading;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer FadedForm;
        private System.Windows.Forms.Timer LoadingTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel STR_VALIDATION;
    }
}