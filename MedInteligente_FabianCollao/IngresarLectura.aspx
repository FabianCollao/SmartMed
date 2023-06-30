<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="MedInteligente_FabianCollao.IngresarLectura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-secondary text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <%-- Mensaje --%>
                    <div class="mensaje">
                        <asp:Label runat="server" id="mensajesLbl" CssClass="text-danger "></asp:Label>
                    </div>
                <!-- Formulario Ingresar Lectura-->
                    <div class="form-group">
                        <label for="medidorLbl">Medidor</label>
                        <asp:DropDownList ID="medidorList" CssClass="form-select" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione un Medidor"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="medidorValidator" runat="server" ControlToValidate="medidorList" ErrorMessage="Selecciona un medidor" CssClass="text-danger" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <label for="fechaLbl">Fecha</label>
                    </div>
                    <div class="d-flex justify-content-center align-items-center">
                        <asp:Calendar ID="fechaCalendario" CssClass="form-control" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                        <br />
                    </div>


                    <div class="form-group">
                        <label for="horaLbl">Hora</label>
                        <asp:TextBox ID="horaTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="horaValidator" runat="server" ControlToValidate="horaTxtBox" Type="Integer" MinimumValue="0" MaximumValue="23" ErrorMessage="La hora debe estar entre 0 y 23" CssClass="text-danger" Display="Dynamic"></asp:RangeValidator>
                    </div>

                    <div class="form-group">
                        <label for="minutoLbl">Minuto</label>
                        <asp:TextBox ID="minutoTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="minutoValidator" runat="server" ControlToValidate="minutoTxtBox" Type="Integer" MinimumValue="0" MaximumValue="59" ErrorMessage="El minuto debe estar entre 0 y 59" CssClass="text-danger" Display="Dynamic"></asp:RangeValidator>

                    </div>

                    <div class="form-group">
                        <label for="consumoLbl">Valor Consumo</label>
                        <asp:TextBox ID="consumoTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="consumoValidator" runat="server" ControlToValidate="consumoTxtBox" Type="Double" MinimumValue="0" MaximumValue="600" ErrorMessage="El valor del consumo debe estar entre 0 y 600" CssClass="text-danger" Display="Dynamic"></asp:RangeValidator>
                    </div>

                    <div class="container mt-1 col">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar Lectura" CssClass="btn btn-secondary w-100" ></asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
