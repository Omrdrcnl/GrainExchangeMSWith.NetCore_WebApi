using System.ComponentModel.DataAnnotations.Schema;


namespace TahilBorsasi.Model
{
    [Table("tblProductName")]
    public class ProductName
    {
        public ProductName()
        {
            EntryProduct = new HashSet<EntryProduct>();
        }
        public byte Id { get; set; }
        public string Name { get; set; }
        public string? Information { get; set; }

        public virtual ICollection<EntryProduct> EntryProduct { get; set; }

    }
}