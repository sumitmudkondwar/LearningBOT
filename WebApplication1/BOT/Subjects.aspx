<%@ Page Title="Subject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subjects.aspx.cs" Inherits="WebApplication1.BOT.Subjects" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <br />
    <div class="form-horizontal">
        <h4>Create a new Subject</h4>
        <hr />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtSubjectName" CssClass="col-md-2 control-label">Subject Name:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtSubjectName" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtSubjectDescription" CssClass="col-md-2 control-label">Subject Description:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="txtSubjectDescription" CssClass="form-control" TextMode="MultiLine" Height="200px" />
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
