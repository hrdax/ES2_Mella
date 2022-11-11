<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formularioproducto.aspx.cs" Inherits="ES2_Mella.Formularioproducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Formulario producto</h1>
<p>Nombre:
    <asp:TextBox ID="TxtNombreProducto" runat="server"></asp:TextBox>
</p>
<p>Precio:&nbsp;&nbsp;
    <asp:TextBox ID="TxtPrecioProducto" runat="server" Width="127px"></asp:TextBox>
</p>
<p>Categoría:
    <asp:DropDownList ID="ListacategoriasProducto" runat="server">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="BRegistrarProducto" Text="Registrar" />
</p>

</asp:Content>
