<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Database_Connectivity.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="font-size:50px;text-align:center">Database connectivity in ASP using ado.net</h1>
            <table style="width:30%;height:200px;margin-top:100px;margin-left:400px;text-align:center;border:solid 1px blue;">
               
  <tr>
    <td>
        <b>Name: </b>
    </td>
      <td>

          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      </td>
      </tr>
     <tr>
    <td>
        <b>Email: </b>
    </td>
      <td>

          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      </td>
         </tr>
                    <tr>
                        <td colspan="2">

                            <asp:Button ID="Button1" runat="server" Text="Save into Database" OnClick="Button1_Click"/>
                        </td> 
  </tr>
</table>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [UserData]"></asp:SqlDataSource>

           
        </div>
    </form>
</body>
</html>
