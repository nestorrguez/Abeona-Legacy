<%@ Page title="Code Generator C#" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CodeGenCS.aspx.cs" Inherits="CodeGenerator.CodeGenCS" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .CodeBox {
            height:80%;
            width:75%;
            background-color: black;
            font-family: 'Consolas','Times New Roman';
            text-align: left;
            color: white;
            float: right;
        }

        .left {
            float:left;
        }

        .button {
            width: 90%;
            left: 5%;
        }

        .main {
            float: none;
            width:100%;
            height: 80%;
            align-content: center;
        }

        .below {
            float: left;
            height: 20%;
            width: 100%;
        }

        .panel {
            background-color: #808080;
        }
    </style>
        <div class="main" runat="server">
        <asp:panel ID="panel1" class="left" runat="server" width="20%" Height="500px" BackColor="SteelBlue">
            <center>
                <br /><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="button" Text="Cuerpo del programa" /><br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="button" Text="Insertar comentario"/><br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" class="button" Text="Opciones de variable"/><br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" class="button" Text="Imprimir texto"/><br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" class="button" Text="Funciones predeterminadas"/><br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" class="button" Text="Estructuras de control"/><br />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" class="button" Text="Ciclos"/><br />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" class="button" Text="Clases"/><br />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" class="button" Text="Herramientas" /><br />
            </center>
          </asp:panel>
        <asp:TextBox  ID="TextBox1" runat="server" Height="500px" CssClass="CodeBox" ReadOnly="false" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="below">
        <asp:Panel runat="server" visible="false" id="CuerpoPrograma" CssClass="panel" Height="50px">
            <br />
               <asp:Label ID="Label1" Text="Nombre del proyecto: " runat="server"></asp:Label>  
               <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
               <asp:Button id="Open" runat="server" Text="Abrir programa" onclick="Unnamed_Click"/>
               <asp:Button id="close" runat="server" Text="Cerrar programa" OnClick="close_Click" />
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="Comentario" CssClass="panel">
        <asp:Label runat="server" ID="Label3" Text="Escribe el comentario: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button id="OK1" runat="server" Text="Aceptar" OnClick="OK1_Click"/>
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="Variables" CssClass="panel">
            <asp:Label runat="server" ID="Label4" Text="Nueva variable"></asp:Label><br /> 
            <asp:Label runat="server" ID="Label2" Text="Nombre: "></asp:Label>
            <asp:TextBox runat="server" ID="TextBox4"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button runat="server" ID="AddVar" Text="Agregar variable" OnClick="AddVar_Click"/><br />
            <asp:Label runat="server" ID="Label5" Text="Tipo de dato"></asp:Label>
            <asp:RadioButton runat="server" ID="_int" Text="int" selected="true"/>
            <asp:RadioButton runat="server" ID="_double" Text="double" selected="true"/>
            <asp:RadioButton runat="server" ID="_char" Text="char" selected="true"/>
            <asp:RadioButton runat="server" ID="_string" Text="string" selected="true"/>
            <br /><br />
            <asp:Label runat="server" ID="label6" Text="Usar variable"></asp:Label><br />
            <asp:ListBox runat="server" ID="Vars1" Height="30px" Width="150px"></asp:ListBox>
            <asp:Button runat="server" ID="In" Text="Pedir dato" OnClick="In_Click"/>
            <asp:Button runat="server" ID="Declare" text="Declarar valor" onclick="Declare_Click"/>
            <asp:Button runat="server" ID="ConvertData" Text="Convertir dato" onclick="ConvertData_Click" Visible="false"/>
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="Imprimir" CssClass="panel">
            <asp:Label runat="server" ID="AddTxt" Text="Agregar texto"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            &nbsp;<asp:Button runat="server" ID="add" Text="+" OnClick="add_Click" /><br />
            <asp:Label runat="server" ID="Label9" Text="Agregar variable"></asp:Label>
            &nbsp;<asp:ListBox ID="Vars2" runat="server" Height="30px" Width="150px" OnSelectedIndexChanged="Vars2_SelectedIndexChanged"></asp:ListBox>
            &nbsp;<asp:Button runat="server" ID="Button10" Text="+" OnClick="Button10_Click" /><br />
            <asp:Label runat="server" ID="Label10" Text="->"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox6" runat="server" ReadOnly="true"></asp:TextBox>
            &nbsp;<asp:button runat="server" ID="OK3" text="Listo" OnClick="OK3_Click" />
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="PreFun" CssClass="panel">
            <asp:Button runat="server" ID="Pause" Text="Pausa" OnClick="Pause_Click" />
            <asp:Button runat="server" ID="Clear1" Text="Limpiar Consola" OnClick="Clear_Click1" />
            <asp:Button runat="server" ID="Colors" Text="Colores" OnClick="Colors_Click" />
            <asp:Button runat="server" ID="Sleep" Text="Retrasar" OnClick="Sleep_Click" />
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="EstCon" CssClass="panel">
            <asp:Label runat="server" Text="If" ID="label13"></asp:Label><br />
            <asp:Label ID="Label24" runat="server" Text="Condicion para el If: "></asp:Label>
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            <asp:Button ID="Button11" runat="server" Text="Abrir If" />
            <asp:Button ID="Button12" runat="server" Text="Cerrar If" /><br />
            <asp:Button ID="Button13" runat="server" Text="Abrir Else" />
            <asp:Button ID="Button14" runat="server" Text="Cerrar Else" /><br />
            <asp:Label ID="Label12" runat="server" Text="Switch"></asp:Label><br />
            <asp:Label ID="Label11" runat="server" Text="Variable a usar: "></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:Button ID="Button15" runat="server" Text="Abrir Switch" />
            <asp:Button ID="Button16" runat="server" Text="Cerrar Switch" /><br />
            <asp:Label ID="Label14" runat="server" Text="Condicion para el caso: "></asp:Label>
            <asp:Button ID="Button17" runat="server" Text="Abrir Caso" />
            <asp:Button ID="Button18" runat="server" Text="Cerrar Caso" />
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="Ciclos" CssClass="panel">
            <asp:Label ID="Label15" runat="server" Text="While"></asp:Label><br />
            <asp:Label ID="Label16" runat="server" Text="Condicion para el While: "></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:Button ID="Button19" runat="server" Text="Abrir While" />
            <asp:Button ID="Button20" runat="server" Text="Cerrar While" /><br /><br />
            <asp:Label ID="Label17" runat="server" Text="Do-While"></asp:Label><br />
            <asp:Label ID="Label18" runat="server" Text="Condicion para  el Do-While: "></asp:Label>
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            <asp:Button ID="Button21" runat="server" Text="Abrir Do-While" />
            <asp:Button ID="Button22" runat="server" Text="Cerrar Do-While" /><br /><br />
            <asp:Label ID="Label22" runat="server" Text="For "></asp:Label><br />
            <asp:Label ID="Label19" runat="server" Text="Variable y valor inicial: "></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label20" runat="server" Text="Condicion: "></asp:Label>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label21" runat="server" Text="Constante: "></asp:Label>
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button23" runat="server" Text="Abrir For" />
            <asp:Button ID="Button24" runat="server" Text="Cerrar For" />
        </asp:Panel>
        <asp:Panel runat="server" visible="false" ID="Clases" CssClass="panel">
            <asp:Label ID="Label23" runat="server" text="Nombre de la clase: "></asp:Label>
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            <asp:Button ID="Button25" runat="server" Text="Abrir clase" />
            <asp:Button ID="Button26" runat="server" Text="Cerrar clase" />
        </asp:Panel>
        <asp:Panel runat="server" Visible="false" ID="Herramientas" CssClass="panel">
            <asp:Button runat="server" Text="Borrar codigo" ID="Clear" OnClick="Clear_Click"/>
            <asp:Button runat="server" Text="Descargar codigo" ID="Download"/>
            <asp:Button runat="server" Text="Compilar" ID="Compiler" OnClick="Compiler_Click" />
        </asp:Panel>

        <asp:panel runat="server" Visible="false" ID="DeclareT" CssClass="panel">
            <asp:Label runat="server" ID="Label7"></asp:Label>
            <asp:Label runat="server" ID="Label8" Text=" = "></asp:Label>
            <asp:TextBox runat="server" ID="value1"></asp:TextBox>
            <asp:Button runat="server" ID="OK2" Text="Listo" OnClick="OK2_Click" />
        </asp:panel>
        <asp:Panel runat="server" CssClass="panel">
            <asp:Label runat="server" Text=""></asp:Label>
        </asp:Panel>
    </div>
    </asp:Content>