using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Navigation;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Controllers;
using Happyzu.Mall.Web.Admin.Abp;

namespace Happyzu.Mall.Web.Admin.Controllers
{
    public class AdminControllerBase : AbpController
    {
        public IUserNavigationManager UserNavigationManager;
        
        public AdminControllerBase (IUserNavigationManager userNavigationManager)
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
            UserNavigationManager = userNavigationManager;
        }

        protected async Task GetUserMenu()
        {
            var user = AbpSession.ToUserIdentifier();
            ViewBag.AdminMenu =await UserNavigationManager.GetMenuAsync(AdminNavigationProvider.AdminMenu, user);
        }
    }
}
