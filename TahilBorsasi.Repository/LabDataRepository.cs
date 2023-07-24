using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class LabDataRepository : RepositoryBase<LabData>
    {
        public LabDataRepository(RepositoryContext context) : base(context) { }
    }
 
}
