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
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    
    <h2 class = "tituloh2">
        Ultimos Articulos
    </h2>
    <ul>
    <li><p><a href = "/Producto.aspx"><asp:Label ID="nombreUltimoProducto1" runat="server" Text="Label">Pecera</asp:Label></a>
        <asp:Label ID="precioUltimoProducto1" runat="server" Text="Label">0,00 €</asp:Label>
    </p></li>
    <li><p><a href = "/Producto.aspx"><asp:Label ID="nombreUltimoProducto2" runat="server" Text="Label">Algo raro que había por casa</asp:Label></a>
        <asp:Label ID="precioUltimoProducto2" runat="server" Text="Label">0,00 €</asp:Label>
    </p></li>
    <li><p><a href = "/Producto.aspx"><asp:Label ID="nombreUltimoProducto3" runat="server" Text="Label">Experimento 23</asp:Label></a>
        <asp:Label ID="precioUltimoProducto3" runat="server" Text="Label">0,00 €</asp:Label>
    </p></li>
        <li><p><a href = "/Producto.aspx"><asp:Label ID="nombreUltimoProducto4" runat="server" Text="Label">Pecera con peces</asp:Label></a>
        <asp:Label ID="precioUltimoProducto4" runat="server" Text="Label">0,00 €</asp:Label>
    </p></li>
        <li><p><a href = "/Producto.aspx"><asp:Label ID="nombreUltimoProducto5" runat="server" Text="Label">Pecera con peces muertos</asp:Label></a>
        <asp:Label ID="precioUltimoProducto5" runat="server" Text="Label">0,00 €</asp:Label>
    </p></li>
    </ul>
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
                  <strong><asp:Label ID="Label1" runat="server" Text="-10"></asp:Label></strong>
        </p>
              <p style="width: 100%">
                  &nbsp;</p>
              <p style="width: 100%">
                  &nbsp;</p>
              <br />
              <br />
    </div>
    <div style="float: left;">
        <asp:Image ID="UserLogo" runat="server" BorderColor="#666666" Height="252px" 
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

