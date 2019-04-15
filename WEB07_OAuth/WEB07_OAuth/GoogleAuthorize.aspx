<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogleAuthorize.aspx.cs" Inherits="WEB07_OAuth.GoogleAuthorize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LABA7</title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="container">
            <div class="login">
                <h1>Login use ing google</h1>
                <p><asp:TextBox ID="txtgmail" runat="server" placeholder="Gmail"></asp:TextBox></p>
                <p><asp:Button ID="Authorize" runat="server" Text="Google Auth" OnClick ="Authorize_Click" /></p>
            </div>
        </section>
        <div>
        </div>
    </form>
</body>
</html>
