using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lab4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRefreshTime_Click(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToLongTimeString();
    }
    protected void btnPart2_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("/Lab4Part2.aspx");
    }
}