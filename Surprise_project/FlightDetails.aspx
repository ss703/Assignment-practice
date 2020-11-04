<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightDetails.aspx.cs" Inherits="TICKET_PROJECT.FlightDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 103%;
            height: 265px;
        }
        .auto-style2 {
            width: 230px;
        }
        .auto-style3 {
            width: 224px;
        }
        .auto-style4 {
            width: 965px;
            height: 588px;
        }
    </style>
</head>
<body style="background-image:url('d1.jpeg');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server" class="auto-style4">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="204px" Width="328px" AutoGenerateColumns="False" DataKeyNames="FlightId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="FlightId" HeaderText="FlightId" ReadOnly="True" SortExpression="FlightId" />
                <asp:BoundField DataField="FlightNumber" HeaderText="FlightNumber" SortExpression="FlightNumber" />
                <asp:BoundField DataField="FlightName" HeaderText="FlightName" SortExpression="FlightName" />
                <asp:BoundField DataField="Source" HeaderText="Source" SortExpression="Source" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [FlightDe]"></asp:SqlDataSource>
        <p>
            <asp:Label ID="Label1" runat="server" ForeColor="#0066FF" Text="Create Flight"></asp:Label>
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">FligthID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="178px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">FlightNumber</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="178px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">FlightName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="184px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Source</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" Height="22px" Width="179px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Destination</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="173px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AddFlight" BackColor="#0066FF" Height="40px" Width="174px" ForeColor="#CC0000" />
    </form>
</body>
</html>
