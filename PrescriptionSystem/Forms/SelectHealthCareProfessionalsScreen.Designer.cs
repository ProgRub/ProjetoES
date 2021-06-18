
namespace Forms
{
    partial class SelectHealthCareProfessionalsScreen
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
            this.CheckedListBoxProfessionals = new System.Windows.Forms.CheckedListBox();
            this.CheckBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.ButtonAddViewers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.Location = new System.Drawing.Point(186, 4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(414, 47);
            this.LabelTitle.TabIndex = 27;
            this.LabelTitle.Text = "Select the Health Care Professionals who will be able to view the details of the " +
    "prescriptions you selected before";
            // 
            // CheckedListBoxProfessionals
            // 
            this.CheckedListBoxProfessionals.CheckOnClick = true;
            this.CheckedListBoxProfessionals.ColumnWidth = 300;
            this.CheckedListBoxProfessionals.FormattingEnabled = true;
            this.CheckedListBoxProfessionals.Location = new System.Drawing.Point(0, 78);
            this.CheckedListBoxProfessionals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckedListBoxProfessionals.MultiColumn = true;
            this.CheckedListBoxProfessionals.Name = "CheckedListBoxProfessionals";
            this.CheckedListBoxProfessionals.Size = new System.Drawing.Size(746, 328);
            this.CheckedListBoxProfessionals.TabIndex = 28;
            this.CheckedListBoxProfessionals.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxProfessionals_ItemCheck);
            // 
            // CheckBoxSelectAll
            // 
            this.CheckBoxSelectAll.AutoSize = true;
            this.CheckBoxSelectAll.Enabled = false;
            this.CheckBoxSelectAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxSelectAll.Location = new System.Drawing.Point(0, 48);
            this.CheckBoxSelectAll.Name = "CheckBoxSelectAll";
            this.CheckBoxSelectAll.Size = new System.Drawing.Size(92, 25);
            this.CheckBoxSelectAll.TabIndex = 29;
            this.CheckBoxSelectAll.Text = "Select All";
            this.CheckBoxSelectAll.UseVisualStyleBackColor = true;
            this.CheckBoxSelectAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckBoxSelectAll_MouseClick);
            // 
            // ButtonAddViewers
            // 
            this.ButtonAddViewers.Enabled = false;
            this.ButtonAddViewers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddViewers.Location = new System.Drawing.Point(752, 227);
            this.ButtonAddViewers.Name = "ButtonAddViewers";
            this.ButtonAddViewers.Size = new System.Drawing.Size(59, 30);
            this.ButtonAddViewers.TabIndex = 30;
            this.ButtonAddViewers.Text = "Done";
            this.ButtonAddViewers.UseVisualStyleBackColor = true;
            this.ButtonAddViewers.Click += new System.EventHandler(this.ButtonSelectHealthCareProfessionals_Click);
            // 
            // SelectHealthCareProfessionalsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAddViewers);
            this.Controls.Add(this.CheckBoxSelectAll);
            this.Controls.Add(this.CheckedListBoxProfessionals);
            this.Controls.Add(this.LabelTitle);
            this.Name = "SelectHealthCareProfessionalsScreen";
            this.Size = new System.Drawing.Size(814, 419);
            this.Load += new System.EventHandler(this.SelectHealthCareProfessionalsScreen_Load);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.LabelTitle, 0);
            this.Controls.SetChildIndex(this.CheckedListBoxProfessionals, 0);
            this.Controls.SetChildIndex(this.CheckBoxSelectAll, 0);
            this.Controls.SetChildIndex(this.ButtonAddViewers, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.CheckedListBox CheckedListBoxProfessionals;
        private System.Windows.Forms.CheckBox CheckBoxSelectAll;
        private System.Windows.Forms.Button ButtonAddViewers;
    }
}
