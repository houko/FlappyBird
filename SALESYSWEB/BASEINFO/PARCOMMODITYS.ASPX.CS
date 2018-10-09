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

public partial class parCommoditys : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataListBind();
        }
    }

    private void DataListBind()
    {
        Guid commid = new Guid(Request["commid"].ToString());
        Commoditys comms = new Commoditys();
        DataList1.DataSource = comms.SelectInfoByID(commid);
        DataList1.DataBind();
    }

    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = e.Item.ItemIndex;
        DataListBind();
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        Guid cid = new Guid(Request["commid"].ToString());
        Commoditys comms = new Commoditys();
        if (comms.delCommodity(cid) > 0)
        {
            RegisterClientScriptBlock("FormatError", "<script language='javascript'>alert('删除成功！');</script>");
            Response.Redirect("disCommoditys.aspx");
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
            TextBox txtcomname = (TextBox)e.Item.FindControl("TextBox1");
            txtcomname.Text = ((Commodity)e.Item.DataItem).CommName;
            TextBox txtcsname = (TextBox)e.Item.FindControl("TextBox2");
            txtcsname.Text = ((Commodity)e.Item.DataItem).CommShortName;
            TextBox txtcompp = (TextBox)e.Item.FindControl("TextBox3");
            txtcompp.Text = ((Commodity)e.Item.DataItem).CommProducePlace;
            TextBox txtUnit = (TextBox)e.Item.FindControl("TextBox4");
            txtUnit.Text = ((Commodity)e.Item.DataItem).Unit;
            TextBox txtsp = (TextBox)e.Item.FindControl("TextBox5");
            txtsp.Text = ((Commodity)e.Item.DataItem).Specs;
            TextBox txtpn = (TextBox)e.Item.FindControl("TextBox6");
            txtpn.Text = ((Commodity)e.Item.DataItem).PassNumber;
            TextBox txtpl = (TextBox)e.Item.FindControl("TextBox7");
            txtpl.Text = ((Commodity)e.Item.DataItem).PassList;
            DropDownList ddlcom = (DropDownList)e.Item.FindControl("DropDownList1");
            Companys coms = new Companys();
            ddlcom.DataSource = coms.SelectAll();
            ddlcom.DataTextField = "Cname";
            ddlcom.DataValueField = "Cid";
            ddlcom.DataBind();
            ListItem list = ddlcom.Items.FindByText(((Commodity)e.Item.DataItem).ComName);
            list.Selected = true;
            TextBox txtremark= (TextBox)e.Item.FindControl("TextBox8");
            txtremark.Text = ((Commodity)e.Item.DataItem).Remark;
            
        }

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            LinkButton lb = (LinkButton)e.Item.FindControl("lnkDelete");
            lb.Attributes.Add("onclick", "return confirm('确认删除？');");
        }
    }

    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        Guid cid = new Guid(Request["commid"].ToString());
        TextBox txtcomname = (TextBox)e.Item.FindControl("TextBox1");
        TextBox txtcsname = (TextBox)e.Item.FindControl("TextBox2");
        TextBox txtcompp = (TextBox)e.Item.FindControl("TextBox3");
        TextBox txtUnit = (TextBox)e.Item.FindControl("TextBox4");
        TextBox txtsp = (TextBox)e.Item.FindControl("TextBox5");
        TextBox txtpn = (TextBox)e.Item.FindControl("TextBox6");
        TextBox txtpl = (TextBox)e.Item.FindControl("TextBox7");
        DropDownList ddlcom = (DropDownList)e.Item.FindControl("DropDownList1");
        TextBox txtremark = (TextBox)e.Item.FindControl("TextBox8");


        string comname = txtcomname.Text;
        string csname = txtcsname.Text;
        string compp = txtcompp.Text;
        string comunit = txtUnit.Text;
        string comsp = txtsp.Text;
        string compn = txtpn.Text;
        string compl = txtpl.Text;
        Guid conameid = new Guid(ddlcom.SelectedValue.ToString());
        string remark = txtremark.Text;

        try
        {
            Commoditys comms = new Commoditys();
            if (comms.UpdateCommodity(cid,comname,csname,compp,comunit,comsp,compn,compl,conameid,remark) > 0)
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
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
