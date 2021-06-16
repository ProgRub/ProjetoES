using System;
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
    public partial class SelectPrescriptionsScreen : BaseControl
    {
        public SelectPrescriptionsScreen()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenPatient());
        }

        private void SelectPrescriptionsScreen_Load(object sender, EventArgs e)
        {
            var prescriptions = Services.Instance.GetPatientPrescriptions();
            if (!prescriptions.Any()) LabelTitle.Text = "You haven't had any prescriptions prescribed to you yet...";
            else
            {
                CheckBoxSelectAll.Enabled = true;
                ButtonSelectHealthCareProfessionals.Enabled = true;
                foreach (var prescription in prescriptions)
                {
                    CheckedListBoxPrescriptions.Items.Add(prescription);
                }
            }
        }

        private void CheckBoxSelectAll_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void CheckedListBoxPrescriptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                CheckBoxSelectAll.Checked = false;
            }
            else if (e.NewValue == CheckState.Checked && CheckedListBoxPrescriptions.CheckedItems.Count ==
                CheckedListBoxPrescriptions.Items.Count - 1)
            {
                CheckBoxSelectAll.Checked = true;
            }
        }

        private void ButtonSelectHealthCareProfessionals_Click(object sender, EventArgs e)
        {
            if (CheckedListBoxPrescriptions.CheckedItems.Count > 0)
            {
                var checkedPrescriptions = new List<string>();
                foreach (var checkedItem in CheckedListBoxPrescriptions.CheckedItems)
                {
                    checkedPrescriptions.Add(checkedItem.ToString());
                }
                Services.Instance.SelectPrescriptions(checkedPrescriptions);
                MoveToScreen(new SelectHealthCareProfessionalsScreen());
            }
            else
            {
                ShowInformationMessageBox("You have to select at least one prescription!","Error");
            }
        }
    }
}