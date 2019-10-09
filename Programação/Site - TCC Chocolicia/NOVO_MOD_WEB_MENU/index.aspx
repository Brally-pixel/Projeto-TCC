<%@ Page Language="vb"%>

<script runat="server">
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs)

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

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
            width: 368px;
            height: 812px;
        }
        .style2
        {
            height: -12px;
            width: 1068px;
        }
        .style3
        {
            width: 368px;
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
        </style>
</head>
<body style="background-image:url(/Fundo.jpg)">
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
                <div><div id="sb-slider" class="sb-slider" 
                        style="width: 320px; height: 50px; margin-left: 215px; margin-top: 122px;">
				<img alt="Sei lá" src="oi.jpg" title="Imagem 1"/>
				<img alt="Sei lá" src="oi2.png" title="Imagem 2"/>
				<img alt="Sei lá" src="oi3.jpg" title="Imagem 3"/>
			</div>
	    <script type="text/javascript" src="js/jquery.min.js"></script>
		<script type="text/javascript" src="js/jquery.slicebox.min.js"></script>
		<script type="text/javascript">
		    $(function() {
		        $('#sb-slider').slicebox({
		            slicesCount: 3,
		            sequentialRotation: true,
		            sequentialFactor: 500,
		            speed3d: 1000,
		            slideshow: true,
		            slideshowTime: 6000,
		            orientation: 'h'
		        });

		        if (!Modernizr.csstransforms3d) {
		            $('#sb-note').show();

		            $('body').append(
						$('script').attr('type', 'text/javascript').attr('src', 'js/jquery.easing.1.3.js')
					);
		        }
		    });
		</script>
</div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <a href="http://localhost:58584/Produtos.aspx"><img alt="" src="Produtos.jpg" 
                        style="width: 292px; height: 171px" /></a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <a href="http://localhost:58584/Receitas.aspx"><img alt="" src="Receitas.jpg" 
                        style="width: 291px; height: 172px" /></a><br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    
                    <div style="width: 194px; margin-left: 223px";>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Aceitamos:</div>
                    <br />
                    
                    <img alt="" src="images/logos%20completos.jpg" 
                        style="width: 484px; height: 72px; margin-left: 223px" /></td></tr>
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
          <div class="fb-like-box" data-href="http://www.facebook.com/pages/Chocol%C3%ADcia/413079238754945" data-width="292" data-show-faces="true" data-border-color="pink" data-stream="false" data-header="true"></div>
          <br />
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="https://twitter.com/lojachocolicia" class="twitter-follow-button" data-show-count="false" data-lang="pt" data-size="large">Seguir @lojachocolicia</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0];if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src="//platform.twitter.com/widgets.js";fjs.parentNode.insertBefore(js,fjs);}}(document,"script","twitter-wjs");</script>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    </table>
       </form>
       </body>
</html>

