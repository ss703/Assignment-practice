<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUERYSTRInG_aSSiGnmeNT.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 174px;
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style3 {
            width: 38%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="151px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">LastName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="152px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Height="31px" OnClick="Button1_Click" Text="submit" Width="77px" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
