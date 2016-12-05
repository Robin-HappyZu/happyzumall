using System.Web.Mvc;

namespace Happyzu.Mall.Web.Controllers
{
    public class HomeController : MallControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}