using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Store_OrderConfirm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var orderNum = this.Page.Request.QueryString["orderNum"];
        if (orderNum != null)
        {
            confirmationPlaceHolder.Controls.Add(new HtmlGenericControl("h1") { InnerText = "Order number " + orderNum + " has been placed" });
            confirmationPlaceHolder.Controls.Add(new HtmlGenericControl("h2") { InnerText = "An email has been sent to confirm your order" });
        }
        else
        {
            confirmationPlaceHolder.Controls.Add(new Label() { Text = "An error occurred processing your request", CssClass = "errorMessage" });
        }
    }
}