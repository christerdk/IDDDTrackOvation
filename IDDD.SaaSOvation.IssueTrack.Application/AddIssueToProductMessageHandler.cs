using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDDD.SaaSOvation.IssueTrack.Domain.Model;
using IDDD.SaaSOvation.IssueTrack.Repository;

namespace IDDD.SaaSOvation.IssueTrack.Application
{
    public class AddIssueToProductMessageHandler
    {
        //injected product repo
        //injected issue repo

        public void DoIt()
        {
            var observer = new Observer(); //get via identity
            var product = new ProductRepository().Get(new ProductId(Guid.NewGuid()));

            var newIssue = product.CreateNewIssue(observer);
            newIssue.SetTitle("New issue");

            var issueRepo = new IssueRepository();
            issueRepo.Save(newIssue);

        }
    }
}
