<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Repositorio_CNC.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container Corpo">
        <div class="row bg-secondary">
            <div class="col-12 py-3">
                <asp:LinkButton class="btn btn-info " ID="LinkBtnDownloadUnico" runat="server" OnClick="LinkBtnDownloadUnico_Click">Download</asp:LinkButton>
            </div>
        </div>
        <div class="row py-2 bg-light">
            <div class="col-sm-12 col-md-3 col-lg-3 col-xl-3 pt-1 pr-1">
                <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                <asp:TextBox style="width:100%;" ID="txtNome" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 col-md-3 col-lg-3 col-xl-3 pt-1 pr-1">
                <asp:Label ID="Label2" runat="server" Text="Projeto:"></asp:Label>
                <asp:DropDownList style="width:100%;" ID="ddlProjetos" runat="server"></asp:DropDownList>
            </div>
            <div class="col-sm-12 col-md-3 col-lg-3 col-xl-3 pt-1 pr-1">
                <asp:Label ID="Label3" runat="server" Text="Máquina:"></asp:Label>
                <asp:DropDownList style="width:100%;" ID="ddlMaquinas" runat="server"></asp:DropDownList>
            </div>
            <div class="col-sm-12 col-md-3 col-lg-3 col-xl-3 pt-1 pt-sm-1 pt-md-3 pt-lg-3 pt-xl-3">
                <asp:LinkButton class="btn btn-secondary" ID="LinkBtnFiltrar" runat="server" OnClick="LinkBtnFiltrar_Click">Filtrar</asp:LinkButton>
            </div>
        </div>
        <div class="row bg-light">
            <div class="col-12">
                <asp:GridView
                    ID="GridProgramas" 
                    runat="server" 
                    AutoGenerateColumns="False" 
                    CssClass="table table-responsive table-striped table-hover" 
                    GridLines="None" 
                    HorizontalAlign="Center"
                    AllowPaging="True" 
                    AutoGenerateSelectButton="True" 
                    OnSelectedIndexChanged="GridProgramas_SelectedIndexChanged" 
                    OnRowCreated="GridProgramas_RowCreated"  
                    OnPageIndexChanging="GridProgramas_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True"  />
                        <asp:BoundField DataField="NOME" HeaderText="Nome" ReadOnly="True"  />
                        <asp:BoundField DataField="PROJETO" HeaderText="Projeto" ReadOnly="True"  />
                    </Columns>
                    <HeaderStyle CssClass="thead-dark" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
