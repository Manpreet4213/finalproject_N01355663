<%@ Page Title="Pages" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListPages.aspx.cs" Inherits="finalproject.ListPages" %>
<asp:Content ID="pages_list" ContentPlaceHolderID="body" runat="server">
    
    <h1>Manage Pages</h1>
    <div id="page_nav">
        <asp:label for="page_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="page_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="submit"/>
        <!--<div id="debug" runat="server"></div> show queries for debugging  -->
    </div>
    <% 
    //in order to search for pages, search bar is created.  
    %>
    <a href="NewPage.aspx">Add New</a>
     <!-- search results table -->
    <div class="table" runat="server">
        <div class="table-head">
            <div class="table-heading">Pagetitle</div>
            <div class="table-heading">Pagebody</div>
            <div class="table-heading">Pagedate</div>
            <div class="table-heading">Actions</div>
        </div>
        <div id="search_results" class="table-body" runat="server">
        </div>
    </div>

</asp:Content>

