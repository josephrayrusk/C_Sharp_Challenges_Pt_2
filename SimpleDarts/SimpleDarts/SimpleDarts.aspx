<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleDarts.aspx.cs" Inherits="SimpleDarts.SimpleDarts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Player 1 Name</p>
        <p>
            <asp:TextBox ID="p1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            Player 2 Name</p>
        <p>
            <asp:TextBox ID="p2" runat="server" OnTextChanged="p2_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Lets Play!" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
    </form>
</body>
</html>
