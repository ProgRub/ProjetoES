using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms
{
    public partial class SelectPrescriptionsScreen : BaseControl
    {
        private IEnumerable<PrescriptionDTO> _prescriptions;
        public SelectPrescriptionsScreen()
        {
            InitializeComponent();
        }
        private void SelectPrescriptionsScreen_Load(object sender, EventArgs e)
        {
            _prescriptions = Services.Instance.GetAllLoggedInPatientsPrescriptions();
            if (!_prescriptions.Any())
            {
                LabelTitle.Text = "You haven't had any prescriptions prescribed to you yet...";
                return;
            }

            CheckBoxSelectAll.Enabled = true;
            ButtonSelectHealthCareProfessionals.Enabled = true;
            foreach (var prescription in _prescriptions)
            {
                CheckedListBoxPrescriptions.Items.Add(
                    $"{prescription.Id} | Author: {prescription.Author.FullName} | From {prescription.StartDate:d} to {prescription.EndDate:d}");
            }

            SetCheckedListBoxColumnWidth(CheckedListBoxPrescriptions);
        }

        private void CheckBoxSelectAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                for (var i = 0; i < CheckedListBoxPrescriptions.Items.Count; i++)
                {
                    CheckedListBoxPrescriptions.SetItemChecked(i, true);
                }
            }
            else
            {
                for (var i = 0; i < CheckedListBoxPrescriptions.Items.Count; i++)
                {
                    CheckedListBoxPrescriptions.SetItemChecked(i, false);
                }
            }
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
                var checkedPrescriptions = new List<PrescriptionDTO>();
                foreach (var checkedItem in CheckedListBoxPrescriptions.CheckedItems)
                {
                    checkedPrescriptions.Add(GetPrescriptionFromString(checkedItem.ToString()));
                }

                Services.Instance.SelectPrescriptions(checkedPrescriptions);
                MoveToScreen(new SelectHealthCareProfessionalsScreen(), this);
            }
            else
            {
                ShowInformationMessageBox("You have to select at least one prescription!", "Error");
            }
        }

        private PrescriptionDTO GetPrescriptionFromString(string prescriptionString)
        {
            return _prescriptions.First(e =>
                e.Id.ToString() == prescriptionString.Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }
    }
}