<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioUpdateProducto.aspx.cs" Inherits="ES2_Mella.FormularioUpdateProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Editar Producto<asp:Label ID="txtID" runat="server" Text="Label" Visible="False"></asp:Label>
    </h1>
<p>Nombre:
    <asp:TextBox ID="TxtUpdateNombreProducto" runat="server"></asp:TextBox>
</p>
<p>Precio:&nbsp;&nbsp;
    <asp:TextBox ID="TxtUpdatePrecioProducto" runat="server" Width="127px"></asp:TextBox>
</p>
<p>Categoría:
    <asp:DropDownList ID="ListaUpdatecategoriasProducto" runat="server">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="B_Editar" runat="server" Text="Editar" OnClick="B_Editar_Click" />
</p>

</asp:Content>
