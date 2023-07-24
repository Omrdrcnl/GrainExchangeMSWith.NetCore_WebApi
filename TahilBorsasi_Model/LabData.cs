using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblLabData")]

    public class LabData
    {
        public LabData() {
            LastProduct = new HashSet<LastProduct>();
        }
        public int Id {  get; set; }
        public int? EntryProductId { get; set; }
        public int? NutritionalValue { get; set; }
        public bool Process { get; set; }

        public virtual EntryProduct? EntryProduct { get; set; }
        public virtual ICollection<LastProduct> LastProduct { get; set; }
    }
}
