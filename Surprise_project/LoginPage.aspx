<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TICKET_PROJECT.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 2px;
            width: 25px;
        }
        .auto-style2 {
            margin-left: 196px;
        }
        .auto-style3 {
            width: 210px;
        }
        .auto-style4 {
            width: 140px;
        }
        .auto-style5 {
            width: 101%;
            height: 156px;
        }
    </style>
</head>
<body  style="background-image:url('Flight2.jpg');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button7" runat="server" CssClass="auto-style2" Height="31px" Text="Home Page" Width="157px" OnClick="Button1_Click" />
        </div>
        <div class="auto-style1" style="background-color: #00FFFF">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <table class="auto-style5">
                <tr>
                    <td class="auto-style3">UserName               <td class="auto-style4">
                        <asp:TextBox ID="TextBox3" runat="server" Height="22px" Width="273px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Height="21px" Width="271px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button2_Click" Text="Submit" Height="41px" Width="169px" />
            <asp:Label ID="Label2" runat="server" Text="Not yet Registered?"></asp:Label>
            <asp:Button ID="Button5" runat="server" OnClick="Button3_Click" Text="Register" Height="41px" Width="168px" />
        </p>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [Login]"></asp:SqlDataSource>
    </form>
</body>
</html>
