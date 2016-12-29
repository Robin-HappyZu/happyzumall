using System.Reflection;
using Abp.Modules;

namespace Happyzu.Mall
{
    public class MallCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Configuration.Auditing.IsEnabledForAnonymousUsers = true;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
