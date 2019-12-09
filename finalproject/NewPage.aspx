<%@ Page Title="New Page" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NewPage.aspx.cs" Inherits="finalproject.NewPage" %>
<asp:Content ID="newpage" ContentPlaceHolderID="body" runat="server">
    <h2>New Page</h2>
    <div class="formrow">
        <label>Pagetitle:</label>
        <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter your page title" ControlToValidate="page_title"></asp:RequiredFieldValidator>
    </div>
    <div class="formrow">
        <label>Pagebody:</label>
        <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter your page body" ControlToValidate="page_body"></asp:RequiredFieldValidator>
    </div>
    <!-- we have not included here the page date as the system will take the date on its own when the page
          will be entered to the system.-->
    <asp:Button OnClick="Add_Page" Text="Add Page" runat="server" />
    
</asp:Content>




