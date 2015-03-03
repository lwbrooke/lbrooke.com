using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.Odbc;

public partial class Store_CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<ShoppingCartEntry> cart = (List<ShoppingCartEntry>)Session["ShoppingCart"];

        if (cart == null)
        {
            cart = new List<ShoppingCartEntry>();
            Session["ShoppingCart"] = cart;
        }

        if (cart.Count > 0)
        {
            decimal priceTotal = 0, shipping; 
            double weightTotal = 0;
            int quantityCount = 0;

            foreach (ShoppingCartEntry entry in cart)
            {
                priceTotal += entry.item.pPrice * entry.quantity;
                weightTotal += entry.item.pWeight * entry.quantity;
                quantityCount += entry.quantity;
            }

            shipping = Convert.ToDecimal(weightTotal * .46);

            Panel orderSummaryPanelLeft = new Panel();
            orderSummaryPanelLeft.Controls.Add(new Label() { Text = "Items: " + cart.Count });
            orderSummaryPanelLeft.Controls.Add(new Label() { Text = "Quantity: " + quantityCount });
            orderSummaryPanelLeft.Controls.Add(new Label() { Text = "Weight: " + weightTotal });

            Panel orderSummaryPanelRight = new Panel();
            orderSummaryPanelRight.Controls.Add(new Label() { Text = "Item Total: " + priceTotal.ToString("C0") });
            orderSummaryPanelRight.Controls.Add(new Label() { Text = "Shipping: " + shipping.ToString("C0") });
            orderSummaryPanelRight.Controls.Add(new Label() { Text = "Total: " + (shipping + priceTotal).ToString("C0") });

            orderSummaryPanel.Controls.Add(orderSummaryPanelLeft);
            orderSummaryPanel.Controls.Add(orderSummaryPanelRight);
        }
        else
        {
            this.btnShop.Visible = false;
            this.btnSubmitOrder.Visible = false;
            this.btnCart.Visible = false;
            this.shippingInfoPanel.Visible = false;
            this.orderSummaryPanel.Controls.Clear();
            this.orderSummaryPanel.Controls.Add(new Label() { Text = "You cannot place an order with an empty cart.", CssClass = "errorMessage" });
        }
    }
    protected void btnShop_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("~/Store/", true);
    }
    protected void btnSubmitOrder_Click(object sender, EventArgs e)
    {
        if (this.Page.IsValid)
        {
            List<ShoppingCartEntry> cart = (List<ShoppingCartEntry>)Session["ShoppingCart"];

            string sWork = "";

            decimal priceTotal = 0, shipping;
            double weightTotal = 0;
            int quantityCount = 0;

            foreach (ShoppingCartEntry entry in cart)
            {
                sWork += entry.item.pName;
                sWork += "\t\t\t" + entry.quantity + "\t" + entry.item.pPrice.ToString("C0") + "\t" + (entry.item.pPrice * entry.quantity).ToString("C0") + "\n";

                priceTotal += entry.item.pPrice * entry.quantity;
                weightTotal += entry.item.pWeight * entry.quantity;
                quantityCount += entry.quantity;
            }

            shipping = Convert.ToDecimal(weightTotal * .46);

            sWork += "\n\nTotal quantity: " + quantityCount;
            sWork += "\nShipping cost: " + shipping.ToString("C0");
            sWork += "\nTotal order cost: " + priceTotal.ToString("C0");

            sWork += "\n\n" + this.txtName.Text;
            sWork += "\n" + this.txtStreet.Text;
            sWork += "\n" + this.txtCity.Text;
            sWork += " " + this.txtState.Text;
            sWork += ", " + this.txtZip.Text;

            sWork += "\n\nIf you did not place an order with the lbrooke.com/Store, please contact mailto:support@lbrooke.com";

            MailMessage message = new MailMessage("store@lbrooke.com", txtEmail.Text);

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("store@lbrooke.com", "password");
            client.Port = 26;
            client.Host = "mail.lbrooke.com";

            int orderNum = 0;

            try
            {
                OdbcCommand cmd;
                OdbcConnection cn;
                OdbcDataReader dr;

                // when testing
                //cn = new OdbcConnection("DRIVER={MySQL ODBC 5.2 ANSI Driver}; SERVER=aster.arvixe.com; PORT=3306; DATABASE=Store_CSCD379; USER=lbrooke_CS379; PASSWORD=password; OPTION=3;");
                // when the server
                cn = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver}; SERVER=localhost; PORT=3306; DATABASE=Store_CSCD379; USER=lbrooke_CS379; PASSWORD=password; OPTION=3;");

                cn.Open();

                cmd = new OdbcCommand("SELECT `NextOrder` FROM `store_cscd379`.`NextOrderNumber` WHERE  `nextordernumber`.`id` =0;", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                orderNum = dr.GetInt32(0);
                dr.Close();

                cmd.CommandText = "UPDATE  `store_cscd379`.`NextOrderNumber` SET  `NextOrder` =  '" + (orderNum + 1)+ "' WHERE  `nextordernumber`.`id` =0;";
                cmd.ExecuteNonQuery();
                cn.Close();

                message.Subject = "Order Number " + orderNum + " has been processed";
                string bodyBeginning = "The lbrooke.com Store\n\n";
                bodyBeginning += "Your order has been processed.\n\n";
                bodyBeginning += "Order number: " + orderNum + "\n";
                sWork = bodyBeginning + sWork;
                message.Body = sWork;

                client.Send(message);
            }
            catch (Exception ex)
            {
                checkOutBase.Controls.AddAt(0, new Label() { Text = ex.Message, CssClass = "errorMessage" });
                return;
            }

            client = null;
            Session.Clear();
            this.Page.Response.Redirect("OrderConfirm.aspx?orderNum=" + orderNum, true);
        }
    }
    protected void btnCart_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("ShoppingCart.aspx", true);
    }

    private bool isEmpty(ServerValidateEventArgs e)
    {
        return e.Value.Length == 0;
    }
    protected void validatorName_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorName.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorName.ErrorMessage = "Name is Required";
        }
        else
        {
            try
            {
                Regex rgx = new Regex("[^a-zA-Z\\s]"); // matches on anything that isn't whitespace or a letter
                e.IsValid = !rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorName.ErrorMessage = "Invalid Characters Present";
                }
            }
            catch
            {
                e.IsValid = false;
                validatorName.ErrorMessage = "Name Field Invalid";
            } 
        }
    }
    protected void validatorStreet_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorStreet.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorStreet.ErrorMessage = "Street is Required";
        }
        else
        {
            try
            {
                Regex rgx = new Regex("[^a-zA-Z\\d\\.\\s-]"); // matches on anything that isn't whitespace, letter, number, hypen, period
                e.IsValid = !rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorStreet.ErrorMessage = "Invalid Characters Present";
                }
            }
            catch
            {
                e.IsValid = false;
                validatorStreet.ErrorMessage = "Street Field Invalid";
            }
        }
    }
    protected void validatorCity_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorCity.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorCity.ErrorMessage = "City is Required";
        }
        else
        {
            try
            {
                Regex rgx = new Regex("[^a-zA-Z\\.\\s-]"); // matches on anything that isn't whitespace, letter, period, hyphen
                e.IsValid = !rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorCity.ErrorMessage = "Invalid Characters Present";
                }
            }
            catch
            {
                e.IsValid = false;
                validatorCity.ErrorMessage = "City Field Invalid";
            }
        }
    }
    protected void validatorState_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorState.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorState.ErrorMessage = "State is Required";
        }
        else
        {
            try
            {
                Regex rgx = new Regex("[^a-zA-Z]"); // matches on anything that isn't a letter
                e.IsValid = !rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorState.ErrorMessage = "Invalid Characters Present";
                    return;
                }

                e.IsValid = (e.Value.Length == 2);
                if (!e.IsValid)
                {
                    validatorState.ErrorMessage = "State must be 2 characters";
                    return;
                }
            }
            catch
            {
                e.IsValid = false;
                validatorState.ErrorMessage = "State Field Invalid";
            }
        }
    }
    protected void validatorZip_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorZip.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorZip.ErrorMessage = "Zipcode is Required";
        }
        else
        {
            try
            {
                Regex rgx = new Regex("[^0-9]"); // matches on anything that isn't a number
                e.IsValid = !rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorZip.ErrorMessage = "Invalid Characters Present";
                    return;
                }

                e.IsValid = (e.Value.Length == 5);
                if (!e.IsValid)
                {
                    validatorState.ErrorMessage = "Zipcode must be 5 numbers";
                    return;
                }
            }
            catch
            {
                e.IsValid = false;
                validatorZip.ErrorMessage = "Zipcode Field Invalid";
            }
        }
    }
    protected void validatorEmail_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorEmail.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorEmail.ErrorMessage = "Email is Required";
        }
        else
        {
            try
            {
                // email validator found at http://regexlib.com/REDetails.aspx?regexp_id=26
                Regex rgx = new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$"); // matches on emails
                e.IsValid = rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorEmail.ErrorMessage = "Invalid Characters Present";
                }
            }
            catch
            {
                e.IsValid = false;
                validatorEmail.ErrorMessage = "Email Field Invalid";
            }
        }
    }
}