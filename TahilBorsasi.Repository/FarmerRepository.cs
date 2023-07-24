using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class FarmerRepository : RepositoryBase<Farmer>
    {
        public FarmerRepository(RepositoryContext context) : base(context) { }
    }

}
