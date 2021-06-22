
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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(509, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prescription\'s History";
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
            this.ListViewPrescriptionHistory.Location = new System.Drawing.Point(33, 117);
            this.ListViewPrescriptionHistory.MultiSelect = false;
            this.ListViewPrescriptionHistory.Name = "ListViewPrescriptionHistory";
            this.ListViewPrescriptionHistory.Size = new System.Drawing.Size(1297, 632);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ListViewPrescriptionHistory);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "GetPrescriptionHistoryScreen";
            this.Size = new System.Drawing.Size(1334, 785);
            this.Enter += new System.EventHandler(this.GetPrescriptionHistoryScreen_Enter);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ListViewPrescriptionHistory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewPrescriptionHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderCreatedBy;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderEndDate;
        private System.Windows.Forms.ColumnHeader columnHeaderLink;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
    }
}
