
namespace Forms.TherapistScreens
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
            this.LabelTreatments = new System.Windows.Forms.Label();
            this.DateTimePickerSessionHour = new System.Windows.Forms.DateTimePicker();
            this.LabelHour = new System.Windows.Forms.Label();
            this.DateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.LabelDate = new System.Windows.Forms.Label();
            this.ComboBoxPatient = new System.Windows.Forms.ComboBox();
            this.LabelPatient = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
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
            this.CheckedListBoxTreatments.Size = new System.Drawing.Size(725, 224);
            this.CheckedListBoxTreatments.TabIndex = 24;
            this.CheckedListBoxTreatments.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxTreatments_ItemCheck);
            // 
            // ButtonAddTherapySession
            // 
            this.ButtonAddTherapySession.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddTherapySession.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTherapySession.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTherapySession.Location = new System.Drawing.Point(402, 455);
            this.ButtonAddTherapySession.Name = "ButtonAddTherapySession";
            this.ButtonAddTherapySession.Size = new System.Drawing.Size(221, 44);
            this.ButtonAddTherapySession.TabIndex = 23;
            this.ButtonAddTherapySession.Text = "Add Therapy Session";
            this.ButtonAddTherapySession.UseVisualStyleBackColor = false;
            this.ButtonAddTherapySession.Click += new System.EventHandler(this.ButtonAddTherapySession_Click);
            // 
            // LabelTreatments
            // 
            this.LabelTreatments.AutoSize = true;
            this.LabelTreatments.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTreatments.Location = new System.Drawing.Point(42, 201);
            this.LabelTreatments.Name = "LabelTreatments";
            this.LabelTreatments.Size = new System.Drawing.Size(88, 20);
            this.LabelTreatments.TabIndex = 22;
            this.LabelTreatments.Text = "Treatments:";
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
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelHour.Location = new System.Drawing.Point(81, 155);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(49, 20);
            this.LabelHour.TabIndex = 18;
            this.LabelHour.Text = "Hour:";
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDate.Location = new System.Drawing.Point(136, 108);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.Size = new System.Drawing.Size(222, 27);
            this.DateTimePickerDate.TabIndex = 17;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDate.Location = new System.Drawing.Point(85, 108);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(45, 20);
            this.LabelDate.TabIndex = 16;
            this.LabelDate.Text = "Date:";
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
            // LabelPatient
            // 
            this.LabelPatient.AutoSize = true;
            this.LabelPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPatient.Location = new System.Drawing.Point(69, 59);
            this.LabelPatient.Name = "LabelPatient";
            this.LabelPatient.Size = new System.Drawing.Size(61, 20);
            this.LabelPatient.TabIndex = 14;
            this.LabelPatient.Text = "Patient:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(391, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(232, 31);
            this.LabelTitle.TabIndex = 13;
            this.LabelTitle.Text = "Add Therapy Session";
            // 
            // LabelEstimatedDuration
            // 
            this.LabelEstimatedDuration.AutoSize = true;
            this.LabelEstimatedDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEstimatedDuration.Location = new System.Drawing.Point(883, 277);
            this.LabelEstimatedDuration.Name = "LabelEstimatedDuration";
            this.LabelEstimatedDuration.Size = new System.Drawing.Size(144, 20);
            this.LabelEstimatedDuration.TabIndex = 25;
            this.LabelEstimatedDuration.Text = "Estimated Duration:";
            // 
            // LabelSessionDuration
            // 
            this.LabelSessionDuration.AutoSize = true;
            this.LabelSessionDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelSessionDuration.Location = new System.Drawing.Point(922, 311);
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
            this.Controls.Add(this.LabelTreatments);
            this.Controls.Add(this.DateTimePickerSessionHour);
            this.Controls.Add(this.LabelHour);
            this.Controls.Add(this.DateTimePickerDate);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.ComboBoxPatient);
            this.Controls.Add(this.LabelPatient);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddTherapySessionScreen";
            this.Size = new System.Drawing.Size(1075, 675);
            this.Enter += new System.EventHandler(this.AddTherapySessionScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.LabelPatient, 0);
            this.Controls.SetChildIndex(this.ComboBoxPatient, 0);
            this.Controls.SetChildIndex(this.LabelDate, 0);
            this.Controls.SetChildIndex(this.DateTimePickerDate, 0);
            this.Controls.SetChildIndex(this.LabelHour, 0);
            this.Controls.SetChildIndex(this.DateTimePickerSessionHour, 0);
            this.Controls.SetChildIndex(this.LabelTreatments, 0);
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
        private System.Windows.Forms.Label LabelTreatments;
        private System.Windows.Forms.DateTimePicker DateTimePickerSessionHour;
        private System.Windows.Forms.Label LabelHour;
        private System.Windows.Forms.DateTimePicker DateTimePickerDate;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ComboBox ComboBoxPatient;
        private System.Windows.Forms.Label LabelPatient;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelEstimatedDuration;
        private System.Windows.Forms.Label LabelSessionDuration;
    }
}
