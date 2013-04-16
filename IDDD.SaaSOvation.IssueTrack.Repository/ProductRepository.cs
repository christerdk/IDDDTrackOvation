using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDDD.SaaSOvation.IssueTrack.Domain.Model;

namespace IDDD.SaaSOvation.IssueTrack.Repository
{
    public class ProductRepository
    {
        public Product Get(ProductId productId)
        {
            return new Product(new TenantId(Guid.NewGuid()), productId, String.Empty, String.Empty);
        }
    }
}
