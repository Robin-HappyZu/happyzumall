using Abp.Web.Mvc.Controllers;

namespace Happyzu.Mall.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MallControllerBase : AbpController
    {
        protected MallControllerBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}