using System.Collections.Generic;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class MedicalCondition:Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public ICollection<MedicineHasIncompatibleMedicalConditions> MedicineHasIncompatibleMedicalConditionsList { get; set; }
        public ICollection<UserHasMedicalCondition> UserHasMedicalConditions { get; set; }
    }
}