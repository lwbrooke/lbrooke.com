using System;

public partial class Assign1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.lblDate.InnerText = "Today's date is " + DateTime.Today.ToLongDateString();
        }
    }
    protected void btnCalcAge_Click(object sender, EventArgs e)
    {
        try
        {
            var BDay = Int32.Parse(this.txtBDay.Value);
            var BMonth = Int32.Parse(this.txtBMonth.Value);
            var BYear = Int32.Parse(this.txtBYear.Value);
            var GDay = Int32.Parse(this.txtGDay.Value);
            var GMonth = Int32.Parse(this.txtGMonth.Value);
            var GYear = Int32.Parse(this.txtGYear.Value);            

            if (BMonth > 12 || GMonth > 12 || BMonth < 1 || GMonth < 1 || BDay > 31 || GDay > 31 || GDay < 1 || BDay < 1 || BYear < 0 || GYear < 0)
            {
                this.lblCalcAge.InnerText = "All date boxes must have a valid date in them.";
            }
            else if (GYear >= BYear) 
            { 
                var age = GYear - BYear;
                if (GMonth < BMonth)
                {
                    age--;
                } else if (GMonth == BMonth && GDay < BDay)
                {
                    age--;
                }

                this.lblCalcAge.InnerText = "You will be " + age + " years old when you graduate. Congratulations!";
            }
            else
            {
                this.lblCalcAge.InnerText = "All date boxes must have a valid date in them.";
            }

        }
        catch (FormatException)
        {
            this.lblCalcAge.InnerText = "All date boxes must have a valid date in them.";
        }
        catch (ArgumentNullException)
        {
            this.lblCalcAge.InnerText = "All date boxes must be filled with a valid date";
        }
    }
}