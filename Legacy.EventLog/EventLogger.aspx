<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventLogger.aspx.cs" Inherits="Legacy.EventLog.EventLogger" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="LogForm" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="NewEventTextBox" runat="server" Width="852px" BackColor="#66FF33"></asp:TextBox>
        <asp:Button ID="AddLogButton" runat="server" OnClick="AddLogButton_Click" Text="GO!" Width="71px" BackColor="#FF66FF" BorderStyle="Dashed" ForeColor="#990033" />
        <hr />
        <br />
        <asp:Label ID="InfoStatusLabel" runat="server" BackColor="#000066" BorderColor="#660066" BorderStyle="Groove" ForeColor="White"></asp:Label>
        <br />
        <asp:ListBox ID="LoggedEventsList" runat="server" Height="668px" Width="871px" Enabled="False" BackColor="#990099" ForeColor="Aqua"></asp:ListBox>
    </form>
</body>
</html>
