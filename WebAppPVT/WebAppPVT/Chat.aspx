<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="WebAppPVT.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chat</title>
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

    <h1>Chat</h1>
    <br />
    <asp:ListView ID="ListView1" runat="server"></asp:ListView>
    <p>     
    <asp:TextBox ID="ChatBox" runat="server"></asp:TextBox>
    <asp:Button ID="ChatSendbtn" runat="server" Text="Send" OnClick="ChatSendbtn_Click"  />
    </p>
    <br/>
    
        <span id="OutputText" runat="server"></span>
    <br/>
        <br/>
    <hr />
    <div id="footer"> Copyright Mad Max </div>
    </form>
</body>
</html>
