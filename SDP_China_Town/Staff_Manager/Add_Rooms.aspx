<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_page.Master" CodeBehind="Add_Rooms.aspx.vb" Inherits="SDP_China_Town.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">

        <div class="col-md-12 center-block">
            <h1>Create Rooms</h1>
        </div>

        <div class="col-md-3" style="left: 0px; top: 0px">
            <h4>Description:</h4>
        </div>

        <div class="col-md-9">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

    </div>


    <div class="row">

        <div class="col-md-3" style="left: 0px; top: 0px">
            <h4>Types of Suite:</h4>
        </div>

        <div class="col-md-9">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                <asp:ListItem Selected="True">Please Select a Room</asp:ListItem>
                <asp:ListItem>Luxury</asp:ListItem>
                <asp:ListItem>Business</asp:ListItem>
                <asp:ListItem>Economy</asp:ListItem>
            </asp:DropDownList>
        </div>

    </div>

    
    <div class="row">

        <div class="col-md-12" style="left: 0px; top: 0px">
            <asp:Button ID="Button1" runat="server" Text="Create" CssClass="btn btn-info center-block" />
        </div>

    </div>
</asp:Content>