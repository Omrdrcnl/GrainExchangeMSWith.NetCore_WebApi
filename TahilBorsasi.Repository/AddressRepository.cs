using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class AddressRepository : RepositoryBase<Address>
    {
        public AddressRepository(RepositoryContext context) : base(context) { }
    }
    
}
