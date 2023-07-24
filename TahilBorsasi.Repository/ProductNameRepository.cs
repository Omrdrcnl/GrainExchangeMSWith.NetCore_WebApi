using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TahilBorsasi.Model;

namespace TahilBorsasi.Repository
{
    public class ProductNameRepository : RepositoryBase<ProductName>
    {
        public ProductNameRepository(RepositoryContext context) : base(context) { }
    }
}
