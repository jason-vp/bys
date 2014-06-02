﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiUsuario.aspx.cs" Inherits="BySWeb.MiUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-size: 1.5em;
        }
        .style2
        {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
    <p>Mis Pujas:</p>
        <asp:Repeater runat="server" ID="RPTproductosPujados">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
            <asp:HyperLink ID="misPujas1" runat="server" style="margin-right:15px" NavigateUrl='<%# string.Format("~/Producto.aspx?id={0}", ((BySLib.EN.ProductoEN)Container.DataItem).Id) %>'>
                <asp:Label ID="Label2" runat="server"> <%# ((BySLib.EN.ProductoEN)Container.DataItem).Nombre %></asp:Label>
            </asp:HyperLink>
            </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Listar.aspx?t=p">Ver más...</asp:HyperLink>
        </FooterTemplate>
        </asp:Repeater> 
        
    <p>Mis Productos</p>
        <asp:Repeater runat="server" ID="RPTproductosSobastardos">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
            <asp:HyperLink ID="misProductos1" runat="server" style="margin-right:15px" NavigateUrl='<%# string.Format("~/Producto.aspx?id={0}", ((BySLib.EN.ProductoEN)Container.DataItem).Id) %>'>
                <asp:Label ID="Label2" runat="server"> <%# ((BySLib.EN.ProductoEN)Container.DataItem).Nombre%></asp:Label>
            </asp:HyperLink>
            </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# string.Format("~/Listar.aspx?t=m&n={0}",Session["userId"]) %>'>Ver más...</asp:HyperLink>
        </FooterTemplate>
        </asp:Repeater> 
        
    <p>Mis Compras</p>
        <asp:Repeater runat="server" ID="RPTproductosComprados">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
            <asp:HyperLink ID="misCompras1" runat="server" style="margin-right:15px" NavigateUrl='<%# string.Format("~/Producto.aspx?id={0}", ((BySLib.EN.ProductoEN)Container.DataItem).Id) %>'>
                <asp:Label ID="Label2" runat="server"> <%# ((BySLib.EN.ProductoEN)Container.DataItem).Nombre%></asp:Label>
            </asp:HyperLink>
            </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
            <asp:HyperLink runat="server" NavigateUrl="~/Listar.aspx?t=mc">Ver más...</asp:HyperLink>
        </FooterTemplate>
        </asp:Repeater>

        
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style1">
     
        <strong>DATOS PERSONALES</strong></p>
    <div style="text-align: right; margin-left: 678px; height: 22px;">
        <img alt="" src="" style="height: 100px" /></div>
        <asp:Panel ID="PnlError" runat="server" Visible="False">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
            ID="lbError" runat="server" style="text-align: center" Text="lbError"></asp:Label>
        &nbsp;</asp:Panel>

    <p>
        <strong>Nombre&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="tbNombre" runat="server" Width="350px" ></asp:TextBox>
        </strong>
        <div class="validator">
            <asp:CustomValidator ID="CustomValidator1" ControlToValidate="tbNombre"
           OnServerValidate="ComprobarNombre" runat="server" ErrorMessage="El nombre contiene caracteres incorrectos. Introduce solo letras y espacios." 
           Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
    </p>
    <p>
        <strong>Direccion
        </strong>&nbsp;
        <asp:TextBox ID="tbDireccion" runat="server" Width="300px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
    <p>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ControlToValidate="tbDireccion"
        ErrorMessage="Introduce una dirección" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <div class="validator">
            <asp:CustomValidator ID="CustomValidator2" ControlToValidate="tbDireccion"
           OnServerValidate="ComprobarNombre" runat="server" ErrorMessage="Direccion incorrecta" 
           Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
    <p>
        <strong>Poblacion</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Localidad" runat="server"></asp:TextBox>
&nbsp;&nbsp; <strong>C.P.</strong>&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="CP" 
            runat="server" Width="75px"></asp:TextBox>
    </p>
    <p>
        <strong>Telefono</strong>&nbsp;&nbsp; 
        <asp:TextBox ID="tbtlf" runat="server" 
            TextMode="Phone" Width="125px" style="margin-left: 3px" Height="22px"></asp:TextBox>
        &nbsp;</p>
        <div class="validator">
             <asp:CustomValidator ID="ValidatorTelefono" ControlToValidate="tbtlf"
            OnServerValidate="ComprobarTelefono" runat="server" ErrorMessage="Teléfono Incorrecto" 
            Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
         </div>
    <p>
        &nbsp;</p>
    <p class="style1">
        <strong>DETALLES DEL USUARIO&nbsp;&nbsp; </strong>&nbsp;&nbsp;&nbsp; <strong>&nbsp;</strong></p>
    <p>
        <strong>Email&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="tbmail" runat="server" TextMode="Email" Width="150px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp; <strong>Puntuacion&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp; Usuario&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </strong>
        <div class="style2" style="right: 50px; position: inherit;">
            El email introducido es incorrecto</div>
    </p>
    <p>
        <strong>Contraseña Actual&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="Contraseña_Actual" runat="server" TextMode="Password" 
            Width="90px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>Nueva Contraseña</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbcontrasenyanueva" runat="server" TextMode="Password" 
            Width="90px" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;Repite Contraseña</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbcontrasenyanueva2" runat="server" TextMode="Password" 
            Width="90px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordReq" runat="server"
        ControlToValidate="Contraseña_Actual"
        ErrorMessage="Introduce tu contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
            <div class="validator_pass"><asp:CustomValidator ID="ValidatorPassword" ControlToValidate="tbcontrasenyanueva"
        OnServerValidate="ComprobarPassword2" runat="server" 
                ErrorMessage="La contraseña debe contener mayúsculas, minúsculas y números y debe tener entre 6 y 12 caracteres" 
                Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator></div>

        <div class="validator"><asp:CustomValidator ID="ValidatorPassword2" ControlToValidate="tbcontrasenyanueva2"
         runat="server" ErrorMessage="La nueva contraseña no coincide" Display="Dynamic" 
                ValidateEmptyText="false" ForeColor="Red"></asp:CustomValidator></div>

    <p>
        <asp:Label ID="Label4" runat="server" ForeColor="#CC0000" 
            Text="La contraseña introducida no coincide con la actual" Visible="False"></asp:Label>
    </p>
    <p>
        <strong>Credito Actual&nbsp;&nbsp;&nbsp; </strong>&nbsp;<asp:TextBox 
            ID="Credito" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; <strong>Añadir Credito&nbsp;&nbsp;&nbsp;&nbsp; </strong>&nbsp;<asp:Button 
            ID="Boton_Añadir_Credito" runat="server" Text="Añadir" />
    &nbsp;&nbsp;
    </p>
    <p>
        Imagen perfil:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Boton_Editar_Datos" runat="server" Text="Editar" 
            Width="100px" onclick="Boton_Editar_Datos_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Boton_Revertir_Datos" runat="server" Text="Descartar" 
            Width="100px" />
    </p>
   <!--
    <p class="style1">
        <strong>COMENTARIOS REALIZADOS</strong></p>
        <div class="comentario">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
              <a href="/DetallesUsuario.aspx">Perico90</a>
        &nbsp;&nbsp;&nbsp;

         Producto:
              <a href="/Producto.aspx">Barco velero</a>
        &nbsp;&nbsp; Puntuación:&nbsp;                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripción:&nbsp;&nbsp; &nbsp;<asp:TextBox 
            ID="TextBox19" runat="server" Height="100px" Width="700px" style="margin-left:20px" Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
                <asp:Button ID="Button_Editar_Comentario_1" runat="server" Text="Editar" 
            Width="100px" onclick="Boton_Editar_Datos_Click" />
        </div>
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
            ID="TextBox3" runat="server" Height="100px" Width="700px" style="margin-left:20px" Value="Entregadas en mano y pagado en negro, muy buen servicio."></asp:TextBox>
        &nbsp;&nbsp;&nbsp; 
        &nbsp;</p>
        <asp:Button ID="Button_Editar_Comentario_2" runat="server" Text="Editar" 
            Width="100px" onclick="Boton_Editar_Datos_Click" />
        </div>-->
</asp:Content>
