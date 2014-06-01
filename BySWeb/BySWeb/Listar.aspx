<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="BySWeb.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    <div _designerregion="0">
            <h3>Ver</h3> 
            <p>
                <asp:RadioButton ID="rbPujas" GroupName="gnVer" Text="Mis Pujas" runat="server">
                </asp:RadioButton></br>
                <asp:RadioButton ID="rbCompras" GroupName="gnVer" Text="Mis Compras" runat="server">
                </asp:RadioButton></br>
                <asp:RadioButton ID="rbMisProductos" GroupName="gnVer" Text="Mis Productos" runat="server">
                </asp:RadioButton>
                </br>
                <asp:Button ID="btVer" runat="server" Text="Ver" onclick="btVer_Click" />
                </br>
                <asp:Label ID="lbSide" runat="server"></asp:Label>
</p>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="min-height: 1100px">
    <h2 class = "tituloh2">Resultados de: <asp:Label ID="lbBusqueda" runat="server"></asp:Label></h2>
    <div style="height: 30px;">
    <p>Buscar por: &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbBuscar" runat="server"></asp:TextBox>&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Ver" Value="Ver" onclick="Button2_Click" />
        </p>
    </div>
    <asp:Label ID="lbError" runat="server"></asp:Label>
    <asp:Repeater runat="server" ID="RPTproductosListados">
        <ItemTemplate>
            <asp:HyperLink ID="productoDestacado1" runat="server" NavigateUrl= '<%# string.Format("~/Producto.aspx?id={0}", ((BySLib.EN.ProductoEN)Container.DataItem).Id) %>' ><div class = "imgportada">
   
                <asp:Image ID="imagenDestacados1" runat="server" ImageUrl= '<%# string.Format("{0}",((BySLib.EN.ProductoEN)Container.DataItem).Foto ) %>' />

                <h3><asp:Label ID="nombreProDestacado1" runat="server"> <%# ((BySLib.EN.ProductoEN)Container.DataItem).Nombre %> </asp:Label></h3>

                <p><asp:Label ID="precioDestacados1" runat="server"><%# ((BySLib.EN.ProductoEN)Container.DataItem).PrecioSalida %></asp:Label></p>
            </div></asp:HyperLink>
        </ItemTemplate>
    </asp:Repeater>

    <asp:Panel ID="PagingPanel" runat="server" style="width: 500px"></asp:Panel>
    
    </div>
    </asp:Content>
