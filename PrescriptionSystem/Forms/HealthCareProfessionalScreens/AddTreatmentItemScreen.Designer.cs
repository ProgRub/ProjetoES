
namespace Forms.HealthCareProfessionalScreens
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
            this.ButtonAddTreatment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTreatmentName = new System.Windows.Forms.TextBox();
            this.TextBoxTreatmentDescription = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelDuration = new System.Windows.Forms.Label();
            this.TextBoxMinimumAge = new System.Windows.Forms.TextBox();
            this.TextBoxMaximumAge = new System.Windows.Forms.TextBox();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelHifenMinimumMaximumAge = new System.Windows.Forms.Label();
            this.DateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.GroupBoxBodyPart = new System.Windows.Forms.GroupBox();
            this.RadioButtonRightFoot = new System.Windows.Forms.RadioButton();
            this.RadioButtonLeftFoot = new System.Windows.Forms.RadioButton();
            this.RadioButtonRightLeg = new System.Windows.Forms.RadioButton();
            this.RadioButtonLeftLeg = new System.Windows.Forms.RadioButton();
            this.RadioButtonTorso = new System.Windows.Forms.RadioButton();
            this.RadioButtonRightArm = new System.Windows.Forms.RadioButton();
            this.RadioButtonLeftArm = new System.Windows.Forms.RadioButton();
            this.RadioButtonHead = new System.Windows.Forms.RadioButton();
            this.GroupBoxBodyPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonAddTreatment
            // 
            this.ButtonAddTreatment.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddTreatment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTreatment.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTreatment.Location = new System.Drawing.Point(306, 545);
            this.ButtonAddTreatment.Name = "ButtonAddTreatment";
            this.ButtonAddTreatment.Size = new System.Drawing.Size(149, 43);
            this.ButtonAddTreatment.TabIndex = 6;
            this.ButtonAddTreatment.Text = "Add Treatment";
            this.ButtonAddTreatment.UseVisualStyleBackColor = false;
            this.ButtonAddTreatment.Click += new System.EventHandler(this.ButtonAddTreatment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create Treatment Prescription Item";
            // 
            // TextBoxTreatmentName
            // 
            this.TextBoxTreatmentName.Location = new System.Drawing.Point(174, 85);
            this.TextBoxTreatmentName.Name = "TextBoxTreatmentName";
            this.TextBoxTreatmentName.Size = new System.Drawing.Size(425, 27);
            this.TextBoxTreatmentName.TabIndex = 10;
            // 
            // TextBoxTreatmentDescription
            // 
            this.TextBoxTreatmentDescription.AcceptsReturn = true;
            this.TextBoxTreatmentDescription.Location = new System.Drawing.Point(174, 145);
            this.TextBoxTreatmentDescription.Multiline = true;
            this.TextBoxTreatmentDescription.Name = "TextBoxTreatmentDescription";
            this.TextBoxTreatmentDescription.Size = new System.Drawing.Size(425, 87);
            this.TextBoxTreatmentDescription.TabIndex = 11;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(119, 85);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(52, 20);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Name:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(87, 145);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(88, 20);
            this.LabelDescription.TabIndex = 17;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelDuration
            // 
            this.LabelDuration.AutoSize = true;
            this.LabelDuration.Location = new System.Drawing.Point(103, 259);
            this.LabelDuration.Name = "LabelDuration";
            this.LabelDuration.Size = new System.Drawing.Size(70, 20);
            this.LabelDuration.TabIndex = 24;
            this.LabelDuration.Text = "Duration:";
            // 
            // TextBoxMinimumAge
            // 
            this.TextBoxMinimumAge.Location = new System.Drawing.Point(325, 312);
            this.TextBoxMinimumAge.Name = "TextBoxMinimumAge";
            this.TextBoxMinimumAge.Size = new System.Drawing.Size(45, 27);
            this.TextBoxMinimumAge.TabIndex = 25;
            // 
            // TextBoxMaximumAge
            // 
            this.TextBoxMaximumAge.Location = new System.Drawing.Point(398, 312);
            this.TextBoxMaximumAge.Name = "TextBoxMaximumAge";
            this.TextBoxMaximumAge.Size = new System.Drawing.Size(45, 27);
            this.TextBoxMaximumAge.TabIndex = 26;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(282, 312);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(39, 20);
            this.LabelAge.TabIndex = 27;
            this.LabelAge.Text = "Age:";
            // 
            // LabelHifenMinimumMaximumAge
            // 
            this.LabelHifenMinimumMaximumAge.AutoSize = true;
            this.LabelHifenMinimumMaximumAge.Location = new System.Drawing.Point(377, 316);
            this.LabelHifenMinimumMaximumAge.Name = "LabelHifenMinimumMaximumAge";
            this.LabelHifenMinimumMaximumAge.Size = new System.Drawing.Size(15, 20);
            this.LabelHifenMinimumMaximumAge.TabIndex = 28;
            this.LabelHifenMinimumMaximumAge.Text = "-";
            // 
            // DateTimePickerDuration
            // 
            this.DateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerDuration.Location = new System.Drawing.Point(174, 259);
            this.DateTimePickerDuration.Name = "DateTimePickerDuration";
            this.DateTimePickerDuration.ShowUpDown = true;
            this.DateTimePickerDuration.Size = new System.Drawing.Size(250, 27);
            this.DateTimePickerDuration.TabIndex = 29;
            this.DateTimePickerDuration.Value = new System.DateTime(2021, 6, 20, 0, 0, 0, 0);
            // 
            // GroupBoxBodyPart
            // 
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonRightFoot);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonLeftFoot);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonRightLeg);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonLeftLeg);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonTorso);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonRightArm);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonLeftArm);
            this.GroupBoxBodyPart.Controls.Add(this.RadioButtonHead);
            this.GroupBoxBodyPart.Location = new System.Drawing.Point(258, 363);
            this.GroupBoxBodyPart.Name = "GroupBoxBodyPart";
            this.GroupBoxBodyPart.Size = new System.Drawing.Size(233, 157);
            this.GroupBoxBodyPart.TabIndex = 31;
            this.GroupBoxBodyPart.TabStop = false;
            this.GroupBoxBodyPart.Text = "Body Part:";
            // 
            // RadioButtonRightFoot
            // 
            this.RadioButtonRightFoot.AutoSize = true;
            this.RadioButtonRightFoot.Location = new System.Drawing.Point(133, 117);
            this.RadioButtonRightFoot.Name = "RadioButtonRightFoot";
            this.RadioButtonRightFoot.Size = new System.Drawing.Size(95, 24);
            this.RadioButtonRightFoot.TabIndex = 7;
            this.RadioButtonRightFoot.TabStop = true;
            this.RadioButtonRightFoot.Text = "RightFoot";
            this.RadioButtonRightFoot.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLeftFoot
            // 
            this.RadioButtonLeftFoot.AutoSize = true;
            this.RadioButtonLeftFoot.Location = new System.Drawing.Point(133, 87);
            this.RadioButtonLeftFoot.Name = "RadioButtonLeftFoot";
            this.RadioButtonLeftFoot.Size = new System.Drawing.Size(85, 24);
            this.RadioButtonLeftFoot.TabIndex = 6;
            this.RadioButtonLeftFoot.TabStop = true;
            this.RadioButtonLeftFoot.Text = "LeftFoot";
            this.RadioButtonLeftFoot.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRightLeg
            // 
            this.RadioButtonRightLeg.AutoSize = true;
            this.RadioButtonRightLeg.Location = new System.Drawing.Point(133, 56);
            this.RadioButtonRightLeg.Name = "RadioButtonRightLeg";
            this.RadioButtonRightLeg.Size = new System.Drawing.Size(89, 24);
            this.RadioButtonRightLeg.TabIndex = 5;
            this.RadioButtonRightLeg.TabStop = true;
            this.RadioButtonRightLeg.Text = "RightLeg";
            this.RadioButtonRightLeg.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLeftLeg
            // 
            this.RadioButtonLeftLeg.AutoSize = true;
            this.RadioButtonLeftLeg.Location = new System.Drawing.Point(133, 27);
            this.RadioButtonLeftLeg.Name = "RadioButtonLeftLeg";
            this.RadioButtonLeftLeg.Size = new System.Drawing.Size(79, 24);
            this.RadioButtonLeftLeg.TabIndex = 4;
            this.RadioButtonLeftLeg.TabStop = true;
            this.RadioButtonLeftLeg.Text = "LeftLeg";
            this.RadioButtonLeftLeg.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTorso
            // 
            this.RadioButtonTorso.AutoSize = true;
            this.RadioButtonTorso.Location = new System.Drawing.Point(7, 117);
            this.RadioButtonTorso.Name = "RadioButtonTorso";
            this.RadioButtonTorso.Size = new System.Drawing.Size(66, 24);
            this.RadioButtonTorso.TabIndex = 3;
            this.RadioButtonTorso.TabStop = true;
            this.RadioButtonTorso.Text = "Torso";
            this.RadioButtonTorso.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRightArm
            // 
            this.RadioButtonRightArm.AutoSize = true;
            this.RadioButtonRightArm.Location = new System.Drawing.Point(6, 85);
            this.RadioButtonRightArm.Name = "RadioButtonRightArm";
            this.RadioButtonRightArm.Size = new System.Drawing.Size(93, 24);
            this.RadioButtonRightArm.TabIndex = 2;
            this.RadioButtonRightArm.TabStop = true;
            this.RadioButtonRightArm.Text = "RightArm";
            this.RadioButtonRightArm.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLeftArm
            // 
            this.RadioButtonLeftArm.AutoSize = true;
            this.RadioButtonLeftArm.Location = new System.Drawing.Point(6, 56);
            this.RadioButtonLeftArm.Name = "RadioButtonLeftArm";
            this.RadioButtonLeftArm.Size = new System.Drawing.Size(83, 24);
            this.RadioButtonLeftArm.TabIndex = 1;
            this.RadioButtonLeftArm.TabStop = true;
            this.RadioButtonLeftArm.Text = "LeftArm";
            this.RadioButtonLeftArm.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHead
            // 
            this.RadioButtonHead.AutoSize = true;
            this.RadioButtonHead.Location = new System.Drawing.Point(6, 27);
            this.RadioButtonHead.Name = "RadioButtonHead";
            this.RadioButtonHead.Size = new System.Drawing.Size(66, 24);
            this.RadioButtonHead.TabIndex = 0;
            this.RadioButtonHead.TabStop = true;
            this.RadioButtonHead.Text = "Head";
            this.RadioButtonHead.UseVisualStyleBackColor = true;
            // 
            // AddTreatmentItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GroupBoxBodyPart);
            this.Controls.Add(this.DateTimePickerDuration);
            this.Controls.Add(this.LabelHifenMinimumMaximumAge);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.TextBoxMaximumAge);
            this.Controls.Add(this.TextBoxMinimumAge);
            this.Controls.Add(this.LabelDuration);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxTreatmentDescription);
            this.Controls.Add(this.TextBoxTreatmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAddTreatment);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "AddTreatmentItemScreen";
            this.Size = new System.Drawing.Size(762, 612);
            this.Load += new System.EventHandler(this.AddTreatmentItemScreen_Load);
            this.Controls.SetChildIndex(this.ButtonAddTreatment, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TextBoxTreatmentName, 0);
            this.Controls.SetChildIndex(this.TextBoxTreatmentDescription, 0);
            this.Controls.SetChildIndex(this.LabelName, 0);
            this.Controls.SetChildIndex(this.LabelDescription, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.LabelDuration, 0);
            this.Controls.SetChildIndex(this.TextBoxMinimumAge, 0);
            this.Controls.SetChildIndex(this.TextBoxMaximumAge, 0);
            this.Controls.SetChildIndex(this.LabelAge, 0);
            this.Controls.SetChildIndex(this.LabelHifenMinimumMaximumAge, 0);
            this.Controls.SetChildIndex(this.DateTimePickerDuration, 0);
            this.Controls.SetChildIndex(this.GroupBoxBodyPart, 0);
            this.GroupBoxBodyPart.ResumeLayout(false);
            this.GroupBoxBodyPart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddTreatment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTreatmentName;
        private System.Windows.Forms.TextBox TextBoxTreatmentDescription;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelDuration;
        private System.Windows.Forms.TextBox TextBoxMinimumAge;
        private System.Windows.Forms.TextBox TextBoxMaximumAge;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelHifenMinimumMaximumAge;
        private System.Windows.Forms.DateTimePicker DateTimePickerDuration;
        private System.Windows.Forms.GroupBox GroupBoxBodyPart;
        private System.Windows.Forms.RadioButton RadioButtonRightFoot;
        private System.Windows.Forms.RadioButton RadioButtonLeftFoot;
        private System.Windows.Forms.RadioButton RadioButtonRightLeg;
        private System.Windows.Forms.RadioButton RadioButtonLeftLeg;
        private System.Windows.Forms.RadioButton RadioButtonTorso;
        private System.Windows.Forms.RadioButton RadioButtonRightArm;
        private System.Windows.Forms.RadioButton RadioButtonLeftArm;
        private System.Windows.Forms.RadioButton RadioButtonHead;
    }
}
