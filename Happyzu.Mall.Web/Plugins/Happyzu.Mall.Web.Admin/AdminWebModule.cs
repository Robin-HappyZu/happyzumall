using System.Reflection;
using Abp.Modules;
using Abp.Web.Mvc;
using Happyzu.Mall.Web.Admin.Abp;

namespace Happyzu.Mall.Web.Admin
{
    [DependsOn(
    typeof(AbpWebMvcModule),
    typeof(MallCoreModule),
    typeof(MallDataModule),
    typeof(MallApplicationModule))]
    public class AdminWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AdminNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

        }
    }
}
