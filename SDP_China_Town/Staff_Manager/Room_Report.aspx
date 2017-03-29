<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_page.Master" CodeBehind="Room_Report.aspx.vb" Inherits="SDP_China_Town.WebForm2" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                        <div class="row">

        <div class="col-md-12 center-block">
            <h1>Room Occupancy Report</h1>
        </div>

      

    <div class="row">

        <div class="col-md-12" style="left: 0px; top: 0px">
            <asp:GridView ID="gd1" runat="server" CssClass="table table-bordered table-condensed"></asp:GridView>
        </div>

    </div>

     
</asp:Content>