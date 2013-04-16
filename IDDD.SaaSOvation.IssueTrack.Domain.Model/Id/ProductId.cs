using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model.Id
{
    public class ProductId
    {
        public Guid Id { get; private set; }

        public ProductId(Guid id)
        {
            Id = id;
        }
    }
}
