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
    <asp:Repeater runat="server" ID="RPTproductosListados">
        <ItemTemplate>
            <asp:HyperLink ID="productoDestacado1" runat="server" NavigateUrl= '<%# string.Format("~/Producto.aspx?id={0}", ((BySLib.EN.ProductoEN)Container.DataItem).Id) %>' ><div class = "imgportada">
   
                <asp:Image ID="imagenDestacados1" runat="server" ImageUrl= '<%# string.Format("{0}",((BySLib.EN.ProductoEN)Container.DataItem).Fotos[0].Ruta) %>' />

                <!--"\" + </%# ((BySLib.EN.ProductoEN)Container.DataItem).Fotos[0].ruta %> + "\""-->

                <h3><asp:Label ID="nombreProDestacado1" runat="server"> <%# ((BySLib.EN.ProductoEN)Container.DataItem).Nombre %> </asp:Label></h3>

                <p><asp:Label ID="precioDestacados1" runat="server"><%# ((BySLib.EN.ProductoEN)Container.DataItem).Pujas %></asp:Label></p>
            </div></asp:HyperLink>
        </ItemTemplate>
    </asp:Repeater>

     <!--<asp:HyperLink ID="productoListado1" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
   
        <asp:Image ID="imagenListados1" runat="server" ImageUrl="~/images/bic.jpg" />

        <h3><asp:Label ID="nombreProListado1" runat="server" Text="Label">Boligrafo Bic, de los buenos</asp:Label></h3>

        <p><asp:Label ID="precioListados1" runat="server" Text="Label">2.27 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado2" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados2" runat="server" ImageUrl="~/images/casco.jpeg" />

        <h3><asp:Label ID="nombreProListado2" runat="server" Text="Label">Casco integral ortera</asp:Label></h3>

        <p><asp:Label ID="precioListados2" runat="server" Text="Label">57.50 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado3" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados3" runat="server" ImageUrl="~/images/cascos.jpg" />

        <h3><asp:Label ID="nombreProListado3" runat="server" Text="Label">Steelseries Icemat Siberia V2 Negros</asp:Label></h3>

        <p><asp:Label ID="precioListados3" runat="server" Text="Label">34.76 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado4" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados4" runat="server" ImageUrl="~/images/puerros.jpg" />

        <h3><asp:Label ID="nombreProListado4" runat="server" Text="Label">Puerros de la huerta</asp:Label></h3>

        <p><asp:Label ID="precioListados4" runat="server" Text="Label">1.44 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado5" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados5" runat="server" ImageUrl="~/images/entrada.JPG" />

        <h3><asp:Label ID="nombreProListado5" runat="server" Text="Label">Entrada TomorrowLand 2014 Maletin</asp:Label></h3>

        <p><asp:Label ID="precioListados5" runat="server" Text="Label">1367.99 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado6" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados6" runat="server" ImageUrl="~/images/mac.jpg" />

        <h3><asp:Label ID="nombreProListado6" runat="server" Text="Label">Pisapapeles muy caro</asp:Label></h3>

        <p><asp:Label ID="precioListados6" runat="server" Text="Label">1102.29 €</asp:Label></p>
    </div></asp:HyperLink>


   <asp:HyperLink ID="productoListado7" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados7" runat="server" ImageUrl="~/images/mechon.jpg" />

        <h3><asp:Label ID="nombreProListadol7" runat="server" Text="Label">Mechon de pelo de Megan Fox</asp:Label></h3>

        <p><asp:Label ID="precioListados7" runat="server" Text="Label">34980.50 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado8" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados8" runat="server" ImageUrl="~/images/popeye.jpg" />

        <h3><asp:Label ID="nombreProListado8" runat="server" Text="Label">Embarcacion recreativa de lujo para bañera</asp:Label></h3>

        <p><asp:Label ID="precioListados8" runat="server" Text="Label">3.13 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado9" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados9" runat="server" ImageUrl="~/images/sartenes.jpg" />

        <h3><asp:Label ID="nombreProListado9" runat="server" Text="Label">Sartenes de ceramica marca Gayer</asp:Label></h3>

        <p><asp:Label ID="precioListados9" runat="server" Text="Label">45.80 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productListado10" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados10" runat="server" ImageUrl="~/images/Tgrafica.jpg" />

        <h3><asp:Label ID="nombreProListado10" runat="server" Text="Label">AMD Radeon R9-295x2 de Review</asp:Label></h3>

        <p><asp:Label ID="precioListados10" runat="server" Text="Label">1590.54 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado11" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados11" runat="server" ImageUrl="~/images/travelo.jpg" />

        <h3><asp:Label ID="nombreProListado11" runat="server" Text="Label">Concierto privado de mujer barbuda</asp:Label></h3>

        <p><asp:Label ID="precioListados11" runat="server" Text="Label">0.00 €</asp:Label></p>
    </div></asp:HyperLink>


    <asp:HyperLink ID="productoListado12" runat="server" NavigateUrl="~/Producto.aspx"><div class = "imgportada">
        <asp:Image ID="imagenListados12" runat="server" ImageUrl="~/images/washer.jpg" />

        <h3><asp:Label ID="nombreProListado12" runat="server" Text="Label">Lavadora portal alternativo a Narnia</asp:Label></h3>

        <p><asp:Label ID="precioListados12" runat="server" Text="Label">6.78 €</asp:Label></p>
    </div></asp:HyperLink> -->
    <div style="height: 30px;">1&nbsp;<a href="">2</a>&nbsp;<a href="">3</a>&nbsp;<a href="">4</a>&nbsp;<a href="">5</a>&nbsp;<a href="">6</a>&nbsp;<a href="">7</a>&nbsp;<a href="">8</a>&nbsp;<a href="">6</a>&nbsp;<a href="">9</a>&nbsp;<a href="">10</a>&nbsp;<a href="">>></a>&nbsp;</div>
    </div>
    </asp:Content>
