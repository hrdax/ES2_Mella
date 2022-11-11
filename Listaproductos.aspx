<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listaproductos.aspx.cs" Inherits="ES2_Mella.Listaproductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Productos</h1>
    <asp:GridView ID="Listaproductosver" runat="server" Height="97px" Width="885px" OnRowDeleting="Listaproductosver_RowDeleting" OnRowEditing="Listaproductosver_RowEditing" OnRowUpdating="Listaproductosver_RowUpdating">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Eliminar" ShowHeader="True" Text="Eliminar" />
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Editar" ShowHeader="True" Text="Editar" />
            <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Agregar al Carrito" ShowHeader="True" Text="A" />
        </Columns>
    </asp:GridView>
    
</asp:Content>
