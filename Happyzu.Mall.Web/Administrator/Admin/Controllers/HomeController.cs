using System.Web.Mvc;

namespace Happyzu.Mall.Web.Admin.Controllers
{
    public class HomeController : MallAdminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
