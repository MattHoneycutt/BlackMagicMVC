using System.Web.Mvc;

namespace BlackMagic.Mvc.WebFormsBridge
{
	public class RazorBridgeActionInvoker : ControllerActionInvoker
	{
		protected override ActionResult CreateActionResult(ControllerContext controllerContext, ActionDescriptor actionDescriptor, object actionReturnValue)
		{
			var result = base.CreateActionResult(controllerContext, actionDescriptor, actionReturnValue);

			if (result is ViewResult && !controllerContext.IsChildAction)
			{
				result = new RazorBridgeViewResult((ViewResult) result);
			}

			return result;
		}
	}
}