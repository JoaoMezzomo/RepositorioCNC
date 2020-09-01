<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Programas_Edita.aspx.cs" Inherits="Repositorio_CNC.Programas.Programas_Edita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        *{
            font-family:'Comic Sans MS';
        }

        body, html, form {
            height:100%;
        }

        .Cabecalho1 {
            border-bottom-style:solid;
            border-bottom-width: 6px;
            border-bottom-color:Highlight;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-secondary" style="height:100%;">
        <div class="row bg-dark Cabecalho1">
            <div class="col-12 text-center py-3">
                <hr class="bg-light"/>
                <h3 class="text-light">Programa</h3>
            </div>
        </div>
        <div class="row pt-3 text-center">
            <div class="col-12">
                <h4 class="text-dark">Informações</h4>
            </div>
        </div>
        <div class="row pt-1">
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 ">
                <asp:Label class="pl-1 text-dark" ID="Label1" runat="server" Text="Nome:"></asp:Label>
                <asp:TextBox class="form-control" style="width:100%;" ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 ">
                <asp:Label class="pl-1 text-dark" ID="Label2" runat="server" Text="Projeto:"></asp:Label>
                <asp:TextBox class="form-control" style="width:100%;" ID="txtProjeto" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 ">
                <asp:Label class="pl-1 text-dark" ID="Label3" runat="server" Text="Versão:"></asp:Label>
                <asp:TextBox class="form-control" style="width:100%;" ID="txtVersao" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 ">
                <asp:Label class="pl-1 text-dark" ID="Label4" runat="server" Text="Usuário:"></asp:Label>
                <asp:TextBox class="form-control" style="width:100%;" ID="txtUsuario" runat="server" ReadOnly="True"></asp:TextBox>
            </div>
        </div>
        <div class="row pt-3 text-center">
            <div class="col-12">
                <h4 class="text-dark">Máquinas</h4>
            </div>
        </div>
    </div>
</asp:Content>
