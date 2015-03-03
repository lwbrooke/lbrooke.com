using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCartEntry
/// </summary>
public class ShoppingCartEntry
{
    public BattleMechItem item { get; set; }
    public int quantity { get; set; }

	public ShoppingCartEntry()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}