using System;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.CommonScreens
{
    public partial class PrescriptionDetailsScreen : BaseControl
    {
        private PrescriptionDTO _prescription;

        public PrescriptionDetailsScreen()
        {
            InitializeComponent();
        }

        private void PrescriptionDetailsScreen_Enter(object sender, EventArgs e)
        {
            _prescription = Services.Instance.GetSelectedPrescription();
            LabelToChangePatient.Text = $"{_prescription.Patient.Id} - {_prescription.Patient.FullName}";
            LabelToChangeAuthor.Text = $"{_prescription.Author.Id} - {_prescription.Author.FullName}";
            LabelStartDate.Text = _prescription.StartDate.ToString("d");
            LabelEndDate.Text = _prescription.EndDate.ToString("d");
            TextBoxDescription.Text = _prescription.Description;
            foreach (var prescriptionItem in _prescription.PrescriptionItemsRecommendedTimes.Keys)
            {
                var parentNode = new TreeNode($"{prescriptionItem.Id} - {prescriptionItem.Name}");
                if (_prescription.PrescriptionItemsRecommendedTimes[prescriptionItem] != null)
                {
                    foreach (var recommendedTime in _prescription.PrescriptionItemsRecommendedTimes[prescriptionItem])
                    {
                        parentNode.Nodes.Add(new TreeNode(recommendedTime.ToString(@"hh\:mm")));
                    }
                }

                TreeViewPrescriptionItems.Nodes.Add(parentNode);
            }

            TreeViewPrescriptionItems.ExpandAll();
        }
    }
}