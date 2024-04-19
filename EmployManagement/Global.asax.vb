Imports System.Web.Http
Imports System.Web.Optimization



Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        ' Web API configurations
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
    End Sub
End Class
