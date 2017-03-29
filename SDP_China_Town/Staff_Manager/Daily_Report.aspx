<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_page.Master" CodeBehind="Daily_Report.aspx.vb" Inherits="SDP_China_Town.WebForm6" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">

        <div class="col-md-12 center-block">
            <h1>Daily Report</h1>
        </div>

       

    </div>

    <div class="row">

        <div class="col-md-12" style="left: 0px; top: 0px">
            <asp:GridView ID="GridView1" runat="server" CssClass=" table table-bordered table-condensed"></asp:GridView>
        </div>

    </div>

        <div class="row">

            <div class="col-md-12" style="left: 0px; top: 0px">
                <asp:Button ID="Button1" runat="server" Text="Generate" CssClass="btn btn-info center-block"/>
            </div>

    </div>
</asp:Content>