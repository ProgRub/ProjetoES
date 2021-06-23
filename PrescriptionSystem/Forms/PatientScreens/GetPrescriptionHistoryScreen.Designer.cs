
namespace Forms.PatientScreens
{
    partial class GetPrescriptionHistoryScreen
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ListViewPrescriptionHistory = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCreatedBy = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStartDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEndDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLink = new System.Windows.Forms.ColumnHeader();
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
            this.LabelTitle.Location = new System.Drawing.Point(445, 47);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(193, 25);
            this.LabelTitle.TabIndex = 6;
            this.LabelTitle.Text = "Prescription\'s History";
            // 
            // ListViewPrescriptionHistory
            // 
            this.ListViewPrescriptionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderCreatedBy,
            this.columnHeaderDescription,
            this.columnHeaderStartDate,
            this.columnHeaderEndDate,
            this.columnHeaderLink});
            this.ListViewPrescriptionHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewPrescriptionHistory.FullRowSelect = true;
            this.ListViewPrescriptionHistory.GridLines = true;
            this.ListViewPrescriptionHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewPrescriptionHistory.HideSelection = false;
            this.ListViewPrescriptionHistory.Location = new System.Drawing.Point(29, 88);
            this.ListViewPrescriptionHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewPrescriptionHistory.MultiSelect = false;
            this.ListViewPrescriptionHistory.Name = "ListViewPrescriptionHistory";
            this.ListViewPrescriptionHistory.Size = new System.Drawing.Size(1135, 475);
            this.ListViewPrescriptionHistory.TabIndex = 6;
            this.ListViewPrescriptionHistory.UseCompatibleStateImageBehavior = false;
            this.ListViewPrescriptionHistory.View = System.Windows.Forms.View.Details;
            this.ListViewPrescriptionHistory.DoubleClick += new System.EventHandler(this.ListViewPrescriptionHistory_DoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id:";
            // 
            // columnHeaderCreatedBy
            // 
            this.columnHeaderCreatedBy.Text = "Created by:";
            this.columnHeaderCreatedBy.Width = 200;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description:";
            this.columnHeaderDescription.Width = 300;
            // 
            // columnHeaderStartDate
            // 
            this.columnHeaderStartDate.Text = "Start date:";
            this.columnHeaderStartDate.Width = 150;
            // 
            // columnHeaderEndDate
            // 
            this.columnHeaderEndDate.Text = "End date:";
            this.columnHeaderEndDate.Width = 150;
            // 
            // columnHeaderLink
            // 
            this.columnHeaderLink.Text = "";
            this.columnHeaderLink.Width = 450;
            // 
            // GetPrescriptionHistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ListViewPrescriptionHistory);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetPrescriptionHistoryScreen";
            this.Size = new System.Drawing.Size(1167, 589);
            this.Enter += new System.EventHandler(this.GetPrescriptionHistoryScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.ListViewPrescriptionHistory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ListView ListViewPrescriptionHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderCreatedBy;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEndDate;
        private System.Windows.Forms.ColumnHeader columnHeaderLink;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
    }
}
