﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="oncommand.aspx.cs" Inherits="asp_Linkbutton_web_app_assignment2.Linkbutton2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="link1" runat="server" OnCommand="link1_Command" Text="Select 1st" CommandName="Selection" CommandArgument="1" OnClick="link1_Click"></asp:LinkButton>
            <asp:LinkButton ID="Link2" runat="server" OnCommand="link2_Command" Text="Select 2nd" CommandName="Selection" CommandArgument="2"></asp:LinkButton>
       </div>
        <asp:Label ID="label1" runat="server"></asp:Label>
       
    </form>
</body>
</html>
