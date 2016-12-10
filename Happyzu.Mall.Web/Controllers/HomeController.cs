using System.Web.Mvc;
using Abp.Configuration;
using Abp.Localization;

namespace Happyzu.Mall.Web.Controllers
{
    public class HomeController : MallControllerBase
    {
        private readonly ISettingManager _settingManager;

        public HomeController(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}