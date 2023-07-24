using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblCity")]

    public class City
    {
        public City()
        {
            Address = new HashSet<Address>();
            District = new HashSet<District>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
