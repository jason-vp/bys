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
        <asp:Label ID="lbError" runat="server"></asp:Label>
    </asp:Panel>
    <p class="style2">
        <strong>Datos de usuario</strong><p>
        Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_Usuario" runat="server"></asp:TextBox>
        
        <div class="validator"><asp:CustomValidator ID="ValidatorNombre" ControlToValidate="TextB_Usuario"
         OnServerValidate="ComprobarUsuario" runat="server" ErrorMessage="Usuario incorrecto" 
         Display="Dynamic" ValidateEmptyText="true"></asp:CustomValidator></div>

        <asp:RequiredFieldValidator ID="UserNameReq" runat="server"
        ControlToValidate="TextB_Usuario"
        ErrorMessage="Introduce un nombre de usuario"> </asp:RequiredFieldValidator>
    </p>
    <p>
        Contraseña:&nbsp;
        <asp:TextBox ID="TextB_Contraseña" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Repite contraseña:&nbsp;
        <asp:TextBox ID="TextB_RepiteContra" runat="server" TextMode="Password"></asp:TextBox>
        
        <div class="validator_pass"><asp:CustomValidator ID="ValidatorPassword" ControlToValidate="TextB_Contraseña"
        OnServerValidate="ComprobarPassword" runat="server" ErrorMessage="La contraseña debe contener mayúsculas, minúsculas y números y debe tener entre 6 y 12 caracteres" Display="Dynamic" ValidateEmptyText="true">
        </asp:CustomValidator></div>

        <div class="validator"><asp:CustomValidator ID="ValidatorPassword2" ControlToValidate="TextB_RepiteContra"
         runat="server" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" ValidateEmptyText="false">
        </asp:CustomValidator></div>

        <asp:RequiredFieldValidator ID="PasswordReq" runat="server"
        ControlToValidate="TextB_Contraseña"
        ErrorMessage="Introduce una contraseña"></asp:RequiredFieldValidator>
    </p>
    <p>
        Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_mail" runat="server" TextMode="Email"></asp:TextBox>
        <div class="validator"><asp:CustomValidator ID="ValidatorEmail" ControlToValidate="TextB_mail"
         OnServerValidate="ComprobarEmail" runat="server" ErrorMessage="Email incorrecto"
         Display="Dynamic" ValidateEmptyText="true"></asp:CustomValidator>
        </div>
    </p>
    <p>
        Avatar:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_avatar" runat="server" TextMode="Url"></asp:TextBox>
        &nbsp;
    </p>
    <p class="style3">
        <strong>Datos personales</strong></p>
    <p>
        Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_Nombre" runat="server"></asp:TextBox>
        <div class="validator"><asp:CustomValidator ID="CustomValidator1" ControlToValidate="TextB_Nombre"
           OnServerValidate="ComprobarUsuario" runat="server" ErrorMessage="Nombre incorrecto" 
           Display="Dynamic" ValidateEmptyText="true"></asp:CustomValidator>
       </div>
    </p>
    <p>
        CP:
        <asp:TextBox ID="TextB_CP" runat="server" ontextchanged="TextB_CP_TextChanged" 
            style = "margin-left:50px; margin-right:10px;" AutoPostBack="True"  ></asp:TextBox>
        <div class="validator"><asp:CustomValidator ID="ValidatorCpostal" ControlToValidate="TextB_CP"
         OnServerValidate="ComprobarCpostal" runat="server" ErrorMessage="Código postal incorrecto" 
         Display="Dynamic" ValidateEmptyText="true"></asp:CustomValidator>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
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
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nº:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_num" runat="server" TextMode="Number"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Piso:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_Piso" runat="server"></asp:TextBox>
    </p>
    <p>
        Teléfono:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextB_tlf" runat="server"></asp:TextBox>
         <div class="validator"><asp:CustomValidator ID="ValidatorTelefono" ControlToValidate="TextB_tlf"
            OnServerValidate="ComprobarTelefono" runat="server" ErrorMessage="Teléfono no válido" 
            Display="Dynamic" ValidateEmptyText="true"></asp:CustomValidator>
         </div>
    </p>
    <p class="style1">
        <asp:Button ID="Button_Enviar" runat="server" OnClick="Button_Enviar_Click" Text="Enviar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="Reset" /></p>
    </asp:Content>
