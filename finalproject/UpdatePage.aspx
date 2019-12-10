<%@ Page Title="Update  Page" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="finalproject.UpdatePage" %>
<asp:Content ID="updatepage" ContentPlaceHolderID="body" runat="server">
    <div id="updatePage" runat="server">
        <div class="viewnav">
            <a class="left" href="ShowPage.aspx?pageid=<%=Request.QueryString["pageid"] %>">Cancel</a>
        </div>
        <h2>Updating Page <span id="page_title" runat="server"></span></h2>
        
        <div class="formrow">
           <label>Pagetitle:</label>
           <asp:TextBox runat="server" ID="page_title1"></asp:TextBox>
           <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter your page title" ControlToValidate="page_title"></asp:RequiredFieldValidator>
        </div>
        <div class="formrow">
           <label>Pagebody:</label>
           <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
           <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter your page body" ControlToValidate="page_body"></asp:RequiredFieldValidator>
        </div>
        <%--// In the codebehind, due to pagedate i was getting an error.i.e.why deleted for a while to correct my page.But, the other error that is coming
           // i am unable to understand that.I tried a lot.--%>

        <asp:Button Text="Update Page" OnClick="Update_Page" runat="server" />
    </div>
</asp:Content>
