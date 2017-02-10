using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Navigation;

namespace Happyzu.Mall.Web.Admin.Controllers
{
    public class HomeController : AdminControllerBase
    {

        public async Task<ActionResult> Index()
        {
            await GetUserMenu();

            return View();
        }

        public HomeController(IUserNavigationManager userNavigationManager) : base(userNavigationManager)
        {
        }
    }
}
