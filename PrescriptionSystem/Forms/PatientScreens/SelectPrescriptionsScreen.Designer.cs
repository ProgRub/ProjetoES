
namespace Forms.PatientScreens
{
    partial class SelectPrescriptionsScreen
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
            this.CheckedListBoxPrescriptions = new System.Windows.Forms.CheckedListBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.CheckBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.ButtonSelectHealthCareProfessionals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CheckedListBoxPrescriptions
            // 
            this.CheckedListBoxPrescriptions.CheckOnClick = true;
            this.CheckedListBoxPrescriptions.ColumnWidth = 500;
            this.CheckedListBoxPrescriptions.FormattingEnabled = true;
            this.CheckedListBoxPrescriptions.Location = new System.Drawing.Point(0, 86);
            this.CheckedListBoxPrescriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckedListBoxPrescriptions.MultiColumn = true;
            this.CheckedListBoxPrescriptions.Name = "CheckedListBoxPrescriptions";
            this.CheckedListBoxPrescriptions.Size = new System.Drawing.Size(746, 310);
            this.CheckedListBoxPrescriptions.TabIndex = 25;
            this.CheckedListBoxPrescriptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxPrescriptions_ItemCheck);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(181, 3);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(460, 47);
            this.LabelTitle.TabIndex = 26;
            this.LabelTitle.Text = "Select the prescriptions to which you want to give vieweing permissions to other " +
    "Health Care Professionals";
            // 
            // CheckBoxSelectAll
            // 
            this.CheckBoxSelectAll.AutoSize = true;
            this.CheckBoxSelectAll.Enabled = false;
            this.CheckBoxSelectAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxSelectAll.Location = new System.Drawing.Point(0, 56);
            this.CheckBoxSelectAll.Name = "CheckBoxSelectAll";
            this.CheckBoxSelectAll.Size = new System.Drawing.Size(92, 25);
            this.CheckBoxSelectAll.TabIndex = 27;
            this.CheckBoxSelectAll.Text = "Select All";
            this.CheckBoxSelectAll.UseVisualStyleBackColor = true;
            this.CheckBoxSelectAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBoxSelectAll_MouseClick);
            // 
            // ButtonSelectHealthCareProfessionals
            // 
            this.ButtonSelectHealthCareProfessionals.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonSelectHealthCareProfessionals.Enabled = false;
            this.ButtonSelectHealthCareProfessionals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSelectHealthCareProfessionals.ForeColor = System.Drawing.Color.White;
            this.ButtonSelectHealthCareProfessionals.Location = new System.Drawing.Point(760, 196);
            this.ButtonSelectHealthCareProfessionals.Name = "ButtonSelectHealthCareProfessionals";
            this.ButtonSelectHealthCareProfessionals.Size = new System.Drawing.Size(172, 76);
            this.ButtonSelectHealthCareProfessionals.TabIndex = 28;
            this.ButtonSelectHealthCareProfessionals.Text = "Select Health Care Professionals";
            this.ButtonSelectHealthCareProfessionals.UseVisualStyleBackColor = false;
            this.ButtonSelectHealthCareProfessionals.Click += new System.EventHandler(this.ButtonSelectHealthCareProfessionals_Click);
            // 
            // SelectPrescriptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonSelectHealthCareProfessionals);
            this.Controls.Add(this.CheckBoxSelectAll);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.CheckedListBoxPrescriptions);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectPrescriptionsScreen";
            this.Size = new System.Drawing.Size(955, 419);
            this.Enter += new System.EventHandler(this.SelectPrescriptionsScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxPrescriptions, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.CheckBoxSelectAll, 0);
            this.Controls.SetChildIndex(this.ButtonSelectHealthCareProfessionals, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBoxPrescriptions;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.CheckBox CheckBoxSelectAll;
        private System.Windows.Forms.Button ButtonSelectHealthCareProfessionals;
    }
}
