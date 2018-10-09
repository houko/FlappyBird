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

public partial class addCommoditys : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Companys coms = new Companys();
            CompanyId.DataSource = coms.SelectAll();
            CompanyId.DataTextField = "Cname";
            CompanyId.DataValueField = "Cid";
            CompanyId.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cname = CommodityName.Text;
        string sname = ShortName.Text;
        string cprop = ProducePlace.Text;
        string cunit = Unit.Text;
        string cspecs = Specs.Text;
        string cpassn = PassNumber.Text;
        string cpassl = PassList.Text;
        string comid = CompanyId.Text;
        string crem = Remark.Text;

        Commoditys comms = new Commoditys();
        if (comms.InsertCommodity(cname, sname, cprop, cunit, cspecs, cpassn, cpassl, comid, crem) > 0)
        {
            Response.Write("<script language=javascript>alert('插入成功')</script>");
            CommodityName.Text ="";
            ShortName.Text ="";
            ProducePlace.Text = "";
            Unit.Text ="";
            Specs.Text = "";
            PassNumber.Text = "";
            PassList.Text = "";
            CompanyId.Text = "";
            Remark.Text = "";
        }
        else
        {
            Response.Write("<script language=javascript>alert('插入失败')</script>");
        }
    }
}
