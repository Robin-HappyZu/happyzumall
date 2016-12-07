using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Happyzu.Mall.Web.Wechat.Controllers
{
    public class HomeController: WechatControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
