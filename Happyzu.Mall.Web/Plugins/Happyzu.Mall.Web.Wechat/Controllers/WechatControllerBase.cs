using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Web.Mvc.Controllers;

namespace Happyzu.Mall.Web.Wechat.Controllers
{
    public class WechatControllerBase:AbpController
    {
        protected WechatControllerBase()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}
