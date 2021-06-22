using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Forms.CommandsCreatePrescription;
using Forms.CommonScreens;
using Forms.TherapistScreens;
using ServicesLibrary;
using ServicesLibrary.Commands;
using ServicesLibrary.DTOs;

namespace Forms.HealthCareProfessionalScreens
{
    public partial class CreatePrescription : BaseControl
    {
        private IEnumerable<TreatmentDTO> _treatments;
        private IEnumerable<ExerciseDTO> _exercises;
        private IEnumerable<PatientDTO> _patients;
        private IEnumerable<MedicineDTO> _medicines;

        public CreatePrescription()
        {
            InitializeComponent();
        }

        private void CreatePrescription_Enter(object sender, EventArgs e)
        {
            CommandsManager.Instance.Notify += (sender, args) => { ButtonUndo.Enabled = CommandsManager.Instance.HasUndo; };

            CommandsManager.Instance.Notify += (sender, args) => { ButtonRedo.Enabled = CommandsManager.Instance.HasRedo; };
            _patients = Services.Instance.GetAllPatients();
            _treatments = Services.Instance.GetAllTreatments();
            _medicines = Services.Instance.GetAllMedicines();
            _exercises = Services.Instance.GetAllExercises();
            comboBoxPatient.Items.Clear();
            comboBoxItems.Items.Clear();

            foreach (var patient in _patients)
            {
                comboBoxPatient.Items.Add($"{patient.Id} - {patient.FullName}");
            }

            foreach (var medicine in _medicines)
            {
                comboBoxItems.Items.Add($"(Medicine) {medicine.Id} | {medicine.Name}");
            }

            foreach (var treatment in _treatments)
            {
                comboBoxItems.Items.Add(
                    $"(Treatment) {treatment.Id} | {treatment.Name} | Age range: {treatment.AgeMinimum}-{treatment.AgeMaximum}");
            }

            foreach (var exercise in _exercises)
            {
                comboBoxItems.Items.Add(
                    $"(Exercise) {exercise.Id} | {exercise.Name} | Age range: {exercise.AgeMinimum}-{exercise.AgeMaximum}");
            }
        }

        private IEnumerable<PrescriptionItemDTO> GetParentNodes(TreeView treeView)
        {
            return (from TreeNode node in treeView.Nodes select GetPrescriptionItemFromString(node.Text)).ToList();
        }

        private IDictionary<PrescriptionItemDTO, IEnumerable<TimeSpan>> GetRecommendedTimesDictionary(TreeView treeView)
        {
            var results = new Dictionary<PrescriptionItemDTO, IEnumerable<TimeSpan>>();

            foreach (TreeNode parent in treeView.Nodes)
            {
                var timeSpans = (from TreeNode child in parent.Nodes select TimeSpan.Parse(child.Text)).ToList();

                results.Add(GetPrescriptionItemFromString(parent.Text), timeSpans);
            }

            return results;
        }

        private PrescriptionItemDTO GetPrescriptionItemFromString(string itemString)
        {
            if (_exercises.Any(e =>
                e.Id.ToString() == itemString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]))
                return _exercises.First(e =>
                    e.Id.ToString() == itemString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]);
            if (_treatments.Any(e =>
                e.Id.ToString() == itemString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]))
                return _treatments.First(e =>
                    e.Id.ToString() == itemString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]);
            return _medicines.First(e =>
                e.Id.ToString() == itemString.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0]);
        }

        private PrescriptionItemDTO GetPrescriptionItemInComboBox()
        {
            if (comboBoxItems.SelectedItem != null)
            {
                switch (comboBoxItems.Text.Substring(comboBoxItems.Text.IndexOf('(') + 1,
                    comboBoxItems.Text.IndexOf(')') - 1))
                {
                    case "Exercise":
                        return _exercises.First(e =>
                            e.Id.ToString() == comboBoxItems.Text.Substring(comboBoxItems.Text.IndexOf(')') + 2)
                                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0]);
                    case "Treatment":
                        return _treatments.First(e =>
                            e.Id.ToString() == comboBoxItems.Text.Substring(comboBoxItems.Text.IndexOf(')') + 2)
                                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0]);
                    case "Medicine":
                        return _medicines.First(e =>
                            e.Id.ToString() == comboBoxItems.Text.Substring(comboBoxItems.Text.IndexOf(')') + 2)
                                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0]);
                    default:
                        throw new NotImplementedException();
                }
            }

            return null;
        }


        private PatientDTO GetSelectedPatientInComboBox()
        {
            if (comboBoxPatient.SelectedItem != null)
            {
                return _patients.First(e =>
                    e.Id.ToString() == comboBoxPatient.Text.Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                        .First());
            }

            return null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var recommendedTimes = GetRecommendedTimesDictionary(TreeViewPrescriptionItems);
            var selectedItems = GetParentNodes(TreeViewPrescriptionItems);
            var prescription = new PrescriptionDTO
            {
                Author = Services.Instance.GetLoggedInHealthCareProfessional(),
                Patient = GetSelectedPatientInComboBox(),
                Description = textBoxDescription.Text,
                StartDate = dateTimePickerStartDate.Value,
                EndDate = dateTimePickerEndDate.Value,
                PrescriptionItemsRecommendedTimes = recommendedTimes,
                Exercises = selectedItems.OfType<ExerciseDTO>(),
                Medicines = selectedItems.OfType<MedicineDTO>(),
                Treatments = selectedItems.OfType<TreatmentDTO>()
            };
            var errorCodes = Services.Instance.CheckPrescriptionCreation(prescription);

            if (errorCodes.Any())
            {
                ShowErrorMessages(errorCodes);
                return;
            }

            Services.Instance.CreatePrescription(prescription);
            ShowInformationMessageBox("Prescription successfully created.", "Success");
            MoveToScreen(new CalendarScreenTherapist(), new LoginScreen());
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
                    case Services.IncompatibleMedicine:
                        errorMessage += "A medicine can cause an allergic reaction.";
                        break;
                    case Services.IncompatibleDisease:
                        errorMessage += "A medicine is contraindicated.";
                        break;
                    case Services.MissingBodyPart:
                        errorMessage += "The patient can't do an exercise.";
                        break;
                    case Services.DatesNotValid:
                        errorMessage += "The end date has to be after the start date.";
                        break;
                }
            }

            ShowInformationMessageBox(errorMessage, "Error");
        }

        private void ButtonAddTime_Click(object sender, EventArgs e)
        {
            if (TreeViewPrescriptionItems.SelectedNode == null) return;

            var collection = TreeViewPrescriptionItems.SelectedNode.Nodes;
            if (TreeViewPrescriptionItems.SelectedNode.Parent != null) return;
            var macro = new MacroCommand();
            var command1 = new CommandCreateRecommendedTime(DateTimePickerRecommendedTime.Value.TimeOfDay);
            macro.Add(command1);

            var command2 = new CommandCreateNode(collection, 1, command1.RecommendedTime.Value.ToString(@"hh\:mm"));
            macro.Add(command2);

            CommandsManager.Instance.Execute(macro);
            TreeViewPrescriptionItems.ExpandAll();
        }

        private void ButtonAddPrescriptionItem_Click(object sender, EventArgs e)
        {
            if (GetPrescriptionItemInComboBox() == null ||GetPrescriptionItemsInPrescription().Any(e=>e.Id== GetPrescriptionItemInComboBox().Id)) return;
            var macro = new MacroCommand();
            var command1 = new CommandCreatePrescriptionItem(GetPrescriptionItemInComboBox());
            macro.Add(command1);

            var command2 = new CommandCreateNode(TreeViewPrescriptionItems.Nodes, 2, command1.Name);
            macro.Add(command2);
            CommandsManager.Instance.Execute(macro);
            TreeViewPrescriptionItems.ExpandAll();
        }

        private void TreeViewPrescriptionItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && TreeViewPrescriptionItems.SelectedNode != null)
            {
                CommandsManager.Instance.Execute(new CommandDeleteNode(TreeViewPrescriptionItems.Nodes,
                    TreeViewPrescriptionItems.SelectedNode));
            }
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Undo();
        }

        private void ButtonRedo_Click(object sender, EventArgs e)
        {
            CommandsManager.Instance.Redo();
            TreeViewPrescriptionItems.ExpandAll();
        }

        private IEnumerable<PrescriptionItemDTO> GetPrescriptionItemsInPrescription()
        {
            var itemNodes = TreeViewPrescriptionItems.Nodes;
            for (var index = 0; index < itemNodes.Count; index++)
            {
                if (itemNodes[index].Parent != null)
                {
                    itemNodes.RemoveAt(index);
                    index--;
                }
            }

            return (from TreeNode itemNode in itemNodes select GetPrescriptionItemFromString(itemNode.Text)).ToList();
        }
    }
}