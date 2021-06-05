using System.Collections.Generic;

namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public abstract class PrescriptionItem : Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<PrescriptionHasPrescriptionItems> PrescriptionHasPrescriptionItemsCollection { get; set; }
    }
}