using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Web.Mvc.Views;

namespace Happyzu.Mall.Web.Admin.Views
{
    public abstract class AdminViewPageBase : AdminViewPageBase<dynamic>
    {

    }

    public abstract class AdminViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AdminViewPageBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}
