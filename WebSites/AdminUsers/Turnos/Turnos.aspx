<%@ Page Title="" Language="C#" MasterPageFile="~/Turnos/Turnos.master" AutoEventWireup="true" CodeFile="Turnos.aspx.cs" Inherits="Turnos_Turnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphnavmenus" Runat="Server">
    <p>
        USUARIO:<asp:Label ID="LabelUsuario" runat="server"></asp:Label>
&nbsp;VENTANILLA:
        <asp:Label ID="LabelVentanilla" runat="server" Text=""></asp:Label>
&nbsp;&nbsp;</p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphPrincipal" Runat="Server">
    <asp:Panel ID="PanelGridViewTurnos" runat="server">
        <asp:UpdatePanel ID="UpdatePanelGridViewTurnos" runat="server">
            <ContentTemplate>
                <br />
                <br />
                <asp:Button ID="ButtonSiguienteTurno" runat="server" OnClick="ButtonSiguienteTurno_Click" Text="Next" />
        <asp:GridView ID="GridViewListadoTurnos" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="333px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="Turno" HeaderText="Turno" />
                <asp:BoundField DataField="Ventanilla" HeaderText="Ventanilla" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Label ID="LabelTurnoActual" runat="server"></asp:Label>
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
        &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphAnuncios" Runat="Server">
</asp:Content>

