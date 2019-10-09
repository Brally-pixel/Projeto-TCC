<%@ import namespace="system.data" %>
<%@ import namespace="system.data.sqlclient" %>
<%@ Page Language="vb"%>
<script runat="server">
Sub Cad_FaleConosco()
        Dim M As Integer = 0        
        If TxtNome.ToString.Trim = "" Then
            MsgBox("Preencha o campo Nome.")
            M = 1
        ElseIf TxtEmail.ToString = "" Then
            MsgBox("Preencha o campo E-mail.")
            M = 1
        ElseIf TxtRecado.ToString = "" Then
            MsgBox("O Recado esta vazio.")
            M = 1
        End If
If M = 0 then
Dim cn As SqlConnection
Dim cmd As New SqlCommand 
            cn = New SqlConnection("Data Source=.;Initial Catalog=Loja_Chocolicia;Persist Security Info=True;User ID=sa;Password=123456;")
cn.Open()
With cmd
.Connection = cn
.CommandText = "IncluiFaleConosco"
                .Parameters.AddWithValue("@Nome", TxtNome.Text)
.Parameters.AddWithValue("@Email", TxtEmail.Text)
.Parameters.AddWithValue("@Recado", TxtRecado.Text)
.CommandType = CommandType.StoredProcedure
.ExecuteNonQuery()
End With
MsgBox("Mensagem enviada!", 32, "Fale Conosco")
LimpaCampos()
End if
End Sub
Sub LimpaCampos()
TxtNome.Text = ""
TxtEmail.Text = ""
TxtRecado.Text = ""
End Sub
</script>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <title>Chocolícia</title>
    <link rel="stylesheet" type="text/css" href="css/slicebox.css" />
	<script type="text/javascript" src="js/modernizr.custom.13303.js"></script>
    <%--style type="text/css">
        #form1
        {
            height: 129px;
            width: 1059px;
        }
        .style1
        {
            width: 223px;
        }
        #Select1
        {
            width: 95px;
        }
        .style2
        {
            width: 719px;
        }
        .style3
        {
            width: 262px;
            height: 152px;
        }
        .style5
        {
            width: 25px;
            height: 24px;
        }
        .style6
        {
            width: 28px;
            height: 26px;
        }
        .style7
        {
            width: 261px;
            height: 161px;
        }
        .style9
        {
            background-color: #808080;
        }
    </style>--%>
    <style type="text/css">
        .style1
        {
            width: 279px;
            height: 796px;
        }
        .style2
        {
            height: -12px;
            width: 1068px;
        }
        .style3
        {
            width: 279px;
            height: 114px;
        }
        #File1
        {
            height: 56px;
        }
        #TextArea1
        {
            width: 960px;
            height: 511px;
            margin-left: 24px;
            margin-top: 0px;
        }
        #Reset1
        {
            height: 31px;
            width: 50px;
        }
        #Submit1
        {
            height: 44px;
            width: 96px;
        }
        .fb-like-box
        {
            height: 18px;
            width: 287px;
            margin-left: 14px;
        }
        #Text1
        {
            width: 313px;
            margin-left: 0px;
        }
 p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:10.0pt;
	margin-left:0cm;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
        #Text2
        {
            width: 473px;
            height: 287px;
            margin-left: 0px;
        }
        #Text3
        {
            width: 313px;
        }
        #TxtEmail
        {
            width: 309px;
        }
        #TxtNome
        {
            width: 310px;
        }
        #TxtRecado
        {
            height: 271px;
            width: 470px;
        }
        </style>
        <script>            (function(d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) return;
                js = d.createElement(s); js.id = id;
                js.src = "//connect.facebook.net/pt_BR/all.js#xfbml=1";
                fjs.parentNode.insertBefore(js, fjs);
            } (document, 'script', 'facebook-jssdk'));</script>

        </head>
<body style="background-image:url(/Fundo2.1.png)">

    <table width="100%" border="1" style="height: 704px">
    <tr>
        <td valign="bottom" class="style3">
        
            <a href="http://localhost:58584/index.aspx">
            <img alt="" src="logo2.png" 
                style="width: 223px; margin-top: 40px; margin-left: 57px; height: 110px" /></a>
                &nbsp;
                </td>
                <td rowspan="2" class="style2" valign="top">

                    <br />
                    <br />
                    <a href="http://localhost:58584/Torta.aspx"><img alt="" src="outra.png" 
                        style="width: 535px; height: 204px; margin-left: 185px" /></a><br />
                    <br />
                    <br />
                    <br />
    <br />                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
                        Font-Size="XX-Large" ForeColor="#482400" Text="Fale Conosco"></asp:Label>
                    &nbsp;<br />
                    <div style="width: 616px; height: 208px; margin-left: 169px">
                        <br />
                        <br />
                        &nbsp;&nbsp; Para falar com nossos funcionários, tirar dúvidas e para enviar críticas e sujestões utilize os meios de comunicaçao 
                        ou os campos abaixo:
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp; email: lojachocolicia@hotmail.com</a><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp; telefone: (11)&nbsp; 4135-6287<br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;celular:&nbsp; (11)&nbsp; 9.7867-4238&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;
                    <p class="MsoNormal">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        Nome:<o:p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </o:p>
                        
                      
                        <asp:TextBox ID="TxtNome" runat="server" Height="22px" Width="358px"></asp:TextBox>
                    <p class="MsoNormal">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </o:p>
                       
                        <asp:TextBox ID="TxtEmail" runat="server" Height="22px" Width="358px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TxtRecado" runat="server" Height="338px" Width="573px"></asp:TextBox><br />
                    <p class="MsoNormal">
                        &nbsp;<p class="MsoNormal">
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Btncad" runat="server" Text="Cadastrar" Height="62px" Width="193px"
BackColor="#D5DEE7" ForeColor="Black" Style="font-size: x-large;"
OnClick="Cad_FaleConosco" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <div style="width: 194px; margin-left: 195px";>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Aceitamos:
                       <br />
                    <br />
                    
                    <img alt="" src="images/logos%20completos.jpg" 
                        style="width: 484px; height: 72px; margin-left: 0px" /><br />
                        <br />
                        <br />
            </td>
    </tr>
    <tr>
      
      <td class="style1" valign="top" style="margin-left: 50px">
        <asp:Menu ID="Menu1" runat="server" BackColor="Transparent" 
            DynamicHorizontalOffset="10" Font-Bold="True" Font-Names="Kokila" 
            Font-Size="XX-Large" ForeColor="#482400" Height="200px" Orientation="Vertical" 
            PathSeparator="|" StaticSubMenuIndent="300px" Width="380px" 
            Font-Italic="True" 
              Font-Strikeout="False" Font-Underline="False">
            <StaticSelectedStyle BackColor="#1C5E55" />
            <StaticMenuItemStyle HorizontalPadding="90px" VerticalPadding="2px" />
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <Items>
            
                <asp:MenuItem NavigateUrl="~/QuemSomos.aspx" Text="  Quem Somos" Value="    Quem Somos"></asp:MenuItem>
                <asp:MenuItem Text="" Value=""></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/localizacao.aspx" Text="  Localização" Value="    Localização"></asp:MenuItem>
                <asp:MenuItem Text="" Value=""></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/fale_conosco.aspx" Text="  Fale Conosco" Value="    Fale Conosco"></asp:MenuItem>
                <asp:MenuItem Text="" Value=""></asp:MenuItem>
                <asp:menuitem NavigateUrl="~/cadastro.aspx" text="  Cadastro" Value="    Cadastro"></asp:menuitem>
            </Items>
        </asp:Menu>
        <br />
        <br />
          <br />
          <br />
          <br />
          <div class="fb-like-box" data-href="http://www.facebook.com/pages/Chocol%C3%ADcia/413079238754945" data-width="292" data-show-faces="true" data-border-color="pink" data-stream="false" data-header="true"></div>
          <br />
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="https://twitter.com/lojachocolicia" class="twitter-follow-button" data-show-count="false" data-lang="pt" data-size="large">Seguir @lojachocolicia</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src="//platform.twitter.com/widgets.js";fjs.parentNode.insertBefore(js,fjs);}}(document,"script","twitter-wjs");</script>

          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    </table>
       </form>
       </body>
</html>

