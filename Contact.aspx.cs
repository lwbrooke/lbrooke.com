using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            var message = new MailMessage("contact@lbrooke.com", "logan.w.brooke@gmail.com", txtSubject.Text, txtEmail.Text + "\n\n" + txtBody.Text);

            var client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("contact@lbrooke.com", "contactpassword");
            client.Port = 26;
            client.Host = "mail.lbrooke.com";

            try
            {
                client.Send(message);
                txtBody.Text = "";
                txtEmail.Text = "";
                txtSubject.Text = "";
                lblMessage.Text = "Your message has been sent";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            } 
        }
    }
    private bool isEmpty(ServerValidateEventArgs e)
    {
        return e.Value.Length == 0;
    }
    protected void validatorEmail_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorEmail.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorEmail.ErrorMessage = "Email is Required";
        }
        else
        {
            try
            {
                // email validator found at http://regexlib.com/REDetails.aspx?regexp_id=26
                Regex rgx = new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$"); // matches on emails
                e.IsValid = rgx.Match(e.Value).Success;
                if (!e.IsValid)
                {
                    validatorEmail.ErrorMessage = "Invalid Characters Present";
                }
            }
            catch
            {
                e.IsValid = false;
                validatorEmail.ErrorMessage = "Email Field Invalid";
            }
        }
    }
    protected void validatorSubject_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorSubject.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorSubject.ErrorMessage = "Subject is Required";
        }
    }
    protected void validatorBody_ServerValidate(object source, ServerValidateEventArgs e)
    {
        validatorBody.ErrorMessage = "";
        if (isEmpty(e))
        {
            e.IsValid = false;
            validatorBody.ErrorMessage = "Body is Required";
        }
    }
}