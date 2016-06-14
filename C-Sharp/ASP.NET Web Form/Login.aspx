<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms101.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        First Name:&nbsp;
        <asp:TextBox ID="txtFirst" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <br />
        Last Name:&nbsp;
        <asp:TextBox ID="txtLast" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Login" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblName" runat="server" BorderStyle="Inset" Width="300px"></asp:Label>
    </form>
</body>
</html>
