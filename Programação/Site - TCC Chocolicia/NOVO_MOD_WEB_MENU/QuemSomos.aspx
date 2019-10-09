<%@ Page Language="vb"%>

<script runat="server">
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs)

    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            margin-left: 41px;
            width: 287px;
        }
        p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:0pt;
	margin-left:0cm;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
        </style>
</head>
<body style="background-image:url(/Fundo0.1.png)">
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/pt_BR/all.js#xfbml=1";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
    <form id="form1" runat="server">

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
                        style="width: 535px; height: 204px; margin-left: 211px" /></a><br />
                    <br />
                    <br />
    <br />                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
                        Font-Size="XX-Large" ForeColor="#482400" Text="Quem Somos"></asp:Label>
                    <br />
                    <br />
                    <div style="width: 602px; height: 510px; margin-left: 184px">
                        <p class="MsoNormal">
                            <span lang="PT" style="font-size:14.0pt;line-height:115%;font-family:&quot;Candara&quot;,&quot;sans-serif&quot;;
mso-fareast-font-family:&quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Courier New&quot;;
mso-ansi-language:PT;mso-fareast-language:PT-BR">&nbsp;&nbsp; A Chocolícia, que está no ramo de vendas de 
                            chocolate desde 2009, vem a cada ano se destacando por conta de sua ótima 
                            participação no mercado.<span style="mso-spacerun:yes">&nbsp; </span>A loja, que 
                            hoje se encontra localizada na cidade de Barueri, SP, tem a participação 
                            incansável de mais de 150 funcionários, que se dedicam para que a loja venha ser 
                            reconhecida tornando-se assim um grande estabelecimento. </span>
                            <span style="mso-ascii-font-family:Calibri;mso-fareast-font-family:&quot;Times New Roman&quot;;
mso-hansi-font-family:Calibri;mso-bidi-font-family:Calibri;mso-fareast-language:
PT-BR"><o:p></o:p></span>
                        </p>
                        <p class="MsoNormal">
                            <span lang="PT" style="font-size:14.0pt;line-height:115%;font-family:&quot;Candara&quot;,&quot;sans-serif&quot;;
mso-fareast-font-family:&quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Courier New&quot;;
mso-ansi-language:PT;mso-fareast-language:PT-BR"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span>A 
                            pequena venda que incialmente não passava-se de um hob, além de uma forma de 
                            aumentar a renda famíliar da antiga empregada doméstica Dona Luiza, acabou por 
                            se tornar uma grande ideia após perceber que os bombons feitos por ela e 
                            vendidos sob o sistema “porta em porta” na própria vizinhança, faziam sucesso e 
                            rediam um ótimo lucro na renda familiar.
                            <br />
                            <span style="mso-spacerun:yes">&nbsp;&nbsp; </span>Então, com o apoio da família 
                            começa a fabricação de uma quantidade maior de bombons, abandona o sistema 
                            “porta em porta” e passa a comercializar em sua<span style="mso-spacerun:yes">&nbsp;
                            </span>própria residência, mas agora com grandes pedidos de encomendas. Após um 
                            ano, por conta do deslanche das vendas, D.Lúzia compra sua primeira máquina de 
                            chocolates, aumentando ainda mais a produção e possibilitando a fabricação de 
                            novos sabores de chocolates.<br />
                            <span style="mso-spacerun:yes">&nbsp;&nbsp; </span>Hoje com uma fabricação e 
                            venda maior de chocolates que a incial, ergueu seu próprio estabelecimento, ao 
                            qual deu o nome de Chocolícia. </span>
                        </p>
                        <p class="MsoNormal">
                            <span lang="PT" style="font-size:14.0pt;line-height:115%;font-family:&quot;Candara&quot;,&quot;sans-serif&quot;;
mso-fareast-font-family:&quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Courier New&quot;;
mso-ansi-language:PT;mso-fareast-language:PT-BR">A loja que conta com os mais variados sabores de chocoates, 
                            também comerciliza outros deliciosos e saborosos produtos como: tortas, 
                            capuccinos, cafés, cupcakes e bolos. Venha você também conferir os produtos da 
                            Chocolícia, a loja que é uma delícia de chocolate!</span><span style="mso-ascii-font-family:Calibri;mso-fareast-font-family:&quot;Times New Roman&quot;;
mso-hansi-font-family:Calibri;mso-bidi-font-family:Calibri;mso-fareast-language:
PT-BR"><o:p></o:p></span></p>
                    </div>
                    <br />

                
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <div style="width: 194px; margin-left: 195px";>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Aceitamos:
                        <br />
                    <br />
                    
                    <img alt="" src="images/logos%20completos.jpg" 
                        style="width: 484px; height: 72px; margin-left: 4px" /><br />
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
            onmenuitemclick="Menu1_MenuItemClick" Font-Italic="True" 
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
          <br />
          <div class="fb-like-box" data-href="http://www.facebook.com/pages/Chocol%C3%ADcia/413079238754945" data-width="292" data-show-faces="true" data-border-color="pink" data-stream="false" data-header="true"></div>
          <br />
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="https://twitter.com/lojachocolicia" class="twitter-follow-button" data-show-count="false" data-lang="pt" data-size="large">Seguir @lojachocolicia</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src="//platform.twitter.com/widgets.js";fjs.parentNode.insertBefore(js,fjs);}}(document,"script","twitter-wjs");</script>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    </table>
       </form>
       </body>
</html>

