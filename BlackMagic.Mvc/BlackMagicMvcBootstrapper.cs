using System.Web.Routing;
using System.Web.Mvc;

namespace BlackMagic.Mvc
{
	public static class BlackMagicMvcBootstrapper
	{
		public static void Bootstrap()
		{
			AreaRegistration.RegisterAllAreas();

			var routes = RouteTable.Routes;

			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("HomeRoute",
							 "{controller}/{action}",
							 new { action = "Index" });
		}
	}
}