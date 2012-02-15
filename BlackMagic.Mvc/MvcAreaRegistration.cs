using System.Web.Routing;
using System.Web.Mvc;

namespace BlackMagic.Mvc
{
	public static class BlackMagicRoutes
	{
		public static void Register(RouteCollection routes)
		{
			routes.MapRoute("HomeRoute",
							 "{controller}/{action}",
							 new { controller = "Home", action = "Index" });
		}
	}

	//public class MvcAreaRegistration : PortableAreaRegistration
	//{
	//    public MvcAreaRegistration()
	//    {
	//        //TODO: 
	//        //DependencyResolver.SetResolver(new StructureMapDependencyResolver());
	//    }

	//    public override string AreaName
	//    {
	//        get { return "MvcArea"; }
	//    }

	//    public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
	//    {
	//        context.MapRoute("resources",
	//            AreaName + "/Resource/{resourceName}",
	//            new { Controller = "EmbeddedResource", action = "Index" },
	//            new[] { "MvcContrib.PortableAreas" });

	//        context.MapRoute("HomeRoute",
	//                         "{controller}/{action}",
	//                         new { controller = "Home", action = "Index" });

	//        base.RegisterArea(context, bus);
	//    }
	//}
}