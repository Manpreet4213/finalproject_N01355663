<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="deletePage.aspx.cs" Inherits="finalproject.deletePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <ASP:Button OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" OnClick="Delete_Student" CssClass="right spaced" Text="Delete" runat="server"/> 
</asp:Content>
