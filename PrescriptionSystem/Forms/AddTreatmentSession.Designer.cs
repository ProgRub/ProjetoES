namespace Forms
{
    partial class AddTreatmentSession
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
            this.labelAddTreatmentSession = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.sessionDate = new System.Windows.Forms.DateTimePicker();
            this.labelHour = new System.Windows.Forms.Label();
            this.sessionHour = new System.Windows.Forms.DateTimePicker();
            this.labelLocal = new System.Windows.Forms.Label();
            this.local = new System.Windows.Forms.TextBox();
            this.labelTreatments = new System.Windows.Forms.Label();
            this.buttonAddTreatmentSession = new System.Windows.Forms.Button();
            this.treatments = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelAddTreatmentSession
            // 
            this.labelAddTreatmentSession.AutoSize = true;
            this.labelAddTreatmentSession.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddTreatmentSession.Location = new System.Drawing.Point(87, 34);
            this.labelAddTreatmentSession.Name = "labelAddTreatmentSession";
            this.labelAddTreatmentSession.Size = new System.Drawing.Size(252, 31);
            this.labelAddTreatmentSession.TabIndex = 0;
            this.labelAddTreatmentSession.Text = "Add Treatment Session";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPatient.Location = new System.Drawing.Point(42, 91);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(61, 20);
            this.labelPatient.TabIndex = 1;
            this.labelPatient.Text = "Patient:";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(109, 88);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPatient.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(42, 137);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 20);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date:";
            // 
            // sessionDate
            // 
            this.sessionDate.Location = new System.Drawing.Point(109, 137);
            this.sessionDate.Name = "sessionDate";
            this.sessionDate.Size = new System.Drawing.Size(250, 27);
            this.sessionDate.TabIndex = 4;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(42, 186);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(49, 20);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "Hour:";
            // 
            // sessionHour
            // 
            this.sessionHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sessionHour.Location = new System.Drawing.Point(109, 186);
            this.sessionHour.Name = "sessionHour";
            this.sessionHour.ShowUpDown = true;
            this.sessionHour.Size = new System.Drawing.Size(250, 27);
            this.sessionHour.TabIndex = 6;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocal.Location = new System.Drawing.Point(42, 234);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(48, 20);
            this.labelLocal.TabIndex = 7;
            this.labelLocal.Text = "Local:";
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(109, 231);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(250, 27);
            this.local.TabIndex = 8;
            // 
            // labelTreatments
            // 
            this.labelTreatments.AutoSize = true;
            this.labelTreatments.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTreatments.Location = new System.Drawing.Point(15, 279);
            this.labelTreatments.Name = "labelTreatments";
            this.labelTreatments.Size = new System.Drawing.Size(88, 20);
            this.labelTreatments.TabIndex = 9;
            this.labelTreatments.Text = "Treatments:";
            // 
            // buttonAddTreatmentSession
            // 
            this.buttonAddTreatmentSession.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddTreatmentSession.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTreatmentSession.Location = new System.Drawing.Point(118, 411);
            this.buttonAddTreatmentSession.Name = "buttonAddTreatmentSession";
            this.buttonAddTreatmentSession.Size = new System.Drawing.Size(221, 29);
            this.buttonAddTreatmentSession.TabIndex = 11;
            this.buttonAddTreatmentSession.Text = "Add treatment session";
            this.buttonAddTreatmentSession.UseVisualStyleBackColor = false;
            // 
            // treatments
            // 
            this.treatments.FormattingEnabled = true;
            this.treatments.Location = new System.Drawing.Point(109, 279);
            this.treatments.Name = "treatments";
            this.treatments.Size = new System.Drawing.Size(250, 114);
            this.treatments.TabIndex = 12;
            // 
            // AddTreatmentSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treatments);
            this.Controls.Add(this.buttonAddTreatmentSession);
            this.Controls.Add(this.labelTreatments);
            this.Controls.Add(this.local);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.sessionHour);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.sessionDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelAddTreatmentSession);
            this.Name = "AddTreatmentSession";
            this.Size = new System.Drawing.Size(432, 468);
            this.Controls.SetChildIndex(this.labelAddTreatmentSession, 0);
            this.Controls.SetChildIndex(this.labelPatient, 0);
            this.Controls.SetChildIndex(this.comboBoxPatient, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.sessionDate, 0);
            this.Controls.SetChildIndex(this.labelHour, 0);
            this.Controls.SetChildIndex(this.sessionHour, 0);
            this.Controls.SetChildIndex(this.labelLocal, 0);
            this.Controls.SetChildIndex(this.local, 0);
            this.Controls.SetChildIndex(this.labelTreatments, 0);
            this.Controls.SetChildIndex(this.buttonAddTreatmentSession, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.treatments, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddTreatmentSession;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker sessionDate;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.DateTimePicker sessionHour;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.Label labelTreatments;
        private System.Windows.Forms.Button buttonAddTreatmentSession;
        private System.Windows.Forms.CheckedListBox treatments;
    }
}
