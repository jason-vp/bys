<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BySWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    <div _designerregion="0">
        Ordenar por:
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" 
            style="margin-left: 0px" Width="139px">
            <asp:ListItem>Relevancia</asp:ListItem>
            <asp:ListItem>Precio</asp:ListItem>
            <asp:ListItem>Tiempo</asp:ListItem>
            <asp:ListItem>Ascendente</asp:ListItem>
            <asp:ListItem>Descendente</asp:ListItem>
        </asp:DropDownList>
        <br />
        <p>Filtrar por:</p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="151px">
            <asp:ListItem>Nuevo con etiquetas</asp:ListItem>
            <asp:ListItem>Nuevo sin etiquetas</asp:ListItem>
            <asp:ListItem>Nuevo con defectos</asp:ListItem>
            <asp:ListItem>Usado</asp:ListItem>
            <asp:ListItem>Sin especificar</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Filtrar" style="margin: auto"/>
        <br />
        <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="min-height: 1100px">
    <h2 class = "tituloh2">Resultados de: </h2>
    <div style="height: 30px;">
    <p>Buscar por:&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Text1" type="text" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Buscar" />
        </p>
    </div>
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
    <div style="height: 30px;">1&nbsp;<a href="">2</a>&nbsp;<a href="">3</a>&nbsp;<a href="">4</a>&nbsp;<a href="">5</a>&nbsp;<a href="">6</a>&nbsp;<a href="">7</a>&nbsp;<a href="">8</a>&nbsp;<a href="">6</a>&nbsp;<a href="">9</a>&nbsp;<a href="">10</a>&nbsp;<a href="">>></a>&nbsp;</div>
    </div>
    </asp:Content>
