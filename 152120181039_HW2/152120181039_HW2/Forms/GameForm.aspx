<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameForm.aspx.cs" Inherits="_152120181039_HW2.Forms.GameForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hangman</title>
    <style type="text/css">
        .container {
            text-align: center;
            height: 677px;
        }
    </style>
</head>
<body style="background-color: #80FF00">
    <form id="form1" runat="server">
        <div class="container">
            <asp:ScriptManager ID="scriptManager" runat="server" />

            <asp:Timer runat="server" ID="timer" Interval="1000" OnTick="timer_Tick" />

            <asp:UpdatePanel runat="server" ID="TimedPanel" UpdateMode="Conditional">

                <ContentTemplate>

                    <asp:Label ID="lblTimerText" runat="server" Text="Timer : " Font-Bold="True"></asp:Label>

                    <asp:Label ID="lblTimer" runat="server" Text="0" Font-Bold="True" />

                </ContentTemplate>

                <Triggers>

                    <asp:AsyncPostBackTrigger ControlID="timer" EventName="Tick" />

                </Triggers>

            </asp:UpdatePanel>


            <br />
            <asp:Label ID="lblPredictDisplayer" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblRandomWord" runat="server" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblHintOfRandomWord" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnA" runat="server" OnClick="btnA_Click" Text="A" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnB" runat="server" OnClick="btnB_Click" Text="B" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnC" runat="server" OnClick="btnC_Click" Text="C" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnD" runat="server" OnClick="btnD_Click" Text="D" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnE" runat="server" OnClick="btnE_Click" Text="E" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnF" runat="server" OnClick="btnF_Click" Text="F" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnG" runat="server" OnClick="btnG_Click" Text="G" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnH" runat="server" OnClick="btnH_Click" Text="H" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnI" runat="server" OnClick="btnI_Click" Text="I" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnJ" runat="server" OnClick="btnJ_Click" Text="J" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnK" runat="server" OnClick="btnK_Click" Text="K" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnL" runat="server" OnClick="btnL_Click" Text="L" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnM" runat="server" OnClick="btnM_Click" Text="M" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnN" runat="server" OnClick="btnN_Click" Text="N" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnO" runat="server" OnClick="btnO_Click" Text="O" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnÖ" runat="server" OnClick="btnÖ_Click" Text="Ö" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnP" runat="server" OnClick="btnP_Click" Text="P" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnR" runat="server" OnClick="btnR_Click" Text="R" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnS" runat="server" OnClick="btnS_Click" Text="S" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnT" runat="server" OnClick="btnT_Click" Text="T" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnU" runat="server" OnClick="btnU_Click" Text="U" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnV" runat="server" OnClick="btnV_Click" Text="V" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnY" runat="server" OnClick="btnY_Click" Text="Y" BackColor="#80FF00" Font-Bold="True" />
            &nbsp;<asp:Button ID="btnZ" runat="server" OnClick="btnZ_Click" Text="Z" BackColor="#80FF00" Font-Bold="True" />
            <br />
            <br />
            <asp:Image ID="img0" runat="server" ImageUrl="~/Images/Man Images/0.png" Height="427px" Width="348px" />
            <asp:Image ID="img1" runat="server" ImageUrl="~/Images/Man Images/1.png" Height="427px" Visible="False" Width="348px" />
            <asp:Image ID="img2" runat="server" Height="427px" ImageUrl="~/Images/Man Images/2.png" Visible="False" Width="348px" />
            <asp:Image ID="img3" runat="server" Height="427px" ImageUrl="~/Images/Man Images/3.png" Visible="False" Width="348px" />
            <asp:Image ID="img4" runat="server" Height="427px" ImageUrl="~/Images/Man Images/4.png" Visible="False" Width="348px" />
            <asp:Image ID="img5" runat="server" Height="427px" ImageUrl="~/Images/Man Images/5.png" Visible="False" Width="348px" />
            <asp:Image ID="img6" runat="server" Height="427px" ImageUrl="~/Images/Man Images/6.png" Visible="False" Width="348px" />
            <asp:Image ID="img7" runat="server" Height="427px" ImageUrl="~/Images/Man Images/7.png" Visible="False" Width="348px" />
            <asp:Image ID="img8" runat="server" Height="427px" ImageUrl="~/Images/Man Images/8.png" Visible="False" Width="348px" />
            <asp:Image ID="img9" runat="server" Height="427px" ImageUrl="~/Images/Man Images/9.png" Visible="False" Width="348px" />
            <br />
            <br />
            <asp:ImageButton ID="btnBack" runat="server" Height="70px" ImageAlign="Left" ImageUrl="~/Images/Button Images/btnBack.png" OnClick="btnBack_Click" Width="70px" />
            <br />
        </div>
    </form>
</body>
</html>
