Imports System.ComponentModel.DataAnnotations

Namespace Employee.Models
    ' Employee model class representing an employee entity.
    Public Class Employee
        ' Unique identifier for the employee.
        Public Property Id As Integer

        ' Name of the employee.
        Public Property Name As String

        ' Email address of the employee, marked as required.
        <Required>
        Public Property Email As String

        ' Department of the employee, defined as nullable enumeration.
        Public Property Department As Dept?
    End Class
End Namespace
