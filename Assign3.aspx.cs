using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class Assign3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            try
            {
                OleDbConnection cn;
                OleDbCommand cmd;
                OleDbDataReader dr;
                Dictionary<int, Assign3Inventory> inventories = new Dictionary<int, Assign3Inventory>();
                Dictionary<int, Assign3Customer> customers = new Dictionary<int, Assign3Customer>();
                Dictionary<int, Assign3Invoice> invoices = new Dictionary<int, Assign3Invoice>();
                List<Panel> openInvoices = new List<Panel>();
                double total = 0;

                // Get database objects... 
                // Connect to database and open... 
                cn = new OleDbConnection();
                if (Request.UserHostAddress.ToString().Equals("::1"))
                {
                    // Local server... 
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Logan\OneDrive\Documents\cscd379\App_Data\Assignment3DB.accdb;Persist Security Info=False;";
                }
                else
                {
                    // Service provider server... 
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\HostingSpaces\lwbrooke\lbrooke.com\wwwroot\App_Data\Assignment3DB.accdb;Persist Security Info=False;";
                }
                cn.Open();


                // get customers
                cmd = new OleDbCommand("SELECT * FROM Customer", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Assign3Customer toAdd = new Assign3Customer() { CustNumber = dr.GetInt32(0), Company = dr.GetString(1), Contact = dr.GetString(2), Phone = dr.GetString(3), AddressShipping = dr.GetString(4), AddressBilling = dr.GetString(5) };
                    customers.Add(toAdd.CustNumber, toAdd);
                }

                // get inventory
                cmd = new OleDbCommand("SELECT * FROM Inventory", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Assign3Inventory toAdd = new Assign3Inventory() { SKU = dr.GetInt32(0), Description = dr.GetString(1), QOH = dr.GetInt32(2), UnitWeight = dr.GetDouble(3), UnitPrice = dr.GetDouble(4) };
                    inventories.Add(toAdd.SKU, toAdd);
                }
                
                // get invoices
                cmd = new OleDbCommand("SELECT * FROM Invoice", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Assign3Invoice toAdd = new Assign3Invoice { InvoiceNumber = dr.GetInt32(0), CustNumber = dr.GetInt32(1), OrderDate = dr.GetDateTime(2), Status = dr.GetString(4), LineItems = new List<Assign3LineItem>() };
                    try
                    {
                        toAdd.ShippedDate = dr.GetDateTime(3);
                    }
                    catch(InvalidCastException)
                    {
                        toAdd.ShippedDate = null;
                    }
                    invoices.Add(toAdd.InvoiceNumber, toAdd);
                }

                // get line items
                cmd = new OleDbCommand("SELECT * FROM LineItem", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Assign3LineItem toAdd = new Assign3LineItem { InvoiceNumber = dr.GetInt32(0), LineNumber = dr.GetInt32(1), SKU = dr.GetInt32(2), QuantityOrdered = dr.GetInt32(3) };
                    invoices[toAdd.InvoiceNumber].LineItems.Add(toAdd);
                    total += (toAdd.QuantityOrdered * inventories[toAdd.SKU].UnitPrice);
                }
                // close db connections
                dr.Close();
                cn.Close();

                // summary information
                pnlContent.Controls.Add(new HtmlGenericControl("h1") { InnerText = "Summary" });
                pnlContent.Controls.Add(new HtmlGenericControl("p") { InnerText = "Order Count: " + invoices.Values.Count });
                pnlContent.Controls.Add(new HtmlGenericControl("p") { InnerText = "Average Order Amount: $" + Math.Round(total / invoices.Values.Count, 2) });
                pnlContent.Controls.Add(new HtmlGenericControl("p") { InnerText = "Total Sales: $" + Math.Round(total, 2) });

                // create orders
                pnlContent.Controls.Add(new HtmlGenericControl("h1") { InnerText = "Open Orders" });
                foreach (Assign3Invoice invoice in invoices.Values)
                {
                    if (invoice.Status.Equals("Open"))
                    {
                        // make panel of information
                        Assign3Customer cust = customers[invoice.CustNumber];
                        Panel toAdd = new Panel();
                        toAdd.CssClass = "invoice";

                        HtmlContainerControl elementToAdd = new HtmlGenericControl("p") { InnerHtml = "Customer Number: " + cust.CustNumber + " - " + cust.Company + "<br/>Contact: " + cust.Contact + "<br/>Phone:" + cust.Phone + "<br/>" + cust.AddressBilling };
                        elementToAdd.Attributes["class"] = "customer";
                        toAdd.Controls.Add(elementToAdd);
                        elementToAdd = new HtmlGenericControl("p") { InnerHtml = "Invoice Number: " + invoice.InvoiceNumber + "<br/>Order Date: " + invoice.OrderDate.ToShortDateString() + "<br/>Status: " + invoice.Status };
                        elementToAdd.Attributes["class"] = "details";                     
                        toAdd.Controls.Add(elementToAdd);
                        

                        // line items table
                        Table table = new Table();
                        table.CssClass = "lineItems";
                        TableHeaderRow hRow = new TableHeaderRow();
                        hRow.Cells.Add(new TableHeaderCell() { Text = "SKU" });
                        hRow.Cells.Add(new TableHeaderCell() { Text = "Description" });
                        hRow.Cells.Add(new TableHeaderCell() { Text = "Quantity" });
                        hRow.Cells.Add(new TableHeaderCell() { Text = "Unit Price" });
                        table.Rows.Add(hRow);

                        double invoiceTotal = 0;
                        foreach (Assign3LineItem item in invoice.LineItems)
                        {
                            TableRow row = new TableRow();
                            row.Cells.Add(new TableHeaderCell() { Text = item.SKU.ToString() });
                            row.Cells.Add(new TableHeaderCell() { Text = inventories[item.SKU].Description });
                            row.Cells.Add(new TableHeaderCell() { Text = item.QuantityOrdered.ToString() });
                            row.Cells.Add(new TableHeaderCell() { Text = inventories[item.SKU].UnitPrice.ToString() });
                            table.Rows.Add(row);
                            invoiceTotal += item.QuantityOrdered * inventories[item.SKU].UnitPrice;
                        }

                        TableRow finalRow = new TableRow() { CssClass = "finalRow" };
                        finalRow.Cells.Add(new TableHeaderCell() { Text = "", CssClass = "finalRow"});
                        finalRow.Cells.Add(new TableHeaderCell() { Text = "", CssClass = "finalRow" });
                        finalRow.Cells.Add(new TableHeaderCell() { Text = "Total:", CssClass = "finalRow" });
                        finalRow.Cells.Add(new TableHeaderCell() { Text = "$" + invoiceTotal, CssClass = "finalRow" });
                        table.Rows.Add(finalRow);

                        toAdd.Controls.Add(table);
                        pnlContent.Controls.Add(toAdd);
                    }
                }
            }
            catch (Exception err)
            {
                lblError.Text = err.Message;
            }
        } // End !IsPostBack
    }
}