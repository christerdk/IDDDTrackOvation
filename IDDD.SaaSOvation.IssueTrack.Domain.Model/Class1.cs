using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class TenantId
    {
        public Guid Id { get; protected set; }

        public TenantId(Guid id)
        {
            Id = id;
        }
    }
}
