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

public partial class Sysset_addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Powers powers = new Powers();
            DropDownList1.DataSource = powers.SelectAll();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = username.Text.Trim();
        string pwd = userpwd.Text.Trim();
        Guid qx = new Guid(DropDownList1.SelectedValue.ToString());

        UserInfos us = new UserInfos();
        if (us.InsertUser(name, pwd, qx) > 0)
        {
            Response.Write("<script language=javascript>alert('插入成功')</script>");
            username.Text = "";
            userpwd.Text = "";
        }
        else
        {
            Response.Write("<script language=javascript>alert('插入失败')</script>");
        }
    }
}
