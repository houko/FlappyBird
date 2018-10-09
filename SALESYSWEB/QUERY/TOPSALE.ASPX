<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="topSale.aspx.cs" Inherits="Query_topSale" Title="热销商品" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<table style="width: 448px; height: 266px;" class=css align="left" border="1" bordercolordark="#003399" bordercolorlight="#ffffff" cellspacing="0">
            <tr>
                <td colspan="1" align="center" style="height: 49px; color: white; background-color: #003399;">
                    热销商品信息</td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 1px;" rowspan="1">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BackColor="White"
        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="ObjectDataSource1"
        GridLines="Horizontal" Width="444px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="TopSale"
        TypeName="SaleSysBIL.Sales"></asp:ObjectDataSource>
</td>
            </tr>

                       <tr>
            </tr>
        </table>
        <br />
        <br /> &nbsp;
</asp:Content>

