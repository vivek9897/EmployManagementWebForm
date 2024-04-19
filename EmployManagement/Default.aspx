<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="EmployManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <!-- Introduction Section -->
        <h1>Welcome to EmployManagement</h1>
        <p class="lead">Manage your employees efficiently with our New application.</p>
        <p><a href="#" id="addEmployeeBtn" class="btn btn-primary btn-lg">Add Employee &raquo;</a></p>

        <!-- Employee Form -->
        <div class="row">
            <div class="col-md-12">
                <h2>Add Employee</h2>
                <div class="form-group">
                    <label for="txtEmployeeName">Name:</label>
                    <input type="text" class="form-control" id="txtEmployeeName" required>
                    <div class="invalid-feedback">Please enter your name.</div>
                </div>
                <div class="form-group">
                    <label for="txtEmployeeDepartment">Department:</label>
                    <input type="text" class="form-control" id="txtEmployeeDepartment" required>
                    <div class="invalid-feedback">Please enter the department.</div>
                </div>
                <div class="form-group">
                    <label for="txtEmployeeEmail">Email:</label>
                    <input type="email" class="form-control" id="txtEmployeeEmail" required>
                    <div class="invalid-feedback">Please enter a valid email address.</div>
                </div>
                <button type="button" id="btnSave" class="btn btn-primary">Save</button>
            </div>
        </div>

        <!-- Employee Grid -->
        <div class="row">
            <div class="col-md-12">
                <h2>Employee List</h2>
                <div id="GridView1">
                    <!-- Employee grid will be populated here -->
                </div>
            </div>
        </div>
        
        <!-- Success Message -->
        <div class="alert alert-success mt-3" id="successMessage" style="display:none;">
            Employee saved successfully!
        </div>
    </div>

    <!-- Scripts -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            // Initialize form validation
            $("#txtEmployeeName, #txtEmployeeDepartment, #txtEmployeeEmail").on('input', function () {
                if ($(this).valid()) {
                    $(this).removeClass('is-invalid');
                } else {
                    $(this).addClass('is-invalid');
                }
            });

            // Initialize button click event
            $("#btnSave").click(function () {
                if ($("#txtEmployeeName").valid() && $("#txtEmployeeDepartment").valid() && $("#txtEmployeeEmail").valid()) {
                    addEmployee();
                }
            });
        });

        // Function to add new employee
        async function addEmployee() {
            const name = $("#txtEmployeeName").val();
            const department = $("#txtEmployeeDepartment").val();
            const email = $("#txtEmployeeEmail").val();

            const response = await fetch("Default.aspx/AddEmployee", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({ Name: name, Department: department, Email: email })
            });

            const data = await response.json();

            if (response.ok) {
                // Show success message
                $("#successMessage").show();
                setTimeout(function () {
                    $("#successMessage").hide();
                }, 5000);

                // Refresh the grid view
                bindEmployeeGrid();
            } else {
                console.error(data);
            }
        }

        // Function to bind employee grid
        async function bindEmployeeGrid() {
            const response = await fetch("Default.aspx/GetAllEmployees");
            const data = await response.json();

            if (response.ok) {
                $("#GridView1").html(data.d);
            } else {
                console.error(data);
            }
        }
    </script>
</asp:Content>
