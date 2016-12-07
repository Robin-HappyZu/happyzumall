using System.Reflection;
using Abp.Modules;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Web.Mvc;

namespace Happyzu.Mall.Web.Admin
{
    [DependsOn(
    typeof(AbpWebMvcModule),
    typeof(MallCoreModule),
    typeof(MallDataModule),
    typeof(MallApplicationModule))]
    public class MallWebAdministratorModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            
        }
    }
}
