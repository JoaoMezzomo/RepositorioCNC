<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Maquinas_Lista.aspx.cs" Inherits="Repositorio_CNC.Maquinas.Maquinas_Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row bg-dark">
            <div class="col-12 text-center py-3">
                <hr class="bg-light"/>
                <h3 class="text-light">Máquinas</h3>
            </div>
        </div>
        <hr />
        <div class="row pb-1">
            <div class="col-sm-12 col-md-12 col-lg-2 col-xl-2 py-1">
                <asp:LinkButton class="btn btn-primary btn-block" ID="LinkBtnNovo" runat="server" OnClick="LinkBtnNovo_Click">Novo</asp:LinkButton>
            </div>
        </div>
        <div class="row py-2 bg-light">
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 pt-1 pr-1">
                <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                <asp:TextBox style="width:100%;" ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 pt-1 pr-1">
                <asp:Label ID="Label2" runat="server" Text="Número:"></asp:Label>
                <asp:TextBox style="width:100%;" ID="txtNumero" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 pt-1 pr-1">
                <asp:Label ID="Label3" runat="server" Text="Tipo:"></asp:Label>
                <asp:DropDownList style="width:100%;" ID="ddlTipo" runat="server"></asp:DropDownList>
            </div>
            <div class="col-sm-12 col-md-12 col-lg-3 col-xl-3 pt-1 pt-sm-1 pt-md-3 pt-lg-3 pt-xl-3">
                <asp:LinkButton class="btn btn-secondary btn-block" ID="LinkBtnFiltrar" runat="server" OnClick="LinkBtnFiltrar_Click">Filtrar</asp:LinkButton>
            </div>
        </div>
        <div class="row bg-light">
            <div class="col-12">
                <asp:GridView
                    ID="GridMaquinas" 
                    runat="server" 
                    AutoGenerateColumns="False" 
                    CssClass="table table-responsive table-striped table-hover" 
                    GridLines="None" 
                    HorizontalAlign="Center"
                    AllowPaging="True" 
                    OnRowCreated="GridMaquinas_RowCreated"  
                    OnPageIndexChanging="GridMaquinas_PageIndexChanging" 
                    AutoGenerateEditButton="True" 
                    OnRowEditing="GridMaquinas_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True"  />
                        <asp:BoundField DataField="NOME" HeaderText="Nome" ReadOnly="True"  />
                        <asp:BoundField DataField="NUMERO" HeaderText="Número" ReadOnly="True"  />
                    </Columns>
                    <HeaderStyle CssClass="thead-dark" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
