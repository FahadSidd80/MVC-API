using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC_API_6323
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
