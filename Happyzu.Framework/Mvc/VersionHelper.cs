using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Timing;

namespace System.Web.Mvc
{
    public static class VersionHelper
    {
        public static string Time()
        {
            return Clock.Now.Year>2016 ? 
                string.Concat( "2016 - " , Clock.Now.Year) : 
                Clock.Now.Year.ToString();
        }
    }
}
