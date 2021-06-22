
namespace Forms.PatientScreens
{
    partial class CalendarScreenPatient
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
            this.TextBoxDayEvents = new System.Windows.Forms.TextBox();
            this.ButtonGetPrescriptionHistory = new System.Windows.Forms.Button();
            this.ButtonAddPermission = new System.Windows.Forms.Button();
            this.MonthCalendarPatient = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3);
            this.ButtonBack.Size = new System.Drawing.Size(94, 40);
            this.ButtonBack.Text = "Logout";
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TextBoxDayEvents
            // 
            this.TextBoxDayEvents.BackColor = System.Drawing.Color.White;
            this.TextBoxDayEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDayEvents.Location = new System.Drawing.Point(0, 287);
            this.TextBoxDayEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDayEvents.Multiline = true;
            this.TextBoxDayEvents.Name = "TextBoxDayEvents";
            this.TextBoxDayEvents.Size = new System.Drawing.Size(506, 331);
            this.TextBoxDayEvents.TabIndex = 33;
            // 
            // ButtonGetPrescriptionHistory
            // 
            this.ButtonGetPrescriptionHistory.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonGetPrescriptionHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonGetPrescriptionHistory.ForeColor = System.Drawing.Color.White;
            this.ButtonGetPrescriptionHistory.Location = new System.Drawing.Point(282, 116);
            this.ButtonGetPrescriptionHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGetPrescriptionHistory.Name = "ButtonGetPrescriptionHistory";
            this.ButtonGetPrescriptionHistory.Size = new System.Drawing.Size(222, 44);
            this.ButtonGetPrescriptionHistory.TabIndex = 30;
            this.ButtonGetPrescriptionHistory.Text = "Get Prescription History";
            this.ButtonGetPrescriptionHistory.UseVisualStyleBackColor = false;
            this.ButtonGetPrescriptionHistory.Click += new System.EventHandler(this.ButtonGetPrescriptionHistory_Click);
            // 
            // ButtonAddPermission
            // 
            this.ButtonAddPermission.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonAddPermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddPermission.ForeColor = System.Drawing.Color.White;
            this.ButtonAddPermission.Location = new System.Drawing.Point(282, 64);
            this.ButtonAddPermission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddPermission.Name = "ButtonAddPermission";
            this.ButtonAddPermission.Size = new System.Drawing.Size(222, 44);
            this.ButtonAddPermission.TabIndex = 29;
            this.ButtonAddPermission.Text = "Add Permission";
            this.ButtonAddPermission.UseVisualStyleBackColor = false;
            this.ButtonAddPermission.Click += new System.EventHandler(this.ButtonAddPermission_Click);
            // 
            // MonthCalendarPatient
            // 
            this.MonthCalendarPatient.BackColor = System.Drawing.SystemColors.Window;
            this.MonthCalendarPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthCalendarPatient.Location = new System.Drawing.Point(0, 64);
            this.MonthCalendarPatient.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.MonthCalendarPatient.MaxSelectionCount = 1;
            this.MonthCalendarPatient.Name = "MonthCalendarPatient";
            this.MonthCalendarPatient.TabIndex = 28;
            this.MonthCalendarPatient.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendarPatient_DateChanged);
            // 
            // CalendarScreenPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TextBoxDayEvents);
            this.Controls.Add(this.ButtonGetPrescriptionHistory);
            this.Controls.Add(this.ButtonAddPermission);
            this.Controls.Add(this.MonthCalendarPatient);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CalendarScreenPatient";
            this.Size = new System.Drawing.Size(511, 627);
            this.Enter += new System.EventHandler(this.CalendarScreenPatient_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.MonthCalendarPatient, 0);
            this.Controls.SetChildIndex(this.ButtonAddPermission, 0);
            this.Controls.SetChildIndex(this.ButtonGetPrescriptionHistory, 0);
            this.Controls.SetChildIndex(this.TextBoxDayEvents, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxDayEvents;
        private System.Windows.Forms.Button ButtonGetPrescriptionHistory;
        private System.Windows.Forms.Button ButtonAddPermission;
        private System.Windows.Forms.MonthCalendar MonthCalendarPatient;
    }
}
