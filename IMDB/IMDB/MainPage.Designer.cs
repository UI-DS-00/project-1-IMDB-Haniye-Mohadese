namespace IMDB
{
    partial class MainPage
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
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(608, 57);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(73, 27);
            this.lblSignUp.TabIndex = 0;
            this.lblSignUp.Text = "SignUp /";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(676, 57);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 27);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblUserProfile.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfile.Location = new System.Drawing.Point(627, 83);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(89, 27);
            this.lblUserProfile.TabIndex = 2;
            this.lblUserProfile.Text = "UserProfile";
            this.lblUserProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserProfile.Click += new System.EventHandler(this.lblUserProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Andalus", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 122);
            this.label1.TabIndex = 3;
            this.label1.Text = "MADU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::IMDB.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSignUp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUserProfile;
        private System.Windows.Forms.Label label1;
    }
}