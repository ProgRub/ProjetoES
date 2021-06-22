
namespace Forms.HealthCareProfessionalScreens
{
    partial class SelectPatientScreen
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
            this.ButtonExamplePatient = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(72, -8);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1376, 75);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "Click a Patient to view his/her prescriptions";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExamplePatient
            // 
            this.ButtonExamplePatient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonExamplePatient.Enabled = false;
            this.ButtonExamplePatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExamplePatient.ForeColor = System.Drawing.Color.White;
            this.ButtonExamplePatient.Location = new System.Drawing.Point(90, 91);
            this.ButtonExamplePatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExamplePatient.Name = "ButtonExamplePatient";
            this.ButtonExamplePatient.Size = new System.Drawing.Size(433, 67);
            this.ButtonExamplePatient.TabIndex = 8;
            this.ButtonExamplePatient.Text = "button1";
            this.ButtonExamplePatient.UseVisualStyleBackColor = false;
            this.ButtonExamplePatient.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(72, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1376, 534);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // SelectPatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonExamplePatient);
            this.Name = "SelectPatientScreen";
            this.Size = new System.Drawing.Size(1451, 617);
            this.Enter += new System.EventHandler(this.SelectPatientScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonExamplePatient, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonExamplePatient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
