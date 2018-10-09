<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" Title="用户登录" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
  <table width=430 border=0 cellpadding=0 cellspacing=0 >
    <tr>
      <td colspan=8 style="height: 130px"><img src="images/login_1.gif" height=130 alt="" style="font-size: 12px; width: 435px;" /></td>
    </tr>
    <tr>
      <td style="width: 141px"><img src="images/login_2.gif" width=139 height=133 /></td>
        <td>
        </td>
        <td style="width: 31335px">
            <table style="width: 289px; height: 79px">
                <tr>
                    <td style="width: 66px">
                        用户名：</td>
                    <td colspan="2" style="width: 610px">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>(admin)</td>
                </tr>
                <tr>
                    <td style="width: 66px; height: 26px;">
                        密码：</td>
                    <td colspan="2" style="width: 610px; height: 26px;">
                        <asp:TextBox ID="TextBox2" runat="server" Width="149px"></asp:TextBox>admin)</td>
                </tr>
                <tr>
                    <td style="width: 66px">
                    </td>
                    <td colspan="2" style="width: 610px">
                        &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:Button ID="btnOk" runat="server" Text="登录" OnClick="btnOk_Click" /><asp:Button ID="btnCancel"
                            runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2" style="width: 610px; height: 22px">
                        <asp:HyperLink ID="HyperLink1" runat="server">注册新用户</asp:HyperLink></td>
                    <td style="width: 182px; height: 22px">
                        <asp:CheckBox ID="cbxRember" runat="server" Text="记住密码" /></td>
                </tr>
            </table>
        </td>
        <td style="width: 396px">
        </td>
	  <td></td>
    </tr>
  </table>
</asp:Content>
