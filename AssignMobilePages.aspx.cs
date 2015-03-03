using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AssignMobilePages : System.Web.UI.Page
{
    private static Random rand;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Browser.IsMobileDevice)
        {
            Page.Response.Redirect("~/Mobile/AssignMobilePages.aspx", true);
        }
        if (!IsPostBack)
        {
            rand = new Random();
        }
    }
    protected void btnRoll_Click(object sender, EventArgs e)
    {
        Button roller = (Button)sender;
        int sides = Int32.Parse(roller.ID.Substring(4));
        UpdatePanel currentUpdater = (UpdatePanel) DiceRollersPanel.FindControl("UpdatePanelD" + sides);

        int dieCount = 0;            
        bool success = Int32.TryParse(((TextBox) currentUpdater.ContentTemplateContainer.FindControl("txtD" + sides)).Text, out dieCount);

        Label resultLabel = (Label)currentUpdater.ContentTemplateContainer.FindControl("lblD" + sides);

        int dieResult = 0;

        string resultExpanded = "Roll(" + dieCount + "d" + sides + ")\n";

        if(dieCount > 0)
        {
            int curRoll = rand.Next(1, sides + 1);
            dieResult += curRoll;
            resultExpanded += curRoll.ToString(); 
        }

        for (int i = 1; i < dieCount; i++)
        {
            int curRoll = rand.Next(1, sides + 1);
            dieResult += curRoll;
            resultExpanded += ", " + curRoll.ToString();
        }

        resultExpanded += "\nTotal: " + dieResult + "\n\n";

        txtHistory.Text = resultExpanded + txtHistory.Text;
        resultLabel.Text = dieResult.ToString();
    }
}