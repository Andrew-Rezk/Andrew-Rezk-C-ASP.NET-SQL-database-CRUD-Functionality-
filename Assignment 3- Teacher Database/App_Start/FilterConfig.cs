using System.Web;
using System.Web.Mvc;

namespace Assignment_3__Teacher_Database
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
