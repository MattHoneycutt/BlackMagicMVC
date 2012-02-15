Imports System.Web.SessionState
Imports System.Web.Routing
Imports System.Web.Mvc
Imports MvcContrib.PortableAreas
Imports BlackMagic.Mvc

Public Class Global_asax
	Inherits System.Web.HttpApplication

	Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the application is started

		AreaRegistration.RegisterAllAreas()
		RegisterRoutes(RouteTable.Routes)
		BlackMagicRoutes.Register(RouteTable.Routes)
		'PortableAreaRegistration.RegisterEmbeddedViewEngine()

	End Sub

	Private Sub RegisterRoutes(routes As RouteCollection)

		routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

		'' MapRoute takes the following parameters, in order:
		'' (1) Route name
		'' (2) URL with parameters
		'' (3) Parameter defaults
		'routes.MapRoute("Default",
		'	"{controller}/{action}/{id}",
		'	New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
		')

	End Sub

	Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the session is started
	End Sub

	Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
		' Fires at the beginning of each request
	End Sub

	Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
		' Fires upon attempting to authenticate the use
	End Sub

	Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when an error occurs
	End Sub

	Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the session ends
	End Sub

	Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
		' Fires when the application ends
	End Sub

End Class