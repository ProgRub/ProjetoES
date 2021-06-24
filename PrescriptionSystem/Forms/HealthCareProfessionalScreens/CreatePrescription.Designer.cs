namespace Forms.HealthCareProfessionalScreens
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelPatient = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelStartDate = new System.Windows.Forms.Label();
            this.LabelEndDate = new System.Windows.Forms.Label();
            this.DateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.ButtonCreatePrescription = new System.Windows.Forms.Button();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.TreeViewPrescriptionItems = new System.Windows.Forms.TreeView();
            this.ButtonAddPrescriptionItem = new System.Windows.Forms.Button();
            this.ComboBoxItems = new System.Windows.Forms.ComboBox();
            this.ButtonAddTime = new System.Windows.Forms.Button();
            this.LabelPrescriptionItems = new System.Windows.Forms.Label();
            this.LabelRecommendedTime = new System.Windows.Forms.Label();
            this.DateTimePickerRecommendedTime = new System.Windows.Forms.DateTimePicker();
            this.ButtonRedo = new System.Windows.Forms.Button();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(475, 21);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(175, 25);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Create prescription";
            // 
            // LabelPatient
            // 
            this.LabelPatient.AutoSize = true;
            this.LabelPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPatient.Location = new System.Drawing.Point(32, 97);
            this.LabelPatient.Name = "LabelPatient";
            this.LabelPatient.Size = new System.Drawing.Size(47, 15);
            this.LabelPatient.TabIndex = 6;
            this.LabelPatient.Text = "Patient:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDescription.Location = new System.Drawing.Point(5, 127);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(71, 15);
            this.LabelDescription.TabIndex = 7;
            this.LabelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsReturn = true;
            this.textBoxDescription.Location = new System.Drawing.Point(90, 129);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(428, 103);
            this.textBoxDescription.TabIndex = 9;
            // 
            // LabelStartDate
            // 
            this.LabelStartDate.AutoSize = true;
            this.LabelStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelStartDate.Location = new System.Drawing.Point(134, 254);
            this.LabelStartDate.Name = "LabelStartDate";
            this.LabelStartDate.Size = new System.Drawing.Size(61, 15);
            this.LabelStartDate.TabIndex = 10;
            this.LabelStartDate.Text = "Start date:";
            // 
            // LabelEndDate
            // 
            this.LabelEndDate.AutoSize = true;
            this.LabelEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEndDate.Location = new System.Drawing.Point(138, 306);
            this.LabelEndDate.Name = "LabelEndDate";
            this.LabelEndDate.Size = new System.Drawing.Size(56, 15);
            this.LabelEndDate.TabIndex = 11;
            this.LabelEndDate.Text = "End date:";
            // 
            // DateTimePickerStartDate
            // 
            this.DateTimePickerStartDate.Location = new System.Drawing.Point(208, 254);
            this.DateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerStartDate.Name = "DateTimePickerStartDate";
            this.DateTimePickerStartDate.Size = new System.Drawing.Size(219, 23);
            this.DateTimePickerStartDate.TabIndex = 12;
            // 
            // DateTimePickerEndDate
            // 
            this.DateTimePickerEndDate.Location = new System.Drawing.Point(208, 302);
            this.DateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerEndDate.Name = "DateTimePickerEndDate";
            this.DateTimePickerEndDate.Size = new System.Drawing.Size(219, 23);
            this.DateTimePickerEndDate.TabIndex = 13;
            // 
            // ButtonCreatePrescription
            // 
            this.ButtonCreatePrescription.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonCreatePrescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreatePrescription.ForeColor = System.Drawing.Color.White;
            this.ButtonCreatePrescription.Location = new System.Drawing.Point(475, 384);
            this.ButtonCreatePrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCreatePrescription.Name = "ButtonCreatePrescription";
            this.ButtonCreatePrescription.Size = new System.Drawing.Size(221, 32);
            this.ButtonCreatePrescription.TabIndex = 14;
            this.ButtonCreatePrescription.Text = "Create";
            this.ButtonCreatePrescription.UseVisualStyleBackColor = false;
            this.ButtonCreatePrescription.Click += new System.EventHandler(this.ButtonCreatePrescription_Click);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(90, 97);
            this.comboBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(428, 23);
            this.comboBoxPatient.TabIndex = 15;
            // 
            // TreeViewPrescriptionItems
            // 
            this.TreeViewPrescriptionItems.Location = new System.Drawing.Point(538, 129);
            this.TreeViewPrescriptionItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TreeViewPrescriptionItems.Name = "TreeViewPrescriptionItems";
            this.TreeViewPrescriptionItems.Size = new System.Drawing.Size(462, 197);
            this.TreeViewPrescriptionItems.TabIndex = 16;
            this.TreeViewPrescriptionItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeViewPrescriptionItems_KeyDown);
            // 
            // ButtonAddPrescriptionItem
            // 
            this.ButtonAddPrescriptionItem.BackColor = System.Drawing.Color.Aquamarine;
            this.ButtonAddPrescriptionItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddPrescriptionItem.Location = new System.Drawing.Point(928, 70);
            this.ButtonAddPrescriptionItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddPrescriptionItem.Name = "ButtonAddPrescriptionItem";
            this.ButtonAddPrescriptionItem.Size = new System.Drawing.Size(72, 22);
            this.ButtonAddPrescriptionItem.TabIndex = 17;
            this.ButtonAddPrescriptionItem.Text = "Add";
            this.ButtonAddPrescriptionItem.UseVisualStyleBackColor = false;
            this.ButtonAddPrescriptionItem.Click += new System.EventHandler(this.ButtonAddPrescriptionItem_Click);
            // 
            // ComboBoxItems
            // 
            this.ComboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxItems.FormattingEnabled = true;
            this.ComboBoxItems.Location = new System.Drawing.Point(538, 97);
            this.ComboBoxItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxItems.Name = "ComboBoxItems";
            this.ComboBoxItems.Size = new System.Drawing.Size(462, 23);
            this.ComboBoxItems.TabIndex = 18;
            // 
            // ButtonAddTime
            // 
            this.ButtonAddTime.BackColor = System.Drawing.Color.Gold;
            this.ButtonAddTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTime.Location = new System.Drawing.Point(1045, 220);
            this.ButtonAddTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddTime.Name = "ButtonAddTime";
            this.ButtonAddTime.Size = new System.Drawing.Size(82, 22);
            this.ButtonAddTime.TabIndex = 20;
            this.ButtonAddTime.Text = "Add Time";
            this.ButtonAddTime.UseVisualStyleBackColor = false;
            this.ButtonAddTime.Click += new System.EventHandler(this.ButtonAddTime_Click);
            // 
            // LabelPrescriptionItems
            // 
            this.LabelPrescriptionItems.AutoSize = true;
            this.LabelPrescriptionItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPrescriptionItems.Location = new System.Drawing.Point(538, 73);
            this.LabelPrescriptionItems.Name = "LabelPrescriptionItems";
            this.LabelPrescriptionItems.Size = new System.Drawing.Size(106, 15);
            this.LabelPrescriptionItems.TabIndex = 21;
            this.LabelPrescriptionItems.Text = "Prescription Items:";
            // 
            // LabelRecommendedTime
            // 
            this.LabelRecommendedTime.AutoSize = true;
            this.LabelRecommendedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRecommendedTime.Location = new System.Drawing.Point(1024, 176);
            this.LabelRecommendedTime.Name = "LabelRecommendedTime";
            this.LabelRecommendedTime.Size = new System.Drawing.Size(121, 15);
            this.LabelRecommendedTime.TabIndex = 22;
            this.LabelRecommendedTime.Text = "Recommended Time:";
            // 
            // DateTimePickerRecommendedTime
            // 
            this.DateTimePickerRecommendedTime.CustomFormat = "HH:mm";
            this.DateTimePickerRecommendedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerRecommendedTime.Location = new System.Drawing.Point(1045, 196);
            this.DateTimePickerRecommendedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerRecommendedTime.Name = "DateTimePickerRecommendedTime";
            this.DateTimePickerRecommendedTime.ShowUpDown = true;
            this.DateTimePickerRecommendedTime.Size = new System.Drawing.Size(83, 23);
            this.DateTimePickerRecommendedTime.TabIndex = 25;
            // 
            // ButtonRedo
            // 
            this.ButtonRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonRedo.Enabled = false;
            this.ButtonRedo.FlatAppearance.BorderSize = 0;
            this.ButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRedo.Image = global::Forms.Properties.Resources.Redo;
            this.ButtonRedo.Location = new System.Drawing.Point(800, 330);
            this.ButtonRedo.Name = "ButtonRedo";
            this.ButtonRedo.Size = new System.Drawing.Size(36, 23);
            this.ButtonRedo.TabIndex = 27;
            this.ButtonRedo.UseVisualStyleBackColor = true;
            this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonUndo.Enabled = false;
            this.ButtonUndo.FlatAppearance.BorderSize = 0;
            this.ButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndo.Image = global::Forms.Properties.Resources.Undo;
            this.ButtonUndo.Location = new System.Drawing.Point(725, 330);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(36, 23);
            this.ButtonUndo.TabIndex = 26;
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // CreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonRedo);
            this.Controls.Add(this.ButtonUndo);
            this.Controls.Add(this.DateTimePickerRecommendedTime);
            this.Controls.Add(this.LabelRecommendedTime);
            this.Controls.Add(this.LabelPrescriptionItems);
            this.Controls.Add(this.ButtonAddTime);
            this.Controls.Add(this.ComboBoxItems);
            this.Controls.Add(this.ButtonAddPrescriptionItem);
            this.Controls.Add(this.TreeViewPrescriptionItems);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.ButtonCreatePrescription);
            this.Controls.Add(this.DateTimePickerEndDate);
            this.Controls.Add(this.DateTimePickerStartDate);
            this.Controls.Add(this.LabelEndDate);
            this.Controls.Add(this.LabelStartDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelPatient);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatePrescription";
            this.Size = new System.Drawing.Size(1396, 628);
            this.Enter += new System.EventHandler(this.CreatePrescription_Enter);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.LabelPatient, 0);
            this.Controls.SetChildIndex(this.LabelDescription, 0);
            this.Controls.SetChildIndex(this.textBoxDescription, 0);
            this.Controls.SetChildIndex(this.LabelStartDate, 0);
            this.Controls.SetChildIndex(this.LabelEndDate, 0);
            this.Controls.SetChildIndex(this.DateTimePickerStartDate, 0);
            this.Controls.SetChildIndex(this.DateTimePickerEndDate, 0);
            this.Controls.SetChildIndex(this.ButtonCreatePrescription, 0);
            this.Controls.SetChildIndex(this.comboBoxPatient, 0);
            this.Controls.SetChildIndex(this.TreeViewPrescriptionItems, 0);
            this.Controls.SetChildIndex(this.ButtonAddPrescriptionItem, 0);
            this.Controls.SetChildIndex(this.ComboBoxItems, 0);
            this.Controls.SetChildIndex(this.ButtonAddTime, 0);
            this.Controls.SetChildIndex(this.LabelPrescriptionItems, 0);
            this.Controls.SetChildIndex(this.LabelRecommendedTime, 0);
            this.Controls.SetChildIndex(this.DateTimePickerRecommendedTime, 0);
            this.Controls.SetChildIndex(this.ButtonUndo, 0);
            this.Controls.SetChildIndex(this.ButtonRedo, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelPatient;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label LabelStartDate;
        private System.Windows.Forms.Label LabelEndDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerEndDate;
        private System.Windows.Forms.Button ButtonCreatePrescription;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.TreeView TreeViewPrescriptionItems;
        private System.Windows.Forms.Button ButtonAddPrescriptionItem;
        private System.Windows.Forms.ComboBox ComboBoxItems;
        private System.Windows.Forms.Button ButtonAddTime;
        private System.Windows.Forms.Label LabelPrescriptionItems;
        private System.Windows.Forms.Label LabelRecommendedTime;
        private System.Windows.Forms.DateTimePicker DateTimePickerRecommendedTime;
        private System.Windows.Forms.Button ButtonRedo;
        private System.Windows.Forms.Button ButtonUndo;
    }
}
