<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="_4tavjezba.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Login ID="loginuser" runat="server"  DisplayRememberMe="False" DestinationPageUrl="~/admin.aspx" OnAuthenticate="loginuser_Authenticate">
        </asp:Login>
    </form>
</body>
</html>
