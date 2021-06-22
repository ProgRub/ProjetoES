
namespace Forms.CommonScreens
{
    partial class PrescriptionDetailsScreen
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
            this.TreeViewPrescriptionItems = new System.Windows.Forms.TreeView();
            this.LabelPatientImmutable = new System.Windows.Forms.Label();
            this.LabelToChangePatient = new System.Windows.Forms.Label();
            this.LabelAuthorImmutable = new System.Windows.Forms.Label();
            this.LabelToChangeAuthor = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.LabelStartDate = new System.Windows.Forms.Label();
            this.LabelEndDate = new System.Windows.Forms.Label();
            this.LabelPrescriptionItems = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TreeViewPrescriptionItems
            // 
            this.TreeViewPrescriptionItems.Location = new System.Drawing.Point(591, 133);
            this.TreeViewPrescriptionItems.Name = "TreeViewPrescriptionItems";
            this.TreeViewPrescriptionItems.Size = new System.Drawing.Size(471, 259);
            this.TreeViewPrescriptionItems.TabIndex = 17;
            // 
            // LabelPatientImmutable
            // 
            this.LabelPatientImmutable.AutoSize = true;
            this.LabelPatientImmutable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPatientImmutable.Location = new System.Drawing.Point(95, 12);
            this.LabelPatientImmutable.Name = "LabelPatientImmutable";
            this.LabelPatientImmutable.Size = new System.Drawing.Size(61, 20);
            this.LabelPatientImmutable.TabIndex = 18;
            this.LabelPatientImmutable.Text = "Patient:";
            // 
            // LabelToChangePatient
            // 
            this.LabelToChangePatient.AutoSize = true;
            this.LabelToChangePatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelToChangePatient.Location = new System.Drawing.Point(155, 12);
            this.LabelToChangePatient.Name = "LabelToChangePatient";
            this.LabelToChangePatient.Size = new System.Drawing.Size(61, 20);
            this.LabelToChangePatient.TabIndex = 19;
            this.LabelToChangePatient.Text = "Patient:";
            // 
            // LabelAuthorImmutable
            // 
            this.LabelAuthorImmutable.AutoSize = true;
            this.LabelAuthorImmutable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAuthorImmutable.Location = new System.Drawing.Point(95, 47);
            this.LabelAuthorImmutable.Name = "LabelAuthorImmutable";
            this.LabelAuthorImmutable.Size = new System.Drawing.Size(62, 20);
            this.LabelAuthorImmutable.TabIndex = 20;
            this.LabelAuthorImmutable.Text = "Author:";
            // 
            // LabelToChangeAuthor
            // 
            this.LabelToChangeAuthor.AutoSize = true;
            this.LabelToChangeAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelToChangeAuthor.Location = new System.Drawing.Point(155, 47);
            this.LabelToChangeAuthor.Name = "LabelToChangeAuthor";
            this.LabelToChangeAuthor.Size = new System.Drawing.Size(62, 20);
            this.LabelToChangeAuthor.TabIndex = 21;
            this.LabelToChangeAuthor.Text = "Author:";
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTo.Location = new System.Drawing.Point(303, 89);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(29, 20);
            this.LabelTo.TabIndex = 23;
            this.LabelTo.Text = "To:";
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFrom.Location = new System.Drawing.Point(95, 89);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(49, 20);
            this.LabelFrom.TabIndex = 22;
            this.LabelFrom.Text = "From:";
            // 
            // LabelStartDate
            // 
            this.LabelStartDate.AutoSize = true;
            this.LabelStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelStartDate.Location = new System.Drawing.Point(144, 89);
            this.LabelStartDate.Name = "LabelStartDate";
            this.LabelStartDate.Size = new System.Drawing.Size(73, 20);
            this.LabelStartDate.TabIndex = 24;
            this.LabelStartDate.Text = "StartDate";
            // 
            // LabelEndDate
            // 
            this.LabelEndDate.AutoSize = true;
            this.LabelEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEndDate.Location = new System.Drawing.Point(338, 89);
            this.LabelEndDate.Name = "LabelEndDate";
            this.LabelEndDate.Size = new System.Drawing.Size(67, 20);
            this.LabelEndDate.TabIndex = 25;
            this.LabelEndDate.Text = "EndDate";
            // 
            // LabelPrescriptionItems
            // 
            this.LabelPrescriptionItems.AutoSize = true;
            this.LabelPrescriptionItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPrescriptionItems.Location = new System.Drawing.Point(764, 89);
            this.LabelPrescriptionItems.Name = "LabelPrescriptionItems";
            this.LabelPrescriptionItems.Size = new System.Drawing.Size(131, 20);
            this.LabelPrescriptionItems.TabIndex = 26;
            this.LabelPrescriptionItems.Text = "Prescription Items";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDescription.Location = new System.Drawing.Point(56, 133);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(93, 20);
            this.LabelDescription.TabIndex = 36;
            this.LabelDescription.Text = "Description:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.AcceptsReturn = true;
            this.TextBoxDescription.Location = new System.Drawing.Point(155, 133);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(428, 259);
            this.TextBoxDescription.TabIndex = 35;
            // 
            // PrescriptionDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelPrescriptionItems);
            this.Controls.Add(this.LabelEndDate);
            this.Controls.Add(this.LabelStartDate);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.LabelToChangeAuthor);
            this.Controls.Add(this.LabelAuthorImmutable);
            this.Controls.Add(this.LabelToChangePatient);
            this.Controls.Add(this.LabelPatientImmutable);
            this.Controls.Add(this.TreeViewPrescriptionItems);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PrescriptionDetailsScreen";
            this.Size = new System.Drawing.Size(1315, 573);
            this.Enter += new System.EventHandler(this.PrescriptionDetailsScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.TreeViewPrescriptionItems, 0);
            this.Controls.SetChildIndex(this.LabelPatientImmutable, 0);
            this.Controls.SetChildIndex(this.LabelToChangePatient, 0);
            this.Controls.SetChildIndex(this.LabelAuthorImmutable, 0);
            this.Controls.SetChildIndex(this.LabelToChangeAuthor, 0);
            this.Controls.SetChildIndex(this.LabelFrom, 0);
            this.Controls.SetChildIndex(this.LabelTo, 0);
            this.Controls.SetChildIndex(this.LabelStartDate, 0);
            this.Controls.SetChildIndex(this.LabelEndDate, 0);
            this.Controls.SetChildIndex(this.LabelPrescriptionItems, 0);
            this.Controls.SetChildIndex(this.TextBoxDescription, 0);
            this.Controls.SetChildIndex(this.LabelDescription, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewPrescriptionItems;
        private System.Windows.Forms.Label LabelPatientImmutable;
        private System.Windows.Forms.Label LabelToChangePatient;
        private System.Windows.Forms.Label LabelAuthorImmutable;
        private System.Windows.Forms.Label LabelToChangeAuthor;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.Label LabelStartDate;
        private System.Windows.Forms.Label LabelEndDate;
        private System.Windows.Forms.Label LabelPrescriptionItems;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
    }
}
