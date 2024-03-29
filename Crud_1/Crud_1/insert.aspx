<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="Crud_1.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 57px;
        }
        .auto-style4 {
            width: 25px;
        }
        .auto-style5 {
            width: 15px;
        }
        .auto-style6 {
            width: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            _Yuvraj_Soni_</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Id</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Name</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Age</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" Width="457px">
        </asp:GridView>
    </form>
</body>
</html>
