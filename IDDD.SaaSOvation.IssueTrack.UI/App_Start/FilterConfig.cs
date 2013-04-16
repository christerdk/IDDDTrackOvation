using System.Web;
using System.Web.Mvc;

namespace IDDD.SaaSOvation.IssueTrack.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}