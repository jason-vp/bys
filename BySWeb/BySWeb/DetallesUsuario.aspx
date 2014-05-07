<%@ Page Title="Detalles de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetallesUsuario.aspx.cs" Inherits="BySWeb.DetallesUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="DetalleUsuario" ContentPlaceHolderID="PlaceholderSidebar" 
    runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" BorderColor="#666666" Height="65px" 
            Width="79px" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp; INFORMACION &nbsp;PERSONAL</p>
    <p dir="ltr">
        Nombre&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox7" runat="server" Width="191px"></asp:TextBox>
    </p>
    <p dir="ltr">
       Apellidos&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-top: 5px" Width="191px"></asp:TextBox>
    </p>
    <p dir="ltr">
        Email&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 19px" 
            Width="191px"></asp:TextBox>
    </p>
    <p dir="ltr">
        Pais&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Alemania</asp:ListItem>
            <asp:ListItem>Austria</asp:ListItem>
            <asp:ListItem>Bélgica</asp:ListItem>
            <asp:ListItem>Bulgaria</asp:ListItem>
            <asp:ListItem>Chipre</asp:ListItem>
            <asp:ListItem>Croacia</asp:ListItem>
            <asp:ListItem>Dinamarca</asp:ListItem>
            <asp:ListItem>Eslovaquia</asp:ListItem>
            <asp:ListItem>Eslovenia</asp:ListItem>
            <asp:ListItem>España</asp:ListItem>
            <asp:ListItem>Estonia</asp:ListItem>
            <asp:ListItem>Finlandia</asp:ListItem>
            <asp:ListItem>Francia</asp:ListItem>
            <asp:ListItem>Grecia</asp:ListItem>
            <asp:ListItem>Hungria</asp:ListItem>
            <asp:ListItem>Irlanda</asp:ListItem>
            <asp:ListItem>Italia</asp:ListItem>
            <asp:ListItem>Letonia</asp:ListItem>
            <asp:ListItem>Lituania</asp:ListItem>
            <asp:ListItem>luxemburgo</asp:ListItem>
            <asp:ListItem>Malta</asp:ListItem>
            <asp:ListItem>Países Bajos</asp:ListItem>
            <asp:ListItem>Polonia</asp:ListItem>
            <asp:ListItem>Portugal</asp:ListItem>
            <asp:ListItem>Reino Unido</asp:ListItem>
            <asp:ListItem>República Checa</asp:ListItem>
            <asp:ListItem>Rumania</asp:ListItem>
            <asp:ListItem>Suecia</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p dir="ltr">
        Localidad&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox4" runat="server" style="margin-bottom: 0px" 
            Width="191px"></asp:TextBox>
    </p>
    <p dir="ltr">
        Puntuación Usuario&nbsp; 
        <asp:TextBox ID="TextBox5" runat="server" Width="87px"></asp:TextBox>
    </p>
    <p dir="ltr">
        Comentarios&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBox6" runat="server" Height="121px" Width="843px"></asp:TextBox>
        <br />
    </p>
    <p dir="ltr">
        &nbsp;</p>
    <p dir="ltr">
&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p dir="ltr">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Enviar" />
    </p>
    <p dir="ltr">
        &nbsp;</p>
    <p dir="ltr">
        &nbsp;</p>
</asp:Content>
