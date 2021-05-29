
namespace Forms
{
    partial class CalendarScreenTherapist
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Size = new System.Drawing.Size(71, 29);
            this.ButtonBack.Text = "Logout";
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSignUp.Location = new System.Drawing.Point(249, 41);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(194, 33);
            this.ButtonSignUp.TabIndex = 23;
            this.ButtonSignUp.Text = "Sign Up";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(249, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(249, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(249, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "Sign Up";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 172);
            this.textBox1.TabIndex = 27;
            // 
            // CalendarScreenTherapist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "CalendarScreenTherapist";
            this.Size = new System.Drawing.Size(446, 390);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.ButtonSignUp, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}
