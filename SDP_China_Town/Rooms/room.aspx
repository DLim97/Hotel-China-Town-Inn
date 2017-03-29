<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="room.aspx.vb" Inherits="SDP_China_Town.room" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta charset="utf-8"/>
    <link href="../css/mainContent.css" rel="stylesheet" />
    <link href="../css/font-awesome.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <title>Rooms</title>
</head>

<body>
   <form id="form1" runat="server">
      <nav id="mainNav" class="navbar navbar-inverse navbar-fixed-top">
         <div class="container">
            <div class="navbar-header page-scroll">
               <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#menu-collapse">
               <span class="sr-only">Toggle navigation</span> Menu <i class="fa fa-bars" aria-hidden="true"></i>
               </button>
               <a class="navbar-brand" href="../Mainpage.aspx">Hotel China Town Inn</a>
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
      <div class="button-container">
         Check in
         <select>
            <option>Today</option>
         </select>
         Check out
         <select>
            <option>Tomorrow</option>
         </select>
      </div>
      <div class="container">
         <div class="container">
            <section class="page-header">
               <h1>Rooms</h1>
            </section>
         </div>
         <div class="row">
            <div class="col-md-4">
               <div class="panel">
                  <div class="panel-default">
                     <a href="roomPresidential1.aspx">
                     <img class="img-responsive" src="../images/hotel1.jpg" />
                     </a>
                     <h3 class="text-primary">Presidential suite</h3>
                     <a href="roomPresidential1.aspx" class="btn btn-warning shake-little">Check More!</a>
                  </div>
               </div>
            </div>
            <div class="col-md-4">
               <div class="panel">
                  <div class="panel-default">
                     <a href="roomLuxury1.aspx">
                     <img class="img-responsive" src="../images/hotel3.jpg" />
                     </a>
                     <h3 class="text-primary">Luxury suite</h3>
                     <a href="roomLuxury1.aspx"class="btn btn-warning shake-little">Check More!</a>
                  </div>
               </div>
            </div>
            <div class="col-md-4">
               <div class="panel">
                  <div class="panel-default">
                     <a href="roomStandard1.aspx">
                     <img class="img-responsive" src="../images/hotel2.jpg" />
                     </a>
                     <h3 class="text-primary">Standard suite</h3>
                     <a href="roomStandard1.aspx" class="btn btn-warning shake-little">Check More!</a>
                  </div>
               </div>
            </div>
         </div>
      </div>
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
   </form>
</body>
</html>