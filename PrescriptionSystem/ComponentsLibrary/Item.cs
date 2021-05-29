using System.ComponentModel.DataAnnotations;

namespace ComponentsLibrary
{
    public class Item
    {
        public int Id { get; set; }

        public bool Zombie { get; set; }

        public byte[] TimeStamp { get; set; }
    }
}