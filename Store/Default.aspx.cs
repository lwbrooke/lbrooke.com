using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

public partial class Store_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_Init(object sender, EventArgs e)
    {
        try
        {
            OdbcCommand cmd;
            OdbcConnection cn;
            OdbcDataReader dr;
            List<BattleMechItem> items = new List<BattleMechItem>();

            // when testing
            //cn = new OdbcConnection("DRIVER={MySQL ODBC 5.2 ANSI Driver}; SERVER=aster.arvixe.com; PORT=3306; DATABASE=Store_CSCD379; USER=lbrooke_CS379; PASSWORD=password; OPTION=3;");
            // when the server
            cn = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver}; SERVER=localhost; PORT=3306; DATABASE=Store_CSCD379; USER=lbrooke_CS379; PASSWORD=password; OPTION=3;");
            cn.Open();

            cmd = new OdbcCommand("SELECT * FROM products", cn);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                items.Add(new BattleMechItem()
                {
                    pID = dr.GetInt32(0),
                    pName = dr.GetString(1),
                    pDescription = dr.GetString(2),
                    pImgURL = dr.GetString(3),
                    pThumbURL = dr.GetString(4),
                    pPrice = dr.GetDecimal(5),
                    pWeight = dr.GetInt32(6)
                });
            }

            dr.Close();
            cn.Close();

            foreach (BattleMechItem item in items)
            {
                Panel p = new Panel();
                p.CssClass = "itemThumbNail";
                ImageButton img = new ImageButton() { ImageUrl = item.pThumbURL, ID = item.pID.ToString() };
                img.Click += new ImageClickEventHandler(this.SelectItem_Click);
                p.Controls.Add(img);
                p.Controls.Add(new Label() { Text = item.pName });
                p.Controls.Add(new Label() { Text = item.pPrice.ToString("C0") });

                itemsPlaceHolder.Controls.Add(p);
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected void SelectItem_Click(object sender, EventArgs e)
    {
        this.Page.Response.Redirect("Details.aspx?pID=" + ((ImageButton) sender).ID, true);
    }
}