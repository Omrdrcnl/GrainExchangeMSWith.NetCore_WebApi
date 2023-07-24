using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblDistrict")]

    public class District
    {
        public District() {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int CityId { get; set; }
        public virtual City? City { get; set; }

        public virtual ICollection<Address> Address { get; set; }

    }
}
