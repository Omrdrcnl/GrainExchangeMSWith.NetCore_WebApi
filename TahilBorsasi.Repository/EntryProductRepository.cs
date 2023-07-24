using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class EntryProductRepository : RepositoryBase<EntryProduct>
    {
        public EntryProductRepository(RepositoryContext context) : base(context) { }
    }

}
