using System.Web.Mvc;
using System.Web.Routing;

namespace BlackMagic.Mvc.WebFormsBridge
{
	public class RazorBridgeViewResult : ViewResult
	{
		private readonly ViewResult _razorViewResult;

		public RazorBridgeViewResult(ViewResult razorViewResult)
		{
			_razorViewResult = razorViewResult;
			ViewData = razorViewResult.ViewData;
			ViewName = razorViewResult.ViewName;
		}

		private static string GetViewName(RouteData routeData, string viewName)
		{
			return !string.IsNullOrEmpty(viewName)
			       	? viewName
			       	: routeData.GetRequiredString("action");
		}

		public override void ExecuteResult(ControllerContext context)
		{
			_razorViewResult.ViewData["MvcViewName"] = GetViewName(context.RouteData, ViewName);
			_razorViewResult.ViewName = "RazorBridgeView";

			_razorViewResult.ExecuteResult(context);
		}
	}
}