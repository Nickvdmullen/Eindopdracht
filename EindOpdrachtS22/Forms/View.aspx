<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="EindOpdrachtS22.Forms.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../ViewCSS.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="divViewInfo">
    
        <asp:Panel ID="pnlViewInfo" runat="server" BackColor="#FFFFCC">
            <asp:Label ID="lblViewBuildName" runat="server" Text="Build Name:"></asp:Label>
            <asp:Label ID="lbBuildName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblViewAuthor" runat="server" Text="Author:"></asp:Label>
            <asp:Label ID="lblAuthor" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblViewAuthor1" runat="server" Text="Rating:"></asp:Label>
            &nbsp;<asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </asp:Panel>
        </div>
        <br />
        <div id="DivViewBuild">
        <asp:Panel ID="pnlViewBuild" runat="server" BackColor="#FFFFCC" Height="946px" OnPreRender="pnlViewBuild_PreRender">
            <br />
        <asp:Image ID="imgDeathKnight" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/DK.PNG" />
        <asp:Image ID="imgDruid" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Druid.PNG" />
        <asp:Image ID="imgHunter" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Hunter.PNG" />
        <asp:Image ID="imgMage" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Mage.PNG" />
        <asp:Image ID="imgMonk" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Monk.PNG" />
        <asp:Image ID="imgPaladin" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Paladin.PNG" />
        <asp:Image ID="imgPriest" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Priest.PNG" />
        <asp:Image ID="imgRogue" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Rogue.PNG" />
        <asp:Image ID="imgShaman" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Shaman.PNG" />
        <asp:Image ID="imgWarlock" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Warlock.PNG" />
        <asp:Image ID="imgWarrior" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/Warrior.PNG" />
        <br />
        <br />
        <asp:Image ID="Image12" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/spec1.png" />
        <asp:Image ID="Image13" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/spec2.png" />
        <asp:Image ID="Image14" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/spec3.png" />
        <br />
        <br />
        <asp:Image ID="Image15" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image16" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image17" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="img15" runat="server" ImageUrl="~/Resources/15.PNG" />
        <br />
        <br />
        <asp:Image ID="Image18" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image19" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image20" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="img30" runat="server" ImageUrl="~/Resources/30.PNG" />
        <br />
        <br />
        <asp:Image ID="Image21" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image22" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image23" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="img45" runat="server" ImageUrl="~/Resources/45.PNG" />
        <br />
        <br />
        <asp:Image ID="Image24" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image25" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image26" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="img60" runat="server" ImageUrl="~/Resources/60.PNG" />
        <br />
        <br />
        <asp:Image ID="Image27" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image28" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image29" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="img75" runat="server" ImageUrl="~/Resources/75.PNG" />
        <br />
        <br />
        <asp:Image ID="Image30" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image31" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="Image32" runat="server" BorderStyle="Solid" ImageUrl="~/Resources/skill.png" />
        <asp:Image ID="img90" runat="server" ImageUrl="~/Resources/90.PNG" />
            <br />
            <asp:Label ID="lblViewComments" runat="server" Text="Comments"></asp:Label>
        <br />
        <br />
            <div id="divGridView">
                &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
            </asp:GridView>
                </div>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
