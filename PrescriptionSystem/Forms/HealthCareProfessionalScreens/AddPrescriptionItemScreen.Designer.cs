
namespace Forms.HealthCareProfessionalScreens
{
    partial class AddPrescriptionItemScreen
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
            this.ButtonMedicine = new System.Windows.Forms.Button();
            this.ButtonTreatment = new System.Windows.Forms.Button();
            this.ButtonExercise = new System.Windows.Forms.Button();
            this.LabelChoosePrescriptionItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonMedicine
            // 
            this.ButtonMedicine.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMedicine.ForeColor = System.Drawing.Color.Lavender;
            this.ButtonMedicine.Location = new System.Drawing.Point(61, 109);
            this.ButtonMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMedicine.Name = "ButtonMedicine";
            this.ButtonMedicine.Size = new System.Drawing.Size(102, 34);
            this.ButtonMedicine.TabIndex = 6;
            this.ButtonMedicine.Text = "Medicine";
            this.ButtonMedicine.UseVisualStyleBackColor = false;
            this.ButtonMedicine.Click += new System.EventHandler(this.ButtonMedicine_Click);
            // 
            // ButtonTreatment
            // 
            this.ButtonTreatment.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonTreatment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTreatment.ForeColor = System.Drawing.Color.Lavender;
            this.ButtonTreatment.Location = new System.Drawing.Point(230, 109);
            this.ButtonTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTreatment.Name = "ButtonTreatment";
            this.ButtonTreatment.Size = new System.Drawing.Size(102, 34);
            this.ButtonTreatment.TabIndex = 7;
            this.ButtonTreatment.Text = "Treatment";
            this.ButtonTreatment.UseVisualStyleBackColor = false;
            this.ButtonTreatment.Click += new System.EventHandler(this.ButtonTreatment_Click);
            // 
            // ButtonExercise
            // 
            this.ButtonExercise.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonExercise.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExercise.ForeColor = System.Drawing.Color.Lavender;
            this.ButtonExercise.Location = new System.Drawing.Point(392, 109);
            this.ButtonExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExercise.Name = "ButtonExercise";
            this.ButtonExercise.Size = new System.Drawing.Size(102, 34);
            this.ButtonExercise.TabIndex = 8;
            this.ButtonExercise.Text = "Exercise";
            this.ButtonExercise.UseVisualStyleBackColor = false;
            this.ButtonExercise.Click += new System.EventHandler(this.ButtonExercise_Click);
            // 
            // LabelChoosePrescriptionItem
            // 
            this.LabelChoosePrescriptionItem.AutoSize = true;
            this.LabelChoosePrescriptionItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelChoosePrescriptionItem.Location = new System.Drawing.Point(61, 55);
            this.LabelChoosePrescriptionItem.Name = "LabelChoosePrescriptionItem";
            this.LabelChoosePrescriptionItem.Size = new System.Drawing.Size(408, 25);
            this.LabelChoosePrescriptionItem.TabIndex = 9;
            this.LabelChoosePrescriptionItem.Text = "Choose the prescription item you want to add.";
            this.LabelChoosePrescriptionItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddPrescriptionItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelChoosePrescriptionItem);
            this.Controls.Add(this.ButtonExercise);
            this.Controls.Add(this.ButtonTreatment);
            this.Controls.Add(this.ButtonMedicine);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPrescriptionItemScreen";
            this.Size = new System.Drawing.Size(568, 208);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.ButtonMedicine, 0);
            this.Controls.SetChildIndex(this.ButtonTreatment, 0);
            this.Controls.SetChildIndex(this.ButtonExercise, 0);
            this.Controls.SetChildIndex(this.LabelChoosePrescriptionItem, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMedicine;
        private System.Windows.Forms.Button ButtonTreatment;
        private System.Windows.Forms.Button ButtonExercise;
        private System.Windows.Forms.Label LabelChoosePrescriptionItem;
    }
}
