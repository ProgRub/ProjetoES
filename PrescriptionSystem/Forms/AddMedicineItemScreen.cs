using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using Microsoft.EntityFrameworkCore;
using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddMedicineItemScreen : BaseControl
    {
        public AddMedicineItemScreen()
        {
            InitializeComponent();
            foreach (var allergy in Services.Instance.GetAllergies())
            {
                CheckedListBoxAllergies.Items.Add(allergy);
            }

            foreach (var disease in Services.Instance.GetDiseases())
            {
                CheckedListBoxDiseases.Items.Add(disease);
            }
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
            var medicineName = textBoxMedicineName.Text;
            var medicineDescription = textBoxMedicineDescription.Text;
            var medicinePrice = Double.Parse(textBoxMedicinePrice.Text);
            var allergies = new List<string>();
            foreach (var checkedItem in CheckedListBoxAllergies.CheckedItems)
            {
                allergies.Add(checkedItem.ToString());
            }
            var diseases = new List<string>();
            foreach (var checkedItem in CheckedListBoxDiseases.CheckedItems)
            {
                diseases.Add(checkedItem.ToString());
            }

            Services.Instance.CreateMedicinePrescriptionItem(medicineName, medicineDescription,
                medicinePrice, allergies, diseases);


        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new AddPrescriptionItemScreen());
        }

        private void textBoxMedicineName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
