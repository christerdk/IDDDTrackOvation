using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class Version
    {
        public VersionId Id { get; protected set; }
        public ProductId ProductId { get; protected set; }
        public TenantId TenantId { get; protected set; }

        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public Version(ProductId productId, TenantId tenantId, string name, string description)
        {
            ProductId = productId;
            TenantId = tenantId;
            Name = name;
            Description = description;
        }
    }
}
