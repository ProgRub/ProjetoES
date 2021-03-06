using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class PrescriptionItemDTO : ItemDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}