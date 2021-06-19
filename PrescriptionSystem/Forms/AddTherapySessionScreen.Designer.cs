
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
            this.CheckedListBoxTreatments.Location = new System.Drawing.Point(136, 201);
            this.CheckedListBoxTreatments.Name = "CheckedListBoxTreatments";
            this.CheckedListBoxTreatments.Size = new System.Drawing.Size(725, 180);
            this.CheckedListBoxTreatments.TabIndex = 24;
            this.CheckedListBoxTreatments.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxTreatments_ItemCheck);
            // 
            // ButtonAddTherapySession
            // 
            this.ButtonAddTherapySession.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddTherapySession.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTherapySession.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTherapySession.Location = new System.Drawing.Point(391, 422);
            this.ButtonAddTherapySession.Name = "ButtonAddTherapySession";
            this.ButtonAddTherapySession.Size = new System.Drawing.Size(221, 44);
            this.ButtonAddTherapySession.TabIndex = 23;
            this.ButtonAddTherapySession.Text = "Add Therapy Session";
            this.ButtonAddTherapySession.UseVisualStyleBackColor = false;
            this.ButtonAddTherapySession.Click += new System.EventHandler(this.ButtonAddTherapySession_Click);
            // 
            // labelTreatments
            // 
            this.labelTreatments.AutoSize = true;
            this.labelTreatments.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTreatments.Location = new System.Drawing.Point(50, 201);
            this.labelTreatments.Name = "labelTreatments";
            this.labelTreatments.Size = new System.Drawing.Size(88, 20);
            this.labelTreatments.TabIndex = 22;
            this.labelTreatments.Text = "Treatments:";
            // 
            // DateTimePickerSessionHour
            // 
            this.DateTimePickerSessionHour.CustomFormat = "HH:mm";
            this.DateTimePickerSessionHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerSessionHour.Location = new System.Drawing.Point(136, 155);
            this.DateTimePickerSessionHour.Name = "DateTimePickerSessionHour";
            this.DateTimePickerSessionHour.ShowUpDown = true;
            this.DateTimePickerSessionHour.Size = new System.Drawing.Size(222, 27);
            this.DateTimePickerSessionHour.TabIndex = 19;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(87, 163);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(49, 20);
            this.labelHour.TabIndex = 18;
            this.labelHour.Text = "Hour:";
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDate.Location = new System.Drawing.Point(136, 108);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.Size = new System.Drawing.Size(222, 27);
            this.DateTimePickerDate.TabIndex = 17;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(89, 116);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 20);
            this.labelDate.TabIndex = 16;
            this.labelDate.Text = "Date:";
            // 
            // ComboBoxPatient
            // 
            this.ComboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPatient.FormattingEnabled = true;
            this.ComboBoxPatient.Location = new System.Drawing.Point(136, 59);
            this.ComboBoxPatient.Name = "ComboBoxPatient";
            this.ComboBoxPatient.Size = new System.Drawing.Size(725, 28);
            this.ComboBoxPatient.Sorted = true;
            this.ComboBoxPatient.TabIndex = 15;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPatient.Location = new System.Drawing.Point(75, 63);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(61, 20);
            this.labelPatient.TabIndex = 14;
            this.labelPatient.Text = "Patient:";
            // 
            // labelAddTreatmentSession
            // 
            this.labelAddTreatmentSession.AutoSize = true;
            this.labelAddTreatmentSession.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddTreatmentSession.Location = new System.Drawing.Point(391, 12);
            this.labelAddTreatmentSession.Name = "labelAddTreatmentSession";
            this.labelAddTreatmentSession.Size = new System.Drawing.Size(232, 31);
            this.labelAddTreatmentSession.TabIndex = 13;
            this.labelAddTreatmentSession.Text = "Add Therapy Session";
            // 
            // LabelEstimatedDuration
            // 
            this.LabelEstimatedDuration.AutoSize = true;
            this.LabelEstimatedDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEstimatedDuration.Location = new System.Drawing.Point(869, 201);
            this.LabelEstimatedDuration.Name = "LabelEstimatedDuration";
            this.LabelEstimatedDuration.Size = new System.Drawing.Size(144, 20);
            this.LabelEstimatedDuration.TabIndex = 25;
            this.LabelEstimatedDuration.Text = "Estimated Duration:";
            // 
            // LabelSessionDuration
            // 
            this.LabelSessionDuration.AutoSize = true;
            this.LabelSessionDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSessionDuration.Location = new System.Drawing.Point(898, 235);
            this.LabelSessionDuration.Name = "LabelSessionDuration";
            this.LabelSessionDuration.Size = new System.Drawing.Size(65, 20);
            this.LabelSessionDuration.TabIndex = 26;
            this.LabelSessionDuration.Text = "00:00:00";
            // 
            // AddTherapySessionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
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
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddTherapySessionScreen";
            this.Size = new System.Drawing.Size(1075, 675);
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
