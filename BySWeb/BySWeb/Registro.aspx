<%@ Page Title="Registro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Registro.aspx.cs" Inherits="BySWeb.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            font-size: large;
            color: #003399;
        }
        .style3
        {
            font-size: large;
            color: #000099;
        }
        
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceholderSidebar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
    <p>
        <br />
    <asp:Panel ID="PnlError" runat="server" Visible="false">
        <asp:Label ID="lbError" runat="server" ></asp:Label>
    </asp:Panel>
    <p class="style2">
        <strong>Datos de usuario</strong><p>
        Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbUsuarioEn" runat="server"></asp:TextBox>
        
        <div class="validator">
            <asp:CustomValidator ID="ValidatorUsuario" ControlToValidate="tbUsuarioEn"
         OnServerValidate="ComprobarUsuario" runat="server" ErrorMessage="Usuario no valido" 
         Display="Dynamic" ValidateEmptyText="true" BorderColor="Red" ForeColor="Red"></asp:CustomValidator></div>

        <asp:RequiredFieldValidator ID="UserNameReq" runat="server"
        ControlToValidate="tbUsuarioEn"
        ErrorMessage="Introduce un nombre de usuario" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        Contraseña:&nbsp;
        <asp:TextBox ID="tbcontrasenya" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Repite contraseña:&nbsp;
        <asp:TextBox ID="tbRepiteContra" runat="server" TextMode="Password"></asp:TextBox>
        
        <div class="validator_pass"><asp:CustomValidator ID="ValidatorPassword" ControlToValidate="tbcontrasenya"
        OnServerValidate="ComprobarPassword" runat="server" 
                ErrorMessage="La contraseña debe contener mayúsculas, minúsculas y números y debe tener entre 6 y 12 caracteres" 
                Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator></div>

        <div class="validator"><asp:CustomValidator ID="ValidatorPassword2" ControlToValidate="tbRepiteContra"
         runat="server" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" 
                ValidateEmptyText="false" ForeColor="Red"></asp:CustomValidator></div>

        <asp:RequiredFieldValidator ID="PasswordReq" runat="server"
        ControlToValidate="tbcontrasenya"
        ErrorMessage="Introduce una contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>
        Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbmail" runat="server" TextMode="Email"></asp:TextBox>
        <div class="validator">
            <asp:CustomValidator ID="ValidatorEmail" ControlToValidate="tbmail"
         OnServerValidate="ComprobarEmail" runat="server" ErrorMessage="Email incorrecto"
         Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
        ControlToValidate="tbmail"
        ErrorMessage="Introduce un email" ForeColor="#FF3399"></asp:RequiredFieldValidator>
    </p>
    <p>
        Avatar:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbavatar" runat="server" TextMode="Url"></asp:TextBox>
        &nbsp;
    </p>
    <p class="style3">
        <strong>Datos personales</strong></p>
    <p>
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
        <div class="validator">
            <asp:CustomValidator ID="CustomValidator1" ControlToValidate="tbNombre"
           OnServerValidate="ComprobarNombre" runat="server" ErrorMessage="Nombre incorrecto" 
           Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
       </div>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
        ControlToValidate="tbNombre"
        ErrorMessage="Introduce un nombre" ForeColor="#FF3399"></asp:RequiredFieldValidator>
    </p>
    <p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                CP:
                <asp:TextBox ID="tbCP" runat="server" ontextchanged="TextB_CP_TextChanged" 
                    style = "margin-left:50px; margin-right:10px;" AutoPostBack="True"  ></asp:TextBox>
                <div class="validator">
                    <asp:CustomValidator ID="ValidatorCP" ControlToValidate="tbCP"
                 OnServerValidate="ComprobarCpostal" runat="server" ErrorMessage="Código postal incorrecto" 
                 Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="tbCP"
                ErrorMessage="Introduce un Código postal" ForeColor="#FF3399"></asp:RequiredFieldValidator>     
                Provincia:
                <asp:DropDownList
                    ID="listaProvincias" runat="server" style = "margin-left:15px; margin-right:50px;">
                </asp:DropDownList>
                Localidad:
                <asp:DropDownList
                    ID="listaLocalidad" runat="server" style = "margin-left:45px;">
                </asp:DropDownList>
            </ContentTemplate>
        </asp:UpdatePanel>

    </p>
    <p>
        Dirección:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbdireccion" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nº:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbnumero" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Piso:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbPiso" runat="server"></asp:TextBox>
    </p>
    <p>
        Teléfono:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbtlf" runat="server"></asp:TextBox>
         <div class="validator">
             <asp:CustomValidator ID="ValidatorTelefono" ControlToValidate="tbtlf"
            OnServerValidate="ComprobarTelefono" runat="server" ErrorMessage="Teléfono no válido" 
            Display="Dynamic" ValidateEmptyText="true" ForeColor="Red"></asp:CustomValidator>
         </div>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
        ControlToValidate="tbtlf"
        ErrorMessage="Introduce un telefono" ForeColor="Red"></asp:RequiredFieldValidator>

    </p>
    <p class="style1">
        <asp:Button ID="Button_Enviar" runat="server" OnClick="Button_Enviar_Click" Text="Enviar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="Reset" /></p>
    </asp:Content>
