using ComponentsLibrary.Entities;

namespace ServicesLibrary.DTOs
{
    public class MedicalConditionDTO : ItemDTO
    {
        public const int Allergy = 0, Disease = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }

        public static MedicalConditionDTO ConvertMedicalConditionToDTO(MedicalCondition medicalCondition)
        {
            return new MedicalConditionDTO
            {
                Id = medicalCondition.Id,
                Name = medicalCondition.Name, Description = medicalCondition.Description, Type = medicalCondition.Type
            };
        }
    }
}