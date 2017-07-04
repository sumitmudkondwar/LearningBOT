<%@ Page Title="Subject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subjects.aspx.cs" Inherits="WebApplication1.BOT.Subjects" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <br />
    <table>
        <tr>
            <td>
                Subject Name:
            </td>
            <td>
                <asp:TextBox ID="txtSubjectName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>

            </td>
        </tr>
    </table>
</asp:Content>
