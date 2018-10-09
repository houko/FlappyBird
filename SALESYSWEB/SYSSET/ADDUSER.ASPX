<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="addUser.aspx.cs" Inherits="Sysset_addUser" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
 <div>
        <div>
            <table align="center" border="1" bordercolordark="#003399" bordercolorlight="#ffffff"
                cellspacing="0" style="font-size: 12px; width: 412px; height: 219px">
                <tr>
                    <td align="center" bgcolor="#003399" colspan="2" style="color: white; height: 27px">
                        添加用户</td>
                </tr>
                <tr>
                    <td align="right" style="width: 77px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="username"
                            Display="Dynamic" ErrorMessage="用户名不能为空">*</asp:RequiredFieldValidator>用户名：</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="username" runat="server" Width="160px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right" style="width: 77px">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="userpwd"
                            ErrorMessage="密码不能为空">*</asp:RequiredFieldValidator>密 &nbsp; 码：</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="userpwd" runat="server" TextMode="Password" Width="160px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right" style="width: 77px; height: 52px">
                     权 &nbsp; 限：</td>
                    <td style="width: 100px; height: 52px">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="　添加　" />
                        <input id="Reset1" type="reset" value="　重置　" /></td>
                </tr>
            </table>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ShowSummary="False" />
    </div>
</asp:Content>

