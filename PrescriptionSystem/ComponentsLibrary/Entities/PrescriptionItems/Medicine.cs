using System.Collections.Generic;

namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public class Medicine:PrescriptionItem
    {
        public double Price { get; set; }
        public ICollection<MedicineHasIncompatibleMedicalConditions> MedicineHasIncompatibleMedicalConditionsList { get; set; }
    }
}