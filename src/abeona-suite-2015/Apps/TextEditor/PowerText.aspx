<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PowerText.aspx.cs" Inherits="Code_Generator_Web.Apps.TextEditor.PowerText" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        *
        {
            margin: 0 auto 0 0px;
            font-family: Arial;
        }
        body
        {
            background: #FFFFFF;
        }
        #texto
        {
            border-radius: 0px;
        }
        #codificar
        {
            padding: 20px;
            background: steelblue;
            border-radius: 10px;
            width: 70%;
            float: left;
            margin-left: 10px;
            margin-top: 10px;
        }
        #botones
        {
            background: skyblue;
            width: 20%;
            float: right;
            margin-right: 10px;
            border-radius: 10px;
            margin-top: 10px;
            padding: 10px;
            text-align: center;
        }
        .boton
        {
            width: 90%;
        }
    </style>
    <div>
      <div id="codificar">
         <asp:TextBox ID="Texto" runat="server" Height="323px" Width="598px" 
              TextMode="MultiLine"></asp:TextBox>
      </div>
      <div id="botones">
          <asp:Button ID="btnNuevo" runat="server" CssClass="boton" Text="Nuevo" onclick="btnNuevo_Click"/>
          <br />
          <br />
          <asp:Button ID="btnDescargar" runat="server" CssClass="boton" Text="Decargar" onclick="btnDescargar_Click"/>    
          <br />
          <br />
          <asp:Button ID="btnSave" runat="server" CssClass="boton" Text="Guardar" onclick="btnSave_Click"/>    
      </div>
    </div>
        </asp:Content>
