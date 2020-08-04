<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Repositorio_CNC.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Repositórios CNC - Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
