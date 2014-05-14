<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="EindOpdracht_S22.Start" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../StartStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server"> 
        <asp:Panel ID="pStart" runat="server" BackColor="#FFFFCC" Height="214px">
            <div id="DivHeader">
            <br />
                <asp:Label ID="lblStartName" runat="server" Text="Welcome to the page."></asp:Label>
            </div>
            <br />
            <div style="height: 69px"id="DivStartButtons">
                    <asp:Button ID="btnStartNew" runat="server" Text="New" 
                        onclick="btnStartNew_Click" />
                    <br />
                    <br />
                    <asp:DropDownList ID="ddlBuilds" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="btnStartLoad" runat="server" Text="Load" />
                
            </div>
        </asp:Panel>
    </form>
</body>
</html>
