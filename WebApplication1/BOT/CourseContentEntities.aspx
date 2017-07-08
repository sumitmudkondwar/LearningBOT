<%@ Page Title="Course Content Entities" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseContentEntities.aspx.cs" Inherits="WebApplication1.BOT.CourseContentEntities" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <br />
    <div class="form-horizontal">
        <h4>Create a new Course Module</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlCourseModule" CssClass="col-md-2 control-label">Course Module:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="ddlCourseModule" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEntityName" CssClass="col-md-2 control-label">Entity Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtEntityName" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtDuration" CssClass="col-md-2 control-label">Duration:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtDuration" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtURI" CssClass="col-md-2 control-label">URI:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtURI" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtOrder" CssClass="col-md-2 control-label">Order:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtOrder" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlStyle" CssClass="col-md-2 control-label">Style:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlStyle" runat="server" CssClass="form-control">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" CssClass="form-control" Width="100px" />
            </div>
            <div class="col-md-offset-2 col-md-11">
                <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="form-control" Width="100px" />
            </div>
        </div>
    </div>
</asp:Content>
