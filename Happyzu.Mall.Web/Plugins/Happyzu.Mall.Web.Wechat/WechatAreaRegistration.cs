using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Happyzu.Mall.Web.Wechat
{
    public class WechatAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Happyzu.Mall.Web.Wechat"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //此路由不能删除
            context.MapRoute("wechat_default",
                              "wechat/{controller}/{action}",
                              new { controller = "home", action = "index", area = "Happyzu.Mall.Web.Wechat" },
                              new[] { "Happyzu.Mall.Web.Wechat.Controllers" });
        }

    }
}