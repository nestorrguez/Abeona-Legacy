<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Code Generator VB.NET" CodeBehind="CodeGenVB.aspx.cs" Inherits="Code_Generator_Web.Apps.CodeGen.CodeGenVB" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:LoginView runat="server" ID="log1">
        <LoggedInTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Res/en construcción.png" height="100%" Width="100%"/>
        </LoggedInTemplate>
        <AnonymousTemplate>
            <p>Para poder hacer uso de esta aplicación <a href="../../Account/Login.aspx">inicie sesión </a> o si aún no tiene una cuenta, <a href="../../Account/Register.aspx">¡registrese ahora!</a>.</p>
        </AnonymousTemplate>
    </asp:LoginView>
</asp:Content>
