using System.Web;
using System.Web.Mvc;

namespace Tevhid_Mvc_Edit_Text
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
