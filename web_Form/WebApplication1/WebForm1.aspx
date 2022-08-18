<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
   
            <table>
  <tr>
    <td> <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label></td>
    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
   
  </tr>
  <tr>
    <td> <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label></td>
    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
  
  </tr>
  <tr>
    <td><asp:Button ID="Button2" runat="server" Text="Button" /></td>
    
  </tr>
  </table>
        </div>
    </form>
    </body>
    </html>
