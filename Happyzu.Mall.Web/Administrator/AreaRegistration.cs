using System.Web.Mvc;

namespace Happyzu.Mall.Web.Administrator
{
    public class AreaRegistration : System.Web.Mvc.AreaRegistration
    {
        public override string AreaName
        {
            get { return "Administrator"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //此路由不能删除
            context.MapRoute("admin_default",
                              "admin/{controller}/{action}",
                              new { controller = "home", action = "index", area = "Administrator" },
                              new[] { "Happyzu.Mall.Web.Administrator.Controllers" });
        }

    }
}
