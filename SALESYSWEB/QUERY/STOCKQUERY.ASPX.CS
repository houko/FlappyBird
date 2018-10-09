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

public partial class Query_StockQuery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtbdate.Attributes.Add("onfocus", "calendar();");
            txtedate.Attributes.Add("onfocus", "calendar();");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Stocks stocks = new Stocks();
        string commodity = null;
        string man = null;
        string type = null;
        string settlment = null;
        string bdate = null;
        string edate = null;

        if (ckbcommodity.Checked)
            commodity = txtComName.Text.Trim();
        if (ckbman.Checked)
            man = txtMan.Text.Trim();
        if (ckbType.Checked)
            type = ddlType.SelectedValue.ToString();
        if (ckbpay.Checked)
            settlment = ddlpay.SelectedValue.ToString();
        if (ckbdate.Checked)
        {
            bdate = txtbdate.Text.Trim();
            edate = txtedate.Text.Trim();
        }
        GridView1.DataSource = stocks.Select(commodity, man, bdate, edate, type, settlment);
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
