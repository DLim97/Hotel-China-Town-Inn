<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_page.Master" CodeBehind="Searching_Details.aspx.vb" Inherits="SDP_China_Town.WebForm12" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">

        <div class="col-md-12 center-block">
            <h1>Search for Customer's Details</h1>
        </div>

        <div class="col-md-3" style="left: 0px; top: 0px">
            <h4>Name:</h4>
        </div>

        <div class="col-md-9">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

    </div>

    <div class="row">

        <div class="col-md-3" style="left: 0px; top: 0px">
            <h4>Identification Number:</h4>
        </div>

        <div class="col-md-9">
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32 && !(event.shiftKey && (event.keyCode >= 48 && event.keyCode <= 57)));"></asp:TextBox>
        </div>

    </div>

    <div class="row">

        <div class="col-md-12" style="left: 0px; top: 0px">
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-condensed"></asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Search Results" CssClass="control-label"></asp:Label>
        </div>

        <div class="row">

            <div class="col-md-12" style="left: 0px; top: 0px">
                <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-info center-block" />
            </div>

        </div>
    </div>
</asp:Content>



