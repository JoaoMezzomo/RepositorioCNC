<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Repositorio_CNC.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Repositórios CNC - Login</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-/Y6pD6FV/Vv2HJnA6t+vslU6fwYXjCFtcEpHbNJ0lyAFsXTsjBbfaDjzALeQsN6M" crossorigin="anonymous"/>

    <style>
        body, html, form {
            height:100%;
        }

        .Fundo {
            background-image: url("Images/cncvertical.jpg");
        }

        @media (min-width:992px) {
            .Caixa {
            box-shadow: 5px 5px 5px;
            border-style:solid;
            border-width:4px;
            border-color:white;
            border-radius: 4px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container Fundo" style="height:100%;">
            <div class="row d-none d-sm-none d-md-block d-lg-block d-xl-block" style="height:26%"></div>
            <div class="row">
                <div class="col-sm-0 col-md-0 col-lg-4 col-xl-4"></div>
                <div class="col-sm-12 col-md-12 col-lg-4 col-xl-4 bg-dark">
                    <div class="Caixa row">
                        <div class="col-12 text-center pb-4 pt-2">
                            <h2 class="text-light">Repositório CNC</h2>
                        </div>
                        <div class="col-12">
                            <asp:TextBox class="form-control" style="width:100%;" ID="txtUsuario" runat="server" placeholder="Usuário"></asp:TextBox>
                        </div>
                        <div class="col-12">
                            <asp:TextBox type="password" class="form-control" style="width:100%;" ID="txtSenha" runat="server" placeholder="Senha"></asp:TextBox>
                        </div>
                        <div class="col-12 pt-2">
                            <asp:LinkButton class="btn btn-lg btn-primary btn-block" ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click1">Entrar</asp:LinkButton>
                        </div>
                        <div class="col-12 text-center">
                            <asp:Label class="text-danger" ID="LabelErro" runat="server" Text="Usuário ou senha inválidos!" Visible="False"></asp:Label>
                        </div>
                        <div class="col-12 text-center">
                            <p class="pt-5 text-muted">Repositório CNC - Empresa Teste</p>
                        </div>
                    </div>
                </div>
                <div class="col-sm-0 col-md-0 col-lg-4 col-xl-4"></div>
            </div>
            <div class="row" style="height:26%"></div>
            <div class="row d-block d-sm-block d-md-none d-lg-none d-xl-none" style="height:8%"></div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta/js/bootstrap.min.js" integrity="sha384-h0AbiXch4ZDo7tp9hKZ4TsHbi047NrKGLO3SEJAg45jXxnGIfYzk4Si90RDIqNm1" crossorigin="anonymous"></script>
</body>
</html>
