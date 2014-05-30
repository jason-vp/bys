<%@ Page Title="Mi Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiProducto.aspx.cs" Inherits="BySWeb.MiProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="MiProducto" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 450px;">
        <h2 class="tiuloh2">
            Producto</h2>
        <div style="float: left; width: 309px">
            <asp:Image ID="ImageProducto" runat="server" BorderColor="#666666" Height="252px"
                Width="309px" ImageUrl="/images/popeye.jpg" Style="margin-left: 61px" />
            <asp:FileUpload ID="FileUpload1" runat="server" Style="margin-left: 41px" /></div>
        <div style="float: right; height: 309px; width: 345px; margin-top: 1px;">
            <p style="width: 99%">
                Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbNombreProducto" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="width: 100%">
                Descripcion:&nbsp;</p>
            <p style="width: 100%">
                &nbsp;<asp:TextBox ID="tbDescripcion" runat="server" 
                    Width="319px" Height="93px" TextMode="MultiLine"></asp:TextBox>
            </p>
            <p style="width: 100%">
                Precio salida:
                <asp:TextBox ID="tbPrecioSalida" runat="server" Width="116px"></asp:TextBox>
                &nbsp;€</p>
            <p style="width: 100%">
                <asp:CheckBox ID="chkCompraInmediata" runat="server" Text="Compra Inmediata" TextAlign="Left" />
                &nbsp;Precio:
                <asp:TextBox ID="tbCompra" runat="server" Style="margin-left: 20px" Width="56px"></asp:TextBox>
                &nbsp;€</p>
            <p style="width: 100%">
                Cantidad:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbCantidadRestante" runat="server" Width="24px"></asp:TextBox>
            </p>
            <p style="width: 100%">
                Categoría:
                <asp:DropDownList ID="Categoria" runat="server" Height="16px" Width="87px">
                    <asp:ListItem>Categoria1</asp:ListItem>
                </asp:DropDownList>
                Subcategoría
                <asp:DropDownList ID="Subcategoria" runat="server" Height="16px" Width="93px">
                    <asp:ListItem>SubCategoria</asp:ListItem>
                </asp:DropDownList>
            </p>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;
            <br />
            <br />
        </p>
    </div>
</asp:Content>
