using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class TradesmanRepository : RepositoryBase<Tradesman>
    {
        public TradesmanRepository(RepositoryContext context) : base(context) { }
    }
}
