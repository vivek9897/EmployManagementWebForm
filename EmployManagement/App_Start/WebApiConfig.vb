Imports System.Web.Http
Imports System.Web.Http.Cors

Public Class WebApiConfig
    Public Shared Sub Register(config As HttpConfiguration)
        ' Configure Web API to use attribute routing.
        config.MapHttpAttributeRoutes()

        ' Configure Web API routes.
        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )

        ' Enable Cross-Origin Resource Sharing (CORS) for all origins, headers, and methods.
        Dim cors = New EnableCorsAttribute("*", "*", "*")
        config.EnableCors(cors)
    End Sub
End Class
