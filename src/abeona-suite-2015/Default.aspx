<%@ Page Title="Abeona" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Code_Generator_Web._Default"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:LoginView ID="Log1" runat="server">     
             <AnonymousTemplate>
                 <center> 
                 <br /><br /><br />
                 <div style="align-content:center;">
                 <asp:Panel ID="Panel1" runat="server">
                      <asp:Image ID="Image1" runat="server" Height="240px" ImageUrl="~/Res/Main.png" ViewStateMode="Enabled" Width="500px" ValidateRequestMode="Disabled" />
                      <h4><br />Realice sus proyectos donde esté.</h4>
                      <h5>Para disfrutar de los beneficios de esta plataforma debe estar registrado y si ya tiene una cuenta, incie sesión</h5>
                      <h5>Unete, ya somos </h5>
                 </asp:Panel>
                 </div>
                 </center>
            </AnonymousTemplate>         
            <LoggedInTemplate> 
                <div style="position:absolute; left:20%; top:20%;">
                    <asp:ImageButton  ID="Image1" runat="server" ImageUrl="~/Res/DG.png" ViewStateMode="Enabled" height="114" Width="171" PostBackUrl="~/Apps/DiagramGen/DiagramGen.aspx"/>
                 </div>
                <div style="position:absolute; left:40%; top:20%;">
                    <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/Res/CG.png" ViewStateMode="Enabled" height="114" Width="145" OnClick="Image2_Click"/>
                    <br /><a href="Apps/CodeGen/CodeGenCS.aspx">C#</a><br />
                    <a href="Apps/CodeGen/CodeGenVB.aspx">Visual Basic .NET</a>
                </div>
                <div style="position:absolute; left:60%; top:20%;">
                    <asp:ImageButton ID="Image3" runat="server" ImageUrl="~/Res/C.png" ViewStateMode="Enabled" height="114" Width="95" OnClick="Image3_Click"/>
                    <br /><a href="Apps/Compiler/CompilerCS.aspx">C#</a><br />
                    <a href="Apps/Compiler/CompilerVB.aspx">Visual Basic .NET</a>
                </div>
                <div style="position:absolute; left:23%; top:50%;">
                    <asp:ImageButton ID="Image4" runat="server" ImageUrl="~/Res/DT.png" ViewStateMode="Enabled" height="114" Width="112" PostBackUrl="~/Apps/DeskTest/DeskTest.aspx"/>
                </div>
                <div style="position:absolute; left:41%; top:50%;">
                    <asp:ImageButton ID="Image5" runat="server" ImageUrl="~/Res/AD.png" ViewStateMode="Enabled" height="114" Width="127" PostBackUrl="~/Apps/AppDes/AppDesigner.aspx"/>
                </div>
                <div style="position:absolute; left:58%; top:50%;">
                    <asp:ImageButton ID="Image6" runat="server" ImageUrl="~/Res/WD.png" ViewStateMode="Enabled" height="114" Width="131" PostBackUrl="~/Apps/WebDes/WebDes.aspx"/>
                </div>
            </LoggedInTemplate>
        </asp:LoginView>
</asp:Content>
