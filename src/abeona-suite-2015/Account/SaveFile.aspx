<%@ Page Title="Guardar archivo como" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="SaveFile.aspx.cs" Inherits="Code_Generator_Web.Account.SaveFile" %>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">        
    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" Width="100%" Height="500" TextMode="MultiLine"></asp:TextBox>
    <asp:Label runat="server" ID="Label1" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar y cerrar" />
    <asp:Button ID="Button2" runat="server" Text="Guardar y continuar" OnClick="Button2_Click" />
</asp:Content>
