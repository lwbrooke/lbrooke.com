using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for BattleMechItem
/// </summary>
public class BattleMechItem
{
    [DisplayName("Item ID")]
    public int pID { get; set; }
    [DisplayName("Item Name")]
    public string pName { get; set; }
    [DisplayName("Item Description")]
    public string pDescription { get; set; }
    public string pImgURL { get; set; }
    public string pThumbURL { get; set; }
    [DisplayName("Item Price")]
    public decimal pPrice { get; set; }
    [DisplayName("Item Weight")]
    public int pWeight { get; set; }

	public BattleMechItem()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}