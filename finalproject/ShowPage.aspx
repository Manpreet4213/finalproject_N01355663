<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowPage.aspx.cs" Inherits="finalproject.ShowPage" %>
<asp:Content ID="page_view" ContentPlaceHolderID="body" runat="server">
    <div class="viewnav">
        <a class="left" href="ListPages.aspx">Back To List</a>
    </div>
    <div id="ipage" runat="server">
        <h2>Details for <span id="page_title" runat="server"></span></h2>
        Page Body:<span id="page_body" runat="server"></span><br />
        Page Date <span id="page_date" runat="server"></span><br />
    </div>
</asp:Content>
