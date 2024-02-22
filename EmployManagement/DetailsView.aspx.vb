Imports EmployManagement.Employee.Models

Public Class DetailsView
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Check if the "Id" query string parameter exists
            If Not String.IsNullOrEmpty(Request.QueryString("Id")) Then
                Dim empId As Integer = Convert.ToInt32(Request.QueryString("Id"))
                LoadEmployeeDetails(empId)
            End If
        End If
    End Sub
    Private Sub LoadEmployeeDetails(empId As Integer)
        Dim empRepo As New MockEmployeeRepository()
        Dim employee = empRepo.GetEmployee(empId)
        If employee IsNot Nothing Then
            lblName.Text = employee.Name
            lblDepartment.Text = employee.Department.ToString()
            lblEmail.Text = employee.Email

            ' Optional: Store the employee ID in ViewState for the Edit/Delete operations
            ViewState("SelectedEmployeeId") = empId
        Else
            ' Handle the case where the employee is not found
            ' For example, redirect back to the list or show an error message
        End If
    End Sub

    Protected Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim selectedEmployeeId As Integer = Convert.ToInt32(ViewState("SelectedEmployeeId"))
        Response.Redirect($"~/Edit.aspx?Id={selectedEmployeeId}")
    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim empRepo As New MockEmployeeRepository()
        Dim selectedEmployeeId As Integer = Convert.ToInt32(ViewState("SelectedEmployeeId"))
        empRepo.Remove(selectedEmployeeId)
        ' After deletion, redirect to the list page or show a success message
        Response.Redirect("~/Default.aspx")
    End Sub

End Class