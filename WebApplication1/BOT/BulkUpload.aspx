<%@ Page Title="Bulk Upload Data" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BulkUpload.aspx.cs" Inherits="WebApplication1.BOT.BulkUpload" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_OnClick" Text="Upload" />
</asp:Content>
