<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_152120181039_HW2.Forms.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hangman</title>
    <style>
        #form1{
            display:flex;
            justify-content:center;
            align-items:center;
        }

    </style>
</head>
<body style="background-color:#80FF00">
    <form id="form1" runat="server">
        <div id="id1">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblHangman" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#FF0066" Text="HANGMAN"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="btnStartGame" runat="server" Height="200px" ImageUrl="~/Images/Button Images/btnStart.png" Width="200px" OnClick="btnStartGame_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="btnSettings" runat="server" Height="200px" ImageUrl="~/Images/Button Images/btnSettings.png" Width="200px" OnClick="btnSettings_Click" />
        </div>
    </form>
</body>
</html>
