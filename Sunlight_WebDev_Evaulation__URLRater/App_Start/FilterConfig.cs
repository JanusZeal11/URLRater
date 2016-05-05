using System.Web;
using System.Web.Mvc;

namespace Sunlight_WebDev_Evaulation__URLRater
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
