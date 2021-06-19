
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxBodyPart = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxAge = new System.Windows.Forms.TextBox();
            this.textBoxMinAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Body Part:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(178, 106);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(219, 23);
            this.textBoxDescription.TabIndex = 31;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxName.Location = new System.Drawing.Point(178, 62);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 23);
            this.textBoxName.TabIndex = 30;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Create Exercise Prescription Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(254, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add Prescription";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Duration:";
            // 
            // dateTimePickerDuration
            // 
            this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDuration.Location = new System.Drawing.Point(178, 149);
            this.dateTimePickerDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDuration.Name = "dateTimePickerDuration";
            this.dateTimePickerDuration.ShowUpDown = true;
            this.dateTimePickerDuration.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerDuration.TabIndex = 42;
            // 
            // checkedListBoxBodyPart
            // 
            this.checkedListBoxBodyPart.CheckOnClick = true;
            this.checkedListBoxBodyPart.FormattingEnabled = true;
            this.checkedListBoxBodyPart.Items.AddRange(new object[] {
            "Head",
            "LeftArm",
            "LeftFoot",
            "LeftLeg",
            "RightArm",
            "RightFoot",
            "RightLeg",
            "Torso"});
            this.checkedListBoxBodyPart.Location = new System.Drawing.Point(178, 194);
            this.checkedListBoxBodyPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxBodyPart.MultiColumn = true;
            this.checkedListBoxBodyPart.Name = "checkedListBoxBodyPart";
            this.checkedListBoxBodyPart.Size = new System.Drawing.Size(219, 76);
            this.checkedListBoxBodyPart.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 49;
            this.label8.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Age:";
            // 
            // textBoxMaxAge
            // 
            this.textBoxMaxAge.Location = new System.Drawing.Point(241, 293);
            this.textBoxMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxAge.MaxLength = 3;
            this.textBoxMaxAge.Name = "textBoxMaxAge";
            this.textBoxMaxAge.Size = new System.Drawing.Size(40, 23);
            this.textBoxMaxAge.TabIndex = 47;
            // 
            // textBoxMinAge
            // 
            this.textBoxMinAge.Location = new System.Drawing.Point(175, 293);
            this.textBoxMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMinAge.MaxLength = 3;
            this.textBoxMinAge.Name = "textBoxMinAge";
            this.textBoxMinAge.Size = new System.Drawing.Size(40, 23);
            this.textBoxMinAge.TabIndex = 46;
            // 
            // AddExerciseItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxAge);
            this.Controls.Add(this.textBoxMinAge);
            this.Controls.Add(this.checkedListBoxBodyPart);
            this.Controls.Add(this.dateTimePickerDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddExerciseItemScreen";
            this.Size = new System.Drawing.Size(536, 463);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.textBoxDescription, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDuration, 0);
            this.Controls.SetChildIndex(this.checkedListBoxBodyPart, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.textBoxMinAge, 0);
            this.Controls.SetChildIndex(this.textBoxMaxAge, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox checkedListBoxBodyPart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxAge;
        private System.Windows.Forms.TextBox textBoxMinAge;
        private System.Windows.Forms.TextBox textBoxExerciseNote;
    }
}
