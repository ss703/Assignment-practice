<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfUsers.aspx.cs" Inherits="TICKET_PROJECT.ListOfUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 87px;
        }
    </style>
</head>
<body  style="background-image:url('flight1.jpg');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server">
        <div>
            <div class="auto-style1">
                All The Users</div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="156px" Width="279px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT * FROM [Flight1]"></asp:SqlDataSource>
    </form>
</body>
</html>
