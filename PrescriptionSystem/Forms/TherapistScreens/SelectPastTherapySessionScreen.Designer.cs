
namespace Forms.TherapistScreens
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.FlowLayoutPanelTherapySessions = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonExampleTherapySession
            // 
            this.ButtonExampleTherapySession.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonExampleTherapySession.Enabled = false;
            this.ButtonExampleTherapySession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExampleTherapySession.ForeColor = System.Drawing.Color.White;
            this.ButtonExampleTherapySession.Location = new System.Drawing.Point(80, 52);
            this.ButtonExampleTherapySession.Name = "ButtonExampleTherapySession";
            this.ButtonExampleTherapySession.Size = new System.Drawing.Size(379, 50);
            this.ButtonExampleTherapySession.TabIndex = 6;
            this.ButtonExampleTherapySession.Text = "button1";
            this.ButtonExampleTherapySession.UseVisualStyleBackColor = false;
            this.ButtonExampleTherapySession.Visible = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(52, -4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1204, 46);
            this.LabelTitle.TabIndex = 7;
            this.LabelTitle.Text = "Click a Therapy Session to annotate it, its treatments and check which treatments" +
    " were completed.";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutPanelTherapySessions
            // 
            this.FlowLayoutPanelTherapySessions.AutoScroll = true;
            this.FlowLayoutPanelTherapySessions.Location = new System.Drawing.Point(52, 44);
            this.FlowLayoutPanelTherapySessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlowLayoutPanelTherapySessions.Name = "FlowLayoutPanelTherapySessions";
            this.FlowLayoutPanelTherapySessions.Size = new System.Drawing.Size(1204, 400);
            this.FlowLayoutPanelTherapySessions.TabIndex = 8;
            // 
            // SelectPastTherapySessionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowLayoutPanelTherapySessions);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonExampleTherapySession);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectPastTherapySessionScreen";
            this.Size = new System.Drawing.Size(1259, 446);
            this.Enter += new System.EventHandler(this.SelectPastTherapySessionScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.ButtonExampleTherapySession, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.FlowLayoutPanelTherapySessions, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExampleTherapySession;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelTherapySessions;
    }
}
