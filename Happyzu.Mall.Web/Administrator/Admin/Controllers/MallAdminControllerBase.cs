using Abp.Web.Mvc.Controllers;

namespace Happyzu.Mall.Web.Admin.Controllers
{
    public abstract class MallAdminControllerBase : AbpController
    {
        protected MallAdminControllerBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}
