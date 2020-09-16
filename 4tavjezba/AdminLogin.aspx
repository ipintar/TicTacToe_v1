<%@ Page Title="" Language="C#" MasterPageFile="~/glavna.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="_4tavjezba.AdminLogin" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<asp:Login ID="loginuser" runat="server" CreateUserText="Registracija" CreateUserUrl="~/admin.aspx" DisplayRememberMe="False" DestinationPageUrl="~/Tictactoe.aspx" OnAuthenticate="loginuser_Authenticate">
</asp:Login>
</asp:Content>
