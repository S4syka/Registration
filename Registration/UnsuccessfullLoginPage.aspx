<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnsuccessfullLoginPage.aspx.cs" Inherits="Registration.UnsuccessfullLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>You have logged in unsuccessfully</h1> <br />
            <asp:Button ID="btnGoBack" runat="server" Text="Go back!" OnClick="btnGoBack_Click" />
        </div>
    </form>
</body>
</html>
