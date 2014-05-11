<%@ Page Title="Detalles de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiProducto.aspx.cs" Inherits="BySWeb.DetallesUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="DetalleUsuario" ContentPlaceHolderID="PlaceholderSidebar" 
    runat="server">
    &nbsp;<h2 class="style2">
        <strong>Ultimos articulos</strong></h2>
    <a href="">
    <div>
        <p>
            Ultimos articulos <q class="precioUltimos">0,00<q>€</q></q>
        </p>
    </div>
    <div>
        <p>
            Ultimos articulos <q class="precioUltimos">0,00<q>€</q></q>
        </p>
    </div>
    <div>
        <p>
            Ultimos articulos <q class="precioUltimos">0,00<q>€</q></q></p>
    </div>
    </a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  
    <p class="style1" style="font-size: xx-large; font-family: Arial">
        &nbsp;&nbsp;&nbsp;Información Personal</p>

          <div style="float: right; height: 309px; width: 345px; margin-top: 1px;">

          <p style="width: 99%">
              Nombre:&nbsp;
              <asp:TextBox ID="TextBox10" runat="server" Width="170px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Apellidos:
                  <asp:TextBox ID="TextBox11" runat="server" Width="168px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="TextBox12" runat="server" Width="166px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Localidad:
                  <asp:TextBox ID="TextBox15" runat="server" Width="166px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Puntuación:
                  <asp:TextBox ID="TextBox14" runat="server" Width="34px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  &nbsp;</p>
              <p style="width: 100%">
                  &nbsp;</p>
              <br />
              <br />
    </div>
    <div style="float: left;">
        <asp:Image ID="Image1" runat="server" BorderColor="#666666" Height="252px" 
            Width="309px" ImageUrl="~/alquiler_barcos.jpg" style="margin-left: 61px" />
    </div>
    <p>
        &nbsp;</p>
 <p>
&nbsp;&nbsp;
        
        <br />
        <br />
        
        </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp;COMENTARIOS:</strong></p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <asp:TextBox ID="TextBox16" runat="server" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Producto:
              <asp:TextBox ID="TextBox17" runat="server" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Puntuación:&nbsp;<asp:TextBox ID="TextBox18" 
            runat="server" Width="34px"></asp:TextBox>
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox19" runat="server" Height="100px" Width="787px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
    </asp:Content>

