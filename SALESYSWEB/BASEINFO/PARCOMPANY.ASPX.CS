using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SaleSysBIL;
using SaleSysEL;

public partial class parCompany : System.Web.UI.Page
{
    private void DataListBind()
    {
        Guid cid = new Guid(Request["cid"].ToString());
        Companys coms = new Companys();
        DataList1.DataSource = coms.SelectInfoByID(cid);
        DataList1.DataBind();
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataListBind();
        }
    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = e.Item.ItemIndex;
        DataListBind();
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        Guid cid = new Guid(Request["cid"].ToString());
        Companys comps = new Companys();
        if (comps.delCompany(cid) > 0)
        {
            RegisterClientScriptBlock("FormatError", "<script language='javascript'>alert('删除成功！');</script>");
            Response.Redirect("disCompany.aspx");
        }
        else
        {
            RegisterClientScriptBlock("FormatError", "<script language='javascript'>alert('删除失败！');</script>");
        }

    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.EditItem)
        {
            TextBox txtcname = (TextBox)e.Item.FindControl("TextBox1");
            txtcname.Text = ((Company)e.Item.DataItem).Cname;
            TextBox txtsname = (TextBox)e.Item.FindControl("TextBox2");
            txtsname.Text =((Company)e.Item.DataItem).Cshortname;
            DropDownList ddltype = (DropDownList)e.Item.FindControl("DropDownList1");
            CompanyTypes comts = new CompanyTypes();
            ddltype.DataSource = comts.SelectAll();
            ddltype.DataTextField = "Ctname";
            ddltype.DataValueField = "Ctid";
            ddltype.DataBind();
            ListItem list = ddltype.Items.FindByText(((Company)e.Item.DataItem).Ctype);
            list.Selected = true;
            TextBox txtcadder = (TextBox)e.Item.FindControl("TextBox3");
            txtcadder.Text = ((Company)e.Item.DataItem).Caddress;
            TextBox txtPostCode = (TextBox)e.Item.FindControl("TextBox4");
            txtPostCode.Text = ((Company)e.Item.DataItem).Cpostcode;
            TextBox txtTel = (TextBox)e.Item.FindControl("TextBox5");
            txtTel.Text = ((Company)e.Item.DataItem).Ctel;
            TextBox txtFax = (TextBox)e.Item.FindControl("TextBox6");
            txtFax.Text = ((Company)e.Item.DataItem).Cfax;
            TextBox txtlink1 = (TextBox)e.Item.FindControl("TextBox7");
            txtlink1.Text = ((Company)e.Item.DataItem).Clinkman1;
            TextBox txtlink2 = (TextBox)e.Item.FindControl("TextBox8");
            txtlink2.Text = ((Company)e.Item.DataItem).Clinkman2;
            TextBox txtEmail = (TextBox)e.Item.FindControl("TextBox9");
            txtEmail.Text = ((Company)e.Item.DataItem).Email;
            TextBox txtbank = (TextBox)e.Item.FindControl("TextBox10");
            txtbank.Text = ((Company)e.Item.DataItem).Bank;
            TextBox txtbankAccount = (TextBox)e.Item.FindControl("TextBox11");
            txtbankAccount.Text = ((Company)e.Item.DataItem).BankAccounts;
        }

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            LinkButton lb = (LinkButton)e.Item.FindControl("lnkDelete");
            lb.Attributes.Add("onclick", "return confirm('确认删除？');");
        }
    }

    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        Guid cid = new Guid(Request["cid"].ToString());
        TextBox txtcname = (TextBox)e.Item.FindControl("TextBox1");
        TextBox txtsname = (TextBox)e.Item.FindControl("TextBox2");
        DropDownList ddltype = (DropDownList)e.Item.FindControl("DropDownList1");
        TextBox txtcadder = (TextBox)e.Item.FindControl("TextBox3");
        TextBox txtPostCode = (TextBox)e.Item.FindControl("TextBox4");
        TextBox txtTel = (TextBox)e.Item.FindControl("TextBox5");
        TextBox txtFax = (TextBox)e.Item.FindControl("TextBox6");
        TextBox txtlink1 = (TextBox)e.Item.FindControl("TextBox7");
        TextBox txtlink2 = (TextBox)e.Item.FindControl("TextBox8");
        TextBox txtEmail = (TextBox)e.Item.FindControl("TextBox9");
        TextBox txtbank = (TextBox)e.Item.FindControl("TextBox10");
        TextBox txtbankAccount = (TextBox)e.Item.FindControl("TextBox11");


        string cn = txtcname.Text;
        string cs = txtsname.Text;
        Guid ct = new Guid(ddltype.SelectedValue.ToString());
        string cad = txtcadder.Text;
        string cpc = txtPostCode.Text;
        string ctel = txtTel.Text;
        string cfax = txtFax.Text;
        string cl1 = txtlink1.Text;
        string cl2 = null;
        if (txtlink2.Text == "")
        {
            cl2 = null;
        }
        else
        {
            cl2 = txtlink2.Text;
        }
        string email = txtEmail.Text;
        string bank = txtbank.Text;
        string bacc = txtbankAccount.Text;

        try
        {
            Companys coms = new Companys();
            if(coms.UpdateCompany(cid,cn,cs,ct,cad,cpc,ctel,cfax,cl1,cl2,email,bank,bacc) > 0)
            {
                Response.Write("<script language=javascript>alert('更新成功')</script>");
                DataList1.EditItemIndex = -1;
                DataListBind();
            }
            else
            {
                Response.Write("<script language=javascript>alert('添加失败')</script>");
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
}
