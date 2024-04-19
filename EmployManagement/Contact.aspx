<%@ Page Title="Contact Us" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="EmployManagement.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6">
                <h1>Contact Us</h1>
                <p>We appreciate your interest in EmployManagement. Please feel free to contact us with any questions or feedback you may have. Our team is here to assist you.</p>
                
                <div class="contact-info mt-4">
                    <h4>Our Office</h4>
                    <address>
                        One Microsoft Way<br />
                        Redmond, WA 98052-6399<br />
                        <abbr title="Phone">P:</abbr> 425.555.0100
                    </address>
                    
                    <h4>Email</h4>
                    <address>
                        <strong>Support:</strong> <a href="mailto:Support@example.com">Support@example.com</a><br />
                        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
                    </address>
                </div>
            </div>
            
            <div class="col-md-6">
                <img src="images/contact.jpg" alt="Contact Us" class="img-fluid rounded">
            </div>
        </div>
        
        <div class="row mt-5">
            <div class="col-md-12">
                <h2>Get In Touch</h2>
                <p>We'd love to hear from you. Please fill out the form below and we'll get back to you as soon as possible.</p>
                
                <form id="contactForm">
                    <div class="form-group">
                        <label for="name">Name:</label>
                        <input type="text" class="form-control" id="name" placeholder="Enter your name">
                    </div>
                    <div class="form-group">
                        <label for="email">Email:</label>
                        <input type="email" class="form-control" id="email" placeholder="Enter your email">
                    </div>
                    <div class="form-group">
                        <label for="message">Message:</label>
                        <textarea class="form-control" id="message" rows="5" placeholder="Enter your message"></textarea>
                    </div>
                    <button type="button" class="btn btn-primary" id="submitContact">Submit</button>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
