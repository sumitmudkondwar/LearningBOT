<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="WebApplication1.BOT.Courses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <br />
    <div class="form-horizontal">
        <h4>Create a new Course</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlSubjectName" CssClass="col-md-2 control-label">Subject Name:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlSubjectName" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlSource" CssClass="col-md-2 control-label">Source:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlSource" runat="server" CssClass="form-control">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCourseName" CssClass="col-md-2 control-label">Course Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCourseName" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCourseDescription" CssClass="col-md-2 control-label">Course Description:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCourseDescription" CssClass="form-control" TextMode="MultiLine" Height="200px" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtAbstract" CssClass="col-md-2 control-label">Abstract:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtAbstract" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlCourseAudience" CssClass="col-md-2 control-label">Course Audience:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlCourseAudience" runat="server" CssClass="form-control">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCourseDuration" CssClass="col-md-2 control-label">Course Duration:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCourseDuration" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlLevel" CssClass="col-md-2 control-label">Level:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlLevel" runat="server" CssClass="form-control">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlRating" CssClass="col-md-2 control-label">Rating:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlRating" runat="server" CssClass="form-control">
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtRatingCount" CssClass="col-md-2 control-label">Rating Count:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtRatingCount" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtAuthor" CssClass="col-md-2 control-label">Author:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtAuthor" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtCourseDate" CssClass="col-md-2 control-label">Course Date:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtCourseDate" CssClass="form-control" />
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
