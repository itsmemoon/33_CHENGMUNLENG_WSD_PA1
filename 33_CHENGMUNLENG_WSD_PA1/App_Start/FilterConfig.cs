using System.Web;
using System.Web.Mvc;

namespace _33_CHENGMUNLENG_WSD_PA1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
