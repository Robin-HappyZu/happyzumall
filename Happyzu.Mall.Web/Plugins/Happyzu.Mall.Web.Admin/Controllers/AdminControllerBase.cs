using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Web.Mvc.Controllers;

namespace Happyzu.Mall.Web.Admin.Controllers
{
    public class AdminControllerBase : AbpController
    {
        public AdminControllerBase ()
        {
            LocalizationSourceName = MallConsts.LocalizationSourceName;
        }
    }
}
