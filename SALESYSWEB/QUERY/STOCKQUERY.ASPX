<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="StockQuery.aspx.cs" Inherits="Query_StockQuery" Title="进货信息查询" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<script language="javascript" src="Calendar.js"></script>
<div align="center">
        <table>
            <tr>
                <td align="left" style="font-size: 12px; width: 519px; color: red; height: 16px">
                    商品进货查询</td>
            </tr>
        </table>
        <br />
        <table style="font-size: 12px; height: 51px; text-align: center; width: 553px;">
            <tr>
                <td align="left" style="width: 661px; height: 27px;">
                    <asp:CheckBox ID="ckbcommodity" runat="server" Text="商品名称" /></td>
                <td align="left" style="width: 223px; height: 27px;">
                    <asp:TextBox ID="txtComName" runat="server" Width="170px"></asp:TextBox></td>
                <td align="left" style="width: 485px; height: 27px;">
                    <asp:CheckBox ID="ckbman" runat="server" Text="经手人" /></td>
                <td align="left" style="width: 148px; height: 27px;">
                    <asp:TextBox ID="txtMan" runat="server" Width="90px"></asp:TextBox></td>
                <td align="left" style="width: 78px; height: 27px;">
                    <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" Text="查询"
                        Width="54px" />
                    </td>
            </tr>
            <tr>
                <td align="left" style="width: 661px; height: 26px">
                    <asp:CheckBox ID="ckbpay" runat="server" Text="支付方式" /></td>
                <td align="left" style="width: 223px; height: 26px">
                    <asp:DropDownList ID="ddlpay" runat="server">
                        <asp:ListItem>现金</asp:ListItem>
                        <asp:ListItem>支票</asp:ListItem>
                    </asp:DropDownList></td>
                <td align="left" style="width: 485px; height: 26px">
                    <asp:CheckBox ID="ckbType" runat="server" Text="类型" /></td>
                <td align="left" style="width: 148px; height: 26px">
                    <asp:DropDownList ID="ddlType" runat="server">
                        <asp:ListItem Value="进货">进货</asp:ListItem>
                        <asp:ListItem Value="退货">退货</asp:ListItem>
                    </asp:DropDownList></td>
                <td align="left" style="width: 78px; height: 26px">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" Width="53px" /></td>
            </tr>
            <tr>
                <td align="left" style="width: 661px; height: 26px">
                    <asp:CheckBox ID="ckbdate" runat="server" Text="日期" /></td>
                <td align="left" colspan="3" style="height: 26px">
                    <asp:TextBox ID="txtbdate" runat="server" Width="158px"></asp:TextBox>至<asp:TextBox
                        ID="txtedate" runat="server" Width="144px"></asp:TextBox></td>
                <td align="left" style="width: 78px; height: 26px">
                </td>
            </tr>

        </table>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF"
        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AutoGenerateColumns="False" Height="185px" Width="552px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="Commodityname" HeaderText="商品名称" SortExpression="CommName"/>
            <asp:BoundField DataField="Settlementtype" HeaderText="支付方式" SortExpression="CommName" DataFormatString="{0:C}"/>
            <asp:BoundField DataField="Manageman" HeaderText="经办人" SortExpression="CommName"/>
            <asp:BoundField DataField="Stockdate" HeaderText="销售日期" SortExpression="CommName"/>
            <asp:BoundField DataField="Type" HeaderText="类型" SortExpression="CommName"/>
            <asp:HyperLinkField HeaderText="选择" Text="详细信息" />
        </Columns>
    </asp:GridView>
</asp:Content>

