<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Builder.aspx.cs" Inherits="EindOpdracht_S22.Builder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../StartStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 119px">
    <form id="form1" runat="server">
    <div></div>
    <asp:Panel ID="pStart" runat="server" BackColor="#FFFFCC" Height="110px" BorderStyle="Solid" BorderColor="Black">
        <br />
        <asp:Label ID="lblBuildName" runat="server" Text="Build Name:"></asp:Label>
        <asp:TextBox ID="tbBuildName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblBuildAuthor" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="tbBuildAuthor" runat="server"></asp:TextBox>
        <br />
        <div id="DivSave">
        <asp:Button ID="btnBuildSave" runat="server" Text="Save" />
        </div>
        <br />
        <br />
    </asp:Panel>
    <asp:Panel ID="Pmargin" runat="server" BackColor   ="#FFFFCC" >
        <br />    
    </asp:Panel>
    <div id="DivBuilder">
    <asp:Panel ID="PBuilder" runat="server" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Solid">

        <asp:ImageButton ID="ibtnDeathKnight" runat="server" 
            ImageUrl="~/Resources/DK.PNG" onclick="ibtnDeathKnight_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnDruid" runat="server" 
            ImageUrl="~/Resources/Druid.PNG" onclick="ibtnDruid_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnMage" runat="server" 
            ImageUrl="~/Resources/Mage.PNG" onclick="ibtnMage_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnMonk" runat="server" 
            ImageUrl="~/Resources/Monk.PNG" onclick="ibtnMonk_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnPaladin" runat="server" 
            ImageUrl="~/Resources/Paladin.PNG" onclick="ibtnPaladin_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnPriest" runat="server" 
            ImageUrl="~/Resources/Priest.PNG" onclick="ibtnPriest_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnHunter" runat="server" 
            ImageUrl="~/Resources/Hunter.PNG" onclick="ibtnHunter_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnShaman" runat="server" 
            ImageUrl="~/Resources/Shaman.PNG" onclick="ibtnShaman_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnRogue" runat="server" 
            ImageUrl="~/Resources/Rogue.PNG" onclick="ibtnRogue_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnWarrior" runat="server" 
            ImageUrl="~/Resources/Warrior.PNG" onclick="ibtnWarrior_Click" 
            BorderStyle="Solid" />
        <asp:ImageButton ID="ibtnWarlock" runat="server" 
            ImageUrl="~/Resources/Warlock.PNG" onclick="ibtnWarlock_Click" 
            BorderStyle="Solid" />
    
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpec1" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/spec1.png" onclick="ibtnSpec1_Click" />
        <asp:ImageButton ID="ibtnSpec2" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/spec2.png" onclick="ibtnSpec2_Click" />
        <asp:ImageButton ID="ibtnSpec3" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/spec3.png" onclick="ibtnSpec3_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpell1" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell2_Click" />
        <asp:ImageButton ID="ibtnSpell2" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell3_Click" />
        <asp:ImageButton ID="ibtnSpell3" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell1_Click" />
        <asp:Image ID="imgLvl1" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/15.PNG" />
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpell4" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell4_Click" />
        <asp:ImageButton ID="ibtnSpell5" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell5_Click" />
        <asp:ImageButton ID="ibtnSpell6" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell6_Click" />
        <asp:Image ID="imgLvl2" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/30.PNG" />
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpell7" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell7_Click" />
        <asp:ImageButton ID="ibtnSpell8" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell8_Click" />
        <asp:ImageButton ID="ibtnSpell9" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell9_Click" />
        <asp:Image ID="imgLvl3" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/45.PNG" />
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpell10" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell10_Click" />
        <asp:ImageButton ID="ibtnSpell11" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell11_Click" />
        <asp:ImageButton ID="ibtnSpell12" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell12_Click" />
        <asp:Image ID="imgLvl4" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/60.PNG" />
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpell13" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell13_Click" />
        <asp:ImageButton ID="ibtnSpell14" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell14_Click" />
        <asp:ImageButton ID="ibtnSpell15" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell15_Click" />
        <asp:Image ID="imgLvl5" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/75.PNG" />
        <br />
        <br />
        <asp:ImageButton ID="ibtnSpell16" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell16_Click" />
        <asp:ImageButton ID="ibtnSpell17" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell17_Click" />
        <asp:ImageButton ID="ibtnSpell18" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/skill.png" onclick="ibtnSpell18_Click" />
       
    
        <asp:Image ID="imgLvl6" runat="server" BorderStyle="Solid" 
            ImageUrl="~/Resources/90.PNG" />
        <br />
        <br />
       
    
    </asp:Panel>
    </div>
    </form>
</body>
</html>
