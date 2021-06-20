using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ServicesLibrary;
using Forms.CommandsCreatePrescription;
using ServicesLibrary.Commands;

namespace Forms
{
    public partial class CreatePrescription : BaseControl
    {
        public CreatePrescription()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenTherapist());
        }

        public static List<string> GetParentNodes(TreeView treeView)
        {
            var results = new List<string>();

            foreach (TreeNode node in treeView.Nodes)
            {
                results.Add(node.Text);
            }
            return results;
        }

        public static List<KeyValuePair<string, string>> GetRecommendedTimesDictionary(TreeView treeView)
        {
            var results = new List<KeyValuePair<string, string>>();

            foreach (TreeNode parent in treeView.Nodes)
            {
                foreach (TreeNode child in parent.Nodes)
                {
                    results.Add(new KeyValuePair<string, string>(parent.Text, child.Text));
                }
            }
            return results;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var results = GetParentNodes(treeViewPrescriptionItems);
            var recommendedTimes = GetRecommendedTimesDictionary(treeViewPrescriptionItems);

            var treatments = new List<string>();
            var medicines = new List<string>();
            var exercises = new List<string>();

            foreach (var item in results)
            {
                Debug.WriteLine(item);
                if (Services.Instance.IsMedicineByName(item)) medicines.Add(item);
                if (Services.Instance.IsExerciseByName(item)) exercises.Add(item);
                if (Services.Instance.IsTreatmentByName(item)) treatments.Add(item);
            }
            
            string patient = "";
            if (comboBoxPatient.SelectedItem != null)
            {
                patient += comboBoxPatient.SelectedItem.ToString();
            }

            IEnumerable<int> errorCodes = Services.Instance.CheckPrescriptionCreation(patient, textBoxDescription.Text, dateTimePickerStartDate.Value.Date,
               dateTimePickerEndDate.Value.Date, treatments, medicines, exercises); 

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
            }
            else
            {
                Services.Instance.CreatePrescription(patient, textBoxDescription.Text, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, treatments, medicines, exercises, recommendedTimes);

                ShowInformationMessageBox("Prescription successfully created.", "Success");
                MoveToScreen(new CalendarScreenTherapist());
            }

        }

        private void ShowErrorMessages(IEnumerable<int> errorCodes)
        {
            var first = true;
            var errorMessage = "";
            foreach (var errorCode in errorCodes)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    errorMessage += Environment.NewLine;
                }
                switch (errorCode)
                {
                    case Services.PatientRequired:
                        errorMessage += "You have to select a patient!";
                        break;
                    case Services.InvalidAge:
                        errorMessage += "A treatment or exercise is not recommended for the patient's age.";
                        break;
                    //case Services.ExerciseInvalidAge:
                    //    errorMessage += "An exercise is not recommended for the patient's age.";
                    //    break;
                    case Services.IncompatibleMedicine:
                        errorMessage += "A medicine can cause an allergic reaction.";
                        break;
                    case Services.IncompatibleDisease:
                        errorMessage += "A medicine is contraindicated.";
                        break;
                    case Services.MissingBodyPart:
                        errorMessage += "The patient can't do an exercise.";
                        break;

                }
            }
            ShowInformationMessageBox(errorMessage, "Error");
        }

        private void CreatePrescription_Load(object sender, EventArgs e)
        {
            
            CommandsManager.Instance.Notify += (sender, args) =>
            {
                ButtonUndo.Enabled = CommandsManager.Instance.HasUndo;
            };

            CommandsManager.Instance.Notify += (sender, args) =>
            {
                ButtonRedo.Enabled = CommandsManager.Instance.HasRedo;
            };

            foreach (var patient in Services.Instance.GetAllPatients())
            {
                comboBoxPatient.Items.Add(patient);
            }

            foreach (var treatment in Services.Instance.GetTreatments())
            {
                comboBoxItems.Items.Add(treatment);
            }

            foreach (var exercise in Services.Instance.GetExercises())
            {
                comboBoxItems.Items.Add(exercise);
            }
            
            foreach (var medicine in Services.Instance.GetMedicine())
            {
                comboBoxItems.Items.Add(medicine);
            }
        }

        private void ComboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonUndo_Click_1(object sender, EventArgs e)
        {
            CommandsManager.Instance.Undo();
        }

        private void ButtonRedo_Click_1(object sender, EventArgs e)
        {
            CommandsManager.Instance.Redo();
        }


        private void ButtonAddTime_Click(object sender, EventArgs e)
        {
            var collection = treeViewPrescriptionItems.SelectedNode.Nodes;

            if (treeViewPrescriptionItems.SelectedNode.Parent != null) return;
            var macro = new MacroCommand();
            var command1 = new CommandCreateRecommendedTime(DateTimePickerRecommendedTime.Value.TimeOfDay);
            command1.Execute();
            macro.Add(command1);

            var command2 = new CommandCreateNode(collection, 1, command1.RecommendedTime.ToString());
            macro.Add(command2);

            CommandsManager.Instance.Execute(macro);
            treeViewPrescriptionItems.ExpandAll();
        }

        private void DateTimePickerRecommendedTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddPrescriptionItem_Click(object sender, EventArgs e)
        {
            
            var macro = new MacroCommand();
            var command1 = new CommandCreatePrescriptionItem(comboBoxItems.SelectedItem.ToString());
            command1.Execute();
            macro.Add(command1);

            var command2 = new CommandCreateNode(treeViewPrescriptionItems.Nodes, 2, command1.Name);
            macro.Add(command2);
            CommandsManager.Instance.Execute(macro);
            treeViewPrescriptionItems.ExpandAll();
            
        }
    }
}
