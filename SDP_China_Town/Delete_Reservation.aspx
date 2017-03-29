<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Delete_Reservation.aspx.vb" Inherits="SDP_China_Town.Delete_Reservation" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login page</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="css/mainContent.css" rel="stylesheet" />
    <link href="css/font-awesome.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="js/mainContentjs.js"></script>
</head>
<body>
   <nav id="mainNav" class="navbar navbar-inverse navbar-fixed-top">
   <div class="container">
      <div class="navbar-header page-scroll">
         <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#menu-collapse">
         <span class="sr-only">Toggle navigation</span> Menu <i class="fa fa-bars"></i>
         </button>
         <a class="navbar-brand" href="Mainpage.aspx">Hotel China Town Inn</a>
      </div>
   <div class="collapse navbar-collapse" id="menu-collapse">
                 <ul class="navbar-nav nav navbar-right">

                     <asp:Panel ID="logout" runat="server" CssClass="navbar-nav nav navbar-right">
                         <li>
                             <a href="Mainpage2.aspx">Logout</a>
                         </li>

                     </asp:Panel>
                     <asp:Panel ID="mdreservations" runat="server" CssClass="navbar-nav nav navbar-right">
                         <li>
                             <a href="Modify_Reservations.aspx">Modify Reservations</a>
                         </li>
                         <li>
                             <a href="Delete_Reservation.aspx">Delete Reservation</a>
                         </li>
                     </asp:Panel>
                     <li>
                         <a href="Rooms/room.aspx">Rooms</a>
                     </li>
                     <li>
                         <a href="#mainAbout">About us</a>
                     </li>
                     <li>
                         <a href="Registerpage.aspx">Register</a>
                     </li>
                     <asp:Panel ID="login" runat="server" CssClass="navbar-nav nav navbar-right">
                         <li>
                             <a href="Loginpage.aspx">Login</a>
                         </li>

                     </asp:Panel>
                     


                 </ul>
             </div>
   </div> 
</nav>
<form id="form1" runat="server">
   <div id="form-page">
      <section class="page-header">
         <div class ="container">
            <div class ="col-lg-6 col-md-6 col-sm-6 col-xs-12 text-center">
               <div class ="banner">
                  <h1>Hotel China Town Inn</h1>
                  <h3>Delete existing reservation</h3>
               </div>
            </div>
            <div class ="col-lg-6 col-md-6 col-sm-6 col-xs-12">
               <div class ="formSection">
                  <div class ="form-horizontal">
                     <fieldset>
                        <legend>Login Details</legend>
                       <div class="form-group">
                              <asp:Label ID="lblSearchID" runat="server" Text="Search Booking ID" CssClass="col-lg-2 control-label"></asp:Label>
                              <div class="col-lg-10">
                                 <asp:TextBox ID="txtSearchID" runat="server" placeholder="Booking ID" CssClass="form-control" required="required"></asp:TextBox>
                              </div>
                           </div>
                <div class="form-group">
                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" />
            </div>
                         <div class="form-group">
                             <asp:Label ID="lblName" runat="server" Text="Name" CssClass="col-lg-2 control-label"></asp:Label>
                             <div class="col-lg-10">
                                 <asp:TextBox ID="txtName" runat="server" placeholder="Name" CssClass="form-control"></asp:TextBox>
                             </div>
                         </div>
                         <div class="form-group">
                             <asp:Label ID="lblTypeOfSuite" runat="server" Text="Type of Suite" CssClass="col-lg-2 control-label"></asp:Label>
                             <div class="col-lg-10">
                                 <asp:TextBox ID="txtTypeofSuite" runat="server" placeholder="Type of Suite" CssClass="form-control" Enabled="false"></asp:TextBox>
                             </div>
                         </div>
                <div class="form-group">
                              <asp:Label ID="lblCheckInDate" runat="server" Text="Check In Date" CssClass="col-lg-2 control-label"></asp:Label>
                              <div class="col-lg-10">
                                 <asp:TextBox ID="txtCheckIn" runat="server" placeholder="Check-in Date" CssClass="form-control" Enabled="false"></asp:TextBox>
                              </div>
                           </div>
                <div class="form-group">
                    <asp:Label ID="lblCheckOutDate" runat="server" Text="Check Out Date" CssClass="col-lg-2 control-label"></asp:Label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtCheckOut" runat="server" placeholder="Check-out Date" CssClass="form-control" Enabled="false"></asp:TextBox>
                        </div>
                           </div>
            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Delete" CssClass="btn btn-danger" />
            </div>
                     </fieldset>
                  </div>
               </div>
            </div>
         </div>
      </section>
   </div>
</form>
<div class="footer">
   <div class="container">
      <div class="row">
         <div class="col-md-4">
            <div class="footer_block">
               <div class="title">
                  <h3>
                     Opening Hours
                  </h3>
               </div>
               <div class="working_hours">
                  <ul>
                     <li>
                        <i class="fa fa-clock-o"></i>Monday - Thursday
                        06.00 - 22.00 
                     </li>
                     <li>
                        <i class="fa fa-clock-o"></i>Friday
                        06.00 - 23.00
                     </li>
                     <li>
                        <i class="fa fa-clock-o"></i>Saturday
                        06.00 - 23.30
                     </li>
                     <li>
                        <i class="fa fa-clock-o"></i>Sunday
                        06.00 - 21.00
                     </li>
                  </ul>
               </div>
            </div>
         </div>
      </div>
      <div class="regards">
         Best regards from Hotel China Town Inn.
      </div>
   </div>
</div>
</body>
</html>
