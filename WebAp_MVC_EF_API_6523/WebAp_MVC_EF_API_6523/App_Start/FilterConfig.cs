using System.Web;
using System.Web.Mvc;

namespace WebAp_MVC_EF_API_6523
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
