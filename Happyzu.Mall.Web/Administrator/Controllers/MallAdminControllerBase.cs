using Abp.Web.Mvc.Controllers;

namespace Happyzu.Mall.Web.Administrator.Controllers
{
    public abstract class MallAdminControllerBase : AbpController
    {
        protected MallAdminControllerBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}
