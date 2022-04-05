<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SettingsForm.aspx.cs" Inherits="_152120181039_HW2.Forms.SettingsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Settings</title>
    <style type="text/css">
        .container {
            text-align : center;
        }
    </style>
</head>
<body style="background-color:#80FF00">
    <form id="form1" runat="server">
        <div class="container">
            <br />
            Word :&nbsp;
            <asp:TextBox ID="txtBoxAddedWord" runat="server" Width="217px" BackColor="#80FF00"></asp:TextBox>
            <br />
            <br />
            Hint&nbsp;&nbsp; :&nbsp;
            <asp:TextBox ID="txtBoxHintOfAddedWord" runat="server" Width="158px" BackColor="#80FF00"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="btnAdd" runat="server" ImageUrl="~/Images/Button Images/btnAdd.png" OnClick="btnAdd_Click" Width="30px" />
            <br />
            <br />
            <asp:ListBox ID="lstBoxWords" runat="server" Height="364px" Width="281px" BackColor="#80FF00" Font-Bold="True"></asp:ListBox>
            <br />
            <br />
            <asp:ImageButton ID="btnDelete" runat="server" Height="70px" ImageUrl="~/Images/Button Images/btnDelete.png" OnClick="btnDelete_Click" Width="70px" />
            <br />
            <br />
            <asp:Label ID="lblErrorMessage" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="btnBack" runat="server" Height="70px" ImageAlign="Left" ImageUrl="~/Images/Button Images/btnBack.png" OnClick="btnBack_Click" Width="70px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
