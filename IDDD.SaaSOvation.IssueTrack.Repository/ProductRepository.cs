using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDDD.SaaSOvation.IssueTrack.Domain.Model;
using IDDD.SaaSOvation.IssueTrack.Domain.Model.Id;

namespace IDDD.SaaSOvation.IssueTrack.Repository
{
    public class ProductRepository
    {
        public Product Get(ProductId productId)
        {
            return new Product(productId);
        }
    }
}
