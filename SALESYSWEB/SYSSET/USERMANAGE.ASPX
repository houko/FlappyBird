<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="userManage.aspx.cs" Inherits="Sysset_userManage" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
        CellPadding="3" DataSourceID="ObjectDataSource1" GridLines="Horizontal" Width="326px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <Columns>
            <asp:BoundField DataField="Uname" HeaderText="用户名" SortExpression="Uname" />
            <asp:BoundField DataField="Upwd" HeaderText="用户密码" SortExpression="Upwd" />
            <asp:BoundField DataField="Upower" HeaderText="用户权限" SortExpression="Upower" />
            <asp:HyperLinkField HeaderText="选择" Text="修改" />
        </Columns>
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll"
        TypeName="SaleSysBIL.UserInfos"></asp:ObjectDataSource>
</asp:Content>

