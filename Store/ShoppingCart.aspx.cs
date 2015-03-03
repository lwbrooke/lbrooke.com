using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Store_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        List<ShoppingCartEntry> cart = (List<ShoppingCartEntry>)Session["ShoppingCart"];

        if (cart == null)
        {
            cart = new List<ShoppingCartEntry>();
            Session["ShoppingCart"] = cart;
        }

        if (cart.Count > 0)
        {
            Table table = new Table();

            TableHeaderRow hrow = new TableHeaderRow();
            hrow.Cells.Add(new TableHeaderCell() { Text = "Name" });
            hrow.Cells.Add(new TableHeaderCell() { Text = "Unit Price" });
            hrow.Cells.Add(new TableHeaderCell() { Text = "Quantity" });
            hrow.Cells.Add(new TableHeaderCell() { Text = "Total" });
            hrow.Cells.Add(new TableHeaderCell() { Text = "Weight" });
            hrow.Cells.Add(new TableHeaderCell());
            table.Rows.Add(hrow);

            decimal priceTotal = 0, weightTotal = 0;
            int rowCount = 0, itemCount = 0;

            foreach (ShoppingCartEntry entry in cart)
            {
                TableRow row = new TableRow();
                row.Cells.Add(new TableCell() { CssClass = "itemCell", Text = entry.item.pName });
                row.Cells.Add(new TableCell() { CssClass = "itemCell", Text = entry.item.pPrice.ToString("C0") });
                row.Cells.Add(new TableCell() { CssClass = "itemCell", Text = entry.quantity.ToString() });
                row.Cells.Add(new TableCell() { CssClass = "itemCell", Text = (entry.item.pPrice * entry.quantity).ToString("C0") });
                row.Cells.Add(new TableCell() { CssClass = "itemCell", Text = (entry.item.pWeight * entry.quantity).ToString() + " tons" });

                Button btnRemove = new Button() { Text = "Remove Item", ID = rowCount.ToString() };
                btnRemove.Click += btnRemove_Click;
                TableCell cell = new TableCell();
                cell.Controls.Add(btnRemove);
                row.Cells.Add(cell);

                table.Rows.Add(row);

                priceTotal += entry.item.pPrice * entry.quantity;
                weightTotal += entry.item.pWeight * entry.quantity;
                itemCount += entry.quantity;

                rowCount++;
            }

            TableRow frow = new TableRow();
            frow.Cells.Add(new TableCell() { CssClass = "finalCell" });
            frow.Cells.Add(new TableCell() { CssClass = "finalCell" });
            frow.Cells.Add(new TableCell() { CssClass = "finalCell", Text = "Count: " + itemCount });
            frow.Cells.Add(new TableCell() { CssClass = "finalCell", Text = priceTotal.ToString("C0") });
            frow.Cells.Add(new TableCell() { CssClass = "finalCell", Text = weightTotal.ToString() });
            frow.Cells.Add(new TableCell() { CssClass = "finalCell" });
            table.Rows.Add(frow);

            TablePlaceHolder.Controls.Add(table);
        }
        else
        {
            TablePlaceHolder.Controls.Add(new Label() { Text = "Your Shopping Cart is empty. Click the \'BattlemMech\' tab to browse available items.", CssClass = "errorMessage" });
            this.btnCheckout.Visible = false;
            this.btnShop.Visible = false;
        }
    }

    void btnRemove_Click(object sender, EventArgs e)
    {
        Button btnRemove = (Button)sender;
        int index = Int32.Parse(btnRemove.ID.Substring(btnRemove.ID.Length - 1));

        List<ShoppingCartEntry> cart = (List<ShoppingCartEntry>)Session["ShoppingCart"];

        cart.RemoveAt(index);

        Session["ShoppingCart"] = cart;
        this.Page.Response.Redirect("ShoppingCart.aspx");
    }
    protected void btnShop_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("~/Store/", true);
    }
    protected void btnCheckout_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("CheckOut.aspx", true);
    }
}