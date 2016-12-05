using Abp.Web.Mvc.Views;

namespace Happyzu.Mall.Web.Views
{
    public abstract class MallWebViewPageBase : MallWebViewPageBase<dynamic>
    {

    }

    public abstract class MallWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MallWebViewPageBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}