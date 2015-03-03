using System;
using System.Web.UI.WebControls;

public partial class Lab1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Currency.Items.Add(new ListItem("Euro", "0.85"));
            Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
            Currency.Items.Add(new ListItem("Canadian Dollar", "1.2"));
        }
    }

    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal USAmount;
        // Attempt the conversion.
        bool success = Decimal.TryParse(US.Value, out USAmount);

        // Check if it succeeded.
        if (success)
        {
            ListItem item = Currency.Items[Currency.SelectedIndex];
            // The conversion succeeded.
            decimal newAmount = USAmount * Decimal.Parse(item.Value);
            Result.InnerText = USAmount.ToString() + " U.S. dollars = ";
            Result.InnerText += newAmount.ToString() + " " + item.Text;
        }
        else
        {
            // The conversion failed.
            Result.InnerText = "The number you typed in was not in the " +
            "correct format. Use only numbers.";
        }
    }
}