<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CompilerCS.aspx.cs" Inherits="Code_Generator_Web.Apps.Compiler.CompilerCS" Title="Compiler C#" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        body
        {
            background: steelblue;
        }
        #textbox
        {
            margin-top: 10px;
            padding: 10px;
            overflow: auto;
            border-radius: 10px;
        }
        #Codigo
        {
            width: 500px;
            height: 500px;
        }
        #botones
        {
            float: right;
            width: 21%;
            padding: 5px;
            background: White;
            margin-right: 10px;
            text-align: center;
        }
        #botones .buttons
        {
            width: 70%;
            background: black;
            padding: 5px;
            color: White;
            font-weight: bold;
        }
    </style>
    <div>
        <div id="textbox">
            <asp:TextBox ID="Codigo" runat="server" TextMode="MultiLine"></asp:TextBox>
            <div id="botones">
                <asp:Button ID="btnNuevo" class="buttons" runat="server" Text="Nuevo" 
                    onclick="btnNuevo_Click" Font-Size="X-Small" />
                <asp:Button ID="btnFormato" style="margin-top: 10px;" class="buttons" 
                    runat="server" onclick="btnFormato_Click" 
                    Text="Dar Formato" Font-Size="X-Small"/>
                <asp:Button ID="btnDescargar" style="margin-top: 10px;" class="buttons" 
                    runat="server" Text="Descargar (.exe)" onclick="btnDescargar_Click" 
                    Font-Size="X-Small" />
                <asp:Button ID="btnCS" runat="server" style="margin-top: 10px;" 
                    Text="Descargar (.cs)" CssClass="buttons" 
                    Font-Size="X-Small" onclick="btnCS_Click" />
            </div>
        </div>
    </div>
</asp:Content>

