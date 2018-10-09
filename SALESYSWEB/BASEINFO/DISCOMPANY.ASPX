<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true"
    CodeFile="disCompany.aspx.cs" Inherits="disCompany" Title="公司信息" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="CompanyDataSource" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="540px" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Cshortname" HeaderText="公司简称" SortExpression="Cshortname"  />
            <asp:BoundField DataField="Ctype" HeaderText="公司类型" SortExpression="Ctype" />
            <asp:BoundField DataField="Ctel" HeaderText="公司电话" SortExpression="Ctel" />
            <asp:BoundField DataField="Cfax" HeaderText="公司传真" SortExpression="Cfax" />
            <asp:BoundField DataField="Clinkman1" HeaderText="联系人1" SortExpression="Clinkman1" />
            <asp:HyperLinkField DataNavigateUrlFields="Cid" DataNavigateUrlFormatString="parCompany.aspx?cid={0}"
                HeaderText="操作" Text="详细信息" />
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>
    <asp:ObjectDataSource ID="CompanyDataSource" runat="server" SelectMethod="SelectAll"
        TypeName="SaleSysBIL.Companys"></asp:ObjectDataSource>
    <br />
</asp:Content>
