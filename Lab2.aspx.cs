using System;
using System.Web.UI.WebControls;

public partial class Lab2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Currency.Items.Add(new ListItem("Euro", "0.85"));
            Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
            Currency.Items.Add(new ListItem("Canadian Dollar", "1.2"));

            Graph.Visible = false;
        }
    }

    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal USAmount;
        
        // Attempt the conversion.
        bool success = Decimal.TryParse(US.Value, out USAmount);
        Graph.Src = "_images/lab2/pic" + Currency.SelectedIndex.ToString() + ".png";

        // Check if it failed.
        if (!success || USAmount < 0)
        {
            // The conversion failed.
            Result.Style["color"] = "Red";
            Result.InnerText = "You typed in an invalid value. Use only positive numbers.";
        }
        else
        {
            // The conversion succeeded.
            Result.Style["color"] = "Black";
            ListItem item = Currency.Items[Currency.SelectedIndex];
            decimal newAmount = USAmount * Decimal.Parse(item.Value);
            Result.InnerText = USAmount.ToString() + " U.S. dollars = ";
            Result.InnerText += newAmount.ToString() + " " + item.Text;
        }
    }

    protected void ShowGraph_ServerClick(object sender, EventArgs e)
    {
        Graph.Src = "_images/lab2/pic" + Currency.SelectedIndex.ToString() + ".png";
        Graph.Visible = true;
    }

    protected void Redirect_ServerClick(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("http://forum.kerbalspaceprogram.com/forums/35-Add-on-Releases", true);
    }
}