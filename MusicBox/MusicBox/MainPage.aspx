<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MusicBox.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Main</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="menu" style="align-items:center">
        <asp:TextBox ID="SearchBox" runat="server" ToolTip="Enter text here"></asp:TextBox>
        <asp:Button ID="Searchbtn" runat="server" Text="Search" OnClick="Searchbtn_Click" />
        <asp:ImageButton ID="RussLangbtn" runat="server" OnClick="ImageButton1_Click" Width="28px" ImageUrl="~/Data/ru.gif" />
        <asp:ImageButton ID="EngLangbtn" runat="server" Width="28px" ImageUrl="~/Data/uk.jpg" />
        <asp:ImageButton ID="BelLangbtn" runat="server" Width="28px" ImageUrl="~/Data/by.jpg" />
        <asp:RegularExpressionValidator ControlToValidate="SearchBox" ID="RegularExpressionValidator" 
            runat="server" ValidationExpression="^\w{3}" 
            ErrorMessage="Data invalid"
            ForeColor="Red"></asp:RegularExpressionValidator>
    </div>
        <p>
        <asp:Label ID="Validationlbl" runat="server" ></asp:Label>
        </p>
    </form>
</body>
</html>


