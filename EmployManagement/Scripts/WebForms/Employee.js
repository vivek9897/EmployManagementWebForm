$('#saveEmployeeBtn').click(function () {
    var employee = {
        Name: $('#employeeName').val(),
        Department: $('#employeeDepartment').val(),
        Email: $('#employeeEmail').val()
    };

    $.ajax({
        url: '/api/Employee/AddEmployee',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(employee),
        success: function (response) {
            alert(response.message);
            $('#addEmployeeModal').modal('hide');
        },
        error: function (error) {
            alert('Error saving employee.');
        }
    });
});
