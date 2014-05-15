<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BySWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
    <div style="min-height: 970px">

    <h2 class = "tituloh2">Productos destacados</h2>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados1" runat="server" ImageUrl="~/images/bic.jpg" />

        <h3><asp:Label ID="Label1" runat="server" Text="Label">Boligrafo Bic, de los buenos</asp:Label></h3>

        <p><asp:Label ID="precioDestacados1" runat="server" Text="Label">2.27 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados2" runat="server" ImageUrl="~/images/casco.jpeg" />

        <h3><asp:Label ID="Label2" runat="server" Text="Label">Casco integral ortera</asp:Label></h3>

        <p><asp:Label ID="precioDestacados2" runat="server" Text="Label">57.50 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados3" runat="server" ImageUrl="~/images/cascos.jpg" />

        <h3><asp:Label ID="Label3" runat="server" Text="Label">Steelseries Icemat Siberia V2 Negros</asp:Label></h3>

        <p><asp:Label ID="precioDestacados3" runat="server" Text="Label">34.76 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados4" runat="server" ImageUrl="~/images/puerros.jpg" />

        <h3><asp:Label ID="Label4" runat="server" Text="Label">Puerros de la huerta</asp:Label></h3>

        <p><asp:Label ID="precioDestacados4" runat="server" Text="Label">1.44 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados5" runat="server" ImageUrl="~/images/entrada.JPG" />

        <h3><asp:Label ID="Label5" runat="server" Text="Label">Entrada TomorrowLand 2014 Maletin</asp:Label></h3>

        <p><asp:Label ID="precioDestacados5" runat="server" Text="Label">1367.99 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados6" runat="server" ImageUrl="~/images/mac.jpg" />

        <h3><asp:Label ID="Label6" runat="server" Text="Label">Pisapapeles muy caro</asp:Label></h3>

        <p><asp:Label ID="precioDestacados6" runat="server" Text="Label">1102.29 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados7" runat="server" ImageUrl="~/images/mechon.jpg" />

        <h3><asp:Label ID="Label7" runat="server" Text="Label">Mechon de pelo de Megan Fox</asp:Label></h3>

        <p><asp:Label ID="precioDestacados7" runat="server" Text="Label">34980.50 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados8" runat="server" ImageUrl="~/images/popeye.jpg" />

        <h3><asp:Label ID="Label8" runat="server" Text="Label">Embarcacion recreativa de lujo para bañera</asp:Label></h3>

        <p><asp:Label ID="precioDestacados8" runat="server" Text="Label">3.13 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados9" runat="server" ImageUrl="~/images/sartenes.jpg" />

        <h3><asp:Label ID="Label9" runat="server" Text="Label">Sartenes de ceramica marca Gayer</asp:Label></h3>

        <p><asp:Label ID="precioDestacados9" runat="server" Text="Label">45.80 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados10" runat="server" ImageUrl="~/images/Tgrafica.jpg" />

        <h3><asp:Label ID="Label10" runat="server" Text="Label">AMD Radeon R9-295x2 de Review</asp:Label></h3>

        <p><asp:Label ID="precioDestacados10" runat="server" Text="Label">1590.54 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados11" runat="server" ImageUrl="~/images/travelo.jpg" />

        <h3><asp:Label ID="Label11" runat="server" Text="Label">Concierto privado de mujer barbuda</asp:Label></h3>

        <p><asp:Label ID="precioDestacados11" runat="server" Text="Label">0.00 €</asp:Label></p>
    </div></a>


    <a href = "/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenDestacados12" runat="server" ImageUrl="~/images/washer.jpg" />

        <h3><asp:Label ID="Label12" runat="server" Text="Label">Lavadora portal alternativo a Narnia</asp:Label></h3>

        <p><asp:Label ID="precioDestacados12" runat="server" Text="Label">6.78 €</asp:Label></p>
    </div></a>


    </div>
</asp:Content>
