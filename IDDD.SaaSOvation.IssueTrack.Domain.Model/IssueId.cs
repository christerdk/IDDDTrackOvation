using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class IssueId
    {
        public Guid Id { get; set; }

        public IssueId(Guid id)
        {
            Id = id;
        }
    }
}
