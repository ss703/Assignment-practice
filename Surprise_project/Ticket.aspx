<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ticket.aspx.cs" Inherits="TICKET_PROJECT.Ticket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
        .auto-style2 {
            margin-left: 254px;
        }
        .auto-style3 {
            width: 84%;
            height: 361px;
        }
    </style>
</head>
<body  style="background-image:url('flight1.jpg');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" ForeColor="#990000" Text="Register Here"></asp:Label>
            <asp:Button ID="Button4" runat="server" CssClass="auto-style2" Text="HOME PAGE" Width="144px" />
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">ID</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please Enter ID" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter User Name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Confirm Password</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password didnot match" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Age</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Enter Your Age" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="Register" Width="203px" ForeColor="Black" BackColor="#0099FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [Flight1]"></asp:SqlDataSource>
    </form>
</body>
</html>
