<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>User Registration Page</title>
    <link href="Styles.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript">
  
     function CheckUserIDClientSide(source, arguments)
     {
        if (arguments.Value.length > 8)
           if (arguments.Value == arguments.Value.toUpperCase())
           {
			
              arguments.IsValid = true;
              return;
           }
        
        arguments.IsValid = false;
     }         
	</script>
</head>
<body>
    <form id="userRegistrationForm" runat="server">     
		<table>
		<!-- Hint:
			 The CustomValidator control has a property which tells the control whether
			  or not to validate an empty string value in the targeted control.
		-->
			<tr>
				<td><asp:label id="UserIDLabel" runat="server">User ID (All uppercase and greater than 8 characters):</asp:label></td>
				<td><asp:textbox id="UserIDText" runat="server"></asp:textbox></td>
				<td>
				<!-- Done:
					 A validation control called UserIDTextValidator on the Default.aspx 
					  page validates the UserIDText control using the supplied 
					  CheckUserIDClientSide JavaScript function to perform client-side 
					  validation, and uses the supplied UserIDTextValidator_ServerValidate 
					  method to perform server-side validation. 
					 If the user enters an invalid User ID or leaves the User ID field 
					  blank, the validator displays the exclamation.gif graphic and the 
					  error message "User ID is blank or invalid" appears in the validation 
					  summary control. The UserIDText control receives focus if it is the 
					  first control on the form to fail validation.
				-->
					<asp:CustomValidator ID="UserIDTextValidator" runat="server" 
						ControlToValidate="UserIDText" 
						ErrorMessage="User ID is blank or invalid"
						OnServerValidate="UserIDTextValidator_ServerValidate" 
						ClientValidationFunction="CheckUserIDClientSide"
						SetFocusOnError="True" ValidateEmptyText="True" ><img src="data/exclamation.gif" alt="!" /></asp:CustomValidator>	
				</td>
			</tr>
			<tr>
				<td><asp:label id="EmailLabel" runat="server">Email:</asp:label></td>
				<td><asp:textbox id="EmailText" runat="server"></asp:textbox></td>
				<td>
				<!-- Done:
					 A RegularExpressionValidator control called EmailTextValidator on the 
					  Default.aspx page validates the EmailText control. 
					 If a valid email address is not supplied (for example, one using a 
					  format such as name@domain.com or name.surname@domain.com), the 
					  validator displays the exclamation.gif graphic and the error message 
					  "Email address is invalid" appears in the validation summary control. 
					 The EmailText control receives focus if it is the first control on 
					  the form to fail validation.
				-->
					<asp:RegularExpressionValidator ID="EmailTextValidator" runat="server" 
						ControlToValidate="EmailText" 
						ErrorMessage="Email address is invalid"	SetFocusOnError="True" 
						ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
						<img src="data/exclamation.gif" alt="!" />
					</asp:RegularExpressionValidator>
				</td>
			</tr>
			<tr>
				<td><asp:label id="PhoneLabel" runat="server">Phone (US) (999-999-9999):</asp:label></td>
				<td><asp:textbox id="PhoneText" runat="server"></asp:textbox></td>
				<td>
				<!-- Done:
					 A RegularExpressionValidator control called PhoneTextValidator on the 
					  Default.aspx page validates the PhoneText control. 
					 A valid US phone number must be supplied, using one of the following 
					  formats: (999)999-9999, (999) 999-9999, 999-9999, or 999-999-9999. 
					 If a valid number is not supplied, the validator displays the 
					  exclamation.gif graphic and the error message "US phone number is 
					  invalid" appears in the validation summary control. 
					 The PhoneText control receives focus if it is the first control on 
					  the form to fail validation.
				-->
					<asp:RegularExpressionValidator ID="PhoneTextValidator" runat="server" 
						ControlToValidate="PhoneText" ErrorMessage="US phone number is invalid" 
						SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">
						<img src="data/exclamation.gif" alt="!" />
					</asp:RegularExpressionValidator>
				</td>
			</tr>
			<tr>
				<td><asp:label id="LoginLabel" runat="server">Login Name:</asp:label></td>
				<td><asp:textbox id="LoginNameText" runat="server"></asp:textbox></td>
				<td>
				<!-- Done:
					 A validation control called LoginNameTextValidator on the 
					  Default.aspx page validates the LoginNameText control using the 
					  supplied LoginNameTextValidator_ServerValidate server-side event 
					  handler to ensure that the login name doesn't already exist. 
					 If the user enters an existing login name or leaves the Login Name 
					  field blank, the validator displays the exclamation.gif graphic and 
					  displays the error message "Login name is blank or already exists" 
					  in the validation summary control. 
					 The LoginNameText control receives focus if it is the first control 
					  on the form to fail validation.
				-->
					<asp:CustomValidator ID="LoginNameTextValidator" runat="server" 
						ControlToValidate="LoginNameText" 
						ErrorMessage="Login name is blank or already exists" 
						OnServerValidate="LoginNameTextValidator_ServerValidate" SetFocusOnError="True" 
						ValidateEmptyText="True"  EnableClientScript="False">
						<img src="data/exclamation.gif" alt="!" />
					</asp:CustomValidator>
				</td>
			</tr>
			<tr>
				<td></td>
				<td><asp:button id="SubmitButton" runat="server" text="Submit" OnClick="SubmitButton_Click"></asp:button></td>
				<td></td>
			</tr>
		</table>
		<p><asp:label id="ResultLabel" runat="server"></asp:label></p>
		<!-- Done:
			 A ValidationSummary control called UserRegistrationValidationSummary on the 
			  Default.aspx page displays all validation error messages. 
			 The DisplayMode is set to List.
		-->
		<p><asp:ValidationSummary id="UserRegistrationValidationSummary" runat="server" DisplayMode="List"></asp:ValidationSummary></p>
    </form>
</body>
</html>