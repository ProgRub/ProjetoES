namespace ComponentsLibrary.Entities.PrescriptionItems
{
    public abstract class PrescriptionItem : Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}