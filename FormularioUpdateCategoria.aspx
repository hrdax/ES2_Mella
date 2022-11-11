<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioUpdateCategoria.aspx.cs" Inherits="ES2_Mella.FormularioUpdateCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Formulario Editar Categoría<asp:Label ID="txtIDC" runat="server" Text="Label" Visible="False"></asp:Label>
    </h1>
    Nombre:
<asp:TextBox ID="TUpdateNombreCategoria" runat="server"></asp:TextBox>
    <br />
    <p>
        <asp:Button ID="B_Editar_Categoria" runat="server" Text="Editar" OnClick="B_Editar_Categoria_Click" />
    </p>

</asp:Content>
