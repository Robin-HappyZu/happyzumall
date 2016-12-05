using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Happyzu.Mall
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MallApplicationModule))]
    public class MallWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MallApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
