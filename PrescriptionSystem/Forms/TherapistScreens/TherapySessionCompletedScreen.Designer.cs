﻿
namespace Forms.TherapistScreens
{
    partial class TherapySessionCompletedScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TherapySessionCompletedScreen));
            this.ListViewTreatments = new System.Windows.Forms.ListView();
            this.ColumnHeaderTreatmentName = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderTreatmentDescription = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderTreatmentBodyPart = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderTreatmentDuration = new System.Windows.Forms.ColumnHeader();
            this.LabelTreatments = new System.Windows.Forms.Label();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.ButtonRedo = new System.Windows.Forms.Button();
            this.TextBoxTreatmentNote = new System.Windows.Forms.TextBox();
            this.LabelTreatmentNote = new System.Windows.Forms.Label();
            this.CheckBoxCompletedTreatment = new System.Windows.Forms.CheckBox();
            this.LabelSessionInfo = new System.Windows.Forms.Label();
            this.LabelTherapySessionNote = new System.Windows.Forms.Label();
            this.TextBoxTherapySessionNote = new System.Windows.Forms.TextBox();
            this.ButtonAddSessionNote = new System.Windows.Forms.Button();
            this.ButtonAddTreatmentNoteSetCompletedState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ListViewTreatments
            // 
            this.ListViewTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderTreatmentName,
            this.ColumnHeaderTreatmentDescription,
            this.ColumnHeaderTreatmentBodyPart,
            this.ColumnHeaderTreatmentDuration});
            this.ListViewTreatments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewTreatments.FullRowSelect = true;
            this.ListViewTreatments.GridLines = true;
            this.ListViewTreatments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewTreatments.HideSelection = false;
            this.ListViewTreatments.Location = new System.Drawing.Point(45, 67);
            this.ListViewTreatments.MultiSelect = false;
            this.ListViewTreatments.Name = "ListViewTreatments";
            this.ListViewTreatments.Size = new System.Drawing.Size(904, 254);
            this.ListViewTreatments.TabIndex = 6;
            this.ListViewTreatments.UseCompatibleStateImageBehavior = false;
            this.ListViewTreatments.View = System.Windows.Forms.View.Details;
            this.ListViewTreatments.SelectedIndexChanged += new System.EventHandler(this.ListViewTreatments_SelectedIndexChanged);
            // 
            // ColumnHeaderTreatmentName
            // 
            this.ColumnHeaderTreatmentName.Text = "Name";
            this.ColumnHeaderTreatmentName.Width = 200;
            // 
            // ColumnHeaderTreatmentDescription
            // 
            this.ColumnHeaderTreatmentDescription.Text = "Description";
            this.ColumnHeaderTreatmentDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeaderTreatmentDescription.Width = 500;
            // 
            // ColumnHeaderTreatmentBodyPart
            // 
            this.ColumnHeaderTreatmentBodyPart.Text = "Body Part";
            this.ColumnHeaderTreatmentBodyPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeaderTreatmentBodyPart.Width = 100;
            // 
            // ColumnHeaderTreatmentDuration
            // 
            this.ColumnHeaderTreatmentDuration.Text = "Duration";
            this.ColumnHeaderTreatmentDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeaderTreatmentDuration.Width = 100;
            // 
            // LabelTreatments
            // 
            this.LabelTreatments.AutoSize = true;
            this.LabelTreatments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTreatments.Location = new System.Drawing.Point(442, 43);
            this.LabelTreatments.Name = "LabelTreatments";
            this.LabelTreatments.Size = new System.Drawing.Size(87, 21);
            this.LabelTreatments.TabIndex = 7;
            this.LabelTreatments.Text = "Treatments";
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonUndo.Enabled = false;
            this.ButtonUndo.FlatAppearance.BorderSize = 0;
            this.ButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUndo.Image")));
            this.ButtonUndo.Location = new System.Drawing.Point(432, 327);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(36, 23);
            this.ButtonUndo.TabIndex = 8;
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonRedo
            // 
            this.ButtonRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonRedo.Enabled = false;
            this.ButtonRedo.FlatAppearance.BorderSize = 0;
            this.ButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRedo.Image")));
            this.ButtonRedo.Location = new System.Drawing.Point(507, 327);
            this.ButtonRedo.Name = "ButtonRedo";
            this.ButtonRedo.Size = new System.Drawing.Size(36, 23);
            this.ButtonRedo.TabIndex = 9;
            this.ButtonRedo.UseVisualStyleBackColor = true;
            this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
            // 
            // TextBoxTreatmentNote
            // 
            this.TextBoxTreatmentNote.AcceptsReturn = true;
            this.TextBoxTreatmentNote.Enabled = false;
            this.TextBoxTreatmentNote.Location = new System.Drawing.Point(191, 501);
            this.TextBoxTreatmentNote.Multiline = true;
            this.TextBoxTreatmentNote.Name = "TextBoxTreatmentNote";
            this.TextBoxTreatmentNote.Size = new System.Drawing.Size(742, 134);
            this.TextBoxTreatmentNote.TabIndex = 10;
            // 
            // LabelTreatmentNote
            // 
            this.LabelTreatmentNote.AutoSize = true;
            this.LabelTreatmentNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTreatmentNote.Location = new System.Drawing.Point(67, 499);
            this.LabelTreatmentNote.Name = "LabelTreatmentNote";
            this.LabelTreatmentNote.Size = new System.Drawing.Size(118, 21);
            this.LabelTreatmentNote.TabIndex = 11;
            this.LabelTreatmentNote.Text = "Treatment Note";
            // 
            // CheckBoxCompletedTreatment
            // 
            this.CheckBoxCompletedTreatment.AutoSize = true;
            this.CheckBoxCompletedTreatment.Enabled = false;
            this.CheckBoxCompletedTreatment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxCompletedTreatment.Location = new System.Drawing.Point(482, 641);
            this.CheckBoxCompletedTreatment.Name = "CheckBoxCompletedTreatment";
            this.CheckBoxCompletedTreatment.Size = new System.Drawing.Size(186, 25);
            this.CheckBoxCompletedTreatment.TabIndex = 12;
            this.CheckBoxCompletedTreatment.Text = "Completed Treatment?";
            this.CheckBoxCompletedTreatment.UseVisualStyleBackColor = true;
            // 
            // LabelSessionInfo
            // 
            this.LabelSessionInfo.AutoSize = true;
            this.LabelSessionInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSessionInfo.Location = new System.Drawing.Point(377, 4);
            this.LabelSessionInfo.Name = "LabelSessionInfo";
            this.LabelSessionInfo.Size = new System.Drawing.Size(213, 21);
            this.LabelSessionInfo.TabIndex = 13;
            this.LabelSessionInfo.Text = "Same Text as Previous Screen";
            // 
            // LabelTherapySessionNote
            // 
            this.LabelTherapySessionNote.AutoSize = true;
            this.LabelTherapySessionNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTherapySessionNote.Location = new System.Drawing.Point(24, 360);
            this.LabelTherapySessionNote.Name = "LabelTherapySessionNote";
            this.LabelTherapySessionNote.Size = new System.Drawing.Size(161, 21);
            this.LabelTherapySessionNote.TabIndex = 15;
            this.LabelTherapySessionNote.Text = "Therapy Session Note";
            // 
            // TextBoxTherapySessionNote
            // 
            this.TextBoxTherapySessionNote.AcceptsReturn = true;
            this.TextBoxTherapySessionNote.Location = new System.Drawing.Point(191, 362);
            this.TextBoxTherapySessionNote.Multiline = true;
            this.TextBoxTherapySessionNote.Name = "TextBoxTherapySessionNote";
            this.TextBoxTherapySessionNote.Size = new System.Drawing.Size(742, 134);
            this.TextBoxTherapySessionNote.TabIndex = 14;
            this.TextBoxTherapySessionNote.TextChanged += new System.EventHandler(this.TextBoxTherapySessionNote_TextChanged);
            // 
            // ButtonAddSessionNote
            // 
            this.ButtonAddSessionNote.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddSessionNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSessionNote.ForeColor = System.Drawing.Color.White;
            this.ButtonAddSessionNote.Location = new System.Drawing.Point(955, 405);
            this.ButtonAddSessionNote.Name = "ButtonAddSessionNote";
            this.ButtonAddSessionNote.Size = new System.Drawing.Size(140, 54);
            this.ButtonAddSessionNote.TabIndex = 16;
            this.ButtonAddSessionNote.Text = "Add Session Note";
            this.ButtonAddSessionNote.UseVisualStyleBackColor = false;
            this.ButtonAddSessionNote.Click += new System.EventHandler(this.ButtonAddSessionNote_Click);
            // 
            // ButtonAddTreatmentNoteSetCompletedState
            // 
            this.ButtonAddTreatmentNoteSetCompletedState.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonAddTreatmentNoteSetCompletedState.Enabled = false;
            this.ButtonAddTreatmentNoteSetCompletedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddTreatmentNoteSetCompletedState.ForeColor = System.Drawing.Color.White;
            this.ButtonAddTreatmentNoteSetCompletedState.Location = new System.Drawing.Point(955, 513);
            this.ButtonAddTreatmentNoteSetCompletedState.Name = "ButtonAddTreatmentNoteSetCompletedState";
            this.ButtonAddTreatmentNoteSetCompletedState.Size = new System.Drawing.Size(186, 98);
            this.ButtonAddTreatmentNoteSetCompletedState.TabIndex = 17;
            this.ButtonAddTreatmentNoteSetCompletedState.Text = "Add Treatment Note && Set Completed State";
            this.ButtonAddTreatmentNoteSetCompletedState.UseVisualStyleBackColor = false;
            this.ButtonAddTreatmentNoteSetCompletedState.Click += new System.EventHandler(this.ButtonAddTreatmentNoteSetCompletedState_Click);
            // 
            // TherapySessionCompletedScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAddTreatmentNoteSetCompletedState);
            this.Controls.Add(this.ButtonAddSessionNote);
            this.Controls.Add(this.LabelTherapySessionNote);
            this.Controls.Add(this.TextBoxTherapySessionNote);
            this.Controls.Add(this.LabelSessionInfo);
            this.Controls.Add(this.CheckBoxCompletedTreatment);
            this.Controls.Add(this.LabelTreatmentNote);
            this.Controls.Add(this.TextBoxTreatmentNote);
            this.Controls.Add(this.ButtonRedo);
            this.Controls.Add(this.ButtonUndo);
            this.Controls.Add(this.LabelTreatments);
            this.Controls.Add(this.ListViewTreatments);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TherapySessionCompletedScreen";
            this.Size = new System.Drawing.Size(1144, 670);
            this.Load += new System.EventHandler(this.TherapySessionCompletedScreen_Load);
            this.Controls.SetChildIndex(this.ListViewTreatments, 0);
            this.Controls.SetChildIndex(this.LabelTreatments, 0);
            this.Controls.SetChildIndex(this.ButtonUndo, 0);
            this.Controls.SetChildIndex(this.ButtonRedo, 0);
            this.Controls.SetChildIndex(this.TextBoxTreatmentNote, 0);
            this.Controls.SetChildIndex(this.LabelTreatmentNote, 0);
            this.Controls.SetChildIndex(this.CheckBoxCompletedTreatment, 0);
            this.Controls.SetChildIndex(this.LabelSessionInfo, 0);
            this.Controls.SetChildIndex(this.ButtonBack, 0);
            this.Controls.SetChildIndex(this.TextBoxTherapySessionNote, 0);
            this.Controls.SetChildIndex(this.LabelTherapySessionNote, 0);
            this.Controls.SetChildIndex(this.ButtonAddSessionNote, 0);
            this.Controls.SetChildIndex(this.ButtonAddTreatmentNoteSetCompletedState, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewTreatments;
        private System.Windows.Forms.ColumnHeader ColumnHeaderTreatmentName;
        private System.Windows.Forms.ColumnHeader ColumnHeaderTreatmentDescription;
        private System.Windows.Forms.ColumnHeader ColumnHeaderTreatmentBodyPart;
        private System.Windows.Forms.ColumnHeader ColumnHeaderTreatmentDuration;
        private System.Windows.Forms.Label LabelTreatments;
        private System.Windows.Forms.Button ButtonUndo;
        private System.Windows.Forms.Button ButtonRedo;
        private System.Windows.Forms.TextBox TextBoxTreatmentNote;
        private System.Windows.Forms.Label LabelTreatmentNote;
        private System.Windows.Forms.CheckBox CheckBoxCompletedTreatment;
        private System.Windows.Forms.Label LabelSessionInfo;
        private System.Windows.Forms.Label LabelTherapySessionNote;
        private System.Windows.Forms.TextBox TextBoxTherapySessionNote;
        private System.Windows.Forms.Button ButtonAddSessionNote;
        private System.Windows.Forms.Button ButtonAddTreatmentNoteSetCompletedState;
    }
}