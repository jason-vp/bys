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
        <a href="DetallesUsuario.aspx"><asp:Image ID="imgUsuario" runat="server" 
            Height="87px" Width="95px" 
            ImageUrl="~/images/travelo.jpg" /></a>
    </div>
    <p>
        <asp:HyperLink ID="hLinkDetallesUsuario" runat="server"><asp:Label ID="lblNombreProp" runat="server" 
            Text="Pedrito" NavigateUrl="~/DetallesUsuario.aspx"></asp:Label></asp:HyperLink></p>
    <p>
        Puntuación:
        <asp:Label ID="lblPuntUser" runat="server" Text="8"></asp:Label></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
    <div id="contenedor">
        <h2 class="tiuloh2">Producto</h2>
        <div id="lateral">
            <asp:Image ID="imgProducto" runat="server" Width="212px" Height="226px" 
                ImageUrl="~/images/popeye.jpg" />
        </div>
        <div id="principal">
            <div class="divInfoProd">
                <p>
                    <h3><asp:Label ID="lblNombreProd" runat="server" Text="Barco velero"></asp:Label></h3></p>
                    <div class="divLblDescrip" align="left">
                <p style="height:80px">
                    <asp:Label ID="lblDescripcion" runat="server" 
                        Text="Barco de 12 metros de eslora. Solo 3 años de uso. Muy cuidado.Barco de 12 metros de eslora. Solo 3 años de uso. Muy cuidadoBarco de 12 metros de eslora. Solo 3 años de uso. Muy cuidado"></asp:Label>
                </p>
                        <p __designer:mapid="66">
                            Cantidad Restante:<asp:Label ID="lblCantidadRest" runat="server"
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
                            <asp:Label ID="lblPujaActual" runat="server" Text="30"></asp:Label>
                            &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" 
                                ImageUrl="~/images/refresh.gif" onclick="ImageButton1_Click" 
                                  style="height: 16px" />
                        </p></ContentTemplate>
                        </asp:UpdatePanel>
                        
                        <p>
                            <asp:TextBox ID="tbPuja" runat="server" Width="63px"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnPuja" runat="server" Text="Pujar" Height="24px" Style="margin-top: 0px"
                                Width="68px" onclick="btnPuja_Click" /></p>
                    </asp:Panel>
                    <asp:Panel ID="PnlCompra" runat="server" Visible="true">
                        <p>
                            Precio:
                            <asp:Label ID="lblPrecio" runat="server" Text="50"></asp:Label>
                        </p>
                        <p>
                            &nbsp;<asp:Button ID="btnCompra" runat="server" Text="Comprar ahora!" 
                                Height="25px" onclick="btnCompra_Click" /></p>
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

        <h3 style="margin-left:20px; margin-bottom:20px">COMENTARIOS:</h3>

       <asp:Repeater runat="server" ID="RPTcomentariosProducto">
            <ItemTemplate>
                <div class="comentario">
                    <p style="margin-left:20px">
                        Usuario: <asp:HyperLink ID="usuarioComentario1" runat="server" NavigateUrl='<%# string.Format("~/DetallesUsuario.aspx?id={0}", ((BySLib.EN.CompraEN)Container.DataItem).Pujador) %>' style="margin-right:15px">
                                    <asp:Label ID="Label1" runat="server"> <%# BySLib.BL.UsuarioBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr() ,((BySLib.EN.CompraEN)Container.DataItem).Pujador).Nick %></asp:Label>
                                 </asp:HyperLink>
                        Producto: <asp:HyperLink ID="productoComentario1" runat="server" style="margin-right:15px">
                                    <asp:Label ID="Label2" runat="server"> <%# BySLib.BL.ProductoBL.GetByIdToEN(BySWeb.Utilities.Tools.GetDbCnxStr(), ((BySLib.EN.CompraEN)Container.DataItem).Producto).Nombre %></asp:Label>
                                  </asp:HyperLink>
                        Puntuación:<asp:Label ID="lblPuntComent1" runat="server" style="margin-left:10px"><%# ((BySLib.EN.CompraEN)Container.DataItem).Puntuacion %></asp:Label>
                    </p>
                    <p style="margin-left:20px">
                        Descripción:<asp:Label ID="lblDescripcionComent1" runat="server" style="margin-left:20px"> <%# ((BySLib.EN.CompraEN)Container.DataItem).Comentario %> </asp:Label>
                    </p>
                </div>
            </ItemTemplate>
        </asp:Repeater> 

       <!-- <div class="comentario">
            <p style="margin-left:20px">
                Usuario: <asp:HyperLink ID="usuarioComentario1" runat="server" NavigateUrl="~/DetallesUsuario.aspx" style="margin-right:15px">Perico90</asp:HyperLink>
                Producto: <asp:HyperLink ID="productoComentario1" runat="server" style="margin-right:15px">Barco velero</asp:HyperLink>
                Puntuación:<asp:Label ID="lblPuntComent1" runat="server" Text="5" style="margin-left:10px"></asp:Label>
            </p>
            <p style="margin-left:20px">
                Descripción:<asp:Label ID="lblDescripcionComent1" runat="server" Text="Entregadas en mano y pagado en negro, muy buen servicio." style="margin-left:20px"></asp:Label>
            </p>
        </div> -->
        
        <div>
            <h3 style="margin-left:20px; margin-bottom:20px">REALIZAR COMENTARIO:</h3>
                <div class="comentario">
                <p style="margin-left:20px">
                    Usuario: <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DetallesUsuario.aspx" style="margin-right:15px">Perico90</asp:HyperLink>
                    Producto: <asp:HyperLink ID="HyperLink2" runat="server" style="margin-right:15px">Barco velero</asp:HyperLink>
                    Puntuación:
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p style="margin-left:20px">
                Descripción: <asp:TextBox ID="TextBox3" runat="server" Height="100px" Width="700px" Value=""></asp:TextBox>
                </p>
                    <asp:Button ID="btnEnviarComent" runat="server" Text="Enviar" Width="100px" style="margin-left:20px" /> <!-- Hay que controlar la DIVitis -->
                </div>
        </div>
</asp:Content>
