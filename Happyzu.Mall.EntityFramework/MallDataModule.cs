using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Happyzu.Mall.EntityFramework;

namespace Happyzu.Mall
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MallCoreModule))]
    public class MallDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MallDbContext>(null);
        }
    }
}
