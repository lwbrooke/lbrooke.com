using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lab4Part2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void UpdateButton_Click(object sender, EventArgs e)
    {
        DateTimeLabel1.Text = DateTime.Now.ToString();
        DateTimeLabel2.Text = DateTime.Now.ToString();
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
    protected void lbtnLab4_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Lab4.aspx", true);
    }
}