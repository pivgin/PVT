using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
	protected void SubmitButton_Click(object sender, EventArgs e)
	{
		// Done:
		// The SubmitButton_Click event handler of the partial _Default class is modified
		//  so that if the page is valid, the message "Page is valid" is applied to the 
		//  ResultLabel control. 
		// If the page is not valid, the message "Page is not valid" is applied to the 
		//  control.

		if (Page.IsValid)
			ResultLabel.Text = "Page is valid";
		else
			ResultLabel.Text = "Page is not valid";
	}

	protected void UserIDTextValidator_ServerValidate(object source, ServerValidateEventArgs args)
	{
		// Do not modify this event handler.

		if (args.Value.Length > 8 && args.Value == args.Value.ToUpper())
			args.IsValid = true;
		else
			args.IsValid = false;
	}

	protected void LoginNameTextValidator_ServerValidate(object source, ServerValidateEventArgs args)
	{
		// Do not modify this event handler.

		if (string.IsNullOrEmpty(args.Value))
			args.IsValid = false;
		else
			args.IsValid = DataHelper.DoesLoginNameExist(args.Value);
	}
}