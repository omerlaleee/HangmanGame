<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameForm.aspx.cs" Inherits="_152120181039_HW2.Forms.GameForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblPredictDisplayer" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblRandomWord" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblHintOfRandomWord" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="btnA" runat="server" OnClick="btnA_Click" Text="A" />
&nbsp;<asp:Button ID="btnB" runat="server" OnClick="btnB_Click" Text="B" />
&nbsp;<asp:Button ID="btnC" runat="server" OnClick="btnC_Click" Text="C" />
&nbsp;<asp:Button ID="btnÇ" runat="server" OnClick="btnÇ_Click" Text="Ç" />
&nbsp;<asp:Button ID="btnD" runat="server" OnClick="btnD_Click" Text="D" />
&nbsp;<asp:Button ID="btnE" runat="server" OnClick="btnE_Click" Text="E" />
&nbsp;<asp:Button ID="btnF" runat="server" OnClick="btnF_Click" Text="F" />
&nbsp;<asp:Button ID="btnG" runat="server" OnClick="btnG_Click" Text="G" />
&nbsp;<asp:Button ID="btnĞ" runat="server" OnClick="btnĞ_Click" Text="Ğ" />
&nbsp;<asp:Button ID="btnH" runat="server" OnClick="btnH_Click" Text="H" />
&nbsp;<asp:Button ID="btnI" runat="server" OnClick="btnI_Click" Text="I" />
&nbsp;<asp:Button ID="btnİ" runat="server" OnClick="btnİ_Click" Text="İ" />
&nbsp;<asp:Button ID="btnJ" runat="server" OnClick="btnJ_Click" Text="J" />
&nbsp;<asp:Button ID="btnK" runat="server" OnClick="btnK_Click" Text="K" />
&nbsp;<asp:Button ID="btnL" runat="server" OnClick="btnL_Click" Text="L" />
&nbsp;<asp:Button ID="btnM" runat="server" OnClick="btnM_Click" Text="M" />
&nbsp;<asp:Button ID="btnN" runat="server" OnClick="btnN_Click" Text="N" />
&nbsp;<asp:Button ID="btnO" runat="server" OnClick="btnO_Click" Text="O" />
&nbsp;<asp:Button ID="btnÖ" runat="server" OnClick="btnÖ_Click" Text="Ö" />
&nbsp;<asp:Button ID="btnP" runat="server" OnClick="btnP_Click" Text="P" />
&nbsp;<asp:Button ID="btnR" runat="server" OnClick="btnR_Click" Text="R" />
&nbsp;<asp:Button ID="btnS" runat="server" OnClick="btnS_Click" Text="S" />
&nbsp;<asp:Button ID="btnŞ" runat="server" OnClick="btnŞ_Click" Text="Ş" />
&nbsp;<asp:Button ID="btnT" runat="server" OnClick="btnT_Click" Text="T" />
&nbsp;<asp:Button ID="btnU" runat="server" OnClick="btnU_Click" Text="U" />
&nbsp;<asp:Button ID="btnÜ" runat="server" OnClick="btnÜ_Click" Text="Ü" />
&nbsp;<asp:Button ID="btnV" runat="server" OnClick="btnV_Click" Text="V" />
&nbsp;<asp:Button ID="btnY" runat="server" OnClick="btnY_Click" Text="Y" />
&nbsp;<asp:Button ID="btnZ" runat="server" OnClick="btnZ_Click" Text="Z" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;<div style="width: 618px; height: 74px">&nbsp;<asp:Image ID="img1" runat="server" ImageUrl="~/Images/1.png" Visible="False" />
                <asp:Image ID="img2" runat="server" ImageUrl="~/Images/2.png" Visible="False" />
                <asp:Image ID="img3" runat="server" ImageUrl="~/Images/3.png" Visible="False" />
                <asp:Image ID="img4" runat="server" ImageUrl="~/Images/4.png" Visible="False" />
                <asp:Image ID="img5" runat="server" ImageUrl="~/Images/5.png" Visible="False" />
                <asp:Image ID="img6" runat="server" ImageUrl="~/Images/6.png" Visible="False" />
                <asp:Image ID="img7" runat="server" ImageUrl="~/Images/7.png" Visible="False" />
                <asp:Image ID="img8" runat="server" ImageUrl="~/Images/8.png" Visible="False" />
                <asp:Image ID="img9" runat="server" ImageUrl="~/Images/9.png" Visible="False" />
            </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblWrongGuessCounter" runat="server">Yanlış Tahmin Sayısı : 0</asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
        </div>
    </form>
</body>
</html>
