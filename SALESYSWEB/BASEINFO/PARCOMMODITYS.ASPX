<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="parCommoditys.aspx.cs" Inherits="parCommoditys" Title="修改商品信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
 <div align="left">
        <table align="left" style="height: 376px" class=css border="1" bordercolordark="#003399" bordercolorlight="#ffffff" cellspacing="0">
            <tr>
                <td align="center" colspan="2" style="height: 39px; color: white; background-color: #003399; width: 374px;">
                    公司详细信息</td>
            </tr>
            <tr>
                <td align="left" colspan="2" rowspan="12" style="width: 374px"    >
                    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#E7E7FF" OnEditCommand="DataList1_EditCommand" BorderStyle="None" BorderWidth="1px" CellPadding="1" 
                        GridLines="Horizontal" Width="384px" DataKeyField="CommId" OnDeleteCommand="DataList1_DeleteCommand" OnItemDataBound="DataList1_ItemDataBound" OnUpdateCommand="DataList1_UpdateCommand" CellSpacing="1">
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <AlternatingItemStyle BackColor="#F7F7F7" />
                        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <ItemTemplate>
                            <table style="width: 368px">
                                <tr>
                                    <td style="width: 72px">
                                        商品名称:</td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CnameLabel" runat="server" Text='<%# Eval("CommName") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品简称:
                                    </td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CshortnameLabel" runat="server" Text='<%# Eval("CommShortName") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品产地:</td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CommPP" runat="server" Text='<%# Eval("CommProducePlace") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品单位:</td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CUnit" runat="server" Text='<%# Eval("Unit") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品规格:</td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CSpecs" runat="server" Text='<%# Eval("Specs") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品批号:</td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CpassNumber" runat="server" Text='<%# Eval("PassNumber") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        批准文号:</td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CPassList" runat="server" Text='<%# Eval("PassList") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        供应商:
                                    </td>
                                    <td style="width: 183px">
                                        <asp:Label ID="ComName" runat="server" Text='<%# Eval("ComName") %>'></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        备注:
                                    </td>
                                    <td style="width: 183px">
                                        <asp:Label ID="CRemark" runat="server" Text='<%# Eval("Remark") %>'></asp:Label></td>
                                </tr>
                            </table>
                            &nbsp; &nbsp;
                            <asp:LinkButton ID="lnkEdit" runat="server" CommandName="Edit">更新</asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete">删除</asp:LinkButton><br />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <table style="width: 368px">
                                <tr>
                                    <td style="width: 72px">
                                        商品名称:</td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品简称:
                                    </td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品产地:</td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                        
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品单位:
                                    </td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品规格:</td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        商品批号:
                                    </td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        批准文号:</td>
                                    <td style="width: 183px">
                                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px">
                                        供应商:</td>
                                    <td style="width: 183px">
                                        <asp:DropDownList ID="DropDownList1" runat="server">
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td style="width: 72px; height: 46px;">
                                        备注:
                                    </td>
                                    <td style="width: 183px; height: 46px;">
                                        <asp:TextBox ID="TextBox8" runat="server" Height="61px" Width="151px"></asp:TextBox></td>
                                </tr>                       
                            </table>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update">保存</asp:LinkButton>
                        </EditItemTemplate>
                    </asp:DataList>
</td>
</table>
    
    </div>
</asp:Content>

