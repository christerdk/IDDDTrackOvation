

namespace IDDD.SaaSOvation.IssueTrack.Domain.Model
{
    public class Issue
    {
        public TenantId TenantId { get; protected set; }
        public ProductId ProductId { get; protected set; }
        public VersionId VersionId { get; protected set; }
        public IssueId Id { get; protected set; }
        public IssueStatus Status { get; protected set; }
        //public Issue(Observer observer, string Title, string Description, IssueType type, ProductId productId, TenantId tenantId)
        //{
        //    AddToProduct(productId);
        //}

        public Issue(Observer observer, ProductId productId, TenantId tenantId)
        {
            AddToProduct(productId);
        }

        public Observer Observer { get; protected set; }
        public Assignee Assignee { get; protected set; }
        public IssueType Type { get; protected set; }

        public string Title { get; protected set; }
        public string Description { get; protected set; }

        public void SetTitle(string title)
        {
            this.Title = title;
        }
        protected void AddToProduct(ProductId productId)
        {
            this.ProductId = productId;
        }
    }
}