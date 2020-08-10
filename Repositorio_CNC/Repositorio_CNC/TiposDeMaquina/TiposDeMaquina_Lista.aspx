<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TiposDeMaquina_Lista.aspx.cs" Inherits="Repositorio_CNC.TiposDeMaquina.TiposDeMaquina_Lista" %>
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
    <div class="container bg-secondary">
        <div class="row bg-dark Cabecalho1">
            <div class="col-12 text-center py-3">
                <hr class="bg-light"/>
                <h3 class="text-light">Tipos de Máquina</h3>
            </div>
        </div>
        <div class="row pb-1 pt-2">
            <div class="col-sm-12 col-md-12 col-lg-2 col-xl-2 py-1">
                <asp:LinkButton class="btn btn-primary btn-block" ID="LinkBtnNovo" runat="server" OnClick="LinkBtnNovo_Click">Novo</asp:LinkButton>
            </div>
        </div>
        <div class="row py-2 bg-secondary">
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 pt-1 pt-sm-1 pt-md-1 pt-lg-0 pt-xl-0 pr-3 pr-sm-3 pr-md-3 pr-lg-1 pr-xl-1">
                <asp:TextBox class="form-control" placeholder="Nome" style="width:100%;" ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 pt-1 pt-sm-1 pt-md-1 pt-lg-0 pt-xl-0">
                <asp:LinkButton class="btn btn-info btn-block" ID="LinkBtnFiltrar" runat="server" OnClick="LinkBtnFiltrar_Click">Filtrar</asp:LinkButton>
            </div>
        </div>
        <div class="row bg-light">
            <div class="col-12">
                <asp:GridView
                    ID="GridTipos" 
                    runat="server" 
                    AutoGenerateColumns="False" 
                    CssClass="table table-responsive table-hover" 
                    GridLines="None" 
                    HorizontalAlign="Center"
                    AllowPaging="True" 
                    OnRowCreated="GridTipos_RowCreated"  
                    OnPageIndexChanging="GridTipos_PageIndexChanging" 
                    AutoGenerateEditButton="True" 
                    OnRowEditing="GridTipos_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True"  />
                        <asp:BoundField DataField="NOME" HeaderText="Nome" ReadOnly="True"  />
                    </Columns>
                    <HeaderStyle CssClass="thead-dark" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
