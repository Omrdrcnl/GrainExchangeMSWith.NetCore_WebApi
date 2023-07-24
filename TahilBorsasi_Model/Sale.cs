using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblSale")]
    public class Sale
    {
        public Sale() {
            SaleTrades = new HashSet<SaleTrades>();
        }
        public int Id { get; set; }
        public int? LastProductId { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? ActualPrice { get; set; }
        public decimal? Amount { get; set; }

        public virtual LastProduct? LastProduct { get; set; }
        public virtual ICollection<SaleTrades> SaleTrades { get; set; }
    }
}
