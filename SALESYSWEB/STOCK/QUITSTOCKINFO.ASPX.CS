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

public partial class stock_quitStockInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        addStockDate.Attributes.Add("onfocus", "calendar();");
        Commoditys coms = new Commoditys();
        CommodityId.DataSource = coms.SelectAll();
        CommodityId.DataTextField = "CommName";
        CommodityId.DataValueField = "CommId";
        CommodityId.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Stocks stock = new Stocks();
        Guid commid = new Guid(CommodityId.SelectedValue.ToString());
        string comnum = Number.Text;
        decimal comprice = decimal.Parse(Price.Text);
        string settType = SettlementType.Text;
        decimal payment = decimal.Parse(Payment.Text);
        decimal factpayment = decimal.Parse(FactPayment.Text);
        decimal notpayment = decimal.Parse(NotPayment.Text);
        string manageman = "admin";
        DateTime stockdate = DateTime.Parse(addStockDate.Text);

        if (stock.InsertStock(commid, comnum, comprice, settType, payment, factpayment, notpayment, manageman, stockdate, "退货") > 0)
        {
            Response.Write("<script language=javascript>alert('插入成功')</script>");
            Number.Text = "";
            Price.Text = "";
            SettlementType.Text = "";
            Payment.Text = "";
            FactPayment.Text = "";
            NotPayment.Text = "";
            addStockDate.Text = "";
        }
        else
        {
            Response.Write("<script language=javascript>alert('插入失败')</script>");
        }
    }
}
