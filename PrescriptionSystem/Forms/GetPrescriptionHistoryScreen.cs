using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServicesLibrary;
using System.Linq;

namespace Forms
{
    public partial class GetPrescriptionHistoryScreen : BaseControl
    {
        public GetPrescriptionHistoryScreen()
        {
            InitializeComponent();
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenPatient());
        }

        private void GetPrescriptionHistoryScreen_Load(object sender, EventArgs e)
        {

            foreach (var prescription in Services.Instance.GetLoggedInPatientsPrescriptions())
            {
                var listViewItem = new ListViewItem(prescription.Author.FullName);
                listViewItem.SubItems.Add(prescription.Description);
                listViewItem.SubItems.Add(prescription.StartDate.ToString("MM/dd/yyyy"));
                listViewItem.SubItems.Add(prescription.EndDate.ToString("MM/dd/yyyy"));
                listViewItem.SubItems.Add("Show more details");
                listViewPrescriptionHistory.Items.Add(listViewItem);
            }
        }
    }
}
