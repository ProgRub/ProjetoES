
namespace Forms.TherapistScreens
{
    partial class CalendarScreenTherapist
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
            this.MonthCalendarTherapist = new System.Windows.Forms.MonthCalendar();
            this.ButtonCreatePrescriptionItem = new System.Windows.Forms.Button();
            this.ButtonCreateTherapySession = new System.Windows.Forms.Button();
            this.ButtonTherapySessionHistory = new System.Windows.Forms.Button();
            this.TextBoxDayEvents = new System.Windows.Forms.TextBox();
            this.ButtonCreatePrescription = new System.Windows.Forms.Button();
            this.ButtonCheckPatientsPrescriptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Teal;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBack.Size = new System.Drawing.Size(81, 29);
            this.ButtonBack.Text = "Logout";
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // MonthCalendarTherapist
            // 
            this.MonthCalendarTherapist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthCalendarTherapist.Location = new System.Drawing.Point(0, 41);
            this.MonthCalendarTherapist.MaxSelectionCount = 1;
            this.MonthCalendarTherapist.Name = "MonthCalendarTherapist";
            this.MonthCalendarTherapist.TabIndex = 6;
            this.MonthCalendarTherapist.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendarTherapist_DateChanged);
            // 
            // ButtonCreatePrescriptionItem
            // 
            this.ButtonCreatePrescriptionItem.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonCreatePrescriptionItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreatePrescriptionItem.ForeColor = System.Drawing.Color.White;
            this.ButtonCreatePrescriptionItem.Location = new System.Drawing.Point(254, 53);
            this.ButtonCreatePrescriptionItem.Name = "ButtonCreatePrescriptionItem";
            this.ButtonCreatePrescriptionItem.Size = new System.Drawing.Size(213, 33);
            this.ButtonCreatePrescriptionItem.TabIndex = 23;
            this.ButtonCreatePrescriptionItem.Text = "Create Prescription Item";
            this.ButtonCreatePrescriptionItem.UseVisualStyleBackColor = false;
            this.ButtonCreatePrescriptionItem.Click += new System.EventHandler(this.ButtonCreatePrescriptionItem_Click);
            // 
            // ButtonCreateTherapySession
            // 
            this.ButtonCreateTherapySession.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonCreateTherapySession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreateTherapySession.ForeColor = System.Drawing.Color.White;
            this.ButtonCreateTherapySession.Location = new System.Drawing.Point(254, 92);
            this.ButtonCreateTherapySession.Name = "ButtonCreateTherapySession";
            this.ButtonCreateTherapySession.Size = new System.Drawing.Size(213, 33);
            this.ButtonCreateTherapySession.TabIndex = 24;
            this.ButtonCreateTherapySession.Text = "Create Therapy Session";
            this.ButtonCreateTherapySession.UseVisualStyleBackColor = false;
            this.ButtonCreateTherapySession.Click += new System.EventHandler(this.ButtonCreateTherapySession_Click);
            // 
            // ButtonTherapySessionHistory
            // 
            this.ButtonTherapySessionHistory.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonTherapySessionHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTherapySessionHistory.ForeColor = System.Drawing.Color.White;
            this.ButtonTherapySessionHistory.Location = new System.Drawing.Point(254, 131);
            this.ButtonTherapySessionHistory.Name = "ButtonTherapySessionHistory";
            this.ButtonTherapySessionHistory.Size = new System.Drawing.Size(213, 33);
            this.ButtonTherapySessionHistory.TabIndex = 25;
            this.ButtonTherapySessionHistory.Text = "Therapy Session History";
            this.ButtonTherapySessionHistory.UseVisualStyleBackColor = false;
            this.ButtonTherapySessionHistory.Click += new System.EventHandler(this.ButtonTherapySessionHistory_Click);
            // 
            // TextBoxDayEvents
            // 
            this.TextBoxDayEvents.BackColor = System.Drawing.Color.White;
            this.TextBoxDayEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDayEvents.Location = new System.Drawing.Point(0, 215);
            this.TextBoxDayEvents.Multiline = true;
            this.TextBoxDayEvents.Name = "TextBoxDayEvents";
            this.TextBoxDayEvents.Size = new System.Drawing.Size(467, 172);
            this.TextBoxDayEvents.TabIndex = 27;
            // 
            // ButtonCreatePrescription
            // 
            this.ButtonCreatePrescription.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonCreatePrescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreatePrescription.ForeColor = System.Drawing.Color.White;
            this.ButtonCreatePrescription.Location = new System.Drawing.Point(254, 14);
            this.ButtonCreatePrescription.Name = "ButtonCreatePrescription";
            this.ButtonCreatePrescription.Size = new System.Drawing.Size(213, 33);
            this.ButtonCreatePrescription.TabIndex = 28;
            this.ButtonCreatePrescription.Text = "Create Prescription";
            this.ButtonCreatePrescription.UseVisualStyleBackColor = false;
            this.ButtonCreatePrescription.Click += new System.EventHandler(this.ButtonCreatePrescription_Click);
            // 
            // ButtonCheckPatientsPrescriptions
            // 
            this.ButtonCheckPatientsPrescriptions.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonCheckPatientsPrescriptions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCheckPatientsPrescriptions.ForeColor = System.Drawing.Color.White;
            this.ButtonCheckPatientsPrescriptions.Location = new System.Drawing.Point(254, 170);
            this.ButtonCheckPatientsPrescriptions.Name = "ButtonCheckPatientsPrescriptions";
            this.ButtonCheckPatientsPrescriptions.Size = new System.Drawing.Size(213, 33);
            this.ButtonCheckPatientsPrescriptions.TabIndex = 29;
            this.ButtonCheckPatientsPrescriptions.Text = "Check Patient\'s Prescriptions";
            this.ButtonCheckPatientsPrescriptions.UseVisualStyleBackColor = false;
            this.ButtonCheckPatientsPrescriptions.Click += new System.EventHandler(this.ButtonCheckPatientsPrescriptions_Click);
            // 
            // CalendarScreenTherapist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonCheckPatientsPrescriptions);
            this.Controls.Add(this.ButtonCreatePrescription);
            this.Controls.Add(this.TextBoxDayEvents);
            this.Controls.Add(this.ButtonTherapySessionHistory);
            this.Controls.Add(this.ButtonCreateTherapySession);
            this.Controls.Add(this.ButtonCreatePrescriptionItem);
            this.Controls.Add(this.MonthCalendarTherapist);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CalendarScreenTherapist";
            this.Size = new System.Drawing.Size(470, 390);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.MonthCalendarTherapist, 0);
            this.Controls.SetChildIndex(this.ButtonCreatePrescriptionItem, 0);
            this.Controls.SetChildIndex(this.ButtonCreateTherapySession, 0);
            this.Controls.SetChildIndex(this.ButtonTherapySessionHistory, 0);
            this.Controls.SetChildIndex(this.TextBoxDayEvents, 0);
            this.Controls.SetChildIndex(this.ButtonCreatePrescription, 0);
            this.Controls.SetChildIndex(this.ButtonCheckPatientsPrescriptions, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendarTherapist;
        private System.Windows.Forms.Button ButtonCreatePrescriptionItem;
        private System.Windows.Forms.Button ButtonCreateTherapySession;
        private System.Windows.Forms.Button ButtonTherapySessionHistory;
        private System.Windows.Forms.TextBox TextBoxDayEvents;
        private System.Windows.Forms.Button ButtonCreatePrescription;
        private System.Windows.Forms.Button ButtonCheckPatientsPrescriptions;
    }
}
