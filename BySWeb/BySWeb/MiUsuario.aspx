<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiUsuario.aspx.cs" Inherits="BySWeb.MiUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: 1.5em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    <p>
        Mis Pujas</p>
    <p>
        -
        <asp:HyperLink ID="HyperLink3" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink4" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink5" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink6" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink7" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Mis Productos</p>
    <p>
        -
        <asp:HyperLink ID="HyperLink8" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink9" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink10" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink11" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        -
        <asp:HyperLink ID="HyperLink12" runat="server">HyperLink</asp:HyperLink>
&nbsp;<asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style1">
        <strong>DATOS PERSONALES</strong></p>
    <div style="text-align: right; margin-left: 678px; height: 22px;">
        <img alt="" src="" style="height: 100px" /></div>
    <p>
        <strong>Nombre&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="Nombre" runat="server" Width="350px"></asp:TextBox>
        </strong>
    </p>
    <p>
        <strong>Sexo</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:RadioButton 
            ID="Hombre" runat="server" Checked="True" GroupName="Sexo" Text="Hombre" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="Mujer" runat="server" 
            GroupName="Sexo" Text="Mujer" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <strong>Fecha de Nacimiento&nbsp;&nbsp; &nbsp; 
        <asp:TextBox ID="Fecha_Nac" runat="server" TextMode="Date" Width="150px"></asp:TextBox>
        </strong></p>
    <p>
        <strong>Direccion
        </strong>&nbsp;
        <asp:TextBox ID="Direccion" runat="server" Width="300px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>Nº</strong>&nbsp;&nbsp; <asp:TextBox ID="Num" 
            runat="server" Width="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <strong>Piso</strong>&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Piso" 
            runat="server" Width="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <strong>Provincia</strong>&nbsp;&nbsp;
        <asp:TextBox ID="Provincia" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <strong>Localidad</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Localidad" runat="server"></asp:TextBox>
&nbsp;&nbsp; <strong>C.P.</strong>&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="CP" 
            runat="server" Width="75px"></asp:TextBox>
    </p>
    <p>
        <strong>Telefono</strong>&nbsp;&nbsp; 
        <asp:TextBox ID="Telefono" runat="server" 
            TextMode="Phone" Width="125px" style="margin-left: 3px"></asp:TextBox>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p class="style1">
        <strong>DETALLES DEL USUARIO</strong></p>
    <p>
        <strong>Usuario&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="Usuario" 
            runat="server" Width="100px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <strong>&nbsp;Email&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="Email" runat="server" TextMode="Email" Width="150px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp; <strong>Puntuacion Usuario&nbsp;&nbsp;&nbsp;&nbsp; </strong> 
        <asp:TextBox ID="Puntuacion" runat="server" TextMode="Number" Width="50px"></asp:TextBox>
    </p>
    <p>
        <strong>Contraseña Actual&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="Contraseña_Actual" runat="server" TextMode="Password" 
            Width="90px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>Nueva Contraseña</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Contraseña_Nueva" runat="server" TextMode="Password" 
            Width="90px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;Repite Contraseña</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Contreseña_Nueva2" runat="server" TextMode="Password" 
            Width="90px"></asp:TextBox>
    </p>
    <p>
        <strong>Credito Actual&nbsp;&nbsp;&nbsp; </strong>&nbsp;<asp:TextBox 
            ID="Credito" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>Añadir Credito&nbsp;&nbsp;&nbsp;&nbsp; </strong>&nbsp;<asp:Button 
            ID="Boton_Añadir_Credito" runat="server" Text="Añadir" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Boton_Editar_Datos" runat="server" Text="Editar" 
            Width="100px" onclick="Boton_Editar_Datos_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Boton_Revertir_Datos" runat="server" Text="Descartar" 
            Width="100px" />
    </p>
    <asp:Panel ID="PnlError" runat="server" Visible="False">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
            ID="lbError" runat="server" style="text-align: center" Text="lbError"></asp:Label>
        &nbsp;</asp:Panel>
    <p class="style1">
        <strong>COMENTARIOS</strong></p>
    <p>
        Producto:
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
&nbsp;</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Height="83px" Width="748px" 
            TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        Producto:
        <asp:HyperLink ID="HyperLink2" runat="server">HyperLink</asp:HyperLink>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" Height="83px" Width="748px" 
            TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
