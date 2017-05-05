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
        <asp:TextBox ID="NewEventTextBox" runat="server" Width="852px"></asp:TextBox>
        <asp:Button ID="AddLogButton" runat="server" OnClick="AddLogButton_Click" Text="Submit" Width="71px" />
        <hr />
        <br />
        <asp:Label ID="InfoStatus" runat="server"></asp:Label>
        <br />
        <asp:ListBox ID="LoggedEventsList" runat="server" Height="668px" Width="871px"></asp:ListBox>
    </form>
</body>
</html>
