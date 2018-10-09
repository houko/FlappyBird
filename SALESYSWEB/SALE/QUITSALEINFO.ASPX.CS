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

public partial class Sale_quitSaleInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            addSaleDate.Attributes.Add("onfocus", "calendar();");
            Commoditys comms = new Commoditys();
            Companys comps = new Companys();
            DropDownList1.DataSource = comps.SelectAll();
            DropDownList1.DataTextField = "Cname";
            DropDownList1.DataValueField = "Cid";
            DropDownList1.DataBind();
            CommodityId.DataSource = comms.SelectAll();
            CommodityId.DataTextField = "CommName";
            CommodityId.DataValueField = "CommId";
            CommodityId.DataBind();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Guid companyId = new Guid(DropDownList1.SelectedValue.ToString());
        Guid commodityId = new Guid(CommodityId.SelectedValue.ToString());
        decimal price = decimal.Parse(Price.Text);
        int number = int.Parse(Number.Text);
        string settlementType = SettlementType.SelectedValue.ToString();
        decimal pay = decimal.Parse(Payment.Text);
        decimal factpay = decimal.Parse(FactPayment.Text);
        decimal notpay = decimal.Parse(NotPayment.Text);
        string manageman = ManageMan.Text;
        DateTime addsaleDate = DateTime.Parse(addSaleDate.Text.ToString());

        Sales addsale = new Sales();
        if (addsale.InsertSale(companyId, commodityId, number, price, settlementType, pay, factpay, notpay, manageman, addsaleDate, "销售退货") > 0)
        {
            Response.Write("<script language=javascript>alert('插入成功')</script>");
            Number.Text = "";
            Price.Text = "";
            Payment.Text = "";
            FactPayment.Text = "";
            NotPayment.Text = "";
            ManageMan.Text = "";
            addSaleDate.Text = "";
        }
        else
        {
            Response.Write("<script language=javascript>alert('插入失败')</script>");
        }
    }
}
