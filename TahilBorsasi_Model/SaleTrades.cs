using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahilBorsasi.Model
{
    [Table("tblSaleTrades")]

    public class SaleTrades
    {
        public int Id { get; set; }
        public int? SaleId { get; set; }
        public int? TradesmanId { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Tradesman? Tradesman { get; set; }
        public virtual Sale? Sale { get; set; }
    }
}
