<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Registro.aspx.cs" Inherits="BySWeb.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            font-size: large;
            color: #003399;
        }
        .style3
        {
            font-size: large;
            color: #000099;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    <asp:Panel ID="PnlError" runat="server" Visible="false">
        <asp:Label ID="lbError" runat="server"></asp:Label>
    </asp:Panel>
    <p class="style2">
        <strong>Datos de usuario</strong><p>
        Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_Usuario" runat="server"></asp:TextBox>
    </p>
    <p>
        Contraseña:&nbsp;
        <asp:TextBox ID="TextB_Contraseña" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Repite contraseña:&nbsp;
        <asp:TextBox ID="TextB_RepiteContra" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_mail" runat="server" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        Avatar:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_avatar" runat="server" TextMode="Url"></asp:TextBox>
        &nbsp;
    </p>
    <p class="style3">
        <strong>Datos personales</strong></p>
    <p>
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_Nombre" runat="server"></asp:TextBox>
    </p>
    <p>
        Sexo:&nbsp;
        <asp:RadioButton ID="RadioButtonHombre" runat="server" Text="Hombre" />
        &nbsp;
        <asp:RadioButton ID="RadioButtonMujer" runat="server" Text="Mujer" />
        &nbsp;&nbsp;&nbsp;&nbsp; Fecha de nacimiento:&nbsp;
        <asp:TextBox ID="TextB_FNac" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p>
        Provincia:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_provincia" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Localidad:&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextB_Localidad" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CP:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_CP" runat="server" OnTextChanged="TextB_CP_TextChanged" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        Dirección:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nº:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_num" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Piso:&nbsp;
        <asp:TextBox ID="TextB_Piso" runat="server"></asp:TextBox>
    </p>
    <p>
        Teléfono:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_tlf" runat="server"></asp:TextBox>
    </p>
    <p class="style1">
        <asp:Button ID="Button_Enviar" runat="server" OnClick="Button_Enviar_Click" Text="Enviar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="Reset" /></p>
    </asp:Content>
