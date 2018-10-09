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

public partial class addCompany : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Companys comps = new Companys();
        //CompanyType.DataSource = comps.SelectAll();
        //CompanyType.DataTextField = "ctname";
        //CompanyType.DataValueField = "ctid";
        //CompanyType.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Companys comps = new Companys();
        string cn = CompanyName.Text;
        string cs = CompanyShort.Text;
        Guid ct = new Guid(CompanyType.SelectedValue.ToString());
        string cad = CompanyAddress.Text;
        string cpc = Postalcode.Text;
        string ctel = Tel.Text;
        string cfax = Fax.Text;
        string cl1 = Linkman1.Text;
        string cl2 = Linkman2.Text;
        string email = Email.Text;
        string bank = Bank.Text;
        string bacc = BandAccounts.Text;
        if (comps.InsertCompany(cn,cs,ct,cad,cpc,ctel,cfax,cl1,cl2,email,bank,bacc) > 0)
        {
            Response.Write("<script language=javascript>alert('添加成功')</script>");
            CompanyName.Text = "";
            CompanyShort.Text = "";
            CompanyAddress.Text = "";
            Postalcode.Text = "";
            Tel.Text = "";
            Fax.Text = "";
            Linkman1.Text = "";
            Linkman2.Text = "";
            Email.Text = "";
            Bank.Text = "";
            BandAccounts.Text = "";
        }
        else
        {
            Response.Write("<script language=javascript>alert('添加失败')</script>");
        }
    }
}
