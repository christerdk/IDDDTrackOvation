using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class Product
    {
        public ProductId Id { get; protected set; }
        public TenantId TenantId { get; protected set; }

        public Product(ProductId productId, TenantId tenantId)
        {
            Id = productId;
            TenantId = tenantId;
        }

        public List<IssueId> MyIssues = new List<IssueId>();

        public Issue CreateNewIssue(Observer observer)
        {
            return new Issue(observer, this.Id, this.TenantId);

        }
    }
}
