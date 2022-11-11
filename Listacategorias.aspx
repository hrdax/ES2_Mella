<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listacategorias.aspx.cs" Inherits="ES2_Mella.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Categorías</h1>
    <asp:GridView ID="dvgcategoria" runat="server" Width="907px" OnRowDeleting="dvgcategoria_RowDeleting" OnRowEditing="dvgcategoria_RowEditing">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Eliminar" ShowHeader="True" Text="Eliminar" />
            <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Editar" ShowHeader="True" Text="Editar" />
        </Columns>
    </asp:GridView>

</asp:Content>
