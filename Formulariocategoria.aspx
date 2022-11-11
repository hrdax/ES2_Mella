<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Formulariocategoria.aspx.cs" Inherits="ES2_Mella.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Formulario categoría</h1>
    Nombre:
<asp:TextBox ID="TNombreCategoria" runat="server"></asp:TextBox>
    <p>
        <asp:Button ID="BRegistrarcategoria" runat="server" Text="Registrar" OnClick="BRegistrarCategoria" />
    </p>

</asp:Content>
