<%@ Page Title="Detalles de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiProducto.aspx.cs" Inherits="BySWeb.DetallesUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    
    <h2 class = "tituloh2">
        Ultimos Articulos
    </h2>
    <ul>
        <li><p><asp:HyperLink ID="ultimoProducto1" runat="server"><asp:Label ID="nombreUltimoProducto1" runat="server" Text="Label">Pecera</asp:Label></asp:HyperLink>
            <asp:Label ID="precioUltimoProducto1" runat="server" Text="Label">0,00 €</asp:Label>
            </p>
        </li>

        <li>
            <p><asp:HyperLink ID="ultimoProducto2" runat="server"><asp:Label ID="nombreUltimoProducto2" runat="server" Text="Label">Algo raro que había por casa</asp:Label></asp:HyperLink>
                <asp:Label ID="precioUltimoProducto2" runat="server" Text="Label">0,00 €</asp:Label>
            </p>
        </li>

        <li>
            <p><asp:HyperLink ID="ultimoProducto3" runat="server"><asp:Label ID="nombreUltimoProducto3" runat="server" Text="Label">Experimento 23</asp:Label></asp:HyperLink>
                <asp:Label ID="precioUltimoProducto3" runat="server" Text="Label">0,00 €</asp:Label>
            </p>
        </li>

        <li>
            <p><asp:HyperLink ID="ultimoProducto4" runat="server"><asp:Label ID="nombreUltimoProducto4" runat="server" Text="Label">Pecera con peces</asp:Label></asp:HyperLink>
                <asp:Label ID="precioUltimoProducto4" runat="server" Text="Label">0,00 €</asp:Label>
            </p>
        </li>

        <li>
            <p><asp:HyperLink ID="ultimoProducto5" runat="server"><asp:Label ID="nombreUltimoProducto5" runat="server" Text="Label">Pecera con peces muertos</asp:Label></asp:HyperLink>
                <asp:Label ID="precioUltimoProducto5" runat="server" Text="Label">0,00 €</asp:Label>
            </p>
        </li>
    </ul>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  
    <p class="style1" style="font-size: xx-large; font-family: Arial">
        &nbsp;&nbsp;&nbsp;Información Personal</p>

          <div style="float: right; height: 309px; width: 345px; margin-top: 1px;">

          <p style="width: 99%">
              Nick:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="nickDetUsuario" runat="server" Text="LatinLover69"></asp:Label>
        </p>
              <p style="width: 100%">
                  Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  <asp:Label ID="emailDetUsuario" runat="server" Text="tugatito@hhh.com"></asp:Label>
        </p>
              <p style="width: 100%">
                 Localidad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="localidadDetUsuario" runat="server" Text="Puerto Parranda"></asp:Label>
        </p><p style="width: 100%">
                  Puntuación:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><asp:Label ID="puntuacionDetallesUsuario" runat="server" Text="-10"></asp:Label></strong>
        </p>
              
              <p style="width: 100%">
                  &nbsp;</p>
              <p style="width: 100%">
                  &nbsp;</p>
              <br />
              <br />
    </div>
    <div style="float: left;">
        <asp:Image ID="userLogo" runat="server" BorderColor="#666666" Height="252px" 
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
            ID="TextBox20" runat="server" Height="100px" Width="700px" 
                    style="margin-left:20px" 
                    Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
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
        &nbsp;&nbsp; Puntuación:&nbsp;<asp:TextBox ID="TextBox30" 
            runat="server" Width="34px" Value="10"></asp:TextBox>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox21" runat="server" Height="100px" Width="700px" 
                    style="margin-left:20px" 
                    Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        </div>
    </asp:Content>

