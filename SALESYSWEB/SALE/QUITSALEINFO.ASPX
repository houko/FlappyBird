<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="quitSaleInfo.aspx.cs" Inherits="Sale_quitSaleInfo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<script language="javascript" src="Calendar.js"></script>
<script language="javascript">
function jisuan()
{
    n1=document.form1.Price.value;
    n2=document.form1.Number.value;
    document.form1.Payment.value=n1*n2;
    fact();
}
function fact()
{
    var payment;
    var factpayment;
    payment=document.form1.Payment.value;
    factpayment=document.form1.FactPayment.value;
    if(payment-factpayment<0)
    {
        alert('实际支付填写错误');
        form1.FactPayment.select();
    }
    else
    {
        document.form1.NotPayment.value=payment-factpayment;
    }
}
</script>
<div>
        <table style="width: 448px; height: 266px;" class=css align="left" border="1" bordercolordark="#003399" bordercolorlight="#ffffff" cellspacing="0">
            <tr>
                <td colspan="2" align="center" style="height: 49px; color: white; background-color: #003399;">
                    添加销售退货信息</td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 4px">
                    公司名称：<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CommodityId"
                        ErrorMessage="请先添加商品">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px; color: #000000; height: 4px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="213px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 4px;">
                    商品名称：<asp:RequiredFieldValidator ID="RequiredieldValidator1" runat="server" ControlToValidate="CommodityId"
                        ErrorMessage="请先添加商品">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px; height: 4px; color: #000000;">
                    <asp:DropDownList ID="CommodityId" runat="server" Width="213px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 5px;">
                    数量：<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="Number" 
                        Display="Dynamic" ErrorMessage="数量必须是数字" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Price"
                        Display="Dynamic" ErrorMessage="单价不能为空">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px; color: #000000; height: 5px;">
                    <asp:TextBox ID="Number" runat="server" Width="100px" ></asp:TextBox></td>
            </tr>
            <tr style="color: #000000">
                <td align="left" style="width: 124px; height: 6px;">
                    单价：<asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="Price"
                        Display="Dynamic" ErrorMessage="单价格式填写错误" Operator="DataTypeCheck" Type="Currency">*</asp:CompareValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Price"
                        Display="Dynamic" ErrorMessage="请先添加商品">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px; color: #000000; height: 6px;">
                    <asp:TextBox ID="Price" runat="server" Width="100px" ></asp:TextBox>元</td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 1px;" rowspan="3">
                    结算方式：</td>
                <td style="width: 142px; height: 1px;" rowspan="3">
                    <asp:DropDownList ID="SettlementType" runat="server">
                    <asp:ListItem>现金</asp:ListItem>
                    <asp:ListItem>支票</asp:ListItem>
                </asp:DropDownList></td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 2px;">
                    应付金额：<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Payment"
                        Display="Dynamic" ErrorMessage="应付金额不能为空">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px; height: 2px;">
                    <asp:TextBox ID="Payment" runat="server" Width="100px" EnableTheming="True"></asp:TextBox>
                    元</td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 3px;">
                    实付金额：<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="FactPayment"
                        ErrorMessage="实付金额不能为空">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="FactPayment"
                        Display="Dynamic" ErrorMessage="实付金额格式填写错误" Operator="DataTypeCheck" Type="Currency">*</asp:CompareValidator></td>
                <td style="width: 142px; height: 3px;">
                    <asp:TextBox ID="FactPayment" runat="server" Width="100px"></asp:TextBox>元</td>
            </tr>
            <tr>
                <td align="left" style="width: 124px;">
                    未付金额：<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="NotPayment"
                        Display="Dynamic" ErrorMessage="未付金额不能为空" Width="5px">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px;">
                    <asp:TextBox ID="NotPayment" runat="server" Width="100px"></asp:TextBox>元</td>
            </tr>
                       <tr>
                <td align="left" style="height: 12px; width: 124px;">
                    经 手 人：<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ManageMan"
                        ErrorMessage="经手人不能为空">*</asp:RequiredFieldValidator></td>
                <td style="width: 142px; height: 12px;">
                    <asp:TextBox ID="ManageMan" runat="server" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="left" style="width: 124px; height: 5px">
                    进货日期：</td>
                <td style="width: 142px; height: 5px">
                    <asp:TextBox ID="addSaleDate" runat="server" Width="100px"></asp:TextBox></td>
            </tr>

                       <tr>
            </tr>
            <tr>
                <td align="center" colspan="2" style="height: 22px">
                    <asp:Button ID="Button1" runat="server" Text="　添加　" OnClick="Button1_Click" />
                    <input id="Reset1" type="reset" value="　重置　" /></td>
            </tr>
        </table>
        <br />
        <br /> 
    </div>
</asp:Content>

