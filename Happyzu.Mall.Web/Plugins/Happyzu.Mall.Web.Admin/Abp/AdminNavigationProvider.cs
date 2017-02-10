using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Localization;

namespace Happyzu.Mall.Web.Admin.Abp
{
    public class AdminNavigationProvider: NavigationProvider
    {
        public const string AdminMenu = "Administrator";
        public override void SetNavigation(INavigationProviderContext context)
        {
            if (!context.Manager.Menus.ContainsKey(AdminMenu))
            {
                context.Manager.Menus.Add(new KeyValuePair<string, MenuDefinition>(AdminMenu,new MenuDefinition(AdminMenu, new LocalizableString("AdminMenu.Administrator", MallConsts.LocalizationSourceName))));
            }
            var adminNavigation=context.Manager.Menus[AdminMenu];
            adminNavigation.AddItem(new MenuItemDefinition(
                        "Dashboard",
                        new LocalizableString("AdminMenu.Dashboard", MallConsts.LocalizationSourceName),
                        url: "/admin/dashboard",
                        icon: "fa fa-dashboard"
                        ));

        }
    }
}
