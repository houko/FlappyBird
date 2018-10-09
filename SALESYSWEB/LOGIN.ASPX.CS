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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Master.FindControl("TreeView1").Visible = false;
        }
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        UserInfos user = new UserInfos();
        if (user.ckLogin(this.TextBox1.Text, this.TextBox2.Text))
        {
            this.Master.FindControl("TreeView1").Visible = true;
            Session["User"] = TextBox1.Text;
            Response.Redirect("Welcome.aspx");
        }
        else
        {
            Response.Redirect("login.aspx");

        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
    }
}
