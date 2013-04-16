using System;

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model.Events
{
    public class IssueAssociatedWithBacklogItem
    {
        public Guid BacklogItemId { get; set; }
        public IssueId IssueId { get; set; }
    }
}