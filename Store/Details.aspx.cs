using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Store_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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

            cmd = new OdbcCommand("SELECT * FROM products WHERE pID = " + Request.QueryString["pID"], cn);
            dr = cmd.ExecuteReader();

            dr.Read();
            BattleMechItem item = new BattleMechItem()
                {
                    pID = dr.GetInt32(0),
                    pName = dr.GetString(1),
                    pDescription = dr.GetString(2),
                    pImgURL = dr.GetString(3),
                    pThumbURL = dr.GetString(4),
                    pPrice = dr.GetDecimal(5),
                    pWeight = dr.GetInt32(6)
                };

            dr.Close();
            cn.Close();

            Session["CurrentSelection"] = item;

            DetailPanel.Controls.Add(new Image() { ImageUrl = item.pImgURL, CssClass = "largeImage", ID = item.pID.ToString()});

            Panel InfoPanel = new Panel();

            InfoPanel.Controls.Add(new HtmlGenericControl("h1") { InnerText = item.pName });
            InfoPanel.Controls.Add(new HtmlGenericControl("p") { InnerText = item.pDescription });
            InfoPanel.Controls.Add(new Label() { Text = "Price: " + item.pPrice.ToString("C0") });
            InfoPanel.Controls.Add(new Label() { Text = "Weight: " + item.pWeight.ToString() + " tons" });

            DropDownList list = new DropDownList();
            list.ID = "quantityList";
            for (int i = 1; i <= 100; i++)
            {
                list.Items.Add(new ListItem(i.ToString()));
            }
            InfoPanel.Controls.Add(list);

            Button b = new Button();
            b.Text = "Add to Cart";
            b.Click += AddToCart_Click;
            InfoPanel.Controls.Add(b);

            DetailPanel.Controls.Add(InfoPanel);
        }
        catch (Exception)
        {
            DetailPanel.Controls.Clear();
            DetailPanel.Controls.Add(new Label() { Text = "An error occurred processing your request", CssClass = "errorMessage" });
        }

    }

    void AddToCart_Click(object sender, EventArgs e)
    {
        BattleMechItem currentItem = (BattleMechItem)Session["CurrentSelection"];
        List<ShoppingCartEntry> cart = (List<ShoppingCartEntry>)Session["ShoppingCart"];
        DropDownList list = (DropDownList)DetailPanel.FindControl("quantityList");

        if (cart == null)
        {
            cart = new List<ShoppingCartEntry>();
        }

        foreach (ShoppingCartEntry entry in cart)
        {
            if (entry.item.pID == currentItem.pID)
            {
                entry.quantity += Int32.Parse(list.SelectedItem.Text);
                Session["ShoppingCart"] = cart;
                this.Page.Response.Redirect("ShoppingCart.aspx", true);
            }
        }

        cart.Add(new ShoppingCartEntry() { item = currentItem, quantity = Int32.Parse(list.SelectedItem.Text) });
        Session["ShoppingCart"] = cart;
        this.Page.Response.Redirect("ShoppingCart.aspx", true);
    }
}