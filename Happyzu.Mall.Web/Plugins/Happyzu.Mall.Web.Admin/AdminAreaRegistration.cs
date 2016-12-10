using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Happyzu.Mall.Web.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Happyzu.Mall.Web.Admin"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //此路由不能删除
            context.MapRoute("admin_default",
                              "Admin/{controller}/{action}",
                              new { controller = "home", action = "index", area = "Happyzu.Mall.Web.Admin" },
                              new[] { "Happyzu.Mall.Web.Admin.Controllers" });
        }

    }
}