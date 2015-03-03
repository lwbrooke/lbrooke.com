using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Assign2CrossPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (PreviousPage != null && PreviousPage.Title.Equals("Assignment 2 - DB interface, cross-page, viewstate"))
        if (PreviousPage != null)
        {
            // get information out of previous pages viewstate
            InvoiceLineItem[] items = PreviousPage.getArray();
            double shippingRate = PreviousPage.getRate();
            string[] headings = PreviousPage.getHeadings();

            if (items != null && headings != null)
            {
                // create table
                Table invLineItemTable = new Table();
                // create headers

                TableHeaderRow hRow = new TableHeaderRow();
                for (int i = 0; i < headings.Length; i++)
                {
                    TableHeaderCell hCell = new TableHeaderCell();
                    hCell.Text = headings[i];
                    hRow.Cells.Add(hCell);
                }
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
            }
        }
    }
}