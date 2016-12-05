using System.Reflection;
using Abp.Modules;

namespace Happyzu.Mall
{
    public class MallCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
