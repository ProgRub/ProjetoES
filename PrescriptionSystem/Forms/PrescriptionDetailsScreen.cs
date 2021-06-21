using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms
{
    public partial class PrescriptionDetailsScreen : BaseControl
    {
        private PrescriptionDTO _prescription;

        public PrescriptionDetailsScreen()
        {
            InitializeComponent();
        }

        private void PrescriptionDetailsScreen_Load(object sender, EventArgs e)
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