<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebAppPVT.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact</title>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="menu">
    <a href="WebForm1.aspx">Main</a>
    <a href="BIO.aspx">BIO</a>
    <a href="Contact.aspx">Contacts</a>
    <a href="Chat.aspx">Chat</a>
    </div>

    <h1>Contact</h1>
    <br />
    <h2>Information</h2>
    <ul type="square">
        <li>John Malkovich</li>
        <li>NY</li>
        <li>St. James Park Avenue</li>
        <li>+791ЗЗ9Зб878</li>
    </ul>
    
    <h2>Letter Sender</h2>
    <h3>Email</h3>
    <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
    <h3>Letter</h3>
    <p>
    <asp:TextBox ID="MessageBox" runat="server"></asp:TextBox>
    <asp:Button ID="Sendbtn" runat="server" OnClick="Sendbtn_Click" Text="Send"  />
    </p>
    <hr />
    <div id="footer"> Copyright Mad Max </div>
    </form>
</body>
</html>
