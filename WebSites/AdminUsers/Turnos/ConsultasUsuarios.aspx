<%@ Page Title="" Language="C#" MasterPageFile="~/Turnos/ConsultasUsuarios.master" AutoEventWireup="true" CodeFile="ConsultasUsuarios.aspx.cs" Inherits="Usuarios_ConsultasTipoUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphnavmenus" Runat="Server">
    USUARIO:
    <asp:Label ID="LabelUsuario" runat="server" Text=""></asp:Label>
    <asp:ImageButton ID="ImgNuevo" runat="server" AlternateText="Nuevo" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/ImgNuevo.png" OnClick="ImgNuevo_Click" ToolTip="Agrega un nuevo tipo de usuario" />
    <asp:ImageButton ID="ImgEditar" runat="server" AlternateText="Editar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/ImgEditar.png" OnClick="ImgEditar_Click" ToolTip="Edita un tipo de usuario" />
    <asp:ImageButton ID="ImgImprimir" runat="server" AlternateText="Mostrar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/ImgImprimir.gif" OnClick="ImgImprimir_Click" ToolTip="Muestra el listado de los tipos de usuario" />
    <asp:ImageButton ID="ImgInicio" runat="server" AlternateText="Inicio" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/ImgInicio.png" OnClick="ImgInicio_Click" ToolTip="Regresa al menú de Inicio" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPrincipal" Runat="Server">
    <asp:Panel ID="PanelCapturaCedula" runat="server">
        <table class="TablaCapturaCedula">
            <tr>
                <td class="tdTituloOpcionesCatalogo" colspan="2">
                    <asp:Label ID="LabelTitulo" runat="server">aa</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="tdTexto30">
                    * Cedula : &nbsp;
                </td>
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxCedula" runat="server" ToolTip="Proporciona numero a buscar" Width="166px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVTexBoxCedula" runat="server" ControlToValidate="TextBoxCedula" ErrorMessage="Se requiere IdTipoUsuario">ErrorIdTipoUsuario</asp:RequiredFieldValidator>
                    <asp:Button ID="ButtonConsulta" runat="server" OnClick="ButtonConsulta_Click" Text="OK" style="height: 26px" />
                </td>
            </tr>
            </table>
            </asp:Panel>        
            <asp:Panel ID="PanelDatos" runat="server">
                <table class="TablaCapturaDatos">
            <tr>
                <td class="tdTexto30">
                    * PrimerNombre : &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxPrimerNombre" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="tdTexto30">
                    SegundoNombre : &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxSegundoNombre" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="tdTexto30">
                    * PrimerApellido : &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxPrimerApellido" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="tdTexto30">
                    SegundoApellido: &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxSegundoApellido" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="tdTexto30">
                    * Usuario : &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxUsuario" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="tdTexto30">
                    * Contraseña : &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxContraseña" runat="server" Width="400px"></asp:TextBox>
                </td>                 
            </tr>
            <tr>
                <td class="tdTexto30">
            * TipoUsuario : &nbsp;
        </td>   
        <td class="tdTexto70">
            <asp:TextBox ID="TextBoxTipoUsuario" runat="server" Width="400px"></asp:TextBox>
        </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="PanelGrabarDatos" runat="server">
        <asp:ImageButton ID="ImgAceptarAgregar" runat="server" AlternateText="Aceptar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnAceptar.gif" OnClick="ImgAceptarAgregar_Click" ToolTip="Aceptar" />
        <asp:ImageButton ID="ImgCancelarAgregar" runat="server" AlternateText="Cancelar" CausesValidation="False" CommandName="Cancel" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnCancelar.gif" OnClick="ImgCancelarAgregar_Click" ToolTip="Cancelar" OnClientClick="return confirm(&quot;No se guardarán los cambios. ¿Desea Continuar?&quot;)" />
    </asp:Panel>
    <asp:Panel ID="PanelModificarDatos" runat="server">
        <asp:ImageButton ID="ImgAceptarModificar" runat="server" AlternateText="Aceptar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnAceptar.gif" OnClick="ImgAceptarModificar_Click" ToolTip="Aceptar" />
        <asp:ImageButton ID="ImgBorrarModificar" runat="server" AlternateText="Borrar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnBorrar.gif" OnClick="ImgBorrarModificar_Click" OnClientClick='return confirm("Se eliminará el usuario seleccionado permanentemente. ¿Desea Continuar?")' ToolTip="Borrar" />
        <asp:ImageButton ID="ImgCancelarModificar" runat="server" AlternateText="Cancelar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnCancelar.gif" OnClick="ImgCancelarModificar_Click" ToolTip="Cancelar" CommandName="Cancel" OnClientClick='return confirm("No se guardarán los cambios. ¿Desea Continuar?")' />&nbsp;
    </asp:Panel>
    <asp:Panel ID="PanelListarDatos" runat="server">
        <asp:GridView ID="GridViewListadoUsuario" runat="server" CellPadding="4" DataKeyNames="Cedula" ForeColor="#333333" GridLines="None" Width="92%" AutoGenerateColumns="False" OnSelectedIndexChanged="GridViewListadoUsuario_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                <asp:BoundField DataField="PrimerNombre" HeaderText="PrimerNombre" />
                <asp:BoundField DataField="SegundoNombre" HeaderText="SegundoNombre" />
                <asp:BoundField DataField="PrimerApellido" HeaderText="PrimerApellido" />
                <asp:BoundField DataField="SegundoApellido" HeaderText="SegundoApellido" />
                <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                <asp:BoundField DataField="TipoUsuario" HeaderText="TipoUsuario" />
                <asp:CommandField ButtonType="Image" HeaderText="Editar" SelectImageUrl="~/Imagenes/BtnEditar.gif" SelectText="Editar Registro" ShowSelectButton="True">
                <HeaderStyle Font-Bold="True" Font-Names="Verdana" Font-Size="X-Small" HorizontalAlign="Center" Width="10%" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphAnuncios" Runat="Server">
</asp:Content>

