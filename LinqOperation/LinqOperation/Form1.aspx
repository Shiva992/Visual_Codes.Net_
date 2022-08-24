<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="LinqOperation.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
        <asp:ListItem Text="One" Value="One" />
        <asp:ListItem Text="Two" Value="Two" />
        <asp:ListItem Text="Three" Value="Three" />
        <asp:ListItem Text="Four" Value="Four" />
        <asp:ListItem Text="Five" Value="Five" />
        <asp:ListItem Text="Six" Value="Six" />
        <asp:ListItem Text="Seven" Value="Seven" />
    </asp:ListBox>

    <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple">
        <asp:ListItem Text="One" Value="One" />
        <asp:ListItem Text="Two" Value="Two" />
        <asp:ListItem Text="Three" Value="Three" />
        <asp:ListItem Text="Four" Value="Four" />
        <asp:ListItem Text="Five" Value="Five" />
        <asp:ListItem Text="Six" Value="Six" />
        <asp:ListItem Text="Seven" Value="Seven" />
    </asp:ListBox>

    <br />
    <asp:Button ID="Button2" runat="server" Text="Get Selected Items"
        onclick="Button1_Click" />
</div>
    </form>
</body>
</html>
