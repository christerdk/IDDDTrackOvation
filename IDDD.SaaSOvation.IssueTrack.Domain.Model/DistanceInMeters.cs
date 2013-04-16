using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class DistanceInMeters
    {
        public int Amount { get; protected set; }

        public DistanceInMeters(int amount)
        {
            Amount = amount;
        }
    }
}
