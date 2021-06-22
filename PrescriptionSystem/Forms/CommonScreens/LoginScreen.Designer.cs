
namespace Forms.CommonScreens
{
    partial class LoginScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.LabelNoAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Enabled = false;
            this.ButtonBack.Visible = false;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEmail.Location = new System.Drawing.Point(62, 26);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(54, 21);
            this.LabelEmail.TabIndex = 0;
            this.LabelEmail.Text = "E-mail";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPassword.Location = new System.Drawing.Point(40, 62);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(76, 21);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxEmail.Location = new System.Drawing.Point(122, 23);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(392, 29);
            this.TextBoxEmail.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(122, 58);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(392, 29);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(235, 107);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(175, 33);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.FlatAppearance.BorderSize = 0;
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSignUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonSignUp.Location = new System.Drawing.Point(371, 146);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(85, 34);
            this.ButtonSignUp.TabIndex = 5;
            this.ButtonSignUp.Text = "Sign Up!";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // LabelNoAccount
            // 
            this.LabelNoAccount.AutoSize = true;
            this.LabelNoAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNoAccount.Location = new System.Drawing.Point(177, 152);
            this.LabelNoAccount.Name = "LabelNoAccount";
            this.LabelNoAccount.Size = new System.Drawing.Size(171, 21);
            this.LabelNoAccount.TabIndex = 6;
            this.LabelNoAccount.Text = "Don\'t have an account?";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelNoAccount);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelEmail);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(300, 190);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(590, 194);
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.Controls.SetChildIndex(this.LabelEmail, 0);
            this.Controls.SetChildIndex(this.LabelPassword, 0);
            this.Controls.SetChildIndex(this.TextBoxEmail, 0);
            this.Controls.SetChildIndex(this.TextBoxPassword, 0);
            this.Controls.SetChildIndex(this.ButtonLogin, 0);
            this.Controls.SetChildIndex(this.ButtonSignUp, 0);
            this.Controls.SetChildIndex(this.LabelNoAccount, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.Label LabelNoAccount;
    }
}
