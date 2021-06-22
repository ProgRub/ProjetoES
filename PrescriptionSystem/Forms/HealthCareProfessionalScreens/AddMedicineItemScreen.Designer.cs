
namespace Forms.HealthCareProfessionalScreens
{
    partial class AddMedicineItemScreen
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
            this.ButtonAddMedicine = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxMedicineName = new System.Windows.Forms.TextBox();
            this.TextBoxMedicineDescription = new System.Windows.Forms.TextBox();
            this.TextBoxMedicinePrice = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelAllergenics = new System.Windows.Forms.Label();
            this.LabelIncompatibleDiseases = new System.Windows.Forms.Label();
            this.CheckedListBoxDiseases = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBoxAllergies = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonAddMedicine
            // 
            this.ButtonAddMedicine.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddMedicine.ForeColor = System.Drawing.Color.White;
            this.ButtonAddMedicine.Location = new System.Drawing.Point(271, 465);
            this.ButtonAddMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAddMedicine.Name = "ButtonAddMedicine";
            this.ButtonAddMedicine.Size = new System.Drawing.Size(130, 34);
            this.ButtonAddMedicine.TabIndex = 6;
            this.ButtonAddMedicine.Text = "Add Medicine";
            this.ButtonAddMedicine.UseVisualStyleBackColor = false;
            this.ButtonAddMedicine.Click += new System.EventHandler(this.ButtonAddMedicine_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(201, 24);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(260, 21);
            this.LabelTitle.TabIndex = 7;
            this.LabelTitle.Text = "Create Medicine Prescription Item";
            // 
            // TextBoxMedicineName
            // 
            this.TextBoxMedicineName.Location = new System.Drawing.Point(152, 64);
            this.TextBoxMedicineName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMedicineName.Name = "TextBoxMedicineName";
            this.TextBoxMedicineName.Size = new System.Drawing.Size(382, 23);
            this.TextBoxMedicineName.TabIndex = 10;
            // 
            // TextBoxMedicineDescription
            // 
            this.TextBoxMedicineDescription.AcceptsReturn = true;
            this.TextBoxMedicineDescription.Location = new System.Drawing.Point(152, 104);
            this.TextBoxMedicineDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMedicineDescription.Multiline = true;
            this.TextBoxMedicineDescription.Name = "TextBoxMedicineDescription";
            this.TextBoxMedicineDescription.Size = new System.Drawing.Size(382, 71);
            this.TextBoxMedicineDescription.TabIndex = 11;
            // 
            // TextBoxMedicinePrice
            // 
            this.TextBoxMedicinePrice.Location = new System.Drawing.Point(152, 190);
            this.TextBoxMedicinePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxMedicinePrice.Name = "TextBoxMedicinePrice";
            this.TextBoxMedicinePrice.Size = new System.Drawing.Size(382, 23);
            this.TextBoxMedicinePrice.TabIndex = 12;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(104, 67);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 15);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Name:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(76, 107);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(70, 15);
            this.LabelDescription.TabIndex = 17;
            this.LabelDescription.Text = "Description:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(110, 193);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(36, 15);
            this.LabelPrice.TabIndex = 20;
            this.LabelPrice.Text = "Price:";
            // 
            // LabelAllergenics
            // 
            this.LabelAllergenics.AutoSize = true;
            this.LabelAllergenics.Location = new System.Drawing.Point(78, 226);
            this.LabelAllergenics.Name = "LabelAllergenics";
            this.LabelAllergenics.Size = new System.Drawing.Size(68, 15);
            this.LabelAllergenics.TabIndex = 23;
            this.LabelAllergenics.Text = "Allergenics:";
            // 
            // LabelIncompatibleDiseases
            // 
            this.LabelIncompatibleDiseases.AutoSize = true;
            this.LabelIncompatibleDiseases.Location = new System.Drawing.Point(19, 353);
            this.LabelIncompatibleDiseases.Name = "LabelIncompatibleDiseases";
            this.LabelIncompatibleDiseases.Size = new System.Drawing.Size(127, 15);
            this.LabelIncompatibleDiseases.TabIndex = 24;
            this.LabelIncompatibleDiseases.Text = "Incompatible Diseases:";
            // 
            // CheckedListBoxDiseases
            // 
            this.CheckedListBoxDiseases.CheckOnClick = true;
            this.CheckedListBoxDiseases.FormattingEnabled = true;
            this.CheckedListBoxDiseases.Location = new System.Drawing.Point(152, 353);
            this.CheckedListBoxDiseases.MultiColumn = true;
            this.CheckedListBoxDiseases.Name = "CheckedListBoxDiseases";
            this.CheckedListBoxDiseases.Size = new System.Drawing.Size(382, 94);
            this.CheckedListBoxDiseases.TabIndex = 31;
            // 
            // CheckedListBoxAllergies
            // 
            this.CheckedListBoxAllergies.CheckOnClick = true;
            this.CheckedListBoxAllergies.FormattingEnabled = true;
            this.CheckedListBoxAllergies.Location = new System.Drawing.Point(152, 226);
            this.CheckedListBoxAllergies.MultiColumn = true;
            this.CheckedListBoxAllergies.Name = "CheckedListBoxAllergies";
            this.CheckedListBoxAllergies.Size = new System.Drawing.Size(382, 94);
            this.CheckedListBoxAllergies.TabIndex = 28;
            // 
            // AddMedicineItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CheckedListBoxDiseases);
            this.Controls.Add(this.CheckedListBoxAllergies);
            this.Controls.Add(this.LabelIncompatibleDiseases);
            this.Controls.Add(this.LabelAllergenics);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxMedicinePrice);
            this.Controls.Add(this.TextBoxMedicineDescription);
            this.Controls.Add(this.TextBoxMedicineName);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonAddMedicine);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMedicineItemScreen";
            this.Size = new System.Drawing.Size(693, 530);
            this.Enter += new System.EventHandler(this.AddMedicineItemScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonAddMedicine, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.TextBoxMedicineName, 0);
            this.Controls.SetChildIndex(this.TextBoxMedicineDescription, 0);
            this.Controls.SetChildIndex(this.TextBoxMedicinePrice, 0);
            this.Controls.SetChildIndex(this.LabelName, 0);
            this.Controls.SetChildIndex(this.LabelDescription, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.LabelPrice, 0);
            this.Controls.SetChildIndex(this.LabelAllergenics, 0);
            this.Controls.SetChildIndex(this.LabelIncompatibleDiseases, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxAllergies, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxDiseases, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddMedicine;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxMedicineName;
        private System.Windows.Forms.TextBox TextBoxMedicineDescription;
        private System.Windows.Forms.TextBox TextBoxMedicinePrice;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelAllergenics;
        private System.Windows.Forms.Label LabelIncompatibleDiseases;
        private System.Windows.Forms.CheckedListBox CheckedListBoxDiseases;
        private System.Windows.Forms.CheckedListBox CheckedListBoxAllergies;
    }
}
