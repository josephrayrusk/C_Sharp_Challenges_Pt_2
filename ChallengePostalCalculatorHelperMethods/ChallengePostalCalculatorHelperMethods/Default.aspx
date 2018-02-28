<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Postal Calculator</h3>
            <br />
            Width: <asp:TextBox ID="widthText" runat="server" OnTextChanged="widthText_TextChanged"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="heightText" runat="server" OnTextChanged="heightText_TextChanged"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="lengthText" runat="server" OnTextChanged="lengthText_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundButton" runat="server" AutoPostBack="True" GroupName="shipSetting" OnCheckedChanged="groundButton_CheckedChanged" Text="Ground" />
            <br />
            <asp:RadioButton ID="airButton" runat="server" AutoPostBack="True" GroupName="shipSetting" OnCheckedChanged="airButton_CheckedChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="nextDayButton" runat="server" AutoPostBack="True" GroupName="shipSetting" OnCheckedChanged="nextDayButton_CheckedChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
