using ComponentsLibrary.Entities.PrescriptionItems;
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
    public partial class AddTreatmentItemScreen : BaseControl
    {
        public AddTreatmentItemScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AddMedicineItem_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var treatmentName = textBoxTreatmentName.Text;
            var treatmentDescription = textBoxTreatmentDescription.Text;
            var treatmentAgeMinimum = int.Parse(textBoxMinAge.Text);
            var treatmentAgeMaximum = int.Parse(textBoxMaxAge.Text);
            var treatmentDuration = dateTimePickerDuration.Value.TimeOfDay;

            var bodyPart = "";
            foreach (RadioButton rdo in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    bodyPart = rdo.Text;
                    break;
                }
            }
            
            Services.Instance.CreateTreatmentPrescriptionItem(treatmentName, treatmentDescription,
                treatmentAgeMinimum, treatmentAgeMaximum, treatmentDuration, bodyPart);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }
    }
}
