<%@ Page Language="C#" MasterPageFile="~/SaleSysMain.master" AutoEventWireup="true" CodeFile="parCompany.aspx.cs" Inherits="parCompany" Title="公司详细信息" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
 <div align=left>
        &nbsp;<asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#E7E7FF"
            BorderStyle="None" BorderWidth="1px" CellPadding="1" DataKeyField="Cid" GridLines="Horizontal"
            OnDeleteCommand="DataList1_DeleteCommand" OnEditCommand="DataList1_EditCommand"
            OnItemDataBound="DataList1_ItemDataBound" OnUpdateCommand="DataList1_UpdateCommand"
            Width="384px">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemTemplate>
                <table style="width: 368px">
                    <tr>
                        <td style="width: 72px">
                            公司名称:</td>
                        <td style="width: 183px">
                            <asp:Label ID="CnameLabel" runat="server" Text='<%# Eval("Cname") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司简称:
                        </td>
                        <td style="width: 183px">
                            <asp:Label ID="CshortnameLabel" runat="server" Text='<%# Eval("Cshortname") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司类型:</td>
                        <td style="width: 183px">
                            <asp:Label ID="CtypeLabel" runat="server" Text='<%# Eval("Ctype") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司地址:
                        </td>
                        <td style="width: 183px">
                            <asp:Label ID="CaddressLabel" runat="server" Text='<%# Eval("Caddress") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司邮编:</td>
                        <td style="width: 183px">
                            <asp:Label ID="CpostcodeLabel" runat="server" Text='<%# Eval("Cpostcode") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司电话:
                        </td>
                        <td style="width: 183px">
                            <asp:Label ID="CtelLabel" runat="server" Text='<%# Eval("Ctel") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司传真:</td>
                        <td style="width: 183px">
                            <asp:Label ID="CfaxLabel" runat="server" Text='<%# Eval("Cfax") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            联系人1:
                        </td>
                        <td style="width: 183px">
                            <asp:Label ID="Clinkman1Label" runat="server" Text='<%# Eval("Clinkman1") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            联系人2:</td>
                        <td style="width: 183px">
                            <asp:Label ID="Clinkman2Label" runat="server" Text='<%# Eval("Clinkman2") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            邮件:
                        </td>
                        <td style="width: 183px">
                            <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            开户银行:</td>
                        <td style="width: 183px">
                            <asp:Label ID="BankLabel" runat="server" Text='<%# Eval("Bank") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            开户帐号:
                        </td>
                        <td style="width: 183px">
                            <asp:Label ID="BankAccountsLabel" runat="server" Text='<%# Eval("BankAccounts") %>'></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 72px; height: 21px;">
                            添加时间:</td>
                        <td style="width: 183px; height: 21px;">
                            <asp:Label ID="CaddtimeLabel" runat="server" Text='<%# Eval("Caddtime") %>'></asp:Label></td>
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
                            公司名称:</td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司简称:
                        </td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司类型:</td>
                        <td style="width: 183px">
                            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Ctname" DataValueField="Ctid">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司地址:
                        </td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司邮编:</td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司电话:
                        </td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司传真:</td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px; height: 21px;">
                            联系人1:
                        </td>
                        <td style="width: 183px; height: 21px;">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            联系人2:</td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            公司邮件:
                        </td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            开户银行:</td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 72px">
                            开户帐号:
                        </td>
                        <td style="width: 183px">
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update">保存</asp:LinkButton>
            </EditItemTemplate>
        </asp:DataList></div>
    <br />
</asp:Content>

