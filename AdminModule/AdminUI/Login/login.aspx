<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/AdminModule.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AdminUI.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row align-items-center">
            <div class="col-lg-8 offset-lg-2 align-self-start">
                <br /><br />
                <div class="form-group">
                <asp:Label ID="Label3" runat="server" ForeColor="#FF3300" Text=" "></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1">Campo Requerido</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="TextBox2" class="form-control" TextMode="Password" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="rfvPass" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                </div>
                <div class="col-6 offset-5 align-self-start">
                <asp:Button ID="Button1" runat="server" class="btn btn-danger" OnClick="Button1_Click" Text="Iniciar Sesion" />
                    </div>
                <br />
            </div>
        </div>

    </div>


</asp:Content>
