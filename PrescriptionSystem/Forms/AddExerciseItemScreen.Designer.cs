
namespace Forms
{
    partial class AddExerciseItemScreen
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelBodyPart = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonAddExercise = new System.Windows.Forms.Button();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.DateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.CheckedListBoxBodyPart = new System.Windows.Forms.CheckedListBox();
            this.LabelHifenMinimumMaximumAge = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.TextBoxMaximumAge = new System.Windows.Forms.TextBox();
            this.TextBoxMinimumAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelBodyPart
            // 
            this.LabelBodyPart.AutoSize = true;
            this.LabelBodyPart.Location = new System.Drawing.Point(111, 246);
            this.LabelBodyPart.Name = "LabelBodyPart";
            this.LabelBodyPart.Size = new System.Drawing.Size(61, 15);
            this.LabelBodyPart.TabIndex = 35;
            this.LabelBodyPart.Text = "Body Part:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(102, 106);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(70, 15);
            this.LabelDescription.TabIndex = 34;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(130, 65);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 15);
            this.LabelName.TabIndex = 33;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.AcceptsReturn = true;
            this.TextBoxDescription.Location = new System.Drawing.Point(178, 106);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(364, 75);
            this.TextBoxDescription.TabIndex = 31;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.White;
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBoxName.Location = new System.Drawing.Point(178, 62);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(364, 23);
            this.TextBoxName.TabIndex = 30;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(231, 24);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(251, 21);
            this.LabelTitle.TabIndex = 29;
            this.LabelTitle.Text = "Create Exercise Prescription Item";
            // 
            // ButtonAddExercise
            // 
            this.ButtonAddExercise.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddExercise.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddExercise.ForeColor = System.Drawing.Color.White;
            this.ButtonAddExercise.Location = new System.Drawing.Point(302, 402);
            this.ButtonAddExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddExercise.Name = "ButtonAddExercise";
            this.ButtonAddExercise.Size = new System.Drawing.Size(130, 31);
            this.ButtonAddExercise.TabIndex = 28;
            this.ButtonAddExercise.Text = "Add Exercise";
            this.ButtonAddExercise.UseVisualStyleBackColor = false;
            this.ButtonAddExercise.Click += new System.EventHandler(this.ButtonAddExercise_Click);
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Location = new System.Drawing.Point(116, 201);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(56, 15);
            this.LabelDuration.TabIndex = 41;
            this.LabelDuration.Text = "Duration:";
            // 
            // DateTimePickerDuration
            // 
            this.DateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerDuration.Location = new System.Drawing.Point(178, 201);
            this.DateTimePickerDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimePickerDuration.Name = "DateTimePickerDuration";
            this.DateTimePickerDuration.ShowUpDown = true;
            this.DateTimePickerDuration.Size = new System.Drawing.Size(364, 23);
            this.DateTimePickerDuration.TabIndex = 42;
            this.DateTimePickerDuration.Value = new System.DateTime(2021, 6, 20, 0, 0, 0, 0);
            // 
            // CheckedListBoxBodyPart
            // 
            this.CheckedListBoxBodyPart.CheckOnClick = true;
            this.CheckedListBoxBodyPart.FormattingEnabled = true;
            this.CheckedListBoxBodyPart.Items.AddRange(new object[] {
            "Head",
            "LeftArm",
            "LeftFoot",
            "LeftLeg",
            "RightArm",
            "RightFoot",
            "RightLeg",
            "Torso"});
            this.CheckedListBoxBodyPart.Location = new System.Drawing.Point(178, 246);
            this.CheckedListBoxBodyPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckedListBoxBodyPart.MultiColumn = true;
            this.CheckedListBoxBodyPart.Name = "CheckedListBoxBodyPart";
            this.CheckedListBoxBodyPart.Size = new System.Drawing.Size(364, 76);
            this.CheckedListBoxBodyPart.TabIndex = 43;
            // 
            // LabelHifenMinimumMaximumAge
            // 
            this.LabelHifenMinimumMaximumAge.AutoSize = true;
            this.LabelHifenMinimumMaximumAge.Location = new System.Drawing.Point(359, 351);
            this.LabelHifenMinimumMaximumAge.Name = "LabelHifenMinimumMaximumAge";
            this.LabelHifenMinimumMaximumAge.Size = new System.Drawing.Size(12, 15);
            this.LabelHifenMinimumMaximumAge.TabIndex = 49;
            this.LabelHifenMinimumMaximumAge.Text = "-";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(275, 348);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(31, 15);
            this.LabelAge.TabIndex = 48;
            this.LabelAge.Text = "Age:";
            // 
            // TextBoxMaximumAge
            // 
            this.TextBoxMaximumAge.Location = new System.Drawing.Point(378, 348);
            this.TextBoxMaximumAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMaximumAge.MaxLength = 3;
            this.TextBoxMaximumAge.Name = "TextBoxMaximumAge";
            this.TextBoxMaximumAge.Size = new System.Drawing.Size(40, 23);
            this.TextBoxMaximumAge.TabIndex = 47;
            // 
            // TextBoxMinimumAge
            // 
            this.TextBoxMinimumAge.Location = new System.Drawing.Point(312, 348);
            this.TextBoxMinimumAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMinimumAge.MaxLength = 3;
            this.TextBoxMinimumAge.Name = "TextBoxMinimumAge";
            this.TextBoxMinimumAge.Size = new System.Drawing.Size(40, 23);
            this.TextBoxMinimumAge.TabIndex = 46;
            // 
            // AddExerciseItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelHifenMinimumMaximumAge);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.TextBoxMaximumAge);
            this.Controls.Add(this.TextBoxMinimumAge);
            this.Controls.Add(this.CheckedListBoxBodyPart);
            this.Controls.Add(this.DateTimePickerDuration);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelBodyPart);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonAddExercise);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddExerciseItemScreen";
            this.Size = new System.Drawing.Size(680, 463);
            this.Load += new System.EventHandler(this.AddExerciseItemScreen_Load);
            this.Controls.SetChildIndex(this.ButtonAddExercise, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.TextBoxName, 0);
            this.Controls.SetChildIndex(this.TextBoxDescription, 0);
            this.Controls.SetChildIndex(this.LabelName, 0);
            this.Controls.SetChildIndex(this.LabelDescription, 0);
            this.Controls.SetChildIndex(this.LabelBodyPart, 0);
            this.Controls.SetChildIndex(this.LabelDuration, 0);
            this.Controls.SetChildIndex(this.DateTimePickerDuration, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxBodyPart, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.TextBoxMinimumAge, 0);
            this.Controls.SetChildIndex(this.TextBoxMaximumAge, 0);
            this.Controls.SetChildIndex(this.LabelAge, 0);
            this.Controls.SetChildIndex(this.LabelHifenMinimumMaximumAge, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelBodyPart;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonAddExercise;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.CheckedListBox CheckedListBoxBodyPart;
        private System.Windows.Forms.DateTimePicker DateTimePickerDuration;
        private System.Windows.Forms.Label LabelHifenMinimumMaximumAge;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.TextBox TextBoxMaximumAge;
        private System.Windows.Forms.TextBox TextBoxMinimumAge;
    }
}
