
Imports EmployManagement.Employee.Models

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindEmployeeList()
        End If
    End Sub

    Private Sub BindEmployeeList()
        Dim empRepo As New MockEmployeeRepository()
        Dim employees = empRepo.GetAllEmployee()
        GridView1.DataSource = employees
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim selectedId As Integer = Convert.ToInt32(GridView1.SelectedDataKey.Value)
        ShowEmployeeDetails(selectedId)
    End Sub

    Private Sub ShowEmployeeDetails(id As Integer)
        '    Dim empRepo As New MockEmployeeRepository()
        '    Dim employee = empRepo.GetEmployee(id)
        '    ' Assuming you have a DetailsView or similar control to bind to
        '    DetailsView1.DataSource = New List(Of Employee) {employee}
        'DetailsView1.DataBind()
    End Sub
    Protected Sub BtnEdit_Click(sender As Object, e As EventArgs)
        ' Response.Redirect($"~/Edit.aspx?Id={selectedId}")
    End Sub
    Protected Sub BtnRemove_Click(sender As Object, e As EventArgs)
        Dim empRepo As New MockEmployeeRepository()
        ' Assume we have a way to get the selected ID
        'empRepo.Remove(selectedId)
        ' Rebind the employee list to reflect changes
        BindEmployeeList()
    End Sub
    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)
        Dim selectedId As Integer = Convert.ToInt32(GridView1.DataKeys(rowIndex).Value)

        Select Case e.CommandName
            Case "View"
                ' Implement view logic here, e.g., redirect to a details page
                Response.Redirect($"~/DetailsView.aspx?Id={selectedId}")
            Case "Edit"
                ' Implement edit logic here, e.g., redirect to an edit page
                Response.Redirect($"~/Edit.aspx?Id={selectedId}")
            Case "Remove"
                ' Implement remove logic here
                Dim empRepo As New MockEmployeeRepository()
                empRepo.Remove(selectedId)
                BindEmployeeList()
        End Select
    End Sub

End Class