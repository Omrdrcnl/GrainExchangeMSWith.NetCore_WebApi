using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblEntryProduct")]

    public class EntryProduct
    {
        public EntryProduct()
        {
            LabData = new HashSet<LabData>();
        }

        public int Id { get; set; }
        public int? ProductNameId { get; set; }
        public int? FarmerId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? Process { get; set; }

        public virtual ProductName ProductName { get; set; }
        public virtual Farmer? Farmer { get; set; }
        public virtual ICollection<LabData> LabData { get; set; }

    }
}
