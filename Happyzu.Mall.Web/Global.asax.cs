using System;
using System.Web;
using Abp.Castle.Logging.Log4Net;
using Abp.PlugIns;
using Abp.Web;
using Castle.Facilities.Logging;
using Happyzu.Framework.Theming;
using Happyzu.Mall.Web;

[assembly: PreApplicationStartMethod(typeof(PreStarter), "Start")]
namespace Happyzu.Mall.Web
{
    public class MvcApplication : AbpWebApplication<MallWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {

            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                            f => f.UseAbpLog4Net().WithConfig("log4net.config")
                        );

            ThemeManager.Instance.Configure(config =>
            {
                config.ThemeDirectory = "~/Themes";
                config.DefaultTheme = "Default";
                config.ThemeResolver = new CookiesThemeResover();
            });

            base.Application_Start(sender, e);
        }
    }


    public static class PreStarter
    {
        public static void Start()
        {
            //...
            MvcApplication.AbpBootstrapper.PlugInSources.AddFolder(string.Concat(HttpRuntime.AppDomainAppPath,"\\Plugins\\dll"));
            MvcApplication.AbpBootstrapper.PlugInSources.AddToBuildManager();
        }
    }
}
