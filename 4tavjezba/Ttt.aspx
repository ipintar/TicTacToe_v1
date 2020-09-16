<%@ Page Title="" Language="C#" MasterPageFile="~/glavna.Master" AutoEventWireup="true" CodeBehind="Ttt.aspx.cs" Inherits="_4tavjezba.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 268px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
        
      

    <div id="container" runat="server" aria-disabled="False">

        <div class="top right">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style1" style="color: #00FF00; font-weight: bold">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KonekcijaNaBazu %>" ProviderName="<%$ ConnectionStrings:KonekcijaNaBazu.ProviderName %>" SelectCommand="SELECT top 10 [Name], [Score] FROM [studenti] ORDER BY [Score] DESC" InsertCommand="INSERT INTO [studenti] ([Name], [Score]) VALUES (?, ?)"></asp:SqlDataSource>
                                <br />
                    SCOREBOARD:&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowCustomPaging="True" EmptyDataText="No records." BackColor="Black" BorderColor="Lime">
                        <Columns>
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
                        </Columns>
                    </asp:GridView>

         &nbsp;&nbsp;

                                <br />
                                Player X :<asp:TextBox ID="TextBoxPlayerX" runat="server">Player X</asp:TextBox>
                                <br />
                                Player Y:<asp:TextBox ID="TextBoxPlayerY" runat="server">Player Y</asp:TextBox>
                                <br />
                            </td>
                            <td>
                    <asp:Label ID="textBox1" runat="server" Font-Size="XX-Large" ForeColor="#33CC33"></asp:Label>
                    &nbsp;&nbsp;
                                <asp:Button ID="Button11" runat="server" OnClick="Button11_Click1" Text="Add me" />
                    <br />
                    <br />
                    <table style="width: 22%; height: 177px;">
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                            <td>
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                            <td>
                                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                            <td>
                                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                            <td>
                                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                            <td>
                                <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Height="100px" Width="100px" Font-Size="40pt" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="Button10" runat="server" Text="Reset" OnClick="Button10_Click" Width="310px" Font-Size="15pt" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </div>
       
    </div>

    </asp:Content>



