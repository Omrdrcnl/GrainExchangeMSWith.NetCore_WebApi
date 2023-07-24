using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class SaleRepository : RepositoryBase<Sale>
    {
        public SaleRepository(RepositoryContext context) : base(context) { }
    }

}
