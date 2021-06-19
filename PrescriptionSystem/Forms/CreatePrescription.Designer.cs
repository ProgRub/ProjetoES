namespace Forms
{
    partial class CreatePrescription
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.checkedListBoxMedicine = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxTreatment = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxExercise = new System.Windows.Forms.CheckedListBox();
            this.labelMedicine = new System.Windows.Forms.Label();
            this.labelTreatment = new System.Windows.Forms.Label();
            this.labelExercise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create prescription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsReturn = true;
            this.textBoxDescription.Location = new System.Drawing.Point(155, 171);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 136);
            this.textBoxDescription.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(76, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "End date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(155, 338);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerStartDate.TabIndex = 12;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(155, 403);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerEndDate.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(292, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(155, 96);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPatient.TabIndex = 15;
            // 
            // checkedListBoxMedicine
            // 
            this.checkedListBoxMedicine.CheckOnClick = true;
            this.checkedListBoxMedicine.FormattingEnabled = true;
            this.checkedListBoxMedicine.Location = new System.Drawing.Point(468, 96);
            this.checkedListBoxMedicine.Name = "checkedListBoxMedicine";
            this.checkedListBoxMedicine.Size = new System.Drawing.Size(226, 92);
            this.checkedListBoxMedicine.TabIndex = 16;
            // 
            // checkedListBoxTreatment
            // 
            this.checkedListBoxTreatment.CheckOnClick = true;
            this.checkedListBoxTreatment.FormattingEnabled = true;
            this.checkedListBoxTreatment.Location = new System.Drawing.Point(468, 215);
            this.checkedListBoxTreatment.Name = "checkedListBoxTreatment";
            this.checkedListBoxTreatment.Size = new System.Drawing.Size(226, 92);
            this.checkedListBoxTreatment.TabIndex = 17;
            // 
            // checkedListBoxExercise
            // 
            this.checkedListBoxExercise.CheckOnClick = true;
            this.checkedListBoxExercise.FormattingEnabled = true;
            this.checkedListBoxExercise.Location = new System.Drawing.Point(468, 338);
            this.checkedListBoxExercise.Name = "checkedListBoxExercise";
            this.checkedListBoxExercise.Size = new System.Drawing.Size(226, 92);
            this.checkedListBoxExercise.TabIndex = 18;
            // 
            // labelMedicine
            // 
            this.labelMedicine.AutoSize = true;
            this.labelMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMedicine.Location = new System.Drawing.Point(465, 73);
            this.labelMedicine.Name = "labelMedicine";
            this.labelMedicine.Size = new System.Drawing.Size(76, 20);
            this.labelMedicine.TabIndex = 19;
            this.labelMedicine.Text = "Medicine:";
            // 
            // labelTreatment
            // 
            this.labelTreatment.AutoSize = true;
            this.labelTreatment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTreatment.Location = new System.Drawing.Point(468, 191);
            this.labelTreatment.Name = "labelTreatment";
            this.labelTreatment.Size = new System.Drawing.Size(82, 20);
            this.labelTreatment.TabIndex = 20;
            this.labelTreatment.Text = "Treatment:";
            // 
            // labelExercise
            // 
            this.labelExercise.AutoSize = true;
            this.labelExercise.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExercise.Location = new System.Drawing.Point(468, 315);
            this.labelExercise.Name = "labelExercise";
            this.labelExercise.Size = new System.Drawing.Size(68, 20);
            this.labelExercise.TabIndex = 21;
            this.labelExercise.Text = "Exercise:";
            // 
            // CreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelExercise);
            this.Controls.Add(this.labelTreatment);
            this.Controls.Add(this.labelMedicine);
            this.Controls.Add(this.checkedListBoxExercise);
            this.Controls.Add(this.checkedListBoxTreatment);
            this.Controls.Add(this.checkedListBoxMedicine);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatePrescription";
            this.Size = new System.Drawing.Size(749, 582);
            this.Load += new System.EventHandler(this.CreatePrescription_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxDescription, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dateTimePickerStartDate, 0);
            this.Controls.SetChildIndex(this.dateTimePickerEndDate, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.comboBoxPatient, 0);
            this.Controls.SetChildIndex(this.checkedListBoxMedicine, 0);
            this.Controls.SetChildIndex(this.checkedListBoxTreatment, 0);
            this.Controls.SetChildIndex(this.checkedListBoxExercise, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.labelMedicine, 0);
            this.Controls.SetChildIndex(this.labelTreatment, 0);
            this.Controls.SetChildIndex(this.labelExercise, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.CheckedListBox checkedListBoxMedicine;
        private System.Windows.Forms.CheckedListBox checkedListBoxTreatment;
        private System.Windows.Forms.CheckedListBox checkedListBoxExercise;
        private System.Windows.Forms.Label labelMedicine;
        private System.Windows.Forms.Label labelTreatment;
        private System.Windows.Forms.Label labelExercise;
    }
}
