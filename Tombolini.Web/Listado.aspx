<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Tombolini.Web.Listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado</title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Clave" DataField="Clave" />
                <asp:BoundField HeaderText="EMail" DataField="Email" />
                <asp:BoundField HeaderText="Tipo Usuario" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Ultimo Ingreso" DataField="UltimoIngreso" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </asp:Panel>
    </form>
</body>
</html>
