<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="MedInteligente_FabianCollao.IngresarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-secondary text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <!--Agregamos Mensaje-->
                    <div class="mesanjes">
                        <asp:Label runat="server" id="mensajesLbl" CssClass="text-danger"></asp:Label>
                    </div>
                    <!--Formulario Ingresar Medidor-->
                <div class="card-body">
                    <div class="form-group">
                        <label for="tipoLbl">Ingrese Tipo</label>
                        <asp:TextBox ID="tipoTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="medidorValidator" runat="server" ControlToValidate="tipoTxtBox" ErrorMessage="* Campo Obligatorio" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <label for="serieLbl">Ingrese Serie</label>
                        <asp:TextBox ID="serieTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="serieValidator" runat="server" ControlToValidate="serieTxtBox" ErrorMessage="* Campo Obligatorio" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="container mt-1 col">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" text="Agregar" CssClass="btn btn-secondary w-100"></asp:Button>
                    </div>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
