<%@ Page Title="Subjects" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubjectsBulk.aspx.cs" Inherits="WebApplication1.BOT.SubjectsBulk" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <br />
    <div class="form-horizontal">
        <h4>Add a new Subjects</h4>
        <hr />
        <div class="form-group">
            <asp:GridView ID="grdSubjects" runat="server" AutoGenerateEditButton="true" OnRowEditing="grdSubjects_RowEditing" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Subject Name" ItemStyle-Width="30px" />
                    <asp:BoundField DataField="Description" HeaderText="Subject Description" ItemStyle-Width="30px" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
                
            </asp:GridView>
        </div>
    </div>
</asp:Content>
