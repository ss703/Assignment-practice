<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainAdmin.aspx.cs" Inherits="TICKET_PROJECT.MainAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 247px;
        }
        .auto-style3 {
            margin-left: 60px;
        }
        .auto-style5 {
            margin-left: 159px;
        }
    </style>
</head>
<body  style="background-image:url('flight1.jpg');background-repeat:no-repeat;background-size:cover">
    <h2>ADMIN PAGE</h2>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        
        <p>
            <asp:Button ID="Button5" runat="server" CssClass="auto-style2" Height="33px" Text="Home" Width="565px" BackColor="#FFFF99" />
                </p>
        <p>
                <asp:Button ID="Button6" runat="server" Text="List of users" CssClass="auto-style3" OnClick="Button2_Click" Width="235px" BackColor="#CCFFCC" Height="64px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button9" runat="server" BackColor="#FFFFCC" Height="67px" OnClick="Button9_Click" Text="Add Flight" Width="223px" />
&nbsp;<asp:Button ID="Button8" runat="server" Text="Queries from users" CssClass="auto-style5" Height="58px" OnClick="Button2_Click" Width="199px" BackColor="#FFFFCC" />
            &nbsp;
        </p>
    </form>
</body>
</html>
