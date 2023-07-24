using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblAddress")]

    public class Address
    {
        public Address()
        {
            Farmer = new HashSet<Farmer>();
            Tradesman = new HashSet<Tradesman>();
        }

        public int Id { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? NeighborhoodName { get; set; }
        public string? FullAddress { get; set; }

        public virtual City? City { get; set; }
        public virtual District? District { get; set; }

        public virtual ICollection<Farmer> Farmer { get; set; }
        public virtual ICollection<Tradesman> Tradesman { get; set; }
    }
}
