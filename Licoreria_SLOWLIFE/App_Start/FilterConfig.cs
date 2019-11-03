using System.Web;
using System.Web.Mvc;

namespace Licoreria_SLOWLIFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
