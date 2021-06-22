using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.PatientScreens
{
    public partial class SelectHealthCareProfessionalsScreen : BaseControl
    {
        private IEnumerable<HealthCareProfessionalDTO> _healthCareProfessionals;
        public SelectHealthCareProfessionalsScreen()
        {
            InitializeComponent();
        }
        private void SelectHealthCareProfessionalsScreen_Load(object sender, EventArgs e)
        {

            _healthCareProfessionals = Services.Instance.GetAllHealthCareProfessionals();
            if (!_healthCareProfessionals.Any())
            {
                LabelTitle.Text = "There are no Health Care Professionals registered...";
                return;
            }

            CheckBoxSelectAll.Enabled = true;
            ButtonAddViewers.Enabled = true;
            foreach (var professional in _healthCareProfessionals)
            {
                CheckedListBoxProfessionals.Items.Add($"{professional.Id} - {professional.FullName}");
            }

            SetCheckedListBoxColumnWidth(CheckedListBoxProfessionals);
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

        private HealthCareProfessionalDTO GetHealthCareProfessionalByString(string professionalString)
        {
            var professionalSplit = professionalString.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            return _healthCareProfessionals.First(e => e.Id.ToString() == professionalSplit[0]);
        }

        private void ButtonSelectHealthCareProfessionals_Click(object sender, EventArgs e)
        {
            if (CheckedListBoxProfessionals.CheckedItems.Count > 0)
            {
                var checkedProfessionals = new List<HealthCareProfessionalDTO>();

                foreach (var checkedItem in CheckedListBoxProfessionals.CheckedItems)
                {
                    checkedProfessionals.Add(GetHealthCareProfessionalByString(checkedItem.ToString()));
                }
                Services.Instance.AddPermissionToHealthCareProfessionals(checkedProfessionals);
                ShowInformationMessageBox("The selected Health Care Professionals now have access to your prescription details.", "Success");
                MoveToScreen(new SelectPrescriptionsScreen(), new CalendarScreenPatient());
            }
            else
            {
                ShowInformationMessageBox("You have to select at least one Health Care Professional!", "Error");
            }
        }
    }
}
