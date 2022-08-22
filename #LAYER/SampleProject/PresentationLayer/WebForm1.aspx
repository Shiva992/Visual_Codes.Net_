<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PresentationLayer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 264px;
        }
        .auto-style2 {
            width: 264px;
            height: 31px;
        }
        .auto-style3 {
            height: 31px;
        }
        .auto-style4 {
            width: 264px;
            height: 78px;
        }
        .auto-style5 {
            height: 78px;
        }
        .auto-style6 {
            width: 100%;
            height: 683px;
        }
        .auto-style7 {
            width: 264px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 264px;
            height: 34px;
        }
        .auto-style10 {
            height: 34px;
        }
        .auto-style11 {
            width: 264px;
            height: 33px;
        }
        .auto-style12 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style6">
  <tr>
    <td class="auto-style2">Enter Eno</td>
    <td class="auto-style3">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
   
  </tr>
  <tr>
    <td class="auto-style11"></td>
    <td class="auto-style12">
        </td>
    
  </tr>
                  <tr>
    <td class="auto-style1">Enter Ename</td>
    <td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    
  </tr>
  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td>&nbsp;</td>
    
  </tr>
                  <tr>
    <td class="auto-style1">Enter salary</td>
    <td>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                      </td>
    
  </tr>
                  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td>&nbsp;</td>
    
  </tr>
                  <tr>
    <td class="auto-style7">Select Dept</td>
    <td class="auto-style8">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Marketing</asp:ListItem>
            <asp:ListItem>Technical</asp:ListItem>
            <asp:ListItem>Hr department</asp:ListItem>
        </asp:DropDownList></td>
    
  </tr>
                  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td>&nbsp;</td>
    
  </tr>
                  <tr>
    <td class="auto-style1">Select Gender</td>
    <td>
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="r1" Text="Male" />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="r2" Text="Female" />
&nbsp;</td>
    
  </tr>
                  <tr>
    <td class="auto-style1">&nbsp;</td>
    <td>&nbsp;</td>
    
  </tr>
                  <tr>
    <td class="auto-style1">Prefered Location</td>
    <td>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Hyderabad" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Bangalore" />
        <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" />
                      </td>
    
  </tr>
                  <tr>
    <td class="auto-style9"></td>
    <td class="auto-style10"></td>
    
  </tr>
                  <tr>
    <td class="auto-style4"></td>
    <td class="auto-style5">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
                      </td>
    
  </tr>
                  <tr>
    <td class="auto-style1">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

                      </td>
    <td>&nbsp;</td>
    
  </tr>
</table>
        </div>



    </form>
</body>
</html>
