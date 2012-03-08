using System;
using System.IO;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using Microsoft.Web.Mvc;
using Microsoft.Web.Mvc.Html;
using ExpressionHelper = Microsoft.Web.Mvc.Internal.ExpressionHelper;

namespace BlackMagic.Mvc.WebFormsHelpers
{
	public static class BlackMagicMVCHelperExtension
	{
		public static BlackMagicMVCHelper BlackMagicMVC(this Page page)
		{
			return new BlackMagicMVCHelper();
		}
	}

	public class BlackMagicMVCHelper
	{
		private static HtmlHelper GetHtmlHelper()
		{
			var controllerContext = new ControllerContext();
			controllerContext.HttpContext = new HttpContextWrapper(HttpContext.Current);
			controllerContext.RouteData = new RouteData();
			controllerContext.RouteData.Values["controller"] = "does-not-exist";

			var context = new ViewContext(controllerContext, 
				new WebFormView(controllerContext, "does-not-exist", string.Empty), 
				new ViewDataDictionary(), 
				new TempDataDictionary(), 
				TextWriter.Null);
			
			var helper = new HtmlHelper(context, new ViewPage());
			
			return helper;
		}

		public MvcHtmlString ActionLink<TController>(Expression<Action<TController>> action, string linkText) where TController : Controller
		{
			var helper = GetHtmlHelper();
			return helper.ActionLink(action, linkText);
		}

		public MvcHtmlString Partial(string partialName)
		{
			var helper = GetHtmlHelper();
			return helper.Partial(partialName);
		}

		public MvcHtmlString RenderAction<TController>(Expression<Action<TController>> action) where TController : Controller
		{
			var helper = GetHtmlHelper();

			var routeValues = ExpressionHelper.GetRouteValuesFromExpression(action);

			return helper.Action((string) routeValues["action"], (string)routeValues["controller"], routeValues);
		}
	}
}