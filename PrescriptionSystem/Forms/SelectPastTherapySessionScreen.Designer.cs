
namespace Forms
{
    partial class SelectPastTherapySessionScreen
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
            this.ButtonExampleTherapySession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonExampleTherapySession
            // 
            this.ButtonExampleTherapySession.Enabled = false;
            this.ButtonExampleTherapySession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExampleTherapySession.Location = new System.Drawing.Point(106, 53);
            this.ButtonExampleTherapySession.Name = "ButtonExampleTherapySession";
            this.ButtonExampleTherapySession.Size = new System.Drawing.Size(379, 50);
            this.ButtonExampleTherapySession.TabIndex = 6;
            this.ButtonExampleTherapySession.Text = "button1";
            this.ButtonExampleTherapySession.UseVisualStyleBackColor = true;
            this.ButtonExampleTherapySession.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click a Therapy Session to annotate it, its treatments and check which treatments" +
    " we\'re completed.";
            // 
            // SelectPastTherapySessionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonExampleTherapySession);
            this.Name = "SelectPastTherapySessionScreen";
            this.Load += new System.EventHandler(this.SelectPastTherapySessionScreen_Load);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.ButtonExampleTherapySession, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExampleTherapySession;
        private System.Windows.Forms.Label label1;
    }
}
