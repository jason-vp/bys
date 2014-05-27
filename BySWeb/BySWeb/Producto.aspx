<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Producto.aspx.cs" Inherits="BySWeb.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .divMensage
        {
            height: 22px;
        }
        .divInfoProd
        {
            width:100%;
             align:left;
            
            }
        #contenedor
        {
            color: Black;
            text-align: left;
            width: 750px;
            margin: auto;
        }
        
        #lateral
        {
            width: 220px; /*Este será el ancho que tendrá tu columna*/
            float: left; /*Aqui determinas de lado quieres quede esta "columna" */
        }
        
        #principal
        {
            margin-left: 230px; /*Este margen hace que no se encime el contenido en tu menúlateral, es     importante que pongas un pocos pixeles más que el ancho  de tu columna lateral*/
            background-color: #FFFFFF;
        }
        #DivImgUser
        {
            height: 100px;
        }
        #PnlPuja
        {
            background-color: #E2E2E2;
        }
        #PnlCompra
        {
            background-color: #E2E2E2;
        }
        #DivFondogris
        {
            background-color: #E2E2E2;
        }
        #divLblDescrip
        {
            height: 100;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    <div id="DivImgUser">
        <a href="DetallesUsuario.aspx"><asp:Image ID="Image2" runat="server" Height="87px" Width="95px" 
            ImageUrl="~/images/travelo.jpg" /></a>
    </div>
    <p>
        <a href="/DetallesUsuario.aspx"><asp:Label ID="Label1" runat="server" Text="Pedrito" NavigateUrl="~/DetallesUsuario.aspx"></asp:Label></a></p>
    <p>
        Puntuación:
        <asp:Label ID="Label2" runat="server" Text="8"></asp:Label></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div id="contenedor">
        <h2 class="tiuloh2">Producto</h2>
        <div id="lateral">
            <asp:Image ID="imagenProducto" runat="server" Width="212px" Height="226px" 
                ImageUrl="~/images/popeye.jpg" />
        </div>
        <div id="principal">
            <div class="divInfoProd">
                <p>
                    <h3><asp:Label ID="nombreProducto" runat="server" Text="Barco velero"></asp:Label></h3></p>
                    <div class="divLblDescrip" align="left">
                <p style="height:80px">
                    <asp:Label ID="descriProducto" runat="server" Text="Barco de 12 metros de eslora. Solo 3 años de uso. Muy cuidado.Barco de 12 metros de eslora. Solo 3 años de uso. Muy cuidadoBarco de 12 metros de eslora. Solo 3 años de uso. Muy cuidado"></asp:Label>
                </p>
                        <p __designer:mapid="66">
                            Cantidad Restante:<asp:Label ID="LblCantidadRest" runat="server"
                                Text="20"></asp:Label>
                        </p>
                </div>
                
                <p>
                    Fecha de fin:
                    <asp:Label ID="fechaFinProducto" runat="server" Text="12/12/2014 12:34"></asp:Label>

                </p>
                <p>
                                    
                    Estado: 
                    <asp:Label ID="EstadoProducto" runat="server" Text="Disponible"></asp:Label>
                </p>
                <div class="divLblDescrip" align="left">
                <div id="DivFondogris">
                    <asp:Panel ID="PnlPuja" runat="server"><p>
                        &nbsp;<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                          <ContentTemplate>
                            Puja actual:
                            <asp:Label ID="LblPujaActual" runat="server" Text="30"></asp:Label>
                            &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" 
                                ImageUrl="~/images/refresh.gif" onclick="ImageButton1_Click" 
                                  style="height: 16px" />
                        </p></ContentTemplate>
                        </asp:UpdatePanel>
                        
                        <p>
                            <asp:TextBox ID="TextBoxPuja" runat="server" Width="63px"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="ButtonPuja" runat="server" Text="Pujar" Height="24px" Style="margin-top: 0px"
                                Width="68px" /></p>
                    </asp:Panel>
                    <asp:Panel ID="PnlCompra" runat="server" Visible="true">
                        <p>
                            Precio:
                            <asp:Label ID="LblPrecio" runat="server" Text="50"></asp:Label>
                        </p>
                        <p>
                            &nbsp;<asp:Button ID="ButtonCompra" runat="server" Text="Comprar ahora!" Height="25px" /></p>
                    </asp:Panel>
                    </div>
                </div>
        </div>
    </div>
    <asp:Panel ID="pnlError" runat="server" Visible="false">
        <div class="divMensage">
            <asp:Label ID="lbError" runat="server" Text="" Style="color: red"></asp:Label>
        </div>
    </asp:Panel>

        <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>&nbsp;COMENTARIOS:</strong></p> </br>
        <div class="comentario">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <asp:HyperLink ID="usuarioComentario1" runat="server" NavigateUrl="~/DetallesUsuario.aspx">Perico90</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <asp:HyperLink ID="productoComentario1" runat="server">Barco velero</asp:HyperLink>
        &nbsp;&nbsp; Puntuación:&nbsp;<asp:Label ID="puntuacionComentario1" runat="server"
                Text="10"></asp:Label>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;
            <asp:Label ID="descripcionComentario1" runat="server"
                Text="Entregadas en mano y pagado en negro, muy buen servicio."></asp:Label>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        </div>
        <div class="comentario">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DetallesUsuario.aspx">Perico90</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <asp:HyperLink ID="HyperLink2" runat="server">Barco velero</asp:HyperLink>
        &nbsp;&nbsp; Puntuación:&nbsp;<asp:Label ID="Label3" runat="server"
                Text="10"></asp:Label>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label4" runat="server"
                Text="Entregadas en mano y pagado en negro, muy buen servicio."></asp:Label>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        </div>
    </div>
    <div id="hacer comentario">
    <p><h3>Realizar comentario:</h3></p>
            <div class="comentario">
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <a href="/DetallesUsuario.aspx">Perico90</a>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <a href="/Producto.aspx">Barco velero</a>
        &nbsp;&nbsp; Puntuación:&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox3" runat="server" Height="100px" Width="700px" style="margin-left:20px" Value=""></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        <asp:Button ID="Button_Editar_Comentario_3" runat="server" Text="Enviar" 
            Width="100px"  />
            </div>
        </div>
        </div>
</asp:Content>
