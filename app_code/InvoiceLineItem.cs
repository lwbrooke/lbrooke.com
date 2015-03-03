using System;

/// <summary>
/// Represents a single line in an invoice, can calculate shipping cost based on a given rate.
/// </summary>

[Serializable]
public class InvoiceLineItem
{
    public int OrderID { get; set; }
    public int CustID { get; set; }
    public int SequenceNumber { get; set; }
    public int SKU { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
    public double UnitWeight { get; set; }

	public InvoiceLineItem(int OrderID, int CustID, int SequenceNumber, int SKU, string Description, int Quantity, int UnitPrice, double UnitWeight)
	{
        this.OrderID = OrderID;
        this.CustID = CustID;
        this.SequenceNumber = SequenceNumber;
        this.SKU = SKU;
        this.Description = Description;
        this.Quantity = Quantity;
        this.UnitPrice = UnitPrice;
        this.UnitWeight = UnitWeight;
	}

    public double calculateShipping(double shippingRate)
    {
        return Math.Round(this.UnitWeight * shippingRate * this.Quantity, 2);
    }
}