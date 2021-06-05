
namespace Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMedicineName = new System.Windows.Forms.TextBox();
            this.textBoxMedicineDescription = new System.Windows.Forms.TextBox();
            this.textBoxMedicinePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckedListBoxDiseases = new System.Windows.Forms.CheckedListBox();
            this.CheckedListBoxAllergies = new System.Windows.Forms.CheckedListBox();
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
            this.button1.Location = new System.Drawing.Point(218, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Prescription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create Medicine Prescription Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMedicineName
            // 
            this.textBoxMedicineName.Location = new System.Drawing.Point(174, 85);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.Size = new System.Drawing.Size(250, 27);
            this.textBoxMedicineName.TabIndex = 10;
            this.textBoxMedicineName.TextChanged += new System.EventHandler(this.textBoxMedicineName_TextChanged);
            // 
            // textBoxMedicineDescription
            // 
            this.textBoxMedicineDescription.Location = new System.Drawing.Point(174, 138);
            this.textBoxMedicineDescription.Multiline = true;
            this.textBoxMedicineDescription.Name = "textBoxMedicineDescription";
            this.textBoxMedicineDescription.Size = new System.Drawing.Size(250, 93);
            this.textBoxMedicineDescription.TabIndex = 11;
            // 
            // textBoxMedicinePrice
            // 
            this.textBoxMedicinePrice.Location = new System.Drawing.Point(174, 253);
            this.textBoxMedicinePrice.Name = "textBoxMedicinePrice";
            this.textBoxMedicinePrice.Size = new System.Drawing.Size(250, 27);
            this.textBoxMedicinePrice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Allergenics:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Incompatible Diseases:";
            // 
            // CheckedListBoxDiseases
            // 
            this.CheckedListBoxDiseases.CheckOnClick = true;
            this.CheckedListBoxDiseases.FormattingEnabled = true;
            this.CheckedListBoxDiseases.Location = new System.Drawing.Point(174, 471);
            this.CheckedListBoxDiseases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckedListBoxDiseases.MultiColumn = true;
            this.CheckedListBoxDiseases.Name = "CheckedListBoxDiseases";
            this.CheckedListBoxDiseases.Size = new System.Drawing.Size(250, 136);
            this.CheckedListBoxDiseases.TabIndex = 31;
            // 
            // CheckedListBoxAllergies
            // 
            this.CheckedListBoxAllergies.CheckOnClick = true;
            this.CheckedListBoxAllergies.FormattingEnabled = true;
            this.CheckedListBoxAllergies.Location = new System.Drawing.Point(174, 302);
            this.CheckedListBoxAllergies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckedListBoxAllergies.MultiColumn = true;
            this.CheckedListBoxAllergies.Name = "CheckedListBoxAllergies";
            this.CheckedListBoxAllergies.Size = new System.Drawing.Size(250, 136);
            this.CheckedListBoxAllergies.TabIndex = 28;
            // 
            // AddMedicineItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CheckedListBoxDiseases);
            this.Controls.Add(this.CheckedListBoxAllergies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMedicinePrice);
            this.Controls.Add(this.textBoxMedicineDescription);
            this.Controls.Add(this.textBoxMedicineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddMedicineItemScreen";
            this.Size = new System.Drawing.Size(533, 707);
            this.Load += new System.EventHandler(this.AddMedicineItem_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxMedicineName, 0);
            this.Controls.SetChildIndex(this.textBoxMedicineDescription, 0);
            this.Controls.SetChildIndex(this.textBoxMedicinePrice, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxAllergies, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxDiseases, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMedicineName;
        private System.Windows.Forms.TextBox textBoxMedicineDescription;
        private System.Windows.Forms.TextBox textBoxMedicinePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox CheckedListBoxDiseases;
        private System.Windows.Forms.CheckedListBox CheckedListBoxAllergies;
    }
}
