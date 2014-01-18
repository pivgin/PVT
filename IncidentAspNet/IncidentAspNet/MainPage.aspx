<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="IncidentAspNet.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="IncedentName" runat="server"></asp:TextBox>
        <asp:Label ID="Namelbl" runat="server" Text="Name"></asp:Label>
    
    </div>
        <asp:TextBox ID="IncedentDescription" runat="server"></asp:TextBox>
        <asp:Label ID="Descriptionlbl" runat="server" Text="Description"></asp:Label>
        <p>
            <asp:Button ID="Addbtn" runat="server" Text="Add" OnClick="Addbtn_Click" />
        </p>
        <asp:Button ID="Viewbtn" runat="server" Text="View" />
    </form>
</body>
</html>
