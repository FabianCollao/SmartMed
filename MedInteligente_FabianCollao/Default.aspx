<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedInteligente_FabianCollao.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="container mt-4">
        <div class="row">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Ingresar Medidor</h5>
                        <p class="card-text">Formulario para ingresar un medidor</p>
                        <asp:Button ID="btnIngresarMedidor" runat="server" Text="Ir" CssClass="btn btn-primary w-100" PostBackUrl="~/IngresarMedidor.aspx" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Ingresar Lectura</h5>
                        <p class="card-text">Formulario para ingresar una lectura</p>
                        <asp:Button ID="btnIngresarLectura" runat="server" Text="Ir" CssClass="btn btn-primary w-100" PostBackUrl="~/IngresarLectura.aspx" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row mt-4">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Mostrar Medidores</h5>
                        <p class="card-text">Mostrar la lista de medidores</p>
                        <asp:Button ID="btnMostrarMedidores" runat="server" Text="Ir" CssClass="btn btn-primary w-100" PostBackUrl="~/MostrarMedidores.aspx" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Mostrar Lecturas</h5>
                        <p class="card-text">Mostrar la lista de lecturas</p>
                        <asp:Button ID="btnMostrarLecturas" runat="server" Text="Ir" CssClass="btn btn-primary w-100" PostBackUrl="~/MostrarLecturas.aspx" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
