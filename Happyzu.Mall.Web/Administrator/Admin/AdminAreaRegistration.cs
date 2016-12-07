using System.Web.Mvc;

namespace Happyzu.Mall.Web.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "admin"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //此路由不能删除
            context.MapRoute("admin_default",
                              "admin/{controller}/{action}",
                              new { controller = "home", action = "index", area = "admin" },
                              new[] { "Happyzu.Mall.Web.Admin.Controllers" });
        }

    }
}
