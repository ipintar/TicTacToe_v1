﻿<%@ Page Title="" Language="C#" MasterPageFile="~/glavna.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="_4tavjezba.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
    

         <table style="width:100%;">
             <tr>
                 <td><p>
    <asp:SqlDataSource ID="SqlDataSourceStudenti" runat="server" ConnectionString="<%$ ConnectionStrings:KonekcijaNaBazu %>" OnSelecting="SqlDataSourceStudenti_Selecting" ProviderName="<%$ ConnectionStrings:KonekcijaNaBazu.ProviderName %>" SelectCommand="SELECT * FROM [users]" DeleteCommand="DELETE FROM [users] WHERE [username] = ?" InsertCommand="INSERT INTO [users] ([username], [password]) VALUES (?, ?)" UpdateCommand="UPDATE [users] SET [username] = ?, [password] = ? WHERE [username] = ?">
    </asp:SqlDataSource>
</p>
    <p style="color: #00FF00; font-weight: bolder; ">
        ADMIN LIST:</p>
<p>
    <asp:GridView ID="GridViewStudenti" runat="server" AllowCustomPaging="True" AllowSorting="True" BackColor="#9933FF" BorderColor="#CCCCCC" BorderStyle="Groove" BorderWidth="1px" CellPadding="4" DataKeyNames="username" DataSourceID="SqlDataSourceStudenti" ForeColor="Black" GridLines="Horizontal" OnRowDataBound="GridViewStudenti_RowDataBound" OnSelectedIndexChanged="GridViewStudenti_SelectedIndexChanged" Style="text-decoration: underline" AutoGenerateColumns="False" AutoGenerateDeleteButton="True">
        <Columns>
            <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" SortExpression="username" />
            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
&nbsp;</p>
    <p>

         <asp:FormView ID="FormView2" runat="server" DataKeyNames="username" DataSourceID="SqlDataSourceStudenti" DefaultMode="Insert" ForeColor="Lime" BorderStyle="None" Font-Bold="True" HeaderText="Add admin:">
            <EditItemTemplate>
                username:
                <asp:Label ID="usernameLabel1" runat="server" Text='<%# Eval("username") %>' />
                <br />
                password:
                <asp:TextBox ID="passwordTextBox" runat="server" Text='<%# Bind("password") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>

            <InsertItemTemplate>
                username:
                <asp:TextBox ID="usernameTextBox" runat="server" Text='<%# Bind("username") %>' />
                <br />
                password:
                <asp:TextBox ID="passwordTextBox0" runat="server" Text='<%# Bind("password") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                username:
                <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("username") %>' />
                <br />
                password:
                <asp:Label ID="passwordLabel" runat="server" Text='<%# Bind("password") %>' />
                <br />
            </ItemTemplate>
        </asp:FormView>
</p>
                 </td>
                 <td>
    <p style="color: #00FF00; font-weight: bold;">

         SCOREBOARD:</p>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KonekcijaNaBazu %>" ProviderName="<%$ ConnectionStrings:KonekcijaNaBazu.ProviderName %>" SelectCommand="SELECT [Name], [Score] FROM [studenti]"  InsertCommand="INSERT INTO [studenti] ([Name], [Score]) VALUES (?, ?)"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="Records deleted" DataSourceID="SqlDataSource1" AllowSorting="True" ForeColor="Lime" BackColor="Black">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="False" />
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
                        </Columns>
                    </asp:GridView>

                     <br />
                     <asp:Button ID="Button11" runat="server" OnClick="Delete" AutoPostBack="true" Text="RESET" />

                 </td>
             </tr>
         </table>

    <p>

         &nbsp;</p>
    
         </asp:Content>
