<%@ Page Title="Subject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseModules.aspx.cs" Inherits="WebApplication1.BOT.CourseModules" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <br />
    <div class="form-horizontal">
        <h4>Create a new Course Module</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlCourses" CssClass="col-md-2 control-label">Courses:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList runat="server" ID="ddlCourses" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtModuleName" CssClass="col-md-2 control-label">Module Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtModuleName" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtModuleDescription" CssClass="col-md-2 control-label">Module Description:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtModuleDescription" CssClass="form-control" TextMode="MultiLine" Height="200px" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtAbstract" CssClass="col-md-2 control-label">Abstract:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtAbstract" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtDetails" CssClass="col-md-2 control-label">Details:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtDetails" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddllevel" CssClass="col-md-2 control-label">Level:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddllevel" runat="server" CssClass="form-control">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                </asp:DropDownList>
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
            <asp:Label runat="server" AssociatedControlID="txtDuration" CssClass="col-md-2 control-label">Duration:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtDuration" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtLastUpdated" CssClass="col-md-2 control-label">Last Updated:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtLastUpdated" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtOrder" CssClass="col-md-2 control-label">Order:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtOrder" CssClass="form-control" TextMode="SingleLine" />
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
