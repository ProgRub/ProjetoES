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
            this.treeViewPrescriptionItems = new System.Windows.Forms.TreeView();
            this.buttonAddPrescriptionItem = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonAddTime = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonRedo = new System.Windows.Forms.Button();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.DateTimePickerRecommendedTime = new System.Windows.Forms.DateTimePicker();
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
            this.label1.Location = new System.Drawing.Point(481, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create prescription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsReturn = true;
            this.textBoxDescription.Location = new System.Drawing.Point(136, 128);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(428, 103);
            this.textBoxDescription.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(179, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(184, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "End date:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(254, 253);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerStartDate.TabIndex = 12;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(254, 301);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerEndDate.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(476, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(136, 72);
            this.comboBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(428, 23);
            this.comboBoxPatient.TabIndex = 15;
            // 
            // treeViewPrescriptionItems
            // 
            this.treeViewPrescriptionItems.Location = new System.Drawing.Point(570, 129);
            this.treeViewPrescriptionItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewPrescriptionItems.Name = "treeViewPrescriptionItems";
            this.treeViewPrescriptionItems.Size = new System.Drawing.Size(413, 195);
            this.treeViewPrescriptionItems.TabIndex = 16;
            // 
            // buttonAddPrescriptionItem
            // 
            this.buttonAddPrescriptionItem.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAddPrescriptionItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPrescriptionItem.Location = new System.Drawing.Point(693, 70);
            this.buttonAddPrescriptionItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPrescriptionItem.Name = "buttonAddPrescriptionItem";
            this.buttonAddPrescriptionItem.Size = new System.Drawing.Size(54, 22);
            this.buttonAddPrescriptionItem.TabIndex = 17;
            this.buttonAddPrescriptionItem.Text = "Add";
            this.buttonAddPrescriptionItem.UseVisualStyleBackColor = false;
            this.buttonAddPrescriptionItem.Click += new System.EventHandler(this.ButtonAddPrescriptionItem_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(570, 96);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(413, 23);
            this.comboBoxItems.TabIndex = 18;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItems_SelectedIndexChanged);
            // 
            // buttonAddTime
            // 
            this.buttonAddTime.BackColor = System.Drawing.Color.Gold;
            this.buttonAddTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTime.Location = new System.Drawing.Point(1015, 221);
            this.buttonAddTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTime.Name = "buttonAddTime";
            this.buttonAddTime.Size = new System.Drawing.Size(82, 22);
            this.buttonAddTime.TabIndex = 20;
            this.buttonAddTime.Text = "Add Time";
            this.buttonAddTime.UseVisualStyleBackColor = false;
            this.buttonAddTime.Click += new System.EventHandler(this.ButtonAddTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(570, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Prescription Items:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(994, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Recommended Time:";
            // 
            // ButtonRedo
            // 
            this.ButtonRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonRedo.Enabled = false;
            this.ButtonRedo.FlatAppearance.BorderSize = 0;
            this.ButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRedo.Location = new System.Drawing.Point(661, 329);
            this.ButtonRedo.Name = "ButtonRedo";
            this.ButtonRedo.Size = new System.Drawing.Size(36, 23);
            this.ButtonRedo.TabIndex = 24;
            this.ButtonRedo.UseVisualStyleBackColor = true;
            this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click_1);
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonUndo.Enabled = false;
            this.ButtonUndo.FlatAppearance.BorderSize = 0;
            this.ButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndo.Location = new System.Drawing.Point(620, 329);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(36, 23);
            this.ButtonUndo.TabIndex = 23;
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click_1);
            // 
            // DateTimePickerRecommendedTime
            // 
            this.DateTimePickerRecommendedTime.CustomFormat = "HH:mm";
            this.DateTimePickerRecommendedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerRecommendedTime.Location = new System.Drawing.Point(1028, 194);
            this.DateTimePickerRecommendedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerRecommendedTime.Name = "DateTimePickerRecommendedTime";
            this.DateTimePickerRecommendedTime.ShowUpDown = true;
            this.DateTimePickerRecommendedTime.Size = new System.Drawing.Size(57, 23);
            this.DateTimePickerRecommendedTime.TabIndex = 25;
            // 
            // CreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateTimePickerRecommendedTime);
            this.Controls.Add(this.ButtonRedo);
            this.Controls.Add(this.ButtonUndo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAddTime);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.buttonAddPrescriptionItem);
            this.Controls.Add(this.treeViewPrescriptionItems);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatePrescription";
            this.Size = new System.Drawing.Size(1206, 471);
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
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.treeViewPrescriptionItems, 0);
            this.Controls.SetChildIndex(this.buttonAddPrescriptionItem, 0);
            this.Controls.SetChildIndex(this.comboBoxItems, 0);
            this.Controls.SetChildIndex(this.buttonAddTime, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.ButtonUndo, 0);
            this.Controls.SetChildIndex(this.ButtonRedo, 0);
            this.Controls.SetChildIndex(this.DateTimePickerRecommendedTime, 0);
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
        private System.Windows.Forms.TreeView treeViewPrescriptionItems;
        private System.Windows.Forms.Button buttonAddPrescriptionItem;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonAddTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonRedo;
        private System.Windows.Forms.Button ButtonUndo;
        private System.Windows.Forms.DateTimePicker DateTimePickerRecommendedTime;
    }
}
