<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="BySWeb.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .divMensage
        {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div class="divInfoProdImg" style="width: 257px; height: 157px;" align="left" >

        <asp:Image ID="ImageProd" runat="server" Width="250px" Height="250px" />
      <div class="divInfoProd" align="right">
        <asp:TextBox ID="TextBoxPuja" runat="server"></asp:TextBox>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <asp:Button ID="ButtonPuja" runat="server" OnClick="Button1_Click" Text="Pujar" 
            Height="16px" style="margin-top: 0px" Width="68px" />
        <asp:Button ID="ButtonCompra" runat="server" Text="Comprar" Height="32px" />

    </div>
         </div>
    <asp:Panel ID="pnlError" runat="server" Visible="false">
       <div class="divMensage">
            <asp:Label ID="lbError" runat="server" Text="" Style="color: red"></asp:Label>

        </div>
    </asp:Panel>
</asp:Content>
