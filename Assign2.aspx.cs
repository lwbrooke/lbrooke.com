using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Assign2 : System.Web.UI.Page
{
    private double shippingRate;
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn; 
        OleDbCommand cmd; 
        OleDbDataReader dr;

        shippingRate = 0.85;

        if (IsPostBack == false) { 
            try { 
                // Get database objects... 
                // Connect to database and open... 
                cn = new OleDbConnection();
                if (Request.UserHostAddress.ToString().Equals("::1")) { 
                    // Local server... 
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Logan\OneDrive\Documents\cscd379\App_Data\Assignment2DB.accdb;Persist Security Info=False;"; 
                } else { 
                    // Service provider server... 
                    cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\HostingSpaces\lwbrooke\lbrooke.com\wwwroot\App_Data\Assignment2DB.accdb;Persist Security Info=False;"; 
                }
                // Create the SQL command...
                cn.Open();
                lblStatus.Text = ""; 
                // Iterate over the dataset, create clients and add to collection... 
                cmd = new OleDbCommand("SELECT Count(*) from InvoiceLineItem", cn);
                InvoiceLineItem[] items = new InvoiceLineItem[Int32.Parse(cmd.ExecuteScalar().ToString())];

                cmd = new OleDbCommand("SELECT * FROM InvoiceLineItem", cn);
                dr = cmd.ExecuteReader(); 

                // populate invoiceLineItem array
                for(int i = 0; i < items.Length; i++) {
                    dr.Read();
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    items[i] = new InvoiceLineItem(Int32.Parse(values[0].ToString()), Int32.Parse(values[1].ToString()), 
                        Int32.Parse(values[2].ToString()), Int32.Parse(values[3].ToString()), values[4].ToString(), 
                        Int32.Parse(values[5].ToString()), Int32.Parse(values[6].ToString()), Double.Parse(values[7].ToString()));
                }
                
                // add array and shipping rate to the viewstate
                ViewState.Add("LineItems", items);
                ViewState.Add("ShippingRate", shippingRate);

                // create table
                Table invLineItemTable = new Table();
                // create headers
                TableHeaderRow hRow = new TableHeaderRow();
                string[] headings = new string[dr.FieldCount + 1];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    TableHeaderCell hCell = new TableHeaderCell();
                    hCell.Text = dr.GetName(i);
                    headings[i] = hCell.Text;
                    hRow.Cells.Add(hCell);
                }
                hRow.Cells.Add(new TableHeaderCell() { Text = "Shipping Cost" });
                headings[dr.FieldCount] = "Shipping Cost";
                ViewState.Add("Headings", headings);

                invLineItemTable.Rows.Add(hRow);
                // create rows
                foreach (InvoiceLineItem item in items)
                {
                    TableRow row = new TableRow();

                    row.Cells.Add(new TableCell { Text = item.OrderID.ToString() });
                    row.Cells.Add(new TableCell { Text = item.CustID.ToString() });
                    row.Cells.Add(new TableCell { Text = item.SequenceNumber.ToString() });
                    row.Cells.Add(new TableCell { Text = item.SKU.ToString() });
                    row.Cells.Add(new TableCell { Text = item.Description });
                    row.Cells.Add(new TableCell { Text = item.Quantity.ToString() });
                    row.Cells.Add(new TableCell { Text = item.UnitPrice.ToString() });
                    row.Cells.Add(new TableCell { Text = item.UnitWeight.ToString() });
                    row.Cells.Add(new TableCell { Text = item.calculateShipping(shippingRate).ToString() });

                    invLineItemTable.Rows.Add(row);
                }

                tablePlaceHolder.Controls.Add(invLineItemTable);


                dr.Close(); 
                cn.Close(); 
            } 
            catch (Exception err) { 
                lblStatus.Text = err.Message; 
            }
        } // End !IsPostBack
    }
    public InvoiceLineItem[] getArray()
    {
        return (InvoiceLineItem[]) ViewState["LineItems"];
    }
    public double getRate()
    {
        return (double) ViewState["ShippingRate"];
    }
    public string[] getHeadings()
    {
        return (string[]) ViewState["Headings"];
    }
}