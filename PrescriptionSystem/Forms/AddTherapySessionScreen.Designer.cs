
namespace Forms
{
    partial class AddTherapySessionScreen
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
            this.CheckedListBoxTreatments = new System.Windows.Forms.CheckedListBox();
            this.ButtonAddTherapySession = new System.Windows.Forms.Button();
            this.labelTreatments = new System.Windows.Forms.Label();
            this.DateTimePickerSessionHour = new System.Windows.Forms.DateTimePicker();
            this.labelHour = new System.Windows.Forms.Label();
            this.DateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.ComboBoxPatient = new System.Windows.Forms.ComboBox();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelAddTreatmentSession = new System.Windows.Forms.Label();
            this.LabelEstimatedDuration = new System.Windows.Forms.Label();
            this.LabelSessionDuration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CheckedListBoxTreatments
            // 
            this.CheckedListBoxTreatments.CheckOnClick = true;
            this.CheckedListBoxTreatments.FormattingEnabled = true;
            this.CheckedListBoxTreatments.Location = new System.Drawing.Point(119, 151);
            this.CheckedListBoxTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckedListBoxTreatments.Name = "CheckedListBoxTreatments";
            this.CheckedListBoxTreatments.Size = new System.Drawing.Size(361, 166);
            this.CheckedListBoxTreatments.TabIndex = 24;
            this.CheckedListBoxTreatments.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxTreatments_ItemCheck);
            // 
            // ButtonAddTherapySession
            // 
            this.ButtonAddTherapySession.BackColor = System.Drawing.Color.ForestGreen;
            this.ButtonAddTherapySession.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTherapySession.Location = new System.Drawing.Point(197, 333);
            this.ButtonAddTherapySession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddTherapySession.Name = "ButtonAddTherapySession";
            this.ButtonAddTherapySession.Size = new System.Drawing.Size(193, 22);
            this.ButtonAddTherapySession.TabIndex = 23;
            this.ButtonAddTherapySession.Text = "Add Therapy Session";
            this.ButtonAddTherapySession.UseVisualStyleBackColor = false;
            this.ButtonAddTherapySession.Click += new System.EventHandler(this.ButtonAddTherapySession_Click);
            // 
            // labelTreatments
            // 
            this.labelTreatments.AutoSize = true;
            this.labelTreatments.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTreatments.Location = new System.Drawing.Point(44, 151);
            this.labelTreatments.Name = "labelTreatments";
            this.labelTreatments.Size = new System.Drawing.Size(69, 15);
            this.labelTreatments.TabIndex = 22;
            this.labelTreatments.Text = "Treatments:";
            // 
            // DateTimePickerSessionHour
            // 
            this.DateTimePickerSessionHour.CustomFormat = "HH:mm";
            this.DateTimePickerSessionHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerSessionHour.Location = new System.Drawing.Point(119, 116);
            this.DateTimePickerSessionHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerSessionHour.Name = "DateTimePickerSessionHour";
            this.DateTimePickerSessionHour.ShowUpDown = true;
            this.DateTimePickerSessionHour.Size = new System.Drawing.Size(361, 23);
            this.DateTimePickerSessionHour.TabIndex = 19;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(76, 122);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(37, 15);
            this.labelHour.TabIndex = 18;
            this.labelHour.Text = "Hour:";
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDate.Location = new System.Drawing.Point(119, 81);
            this.DateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.Size = new System.Drawing.Size(361, 23);
            this.DateTimePickerDate.TabIndex = 17;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(78, 87);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 15);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date:";
            // 
            // ComboBoxPatient
            // 
            this.ComboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPatient.FormattingEnabled = true;
            this.ComboBoxPatient.Location = new System.Drawing.Point(119, 44);
            this.ComboBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxPatient.Name = "ComboBoxPatient";
            this.ComboBoxPatient.Size = new System.Drawing.Size(361, 23);
            this.ComboBoxPatient.Sorted = true;
            this.ComboBoxPatient.TabIndex = 15;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPatient.Location = new System.Drawing.Point(66, 47);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(47, 15);
            this.labelPatient.TabIndex = 14;
            this.labelPatient.Text = "Patient:";
            // 
            // labelAddTreatmentSession
            // 
            this.labelAddTreatmentSession.AutoSize = true;
            this.labelAddTreatmentSession.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddTreatmentSession.Location = new System.Drawing.Point(201, 1);
            this.labelAddTreatmentSession.Name = "labelAddTreatmentSession";
            this.labelAddTreatmentSession.Size = new System.Drawing.Size(189, 25);
            this.labelAddTreatmentSession.TabIndex = 13;
            this.labelAddTreatmentSession.Text = "Add Therapy Session";
            // 
            // LabelEstimatedDuration
            // 
            this.LabelEstimatedDuration.AutoSize = true;
            this.LabelEstimatedDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEstimatedDuration.Location = new System.Drawing.Point(496, 151);
            this.LabelEstimatedDuration.Name = "LabelEstimatedDuration";
            this.LabelEstimatedDuration.Size = new System.Drawing.Size(112, 15);
            this.LabelEstimatedDuration.TabIndex = 25;
            this.LabelEstimatedDuration.Text = "Estimated Duration:";
            // 
            // LabelSessionDuration
            // 
            this.LabelSessionDuration.AutoSize = true;
            this.LabelSessionDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSessionDuration.Location = new System.Drawing.Point(522, 176);
            this.LabelSessionDuration.Name = "LabelSessionDuration";
            this.LabelSessionDuration.Size = new System.Drawing.Size(55, 15);
            this.LabelSessionDuration.TabIndex = 26;
            this.LabelSessionDuration.Text = "00:00:00";
            // 
            // AddTherapySessionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelSessionDuration);
            this.Controls.Add(this.LabelEstimatedDuration);
            this.Controls.Add(this.CheckedListBoxTreatments);
            this.Controls.Add(this.ButtonAddTherapySession);
            this.Controls.Add(this.labelTreatments);
            this.Controls.Add(this.DateTimePickerSessionHour);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.DateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.ComboBoxPatient);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelAddTreatmentSession);
            this.Name = "AddTherapySessionScreen";
            this.Size = new System.Drawing.Size(761, 419);
            this.Load += new System.EventHandler(this.AddTherapySessionScreen_Load);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.labelAddTreatmentSession, 0);
            this.Controls.SetChildIndex(this.labelPatient, 0);
            this.Controls.SetChildIndex(this.ComboBoxPatient, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.DateTimePickerDate, 0);
            this.Controls.SetChildIndex(this.labelHour, 0);
            this.Controls.SetChildIndex(this.DateTimePickerSessionHour, 0);
            this.Controls.SetChildIndex(this.labelTreatments, 0);
            this.Controls.SetChildIndex(this.ButtonAddTherapySession, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxTreatments, 0);
            this.Controls.SetChildIndex(this.LabelEstimatedDuration, 0);
            this.Controls.SetChildIndex(this.LabelSessionDuration, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBoxTreatments;
        private System.Windows.Forms.Button ButtonAddTherapySession;
        private System.Windows.Forms.Label labelTreatments;
        private System.Windows.Forms.DateTimePicker DateTimePickerSessionHour;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.DateTimePicker DateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox ComboBoxPatient;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelAddTreatmentSession;
        private System.Windows.Forms.Label LabelEstimatedDuration;
        private System.Windows.Forms.Label LabelSessionDuration;
    }
}
