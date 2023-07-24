using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblLastProduct")]

    public class LastProduct
    {
        public LastProduct()
        {
            Sale = new HashSet<Sale>();
        }
        public int Id { get; set; }
        public int? LabId { get; set; }

        public virtual LabData? LabData { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
