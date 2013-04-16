using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class VersionId
    {
        public Guid Id { get; protected set; }

        public VersionId(Guid id)
        {
            Id = id;
        }
    }
}
