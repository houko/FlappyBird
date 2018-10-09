<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="disCommoditys.aspx.cs" Inherits="disCommoditys" Title="商品信息管理" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
        CellPadding="3" DataSourceID="commoditysSource" GridLines="Horizontal" Width="541px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <Columns>
            <asp:BoundField DataField="CommName" HeaderText="商品名称" SortExpression="CommName" />
            <asp:BoundField DataField="CommProducePlace" HeaderText="产地" SortExpression="CommProducePlace" />
            <asp:BoundField DataField="Unit" HeaderText="单位" SortExpression="Unit" />
            <asp:BoundField DataField="Specs" HeaderText="规格" SortExpression="Specs" />
            <asp:BoundField DataField="PassNumber" HeaderText="批号" SortExpression="PassNumber" />
            <asp:BoundField DataField="PassList" HeaderText="批准文号" SortExpression="PassList" />
            <asp:HyperLinkField DataNavigateUrlFields="CommId" DataNavigateUrlFormatString="parCommoditys.aspx?commid={0}"
                HeaderText="选择" Text="详细信息" />
        </Columns>
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>
    <asp:ObjectDataSource ID="commoditysSource" runat="server" SelectMethod="SelectAll"
        TypeName="SaleSysBIL.Commoditys"></asp:ObjectDataSource>
</asp:Content>

