﻿
namespace Forms
{
    partial class SignUpScreen
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
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.RadioButtonPatient = new System.Windows.Forms.RadioButton();
            this.RadioButtonTherapist = new System.Windows.Forms.RadioButton();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelDOB = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.DateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxHealthUserNumber = new System.Windows.Forms.TextBox();
            this.LabelHealthUserNumber = new System.Windows.Forms.Label();
            this.LabelAllergies = new System.Windows.Forms.Label();
            this.LabelMissingBodyParts = new System.Windows.Forms.Label();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.CheckedListBoxAllergies = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBoxMissingBodyParts = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBoxDiseases = new System.Windows.Forms.CheckedListBox();
            this.LabelDiseases = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxEmail.Location = new System.Drawing.Point(158, 206);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(400, 29);
            this.TextBoxEmail.TabIndex = 7;
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(158, 136);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(400, 29);
            this.TextBoxPhoneNumber.TabIndex = 6;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEmail.Location = new System.Drawing.Point(98, 209);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(54, 21);
            this.LabelEmail.TabIndex = 5;
            this.LabelEmail.Text = "E-mail";
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPhoneNumber.Location = new System.Drawing.Point(36, 139);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(116, 21);
            this.LabelPhoneNumber.TabIndex = 4;
            this.LabelPhoneNumber.Text = "Phone Number";
            // 
            // RadioButtonPatient
            // 
            this.RadioButtonPatient.AutoSize = true;
            this.RadioButtonPatient.Checked = true;
            this.RadioButtonPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonPatient.Location = new System.Drawing.Point(149, 18);
            this.RadioButtonPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonPatient.Name = "RadioButtonPatient";
            this.RadioButtonPatient.Size = new System.Drawing.Size(75, 25);
            this.RadioButtonPatient.TabIndex = 8;
            this.RadioButtonPatient.TabStop = true;
            this.RadioButtonPatient.Text = "Patient";
            this.RadioButtonPatient.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTherapist
            // 
            this.RadioButtonTherapist.AutoSize = true;
            this.RadioButtonTherapist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioButtonTherapist.Location = new System.Drawing.Point(287, 18);
            this.RadioButtonTherapist.Name = "RadioButtonTherapist";
            this.RadioButtonTherapist.Size = new System.Drawing.Size(92, 25);
            this.RadioButtonTherapist.TabIndex = 9;
            this.RadioButtonTherapist.Text = "Therapist";
            this.RadioButtonTherapist.UseVisualStyleBackColor = true;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxName.Location = new System.Drawing.Point(158, 66);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(400, 29);
            this.TextBoxName.TabIndex = 12;
            // 
            // LabelDOB
            // 
            this.LabelDOB.AutoSize = true;
            this.LabelDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDOB.Location = new System.Drawing.Point(55, 104);
            this.LabelDOB.Name = "LabelDOB";
            this.LabelDOB.Size = new System.Drawing.Size(97, 21);
            this.LabelDOB.TabIndex = 11;
            this.LabelDOB.Text = "Date of Birth";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(100, 69);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(52, 21);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Name";
            // 
            // DateTimePickerDOB
            // 
            this.DateTimePickerDOB.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerDOB.Location = new System.Drawing.Point(158, 102);
            this.DateTimePickerDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerDOB.MaxDate = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            this.DateTimePickerDOB.Name = "DateTimePickerDOB";
            this.DateTimePickerDOB.Size = new System.Drawing.Size(231, 29);
            this.DateTimePickerDOB.TabIndex = 13;
            this.DateTimePickerDOB.Value = new System.DateTime(2021, 6, 3, 0, 0, 0, 0);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPassword.Location = new System.Drawing.Point(158, 241);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(400, 29);
            this.TextBoxPassword.TabIndex = 15;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPassword.Location = new System.Drawing.Point(76, 244);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(76, 21);
            this.LabelPassword.TabIndex = 14;
            this.LabelPassword.Text = "Password";
            // 
            // TextBoxHealthUserNumber
            // 
            this.TextBoxHealthUserNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxHealthUserNumber.Location = new System.Drawing.Point(158, 171);
            this.TextBoxHealthUserNumber.Name = "TextBoxHealthUserNumber";
            this.TextBoxHealthUserNumber.Size = new System.Drawing.Size(400, 29);
            this.TextBoxHealthUserNumber.TabIndex = 17;
            // 
            // LabelHealthUserNumber
            // 
            this.LabelHealthUserNumber.AutoSize = true;
            this.LabelHealthUserNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHealthUserNumber.Location = new System.Drawing.Point(-1, 174);
            this.LabelHealthUserNumber.Name = "LabelHealthUserNumber";
            this.LabelHealthUserNumber.Size = new System.Drawing.Size(153, 21);
            this.LabelHealthUserNumber.TabIndex = 16;
            this.LabelHealthUserNumber.Text = "Health User Number";
            // 
            // LabelAllergies
            // 
            this.LabelAllergies.AutoSize = true;
            this.LabelAllergies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAllergies.Location = new System.Drawing.Point(76, 276);
            this.LabelAllergies.Name = "LabelAllergies";
            this.LabelAllergies.Size = new System.Drawing.Size(70, 21);
            this.LabelAllergies.TabIndex = 18;
            this.LabelAllergies.Text = "Allergies";
            // 
            // LabelMissingBodyParts
            // 
            this.LabelMissingBodyParts.AutoSize = true;
            this.LabelMissingBodyParts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMissingBodyParts.Location = new System.Drawing.Point(11, 584);
            this.LabelMissingBodyParts.Name = "LabelMissingBodyParts";
            this.LabelMissingBodyParts.Size = new System.Drawing.Size(141, 21);
            this.LabelMissingBodyParts.TabIndex = 20;
            this.LabelMissingBodyParts.Text = "Missing Body Parts";
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSignUp.Location = new System.Drawing.Point(313, 666);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(96, 33);
            this.ButtonSignUp.TabIndex = 22;
            this.ButtonSignUp.Text = "Sign Up";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // CheckedListBoxAllergies
            // 
            this.CheckedListBoxAllergies.CheckOnClick = true;
            this.CheckedListBoxAllergies.FormattingEnabled = true;
            this.CheckedListBoxAllergies.Location = new System.Drawing.Point(158, 276);
            this.CheckedListBoxAllergies.MultiColumn = true;
            this.CheckedListBoxAllergies.Name = "CheckedListBoxAllergies";
            this.CheckedListBoxAllergies.Size = new System.Drawing.Size(400, 148);
            this.CheckedListBoxAllergies.TabIndex = 23;
            // 
            // CheckedListBoxMissingBodyParts
            // 
            this.CheckedListBoxMissingBodyParts.CheckOnClick = true;
            this.CheckedListBoxMissingBodyParts.FormattingEnabled = true;
            this.CheckedListBoxMissingBodyParts.Items.AddRange(new object[] {
            "Head",
            "Left Arm",
            "Left Foot",
            "Left Leg",
            "Right Arm",
            "Right Foot",
            "Right Leg",
            "Torso"});
            this.CheckedListBoxMissingBodyParts.Location = new System.Drawing.Point(158, 584);
            this.CheckedListBoxMissingBodyParts.MultiColumn = true;
            this.CheckedListBoxMissingBodyParts.Name = "CheckedListBoxMissingBodyParts";
            this.CheckedListBoxMissingBodyParts.Size = new System.Drawing.Size(400, 76);
            this.CheckedListBoxMissingBodyParts.TabIndex = 24;
            // 
            // CheckedListBoxDiseases
            // 
            this.CheckedListBoxDiseases.CheckOnClick = true;
            this.CheckedListBoxDiseases.FormattingEnabled = true;
            this.CheckedListBoxDiseases.Location = new System.Drawing.Point(158, 430);
            this.CheckedListBoxDiseases.MultiColumn = true;
            this.CheckedListBoxDiseases.Name = "CheckedListBoxDiseases";
            this.CheckedListBoxDiseases.Size = new System.Drawing.Size(400, 148);
            this.CheckedListBoxDiseases.TabIndex = 26;
            // 
            // LabelDiseases
            // 
            this.LabelDiseases.AutoSize = true;
            this.LabelDiseases.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDiseases.Location = new System.Drawing.Point(76, 430);
            this.LabelDiseases.Name = "LabelDiseases";
            this.LabelDiseases.Size = new System.Drawing.Size(70, 21);
            this.LabelDiseases.TabIndex = 25;
            this.LabelDiseases.Text = "Diseases";
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CheckedListBoxDiseases);
            this.Controls.Add(this.LabelDiseases);
            this.Controls.Add(this.CheckedListBoxMissingBodyParts);
            this.Controls.Add(this.CheckedListBoxAllergies);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.LabelMissingBodyParts);
            this.Controls.Add(this.LabelAllergies);
            this.Controls.Add(this.TextBoxHealthUserNumber);
            this.Controls.Add(this.LabelHealthUserNumber);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.DateTimePickerDOB);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelDOB);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.RadioButtonTherapist);
            this.Controls.Add(this.RadioButtonPatient);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Name = "SignUpScreen";
            this.Size = new System.Drawing.Size(561, 750);
            this.Controls.SetChildIndex(this.LabelPhoneNumber, 0);
            this.Controls.SetChildIndex(this.LabelEmail, 0);
            this.Controls.SetChildIndex(this.TextBoxPhoneNumber, 0);
            this.Controls.SetChildIndex(this.TextBoxEmail, 0);
            this.Controls.SetChildIndex(this.RadioButtonPatient, 0);
            this.Controls.SetChildIndex(this.RadioButtonTherapist, 0);
            this.Controls.SetChildIndex(this.LabelName, 0);
            this.Controls.SetChildIndex(this.LabelDOB, 0);
            this.Controls.SetChildIndex(this.TextBoxName, 0);
            this.Controls.SetChildIndex(this.DateTimePickerDOB, 0);
            this.Controls.SetChildIndex(this.LabelPassword, 0);
            this.Controls.SetChildIndex(this.TextBoxPassword, 0);
            this.Controls.SetChildIndex(this.LabelHealthUserNumber, 0);
            this.Controls.SetChildIndex(this.TextBoxHealthUserNumber, 0);
            this.Controls.SetChildIndex(this.LabelAllergies, 0);
            this.Controls.SetChildIndex(this.LabelMissingBodyParts, 0);
            this.Controls.SetChildIndex(this.ButtonSignUp, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxAllergies, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxMissingBodyParts, 0);
            this.Controls.SetChildIndex(this.LabelDiseases, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxDiseases, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.RadioButton RadioButtonPatient;
        private System.Windows.Forms.RadioButton RadioButtonTherapist;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelDOB;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.DateTimePicker DateTimePickerDOB;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxHealthUserNumber;
        private System.Windows.Forms.Label LabelHealthUserNumber;
        private System.Windows.Forms.Label LabelAllergies;
        private System.Windows.Forms.Label LabelMissingBodyParts;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.CheckedListBox CheckedListBoxAllergies;
        private System.Windows.Forms.CheckedListBox CheckedListBoxMissingBodyParts;
        private System.Windows.Forms.CheckedListBox CheckedListBoxDiseases;
        private System.Windows.Forms.Label LabelDiseases;
    }
}
