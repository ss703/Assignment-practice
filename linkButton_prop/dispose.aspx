﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dispose.aspx.cs" Inherits="asp_Linkbutton_web_app_assignment2.dispose" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:LinkButton ID="link1" runat="server" OnDisposed="link1_Disposed" OnClick="link1_Click">Click here</asp:LinkButton><br />
            <asp:Label ID="label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
