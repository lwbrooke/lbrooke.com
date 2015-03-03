using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Assign3Invoice
/// </summary>
public class Assign3Invoice
{
    public int InvoiceNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public string Status { get; set; }
    public int CustNumber { get; set; }
    public List<Assign3LineItem> LineItems { get; set; }

	public Assign3Invoice()
	{
        
	}
}