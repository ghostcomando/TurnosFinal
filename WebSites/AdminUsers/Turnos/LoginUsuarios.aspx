<%@ Page Title="" Language="C#" MasterPageFile="~/Turnos/ConsultasUsuarios.master" AutoEventWireup="true" CodeFile="LoginUsuarios.aspx.cs" Inherits="Usuarios_LoginUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphnavmenus" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPrincipal" Runat="Server">
    <asp:Panel ID="PanelLoginUsuario" runat="server">
        <table class="TablaCapturaDatos">
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
                    * Contraseña: &nbsp;
                </td>   
                <td class="tdTexto70">
                    <asp:TextBox ID="TextBoxContraseña" runat="server" Width="400px" TextMode="Password"></asp:TextBox>
                </td>
                 </tr>
            <tr>
                <td class="tdTexto30">
                    * Ventanilla: &nbsp;
                </td>   
                <td class="tdTexto70">
                            <asp:DropDownList ID="DropDownListVentanillas" runat="server" DataSourceID="SqlDataSource1" DataTextField="Ventanilla" DataValueField="Ventanilla">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TurnosConnectionString %>" SelectCommand="SELECT [Ventanilla] FROM [Ventanillas]"></asp:SqlDataSource>
                </td>
                 </tr>
            </table>
    </asp:Panel>
    <asp:Panel ID="PanelAceptarCancelar" runat="server">
         <asp:Label ID="LabelPrueba" runat="server"></asp:Label>
         <asp:ImageButton ID="ImgAceptarAgregar" runat="server" AlternateText="Aceptar" CausesValidation="False" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnAceptar.gif" OnClick="ImgAceptarAgregar_Click" ToolTip="Aceptar" />
        <asp:ImageButton ID="ImgCancelarAgregar" runat="server" AlternateText="Cancelar" CausesValidation="False" CommandName="Cancel" CssClass="ImgMenuPrincipal" ImageUrl="~/Imagenes/BtnCancelar.gif" OnClick="ImgCancelarAgregar_Click" ToolTip="Cancelar"  />
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphAnuncios" Runat="Server">
</asp:Content>

