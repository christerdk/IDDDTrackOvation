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

        public override bool Equals(object obj)
        {
            var theObj = obj as TenantId;
            if (theObj == null)
                return false;

            return this.Id.Equals(theObj.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
