using System.Reflection;
using Abp.Modules;
using Abp.Web.Mvc;

namespace Happyzu.Mall.Web.Wechat
{
    [DependsOn(
    typeof(AbpWebMvcModule),
    typeof(MallCoreModule),
    typeof(MallDataModule),
    typeof(MallApplicationModule))]
    public class WechatModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

        }
    }
}
