using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mobile_Mobile : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbtnHome_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Default.aspx", true);
    }
    protected void lbtnAssign1_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Assign1.aspx", true);
    }
    protected void lbtnLab1_Click1(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Lab1.aspx", true);
    }
    protected void lbtnLab2_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Lab2.aspx", true);
    }
    protected void lbtnFallout_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("FalloutTheme.aspx", true);
    }
    protected void lbtnLab3_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Lab3.html", true);
    }
    protected void lbtnAssign2_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Assign2.aspx", true);
    }
    protected void lbtnAssign3_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Assign3.aspx", true);
    }
    protected void lbtnLab4_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Lab4.aspx", true);
    }
    protected void lbtnStore_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Store/", true);
    }
    protected void lbtnAssignMobile_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("AssignMobilePages.aspx");
    }
}
