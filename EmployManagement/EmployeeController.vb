Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.ModelBinding
Imports EmployManagement.Employee.Models
Imports Intuit.Ipp.Data
Imports Newtonsoft.Json

Public Class EmployeeApiController
    Inherits ApiController

    Private ReadOnly _repository As New MockEmployeeRepository()

    ' GET api/employee
    Public Function GetEmployees() As IHttpActionResult
        Dim employees = _repository.GetAllEmployee()
        Dim json = JsonConvert.SerializeObject(employees)
        Return Ok(json)
    End Function

    ' POST api/employee
    Public Function PostEmployee(employee As Employee.Models.Employee) As IHttpActionResult
        If Not ModelState.IsValid Then
            Return BadRequest(ModelState)
        End If

        Dim addedEmployee = _repository.Add(employee)
        Dim json = JsonConvert.SerializeObject(addedEmployee)
        Return Ok(json)
    End Function

    ' Here you can add other methods like PUT, DELETE, etc. if needed
End Class
