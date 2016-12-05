using System.Reflection;
using Abp.Modules;

namespace Happyzu.Mall
{
    [DependsOn(typeof(MallCoreModule))]
    public class MallApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
