using System.Web.Mvc;

namespace Happyzu.Framework.Theming.Attributes
{
    public class LayoutAttribute: ActionFilterAttribute
    {
        public LayoutAttribute(string layout)
        {
            Layout = layout;
        }
        public string Layout { get; private set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.RouteData.Values.Add("Layout", Layout);
            base.OnActionExecuting(filterContext);
        }
    }
}
