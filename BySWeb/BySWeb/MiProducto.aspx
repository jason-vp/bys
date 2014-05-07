<%@ Page Title="Detalles de Usuario" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiProducto.aspx.cs" Inherits="BySWeb.DetallesUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="DetalleUsuario" ContentPlaceHolderID="PlaceholderSidebar" 
    runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  
    <p class="style1" style="font-size: xx-large; font-family: Arial">
        &nbsp;&nbsp;&nbsp;Producto</p>
    <p class="style1" style="font-size: xx-large; font-family: Arial">
        &nbsp;</p>
    <p class="style1" style="font-size: xx-large; font-family: Arial">
        &nbsp;</p>

          <div style="float: right; height: 309px; width: 345px; margin-top: 1px;">

          <p style="width: 99%">
              Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="TextBox10" runat="server" Width="170px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Descripcion:&nbsp;
                  <asp:TextBox ID="TextBox11" runat="server" Width="168px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Precio salida:
                  <asp:TextBox ID="TextBox12" runat="server" Width="166px"></asp:TextBox>
        </p>
              <p style="width: 100%">
&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Compra Inmediata" TextAlign="Left" />
&nbsp;Precio inmediata:
                  <asp:TextBox ID="TextBox15" runat="server" style="margin-left: 20px" 
                      Width="56px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  Cantidad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="TextBox14" runat="server" Width="161px"></asp:TextBox>
        </p>
              <p style="width: 100%">
                  <asp:DropDownList ID="DropDownList1" runat="server">
                      <asp:ListItem>Categoria1</asp:ListItem>
                  </asp:DropDownList>
        </p>
              <p style="width: 100%">
                  <asp:DropDownList ID="DropDownList2" runat="server">
                      <asp:ListItem>SubCategoria</asp:ListItem>
                  </asp:DropDownList>
        </p>
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
    </asp:Content>
