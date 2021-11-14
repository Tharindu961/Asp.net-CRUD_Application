<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style="font-size:x-large" align="center">
             Student Info Manage Form</div>
            <table class="nav-justified">
                <tr>
                    <td class="modal-sm" style="width: 291px; height: 34px"></td>
                    <td style="height: 34px; width: 168px">Student ID</td>
                    <td style="height: 34px">
                        <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" style="margin-left: 0" Width="183px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 291px">&nbsp;</td>
                    <td style="width: 168px">Student name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" style="margin-left: 0" Width="183px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 291px">&nbsp;</td>
                    <td style="width: 168px">Address</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="187px">
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>Canada</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 291px">&nbsp;</td>
                    <td style="width: 168px">Age</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" style="margin-left: 0" Width="183px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 291px">&nbsp;</td>
                    <td style="width: 168px">Contact</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" style="margin-left: 0" Width="183px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 291px">&nbsp;</td>
                    <td style="width: 168px">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" BackColor="#6600FF" BorderColor="Black" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" OnClick="Button1_Click" Text="Insert" Width="82px" />
                    </td>
                </tr>
            </table>
           <asp:GridView ID="GridView1" runat="server" Width="435px">
            </asp:GridView>
        </div>
        <br />


</asp:Content>
