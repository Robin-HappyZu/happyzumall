using System.Web.Mvc;

namespace Happyzu.Mall.Web.Administrator.Controllers
{
    public class HomeController : MallAdminControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
