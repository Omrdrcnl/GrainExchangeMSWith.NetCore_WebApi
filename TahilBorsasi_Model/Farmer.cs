using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblFarmer")]
    public class Farmer
    {
        public Farmer()
        {
            EntryProduct = new HashSet<EntryProduct>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdentyNo { get; set; }
        public string? Contact { get; set; }
        public int? AddressId { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual Address? Address { get; set; }

        public virtual ICollection<EntryProduct> EntryProduct { get; set; }
    }
}
