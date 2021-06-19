
namespace Forms
{
    partial class AddTreatmentItemScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTreatmentName = new System.Windows.Forms.TextBox();
            this.textBoxTreatmentDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTreatmentNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMinAge = new System.Windows.Forms.TextBox();
            this.textBoxMaxAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Head = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(198, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Prescription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create Treatment Prescription Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTreatmentName
            // 
            this.textBoxTreatmentName.Location = new System.Drawing.Point(152, 64);
            this.textBoxTreatmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTreatmentName.Name = "textBoxTreatmentName";
            this.textBoxTreatmentName.Size = new System.Drawing.Size(219, 23);
            this.textBoxTreatmentName.TabIndex = 10;
            // 
            // textBoxTreatmentDescription
            // 
            this.textBoxTreatmentDescription.Location = new System.Drawing.Point(152, 109);
            this.textBoxTreatmentDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTreatmentDescription.Name = "textBoxTreatmentDescription";
            this.textBoxTreatmentDescription.Size = new System.Drawing.Size(219, 23);
            this.textBoxTreatmentDescription.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Note:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxTreatmentNote
            // 
            this.textBoxTreatmentNote.Location = new System.Drawing.Point(152, 152);
            this.textBoxTreatmentNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTreatmentNote.Name = "textBoxTreatmentNote";
            this.textBoxTreatmentNote.Size = new System.Drawing.Size(219, 23);
            this.textBoxTreatmentNote.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Duration:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxMinAge
            // 
            this.textBoxMinAge.Location = new System.Drawing.Point(152, 229);
            this.textBoxMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMinAge.MaxLength = 3;
            this.textBoxMinAge.Name = "textBoxMinAge";
            this.textBoxMinAge.Size = new System.Drawing.Size(40, 23);
            this.textBoxMinAge.TabIndex = 25;
            // 
            // textBoxMaxAge
            // 
            this.textBoxMaxAge.Location = new System.Drawing.Point(216, 231);
            this.textBoxMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaxAge.MaxLength = 3;
            this.textBoxMaxAge.Name = "textBoxMaxAge";
            this.textBoxMaxAge.Size = new System.Drawing.Size(40, 23);
            this.textBoxMaxAge.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "-";
            // 
            // dateTimePickerDuration
            // 
            this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDuration.Location = new System.Drawing.Point(152, 194);
            this.dateTimePickerDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDuration.Name = "dateTimePickerDuration";
            this.dateTimePickerDuration.ShowUpDown = true;
            this.dateTimePickerDuration.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerDuration.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.Head);
            this.groupBox1.Location = new System.Drawing.Point(152, 271);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 118);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Body Part:";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(116, 88);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(77, 19);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "RightFoot";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(116, 65);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(69, 19);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "LeftFoot";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(116, 42);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 19);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "RightLeg";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(116, 20);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 19);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "LeftLeg";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 88);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 19);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Torso";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 64);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "RightArm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 42);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LeftArm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.Location = new System.Drawing.Point(5, 20);
            this.Head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(53, 19);
            this.Head.TabIndex = 0;
            this.Head.TabStop = true;
            this.Head.Text = "Head";
            this.Head.UseVisualStyleBackColor = true;
            // 
            // AddTreatmentItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxAge);
            this.Controls.Add(this.textBoxMinAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTreatmentNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTreatmentDescription);
            this.Controls.Add(this.textBoxTreatmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTreatmentItemScreen";
            this.Size = new System.Drawing.Size(466, 459);
            this.Load += new System.EventHandler(this.AddMedicineItem_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxTreatmentName, 0);
            this.Controls.SetChildIndex(this.textBoxTreatmentDescription, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.textBoxTreatmentNote, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxMinAge, 0);
            this.Controls.SetChildIndex(this.textBoxMaxAge, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.dateTimePickerDuration, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTreatmentName;
        private System.Windows.Forms.TextBox textBoxTreatmentDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTreatmentNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMinAge;
        private System.Windows.Forms.TextBox textBoxMaxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Head;
    }
}
