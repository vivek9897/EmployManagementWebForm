Imports System.Collections.Generic
Imports System.Linq

Namespace Employee.Models
    ' MockEmployeeRepository class acts as an in-memory repository for managing employee data.
    Public Class MockEmployeeRepository
        ' Private list to hold employee data.
        Private ReadOnly _empList As List(Of Employee)

        ' Constructor initializes the list with sample employee data.
        Public Sub New()
            _empList = New List(Of Employee) From {
                New Employee() With {.Id = 1, .Name = "Mark", .Department = Dept.IT, .Email = "Mark@hotmail.com"},
                New Employee() With {.Id = 2, .Name = "Param", .Department = Dept.IT, .Email = "param@hotmail.com"},
                New Employee() With {.Id = 3, .Name = "Tom", .Department = Dept.HR, .Email = "Tom@hotmail.com"}
            }
        End Sub

        ' Retrieves all employees from the list.
        Public Function GetAllEmployee() As IEnumerable(Of Employee)
            Return _empList
        End Function

        ' Retrieves a specific employee by their ID.
        Public Function GetEmployee(id As Integer) As Employee
            Return _empList.FirstOrDefault(Function(emp) emp.Id = id)
        End Function

        ' Adds a new employee to the list.
        Public Function Add(employee As Employee) As Employee
            ' Assign a new ID to the employee.
            employee.Id = _empList.Max(Function(e) e.Id) + 1
            _empList.Add(employee)
            Return employee
        End Function

        ' Updates an existing employee in the list.
        Public Function Update(employeeUpdate As Employee) As Employee
            Dim emp = GetEmployee(employeeUpdate.Id)
            If emp IsNot Nothing Then
                ' Update employee details.
                emp.Name = employeeUpdate.Name
                emp.Email = employeeUpdate.Email
                emp.Department = employeeUpdate.Department
            End If

            Return emp
        End Function

        ' Removes an employee from the list.
        Public Function Remove(id As Integer) As Employee
            Dim empRemove = GetEmployee(id)
            If empRemove IsNot Nothing Then
                _empList.Remove(empRemove)
            End If

            Return empRemove
        End Function
    End Class
End Namespace
