<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidores.aspx.cs" Inherits="MedInteligente_FabianCollao.MostrarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Mostrar Medidores</h3>
                </div>
                <div class="card-body">
                    <%-- Mensaje --%>
                    <div class="mensaje">
                        <asp:Label runat="server" id="mensajesLbl" CssClass="text-danger "></asp:Label>
                    </div>
                    <%-- DropDownList --%>
                    <div class="form-group">
                        <label for="medidores"></label> 
                        <asp:DropDownList ID="seleccionarMedidorList" CssClass="form-select" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="dropDownList_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Text="Seleccionar Medidor"></asp:ListItem>
                        </asp:DropDownList>
                    </div>  
                    <%-- GridMedidor --%>
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server"
                        AutoGenerateColumns="false" id="gridMedidor">
                        <Columns>
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo Medidor" />
                            <asp:BoundField DataField="Serie" HeaderText="Número de Serie" />
                        </Columns>
                    </asp:GridView>

                </div>
            </div>

        </div>

    </div>
</asp:Content>
