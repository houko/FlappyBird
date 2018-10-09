<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="addCommoditys.aspx.cs" Inherits="addCommoditys" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div align="left">
        <table>
            <tr>
                <td align="left" style="font-size: 12px; width: 519px; color: red; height: 16px">
                    添加商品信息</td>
            </tr>
        </table>
        <br />
        <table align="center" style="width: 430px; height: 381px" class=css border="1" bordercolordark="#003399" bordercolorlight="#ffffff" cellspacing="0">
            <tr>
                <td align="center" colspan="2" style="height: 36px; color: white; background-color: #003399;">
                    添加商品信息</td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CommodityName"
                        ErrorMessage="商品名称不能为空">*</asp:RequiredFieldValidator>商品名称：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="CommodityName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ShortName"
                        ErrorMessage="商品简称不能为空">*</asp:RequiredFieldValidator>商品简称：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="ShortName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ProducePlace"
                        ErrorMessage="产地不能为空">*</asp:RequiredFieldValidator>产地：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="ProducePlace" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td s align="right" style="width: 123px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Unit"
                        ErrorMessage="单位不能为空">*</asp:RequiredFieldValidator>单位：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="Unit" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Specs"
                        ErrorMessage="规格不能为空">*</asp:RequiredFieldValidator>规格：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="Specs" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="PassNumber"
                        ErrorMessage="批号不能为空">*</asp:RequiredFieldValidator>批号：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="PassNumber" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="PassList"
                        ErrorMessage="批准文号不能为空">*</asp:RequiredFieldValidator>批准文号：</td>
                <td style="width: 299px" align="left" >
                    <asp:TextBox ID="PassList" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 123px" >
                    供应商：</td>
                <td style="width: 299px" align="left" >
                    <asp:DropDownList ID="CompanyId" runat="server">
                    </asp:DropDownList></td>
            </tr>
                        <tr>
                <td align="right" style="width: 123px" >
                    备注：</td>
                <td style="width: 299px" >
                    <asp:TextBox ID="Remark" runat="server" TextMode="MultiLine" Width="284px" Height="52px">无</asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="　添加　" OnClick="Button1_Click" />
                    <input id="Reset1" type="reset" value="　重置　" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                        ShowSummary="False" />
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>

