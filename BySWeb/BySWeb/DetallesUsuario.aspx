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
              Nick:&nbsp;
              <asp:TextBox ID="TextBox10" runat="server" Width="170px" Value="LatinLover69"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="TextBox12" runat="server" Width="166px" Value="tugatito@hhh.com"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Localidad:
                  <asp:TextBox ID="TextBox15" runat="server" Width="166px" Value="Puerto Parranda"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Puntuación:
                  <asp:TextBox ID="TextBox14" runat="server" Width="34px" Value="-10"></asp:TextBox>
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
            Width="309px" ImageUrl="~/images/popeye.jpg" style="margin-left: 61px" />
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp;COMENTARIOS:</strong></p> </br>
        <div class="comentario">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <a href="/DetallesUsuario.aspx">Perico90</a>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <a href="/Producto.aspx">Llantas robadas</a>
        &nbsp;&nbsp; Puntuación:&nbsp;<asp:TextBox ID="TextBox18" 
            runat="server" Width="34px" Value="10"></asp:TextBox>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox19" runat="server" Height="100px" Width="700px" style="margin-left:20px" Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        </div>
                <div class="comentario">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <a href="/DetallesUsuario.aspx">Perico90</a>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <a href="/Producto.aspx">Llantas robadas</a>
        &nbsp;&nbsp; Puntuación:&nbsp;<asp:TextBox ID="TextBox1" 
            runat="server" Width="34px" Value="10"></asp:TextBox>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox2" runat="server" Height="100px" Width="700px" style="margin-left:20px" Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        </div>
                <div class="comentario">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <a href="/DetallesUsuario.aspx">Perico90</a>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <a href="/Producto.aspx">Llantas robadas</a>
        &nbsp;&nbsp; Puntuación:&nbsp;<asp:TextBox ID="TextBox3" 
            runat="server" Width="34px" Value="10"></asp:TextBox>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox4" runat="server" Height="100px" Width="700px" style="margin-left:20px" Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        </div>
    </asp:Content>

