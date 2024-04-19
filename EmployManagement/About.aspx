<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="EmployManagement.About" %>
<asp:Content ID="BodyConten" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6">
                <h2 class="mb-4">About Our Company</h2>
                <p>
                    Welcome to EmployManagement! We are a dedicated team of professionals committed to providing exceptional human resource management solutions.
                </p>
                <p>
                    Our mission is to streamline the hiring process, manage employee data efficiently, and foster a productive work environment for businesses of all sizes.
                </p>
                <p>
                    With our user-friendly platform, businesses can effortlessly manage employee information, track performance, and handle HR tasks with ease.
                </p>
            </div>
            <div class="col-md-6">
                <img src="~/Content/Images/about-us.jpg" alt="About Us" class="img-fluid rounded">
            </div>
        </div>

        <div class="row mt-5">
            <div class="col-md-12">
                <h3>Why Choose EmployManagement?</h3>
                <ul class="list-group mt-3">
                    <li class="list-group-item">User-Friendly Interface</li>
                    <li class="list-group-item">Secure and Reliable</li>
                    <li class="list-group-item">Efficient HR Solutions</li>
                    <li class="list-group-item">Dedicated Support Team</li>
                </ul>
            </div>
        </div>

        <div class="row mt-5">
            <div class="col-md-12">
                <h3>Our Vision</h3>
                <p>
                    To be the leading provider of HR management solutions, empowering businesses to thrive and succeed in their respective industries.
                </p>
            </div>
        </div>
    </div>
</asp:Content>

<%--<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Your app description page.</p>
    <p>Use this area to provide additional information.</p>
</asp:Content>--%>
<%--<%@ Page Title="About Us" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="EmployManagement.About" %>
--%>
