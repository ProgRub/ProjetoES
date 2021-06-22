
using Forms.CommonScreens;

namespace Forms
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginScreen1 = new LoginScreen();
            this.SuspendLayout();
            // 
            // loginScreen1
            // 
            this.loginScreen1.AutoSize = true;
            this.loginScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginScreen1.BackColor = System.Drawing.Color.Transparent;
            this.loginScreen1.Location = new System.Drawing.Point(1, -4);
            this.loginScreen1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.loginScreen1.MinimumSize = new System.Drawing.Size(590, 194);
            this.loginScreen1.Name = "loginScreen1";
            this.loginScreen1.Size = new System.Drawing.Size(590, 194);
            this.loginScreen1.TabIndex = 0;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginScreen1);
            this.Name = "Window";
            this.Text = "PrescriptionSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginScreen loginScreen1;
    }
}

