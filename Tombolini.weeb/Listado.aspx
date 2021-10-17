<%@ Page Title="Listado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Tombolini.weeb.Listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Clave" DataField="Clave" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Tipo Persona" DataField="TipoUsuario" />
                <asp:BoundField HeaderText="Ultimo Ingreso" DataField="UltimoIngreso" />
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
