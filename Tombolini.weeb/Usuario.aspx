<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Tombolini.weeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de usuario"></asp:Label>
        <br />
        <asp:TextBox ID="txtNomUsu" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel2" Visible="false" runat="Server">
        <asp:Label runat="server" Text="Nombre Usuario:"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="lblNomUsu" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Clave"></asp:Label>
        :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblClave" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="EMail:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Tipo Usuario:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblTipoUsu" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Ultimo Ingreso:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblUltIng" runat="server"></asp:Label>

    </asp:Panel>
</asp:Content>
