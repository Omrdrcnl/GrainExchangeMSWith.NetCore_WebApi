using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    public class Tradesman
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int IdentyNo { get; set; }
        public string? Contact { get; set; }
        public int? AddressId { get; set; }
        public DateTime? BirthDate { get; set; }
        public virtual Address? Address { get; set; }
    }

}
