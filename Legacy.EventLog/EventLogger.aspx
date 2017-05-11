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
        <asp:Button ID="AddLogButton" runat="server" OnClick="AddLogButton_Click" Text="GO!" Width="71px" BackColor="#663300" BorderStyle="Dashed" ForeColor="Yellow" />
        <hr />
        <br />
        <asp:Label ID="InfoStatusLabel" runat="server" BackColor="#000066" BorderColor="#660066" BorderStyle="Groove" ForeColor="White" Width="922px"></asp:Label>
        <br />
        <asp:ListBox ID="LoggedEventsList" runat="server" Height="668px" Width="925px" Enabled="False" BackColor="#FF33CC" ForeColor="Aqua"></asp:ListBox>
    </form>
</body>
</html>
