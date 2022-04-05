<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameOverForm.aspx.cs" Inherits="_152120181039_HW2.Forms.GameOverForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result</title>
    <style type="text/css">
        .div {
            text-align : center;
        }
    </style>
</head>
<body style="background-color:#80FF00">
    <form id="form1" runat="server">
        <div class="div">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblInfoAtTheEndOfGame" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#FF0066"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="btnPlayAgain" runat="server" ImageUrl="~/Images/Button Images/btnPlayAgain.png" OnClick="btnPlayAgain_Click" Width="200px" Height="200px" />
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="btnHomePage" runat="server" ImageUrl="~/Images/Button Images/btnHome.png" OnClick="btnHomePage_Click" Width="200px" Height="200px" />
        </div>
    </form>
</body>
</html>
