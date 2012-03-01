using System.Web.Mvc;
using BlackMagic.Mvc.WebFormsBridge;

namespace BlackMagic.Mvc.Controllers
{
	public abstract class BlackMagicController : Controller
	{
		protected override IActionInvoker CreateActionInvoker()
		{
			return new RazorBridgeActionInvoker();
		}
	}
}