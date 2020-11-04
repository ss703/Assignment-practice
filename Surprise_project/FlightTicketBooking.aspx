<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightTicketBooking.aspx.cs" Inherits="TICKET_PROJECT.FlightTicketBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 200px;
        }
    </style>
    </head>
<body style="background-image:url('flight.jpg');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
        <h1>&nbsp;</h1>
        <h1>&nbsp;</h1>
        <h1 class="auto-style1">&nbsp;</h1>
        <h1 class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp; Welcome to Flight Ticket Booking!!!!</h1>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        
        <p>
            <asp:Button ID="Button8" runat="server" OnClick="Button3_Click" Text="Register" Height="48px" Width="162px" BackColor="#3366FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="Black" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" OnClick="Button4_Click" Text="Login" Width="169px" Height="52px" BackColor="#0066FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server" OnClick="Button5_Click" Text="Admin" Height="50px" Width="144px" BackColor="#0066FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button11" runat="server" OnClick="Button6_Click" Text="Contact Us" Height="51px" Width="147px" BackColor="#0066FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button12" runat="server" Text="Ticket Ready" Height="51px" Width="130px" BackColor="#0066FF" Font-Bold="True" Font-Italic="True" Font-Size="Large" OnClick="Button12_Click" />
        </p>
       
           
         
        
    </form>
</body>
</html>
