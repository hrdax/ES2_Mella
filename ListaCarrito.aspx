<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCarrito.aspx.cs" Inherits="ES2_Mella.ListaCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Carrito<asp:GridView ID="dvgcarro" runat="server" OnRowDeleting="dvgcarro_RowDeleting" Width="899px">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Eliminar" ShowHeader="True" Text="Eliminar" />
        </Columns>
        </asp:GridView>
    </h1>

</asp:Content>
