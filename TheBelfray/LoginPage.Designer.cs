﻿namespace TheBelfray
{
    partial class LoginPage
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
            this.lblForgotPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picContactInfo = new System.Windows.Forms.PictureBox();
            this.picBelfrayLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picContactInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBelfrayLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgotPW
            // 
            this.lblForgotPW.AutoSize = true;
            this.lblForgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblForgotPW.Location = new System.Drawing.Point(622, 612);
            this.lblForgotPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPW.Name = "lblForgotPW";
            this.lblForgotPW.Size = new System.Drawing.Size(156, 22);
            this.lblForgotPW.TabIndex = 11;
            this.lblForgotPW.Text = "Forgot Password?";
            this.lblForgotPW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(550, 560);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 46);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPassword.Location = new System.Drawing.Point(500, 500);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 41);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsername.Location = new System.Drawing.Point(500, 430);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(400, 41);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // picContactInfo
            // 
            this.picContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.picContactInfo.Image = global::TheBelfray.Properties.Resources.Belfray_Contact_Info_final;
            this.picContactInfo.Location = new System.Drawing.Point(885, 14);
            this.picContactInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picContactInfo.Name = "picContactInfo";
            this.picContactInfo.Size = new System.Drawing.Size(480, 154);
            this.picContactInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContactInfo.TabIndex = 9;
            this.picContactInfo.TabStop = false;
            // 
            // picBelfrayLogo
            // 
            this.picBelfrayLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBelfrayLogo.Image = global::TheBelfray.Properties.Resources.Belfray_Logo;
            this.picBelfrayLogo.Location = new System.Drawing.Point(13, 14);
            this.picBelfrayLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBelfrayLogo.Name = "picBelfrayLogo";
            this.picBelfrayLogo.Size = new System.Drawing.Size(480, 154);
            this.picBelfrayLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBelfrayLogo.TabIndex = 8;
            this.picBelfrayLogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 904);
            this.Controls.Add(this.lblForgotPW);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picContactInfo);
            this.Controls.Add(this.picBelfrayLogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Belfray Country Inn";
            ((System.ComponentModel.ISupportInitialize)(this.picContactInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBelfrayLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picContactInfo;
        private System.Windows.Forms.PictureBox picBelfrayLogo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

