using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Forms.CommonScreens;
using ServicesLibrary;
using ServicesLibrary.DTOs;

namespace Forms.PatientScreens
{
    public partial class GetPrescriptionHistoryScreen : BaseControl
    {
        private IEnumerable<PrescriptionDTO> _prescriptions;
        public GetPrescriptionHistoryScreen()
        {
            InitializeComponent();
        }
        private void GetPrescriptionHistoryScreen_Load(object sender, EventArgs e)
        {
            _prescriptions = Services.Instance.GetAllLoggedInPatientsPrescriptions();
            foreach (var prescription in _prescriptions)
            {
                var listViewItem = new ListViewItem(prescription.Id.ToString());
                listViewItem.SubItems.Add(prescription.Author.FullName);
                listViewItem.SubItems.Add(prescription.Description);
                listViewItem.SubItems.Add(prescription.StartDate.ToString("MM/dd/yyyy"));
                listViewItem.SubItems.Add(prescription.EndDate.ToString("MM/dd/yyyy"));
                listViewItem.SubItems.Add("Show more details");
                ListViewPrescriptionHistory.Items.Add(listViewItem);
            }
        }

        private void ListViewPrescriptionHistory_DoubleClick(object sender, EventArgs e)
        {
            if(ListViewPrescriptionHistory.SelectedItems.Count==0)return;
            Services.Instance.SelectPrescriptions(new[] {GetSelectedPrescription()});
            MoveToScreen(new PrescriptionDetailsScreen(),this);
        }

        private PrescriptionDTO GetSelectedPrescription()
        {
            return _prescriptions.First(e =>
                e.Id.ToString() == ListViewPrescriptionHistory.SelectedItems[0].SubItems[0].Text);
        }
    }
}
