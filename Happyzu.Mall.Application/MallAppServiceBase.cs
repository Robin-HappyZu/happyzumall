using Abp.Application.Services;

namespace Happyzu.Mall
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MallAppServiceBase : ApplicationService
    {
        protected MallAppServiceBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}