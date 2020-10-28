<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown.aspx.cs" Inherits="asp_dropdown_web_app.dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </br></br>
            <asp:DropDownList ID="DropDownList" runat="server" Height="37px" Width="134px" >

            <asp:ListItem value="">Please select</asp:ListItem>
            <asp:ListItem >Bangalore</asp:ListItem>
            <asp:ListItem >Davanagere</asp:ListItem>
            <asp:ListItem >Hubli</asp:ListItem>
            <asp:ListItem >Mysore</asp:ListItem>
                </asp:DropDownList></br>

            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
            
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" />
        </p>
        <asp:DropDownList ID="DropDown2" runat="server">
            <asp:ListItem>This is working</asp:ListItem>
            <asp:ListItem>Hey</asp:ListItem>
            <asp:ListItem>Super</asp:ListItem>
            <asp:ListItem>I Cant believe</asp:ListItem>
            <asp:ListItem>Amazing</asp:ListItem>
        </asp:DropDownList>

        </br></br>
        Email<asp:TextBox ID="Email" runat="server" Height="16px" Width="128px" BackColor="White" style="margin-top: 37px" >This is an Example</asp:TextBox>
    </form>
</body>
</html>
