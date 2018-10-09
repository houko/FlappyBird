<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="addCompany.aspx.cs" Inherits="addCompany" Title="添加公司" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div align="left">
        <table>
            <tr>
                <td align="left" style="font-size: 12px; width: 519px; color: red; height: 16px">
                    基本信息→添加公司信息</td>
            </tr>
        </table>
        <br />
        <table align="center" style="height: 376px" class=css border="1" bordercolordark="#003399" bordercolorlight="#ffffff" cellspacing="0">
            <tr>
                <td align="center" colspan="2" style="height: 39px; color: white; background-color: #003399;">
                    添加公司信息</td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"    >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CompanyName"
                        ErrorMessage="公司名称不能为空">*</asp:RequiredFieldValidator>公司名称：</td>
                <td style="width: 334px" align="left" >
                    <asp:TextBox ID="CompanyName" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"    >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CompanyShort"
                        ErrorMessage="公司简称不能为空">*</asp:RequiredFieldValidator>公司简称：</td>
                <td style="width: 334px" align="left">
                    <asp:TextBox ID="CompanyShort" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"  >
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="CompanyAddress"
                        ErrorMessage="地址不能为空" Display="Dynamic">*</asp:RequiredFieldValidator>地 址：</td>
                <td style="width: 334px; height: 26px;" align="left">
                    <asp:TextBox ID="CompanyAddress" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td  align="right" style="width: 149px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Postalcode"
                        Display="Dynamic" ErrorMessage="邮政编码填写错误" ValidationExpression="\d{6}">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Postalcode"
                        ErrorMessage="邮政编码不能为空">*</asp:RequiredFieldValidator>邮政编码：</td>
                <td style="width: 334px; height: 21px" align="left">
                    <asp:TextBox ID="Postalcode" runat="server" Width="97px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"   >
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Tel"
                        Display="Dynamic" ErrorMessage="联系电话填写错误" ValidationExpression="(\d{3}-)?\d{8}|(\d{4}-)(\d{7})">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Tel"
                        ErrorMessage="联系电话不能为空">*</asp:RequiredFieldValidator>联系电话：</td>
                <td style="width: 334px" align="left" >
                    <asp:TextBox ID="Tel" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"   >
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Fax"
                        Display="Dynamic" ErrorMessage="联系电话填写错误" ValidationExpression="(\d{3}-)?\d{8}|(\d{4}-)(\d{7})">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Fax"
                        ErrorMessage="传真不能为空">*</asp:RequiredFieldValidator>传 真：</td>
                <td style="width: 334px" align="left" >
                    <asp:TextBox ID="Fax" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 21px; width: 149px;" align="right"  >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Linkman1"
                        ErrorMessage="联系人1不能为空">*</asp:RequiredFieldValidator>联 系 人 1：</td>
                <td style="height: 21px; width: 334px;" align="left" >
                    <asp:TextBox ID="Linkman1" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 21px; width: 149px;" align="right"  >
                    联 系 人 2：</td>
                <td style="height: 21px; width: 334px;" align="left" >
                    <asp:TextBox ID="Linkman2" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"   >
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="Email"
                        Display="Dynamic" ErrorMessage="E-mail格式填写错误" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Email"
                        ErrorMessage="E-mail不能为空" Display="Dynamic">*</asp:RequiredFieldValidator>E-mail：</td>
                <td style="width: 334px" align="left" >
                    <asp:TextBox ID="Email" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"   >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="Bank"
                        ErrorMessage="银行不能为空">*</asp:RequiredFieldValidator>开户银行：</td>
                <td style="width: 334px" align="left">
                    <asp:TextBox ID="Bank" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 149px"   >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="BandAccounts"
                        ErrorMessage="银行帐号不能为空">*</asp:RequiredFieldValidator>银行账号：</td>
                <td style="width: 334px" align="left">
                    <asp:TextBox ID="BandAccounts" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td  align="right" style="width: 149px" >
                    所属类型：</td>
                <td style="width: 334px" align="left">
                    <asp:DropDownList ID="CompanyType" runat="server" DataTextField="Ctname" DataValueField="Ctid" DataSourceID="ComTypeSource">
                        <asp:ListItem>--请选择--</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="height: 34px">
                    <asp:Button ID="Button1" runat="server" Text="保存" Width="74px" OnClick="Button1_Click" />&nbsp;
                    <input id="Reset1" type="reset" value="　重置　" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                        ShowSummary="False" />
                    &nbsp;&nbsp;
                    <asp:ObjectDataSource ID="ComTypeSource" runat="server" SelectMethod="SelectAll"
                        TypeName="SaleSysBIL.CompanyTypes"></asp:ObjectDataSource>
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>

