<%@ Page Title="Mi Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MiProducto.aspx.cs" Inherits="BySWeb.MiProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="MiProducto" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 678px;">
        <h2 class="tiuloh2">
            Producto</h2>
        <div style="float: left; width: 309px">
            <asp:Image ID="ImageProducto" runat="server" BorderColor="#666666" Height="252px"
                Width="309px" ImageUrl="/images/popeye.jpg" Style="margin-left: 61px" />
            <asp:FileUpload ID="FileUpload1" runat="server" Style="margin-left: 41px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelErrorEstado" runat="server" style="color: #FF0000" 
                Text="Solo puedes editar productos Inactivos" Visible="False"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_Editar" runat="server" onclick="Btn_Editar_Click" 
                style="margin-left: 0px" Text="Editar" Visible="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_Crear" runat="server" Text="Crear" Visible="False" 
                onclick="Btn_Crear_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <div style="float: right; height: 309px; width: 345px; margin-top: 1px;">
            <p style="width: 99%">
                Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbNombreProducto" runat="server" Width="170px"></asp:TextBox>
            <div class="validator">
            <asp:CustomValidator ID="CustomValidatorNombre" ControlToValidate="tbNombreProducto"
           OnServerValidate="ComprobarNombre" runat="server" ErrorMessage="El nombre contiene caracteres incorrectos. Introduce solo letras y espacios." 
           Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
            <p style="width: 100%">
                Descripcion:&nbsp;</p>
            <p style="width: 100%">
                &nbsp;<asp:TextBox ID="tbDescripcion" runat="server" 
                    Width="319px" Height="93px" TextMode="MultiLine"></asp:TextBox>

             <div class="validator">
            <asp:CustomValidator ID="CustomValidatorDescripcion" ControlToValidate="tbDescripcion"
           OnServerValidate="ComprobarDescripcion" runat="server" ErrorMessage="La Descripcion contiene caracteres incorrectos. Introduce solo letras y espacios." 
           Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
            </p>

            <p style="width: 100%">
                Precio salida:
                <asp:TextBox ID="tbPrecioSalida" runat="server" Width="116px"></asp:TextBox>
                €<div class="validator">
                <asp:CustomValidator ID="CustomValidatorPrecioSalida" ControlToValidate="tbNombreProducto"
                OnServerValidate="ComprobarNumero" runat="server" ErrorMessage="El precio de salida contiene caracteres incorrectos. Introduce solo numeros." 
                Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
            <p style="width: 100%">
                <asp:CheckBox ID="chkCompraInmediata" runat="server" Text="Compra Inmediata" TextAlign="Left" />
                &nbsp;Precio:
                <asp:TextBox ID="tbCompra" runat="server" Style="margin-left: 20px" Width="56px"></asp:TextBox>
                €<div class="validator">
                <asp:CustomValidator ID="CustomValidatorCompraInmediata" ControlToValidate="tbCompra"
                 OnServerValidate="ComprobarNumero" runat="server" ErrorMessage="El precio contiene caracteres incorrectos. Introduce solo numeros." 
                 Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
            <p style="width: 100%">
                Cantidad:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tbCantidadRestante" runat="server" Width="24px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha:&nbsp;
                <asp:TextBox ID="tbFecha" runat="server" Width="125px"></asp:TextBox>
            </p>
            <p style="width: 100%">
                Categoría:
                <asp:Label ID="lbcategoria" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
            <p style="width: 100%">
                Subcategoría:

               <asp:Label ID="lbSubcategoria" runat="server" ></asp:Label>
               
                    <asp:DropDownList ID="ddpSubcategoria" runat="server"></asp:DropDownList>
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
