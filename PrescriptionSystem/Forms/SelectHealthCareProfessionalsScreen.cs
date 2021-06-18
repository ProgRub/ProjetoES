﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;

namespace Forms
{
    public partial class SelectHealthCareProfessionalsScreen : BaseControl
    {
        public SelectHealthCareProfessionalsScreen()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new SelectPrescriptionsScreen());
        }

        private void SelectHealthCareProfessionalsScreen_Load(object sender, EventArgs e)
        {

            var professionals = Services.Instance.GetHealthCareProfessionals();
            if (!professionals.Any()) LabelTitle.Text = "There are no Health Care Professionals registered...";
            else
            {
                CheckBoxSelectAll.Enabled = true;
                ButtonAddViewers.Enabled = true;
                foreach (var professional in professionals)
                {
                    CheckedListBoxProfessionals.Items.Add(professional);
                }
            }

            var columnWidth = 0;
            foreach (string item in CheckedListBoxProfessionals.Items)
            {
                var width = TextRenderer.MeasureText(item, CheckedListBoxProfessionals.Font).Width;
                if (width > columnWidth)
                {
                    columnWidth = width + 20;
                }
            }
            CheckedListBoxProfessionals.ColumnWidth = columnWidth;
        }

        private void CheckBoxSelectAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                for (var i = 0; i < CheckedListBoxProfessionals.Items.Count; i++)
                {
                    CheckedListBoxProfessionals.SetItemChecked(i, true);
                }
            }
            else
            {
                for (var i = 0; i < CheckedListBoxProfessionals.Items.Count; i++)
                {
                    CheckedListBoxProfessionals.SetItemChecked(i, false);
                }
            }
        }

        private void CheckedListBoxProfessionals_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                CheckBoxSelectAll.Checked = false;
            }
            else if (e.NewValue == CheckState.Checked && CheckedListBoxProfessionals.CheckedItems.Count ==
                CheckedListBoxProfessionals.Items.Count - 1)
            {
                CheckBoxSelectAll.Checked = true;
            }
        }

        private void ButtonSelectHealthCareProfessionals_Click(object sender, EventArgs e)
        {
            if (CheckedListBoxProfessionals.CheckedItems.Count > 0)
            {
                var checkedProfessionals = new List<string>();
                foreach (var checkedItem in CheckedListBoxProfessionals.CheckedItems)
                {
                    checkedProfessionals.Add(checkedItem.ToString());
                }
                Services.Instance.AddPermissionToHealthCareProfessionals(checkedProfessionals);
                ShowInformationMessageBox("The selected Health Care Professionals now have access to your prescription details.", "Success");
                MoveToScreen(new SelectPrescriptionsScreen());
            }
            else
            {
                ShowInformationMessageBox("You have to select at least one Health Care Professional!", "Error");
            }
        }
    }
}