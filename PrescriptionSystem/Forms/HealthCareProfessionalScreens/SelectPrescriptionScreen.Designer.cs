
namespace Forms.HealthCareProfessionalScreens
{
    partial class SelectPrescriptionScreen
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonExamplePrescription = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(64, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1376, 68);
            this.LabelTitle.TabIndex = 11;
            this.LabelTitle.Text = "Click a prescription to view its details";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExamplePrescription
            // 
            this.ButtonExamplePrescription.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonExamplePrescription.Enabled = false;
            this.ButtonExamplePrescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExamplePrescription.ForeColor = System.Drawing.Color.White;
            this.ButtonExamplePrescription.Location = new System.Drawing.Point(93, 84);
            this.ButtonExamplePrescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExamplePrescription.Name = "ButtonExamplePrescription";
            this.ButtonExamplePrescription.Size = new System.Drawing.Size(433, 67);
            this.ButtonExamplePrescription.TabIndex = 10;
            this.ButtonExamplePrescription.Text = "button1";
            this.ButtonExamplePrescription.UseVisualStyleBackColor = false;
            this.ButtonExamplePrescription.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1376, 534);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // SelectPrescriptionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonExamplePrescription);
            this.Name = "SelectPrescriptionScreen";
            this.Size = new System.Drawing.Size(1443, 610);
            this.Enter += new System.EventHandler(this.SelectPrescriptionScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.ButtonExamplePrescription, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonExamplePrescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
