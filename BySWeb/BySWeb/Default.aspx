<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BySWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    
    <h2 class = "tituloh2">
        Ultimos Articulos
    </h2>
    <ul>
    <li><p><a href = "/Producto.aspx">Pecera </a>
        <q class = "precioUltimos">0,00 €</q>
    </p></li>
    <li><p><a href = "/Producto.aspx">Pecera con peces </a>
        <q class = "precioUltimos">0,00 €</q>
    </p></li>

    <li><p><a href = "/Producto.aspx"> Ejemplo 3 </a>
        <q class = "precioUltimos">0,00 €</q>
    </p></li>
        <li><p><a href = "/Producto.aspx">Pecera con peces </a>
        <q class = "precioUltimos">0,00 €</q>
    </p></li>
        <li><p><a href = "/Producto.aspx">Pecera con peces </a>
        <q class = "precioUltimos">0,00 €</q>
    </p></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="min-height: 970px">
    <h2 class = "tituloh2">Productos destacados</h2>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/bic.jpg" alt="Alternate Text" />
        <h3>Boligrafo Bic, de los buenos</h3>
        <p class = "precioPortadas">
            <q>2,27 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/casco.jpeg" alt="Alternate Text" />
        <h3>Casco integral ortera</h3>
        <p class = "precioPortadas">
            <q>57,50 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/cascos.jpg" alt="Alternate Text" />
        <h3 >Steelseries Icemat Siberia V2 Negros</h3>
        <p class = "precioPortadas">
            <q>34,76 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/puerros.jpg" alt="Alternate Text" />
        <h3 >Puerros de la huerta</h3>
        <p class = "precioPortadas">
            <q>1,44 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/entrada.jpg" alt="Alternate Text" />
        <h3 >Entrada TomorrowLand 2014 Maletin</h3>
        <p class = "precioPortadas">
            1367,99<q>€</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/mac.jpg" alt="Alternate Text" />
        <h3>Pisapapeles muy caro</h3>
        <p class = "precioPortadas">
            <q>1102,23 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/mechon.jpg" alt="Alternate Text" />
        <h3 >Pelo de Megan Fox</h3>
        <p class = "precioPortadas">
            <q>34980,50 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/popeye.jpg" alt="Alternate Text" />
        <h3>Embarcacion recreativa de lujo para bañera</h3>
        <p class = "precioPortadas">
            <q>3,13 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/sartenes.jpg" alt="Alternate Text" />
        <h3>Sartenes de ceramica marca Gayer</h3>
        <p class = "precioPortadas">
            <q>21,30 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/Tgrafica.jpg" alt="Alternate Text" />
        <h3>AMD Radeon R9-295x2 de Review</h3>
        <p class = "precioPortadas">
            <q>1098,45 €</q>
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/travelo.jpg" alt="Alternate Text" />
        <h3>Concierto privado de mujer barbuda</h3>
        <p class = "precioPortadas">
            No hay pujas
        </p>
    </div></a>
    <a href = "/Producto.aspx"><div class = "imgportada">
        <img src="images/washer.jpg" alt="Alternate Text" />
        <h3>Lavadora portal alternativo a Narnia</h3>
        <p class = "precioPortadas">
            <q>6,79 €</q>
        </p>
    </div></a>
    </div>
</asp:Content>
