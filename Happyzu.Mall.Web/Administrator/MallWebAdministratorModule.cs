using System.Reflection;
using Abp.Modules;
using Abp.Web.Mvc;

namespace Happyzu.Mall.Web.Administrator
{
    [DependsOn(
    typeof(AbpWebMvcModule),
    typeof(MallCoreModule),
    typeof(MallDataModule),
    typeof(MallApplicationModule),
    typeof(MallWebApiModule))]
    public class MallWebAdministratorModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
