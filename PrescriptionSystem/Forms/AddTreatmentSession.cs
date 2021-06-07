using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using Microsoft.EntityFrameworkCore;
using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddTreatmentSession : BaseControl
    {
        public AddTreatmentSession()
        {
            InitializeComponent();
            foreach (var patient in Services.Instance.GetAllPatients())
            {
                comboBoxPatient.Items.Add(patient.FullName);
            }
            foreach (var treatment in Services.Instance.GetAllTreatments())
            {
                treatments.Items.Add(treatment.Name);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenTherapist());
        }

    }
}
