<%@ Import Namespace="system.data" %>
<%@ Import Namespace="system.data.sqlclient" %>

<%@ Page Language="vb" %>

<script runat="server">
Dim Estado As Integer
Dim Cidade As Integer
Sub ComboEstado()
Dim cn As SqlConnection
Dim cmd As New SqlCommand
'cn = New SqlConnection("Data Source=DIEGO-PC\SQLEXPRESS;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")
cn = New SqlConnection("Data Source=DALILLA-PC\;Initial Catalog=TCC;Integrated Security=True")
cn.Open()
With cmd
.Connection = cn
.CommandText = "Select uf from estados_tbl"
.CommandType = CommandType.Text
End With
Dim mr As SqlDataReader = cmd.ExecuteReader()
If DDLUF.Items.Count = 0 Then
DDLUF.Items.Add("Selecione um Estado")
While mr.Read
DDLUF.Items.Add(mr("uf").ToString)
End While
End If
cn.Close()
End Sub
Function GetEstado() As Integer
Dim cn As SqlConnection
Dim cmd As New SqlCommand
cn = New SqlConnection("Data Source=DALILLA-PC\;Initial Catalog=TCC;Integrated Security=True")
'cn = New SqlConnection("Data Source=DIEGO-PC\SQLEXPRESS;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")

cn.Open()
With cmd
.Connection = cn
.CommandText = "Select CodEstado from estados_tbl where uf = '" + DDLUF.SelectedItem.ToString + "'"
.CommandType = CommandType.Text
End With
Dim mr As SqlDataReader = cmd.ExecuteReader()
While mr.Read
Estado = mr!CodEstado
End While
Return Estado
cn.Close()
End Function
Function GetCidade() As Integer
Dim cn As SqlConnection
Dim cmd As New SqlCommand
cn = New SqlConnection("Data Source=DALILLA-PC\;Initial Catalog=TCC;Integrated Security=True")
'cn = New SqlConnection("Data Source=DIEGO-PC\SQLEXPRESS;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")
cn.Open()
With cmd
.Connection = cn
.CommandText = "Select CodCidade from cidades_tbl where Cidade = '" + DDLCid.SelectedItem.Text.ToString + "'"
.CommandType = CommandType.Text
End With
Dim mr As SqlDataReader = cmd.ExecuteReader()
While mr.Read
Cidade = mr!CodCidade
End While
Return Estado
cn.Close()
End Function
Sub ComboCidade()
Dim cn As SqlConnection
Dim cmd As New SqlCommand
'cn = New SqlConnection("Data Source=DIEGO-PC\SQLEXPRESS;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")
cn = New SqlConnection("Data Source=DALILLA-PC\;Initial Catalog=TCC;Integrated Security=True")
If DDLUF.SelectedItem.Text <> "Selecione um Estado" Then
GetEstado()
cn.Open()
With cmd
.Connection = cn
.CommandText = "Select Cidade from cidades_tbl where CodEstado='" & Estado & "'"
.CommandType = CommandType.Text
End With
Dim mr As SqlDataReader = cmd.ExecuteReader()
DDLCid.Items.Clear()
While mr.Read
DDLCid.Items.Add(mr("Cidade").ToString)
End While
cn.Close()
Else
DDLCid.Items.Clear()
End If
End Sub
Sub Cad_Cli()
Dim M As Integer = 0
If TxtNome.Text.ToString.Trim = "" Then
MsgBox("Preencha o campo Nome.")
M = 1
ElseIf TxtDataNascimento.Text.ToString = "" Then
MsgBox("Preencha o campo Data.")
M = 1
ElseIf TxtCPF.Text.ToString.Replace("_", "").Trim = "" Then
MsgBox("Preencha o campo CPF.")
M = 1
ElseIf RdBFem.Checked = False And RdBMasc.Checked = False Then
MsgBox("Selecione o Sexo.")
M = 1
ElseIf RdBCas.Checked = False And RdBDiv.Checked = False And RdBSol.Checked = False And RdBViu.Checked = False Then
MsgBox("Selecione o Estado Civil.")
M = 1
ElseIf DDLUF.SelectedIndex = -1 Then
MsgBox("Selecione um Estado.")
M = 1
ElseIf DDLUF.SelectedIndex = -1 Then
MsgBox("Selecione uma Cidade.")
M = 1
ElseIf TxtBairro.Text.ToString.Trim = "" Then
MsgBox("Preencha o campo Bairro.")
M = 1
ElseIf TxtRua.Text.ToString.Trim = "" Then
MsgBox("Preencha o campo Rua.")
M = 1
ElseIf TxtNum.Text.ToString.Trim = "" Then
MsgBox("Preencha o campo Número.")
M = 1
ElseIf TxtCEP.Text.ToString.Replace("_", "").Trim = "" Then
MsgBox("Preencha o campo CEP.")
M = 1
End If
If M = 0 Then
Dim N As Integer = 0
Dim i, x, n1, n2 As Integer
For x = 0 To 1
n1 = 0
For i = 0 To 8 + x
n1 = n1 + Val((TxtCPF.Text.ToString.Substring(0, 3) + TxtCPF.Text.ToString.Substring(4, 3) + TxtCPF.Text.ToString.Substring(8, 3) + TxtCPF.Text.ToString.Substring(12, 2)).ToString.Substring(i, 1)) * (10 + x - i)
Next
n2 = 11 - (n1 - (Int(n1 / 11) * 11))
If n2 = 10 Or n2 = 11 Then n2 = 0
If n2 <> Val((TxtCPF.Text.ToString.Substring(0, 3) + TxtCPF.Text.ToString.Substring(4, 3) + TxtCPF.Text.ToString.Substring(8, 3) + TxtCPF.Text.ToString.Substring(12, 2)).ToString.Substring(9 + x, 1)) Then
N = 1
End If
Next
If N = 0 Then
GetCidade()
Dim cn As SqlConnection
Dim cmd As New SqlCommand
'cn = New SqlConnection("Data Source=DIEGO-PC\SQLEXPRESS;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")
cn = New SqlConnection("Data Source=DALILLA-PC\;Initial Catalog=TCC;Integrated Security=True")
'cn = New SqlConnection("Data Source=localhost;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")
cn.Open()
With cmd
.Connection = cn
.CommandText = "IncluiCli"
.Parameters.AddWithValue("@CPF_Cli", (TxtCPF.Text.ToString.Substring(0, 3) + TxtCPF.Text.ToString.Substring(4, 3) + TxtCPF.Text.ToString.Substring(8, 3) + TxtCPF.Text.ToString.Substring(12, 2)).ToString)
.Parameters.AddWithValue("@Nome_Cli", TxtNome.Text)
If RdBMasc.Checked = True Then
.Parameters.AddWithValue("@Sexo_Cli", "M")
ElseIf RdBFem.Checked = True Then
.Parameters.AddWithValue("@Sexo_Cli", "F")
End If
.Parameters.AddWithValue("@Data_Nasc_Cli", CDate(TxtDataNascimento.Text))
If RdBCas.Checked = True Then
.Parameters.AddWithValue("@Est_Civil_Cli", "C")
ElseIf RdBSol.Checked = True Then
.Parameters.AddWithValue("@Est_Civil_Cli", "S")
ElseIf RdBDiv.Checked = True Then
.Parameters.AddWithValue("@Est_Civil_Cli", "D")
ElseIf RdBViu.Checked = True Then
.Parameters.AddWithValue("@Est_Civil_Cli", "V")
End If
.Parameters.AddWithValue("@Cod_UF_Cli", Convert.ToInt16(DDLUF.SelectedIndex) + 1)
.Parameters.AddWithValue("@Cod_Cidade_Cli", Cidade)
.Parameters.AddWithValue("@Bairro_Cli", TxtBairro.Text)
.Parameters.AddWithValue("@Rua_Cli", TxtRua.Text)
.Parameters.AddWithValue("@Num_Cli", TxtNum.Text)
.Parameters.AddWithValue("@Comple_Cli", TxtComp.Text)
.Parameters.AddWithValue("@CEP_Cli", (TxtCEP.Text.Substring(0, 5) + TxtCEP.Text.Substring(6, 3)).ToString)
.Parameters.AddWithValue("@Tel_Fix_Cli", (TxtTelFix.Text.Substring(1, 2) + TxtTelFix.Text.Substring(4, 4) + TxtTelFix.Text.Substring(9, 4)).ToString)
.Parameters.AddWithValue("@Tel_Mov_Cli", (TxtTelMov.Text.Substring(1, 2) + TxtTelMov.Text.Substring(4, 5) + TxtTelMov.Text.Substring(10, 4)).ToString)
.Parameters.AddWithValue("@Email_Cli", TxtEmail.Text)
.CommandType = CommandType.StoredProcedure
.ExecuteNonQuery()
End With
MsgBox("Inclusão efetuada com Sucesso!", 32, "Relatorio de Clientes")
LimpaCampos()
cmd.Parameters.Clear()
cn.Close()
Else
MsgBox("CPF inválido.")
End If
End If
End Sub
Sub LimpaCampos()
TxtNome.Text = ""
TxtDataNascimento.Text = ""
TxtCPF.Text = ""
RdBFem.Checked = False
RdBMasc.Checked = False
RdBCas.Checked = False
RdBDiv.Checked = False
RdBSol.Checked = False
RdBViu.Checked = False
TxtTelFix.Text = ""
TxtTelMov.Text = ""
TxtEmail.Text = ""
DDLUF.Items.Clear()
DDLCid.Items.Clear()
TxtBairro.Text = ""
TxtRua.Text = ""
TxtNum.Text = ""
TxtComp.Text = ""
TxtCEP.Text = ""
End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Papelaria N.A.R.J.O.</title>
<link rel="stylesheet" type="text/css" href="css/slicebox.css" />
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery-ui.min.js"></script>
<script type="text/javascript">
function Sliderr() {
$(".sliderr #7").show("fade", 500);
$(".sliderr #7").delay(5500).hide("slide", { direction: "left" }, 1000);

var sc = $(".sliderr img").size();
var count = 1;
setInterval(function() {
$(".sliderr #" + count).show("slide", { direction: "right" }, 1000);
$(".sliderr #" + count).delay(5500).hide("slide", { direction: "left" }, 1000);

if (count == sc) {
count = 1;
} else {
count = count + 1;
}
}, 7500);
}
</script>
<script type="text/javascript">
function Sliderl() {
$(".sliderl #8").show("fade", 500);
$(".sliderl #8").delay(5500).hide("slide", { direction: "left" }, 1000);

var sc = $(".sliderl img").size();
var count = 9;
setInterval(function() {
$(".sliderl #" + count).show("slide", { direction: "right" }, 1000);
$(".sliderl #" + count).delay(5500).hide("slide", { direction: "left" }, 1000);

if (count == sc + 7) {
count = 8;
} else {
count = count + 1;
}
}, 7500);
}
</script>
<script type="text/javascript" src="js/modernizr.custom.13303.js"></script>
<style type="text/css">
.sliderr
{
width: 456px;
height: 168px;
overflow: hidden;
margin: 30px auto;
background-color: #28579D;
background-repeat: no-repeat;
background-position: center;
}
.sliderr img
{
width: 456px;
height: 168px;
display: none;
}
.sliderl
{
width: 456px;
height: 168px;
overflow: hidden;
margin: 30px auto;
background-color: #28579D;
background-repeat: no-repeat;
background-position: center;
}
.sliderl img
{
width: 456px;
height: 168px;
display: none;
}
.more
{
position: relative;
clear: both;
font-weight: 400;
font-size: medium;
}
.more ul
{
display: block;
height: 32px;
text-align: center;
}
.more ul li
{
display: inline;
padding: 2px;
}
.more ul li.selected a, .more ul li.selected a:hover
{
background: #ae997a;
color: #fff;
text-shadow: none;
}
.more ul li a
{
text-shadow: 1px 1px 1px Black;
color: White;
background: #28579D;
padding: 3px 6px;
-moz-box-shadow: 1px 1px 2px #aaa;
-webkit-box-shadow: 1px 1px 2px #aaa;
font-family: Segoe Condensed;
}
.more ul li a:hover
{
background: #D6DFE8;
color: Black;
text-shadow: none;
}
</style>
<style type="text/css">
.style2
{
height: 51px;
}
.style4
{
width: 100px;
}
.style5
{
width: 157px;
}
</style>
</head>
<body background="Layout Blue d.jpg" onload="Sliderl();Sliderr()">
<form id="form1" runat="server">
<table border="0" align="center" cellpadding="0" cellspacing="0">
<tr>
<td class="style4">
<div class="sliderr">
<img id="1" src="/1.jpg" alt="Primeira Imagem" />
<img id="2" src="/2.jpg" alt="Segunda Imagem" />
<img id="3" src="/3.jpg" alt="Terceira Imagem" />
<img id="4" src="/4.jpg" alt="Quarta Imagem" />
<img id="5" src="/5.jpg" alt="Quinta Imagem" />
<img id="6" src="/6.jpg" alt="Sexta Imagem" />
<img id="7" src="/7.jpg" alt="Sétima Imagem" />
</div>
</td>
<td>
<img alt="Simbolo" src="SimboloSite.png" style="width: 377px; height: 168px; background-image: center;" />
</td>
<td>
<div class="sliderl">
<img id="8" src="/1.jpg" alt="Primeira Imagem" />
<img id="9" src="/2.jpg" alt="Segunda Imagem" />
<img id="10" src="/3.jpg" alt="Terceira Imagem" />
<img id="11" src="/4.jpg" alt="Quarta Imagem" />
<img id="12" src="/5.jpg" alt="Quinta Imagem" />
<img id="13" src="/6.jpg" alt="Sexta Imagem" />
<img id="14" src="/7.jpg" alt="Sétima Imagem" />
</div>
</td>
</tr>
<tr>
<td colspan="3" class="style2">
<div class="more">
<ul id="sb-examples">
<li><a href="index.aspx">HOME</a></li>
<li><a href="QuemSomos.aspx">QUEM SOMOS</a></li>
<li><a href="OndeEstamos.aspx">ONDE ESTAMOS</a></li>
<li><a href="MapadoSite.aspx">MAPA DO SITE</a></li>
<li><a href="FaleConosco.aspx">FALE CONOSCO</a></li>
<li><a href="Produtos.aspx">PRODUTOS</a></li>
<li><a href="Cadastro.aspx">CADASTRE-SE AQUI</a></li>
</ul>
</div>
<table border="0" align="center" cellpadding="0" cellspacing="0">
<tr>
<td>
<a href="http://www.facebook.com/PapelariaNarjo"><img alt="" src="images/facebook.png" style="width: 200px; height: 100px" /></a><br />
<br />
<a href="https://twitter.com/PapelariaNARJO "><img alt="" src="images/twitter.png" style="width: 200px; height: 100px" /></a>
</td>
<td rowspan="2" class="style5">
</td>
<td style="width: 800px;">
<h1 style="font-family: Gabriola; font-size: x-large;">
CADASTRO</h1>
</td>
</tr>
<tr>
<td>
</td>
<td style="width: 800px; font-family: Gabriola; font-size: x-large;">
<script src="js/jquery.maskedinput-1.3.min.js" type="text/javascript"></script> 
<script type="text/javascript">
$(document).ready(
function() {
$("#TxtCPF").mask("999.999.999-99");
}
);
</script>
<script type="text/javascript">
$(document).ready(
function data() {
$("#TxtDataNascimento").mask("99/99/9999");
}
);
</script>
<script type="text/javascript">
$(document).ready(
function data() {
$("#TxtCEP").mask("99999-999");
}
);
</script>
<script type="text/javascript">
$(document).ready(
function data() {
$("#TxtTelFix").mask("(99)9999-9999");
}
);
</script>
<script type="text/javascript">
$(document).ready(
function data() {
$("#TxtTelMov").mask("(99)99999-9999");
}
);
</script>
Nome:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtNome" runat="server" Height="22px" Width="358px"></asp:TextBox><br />
Data de nascimento:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtDataNascimento" runat="server"
Width="79px" />&nbsp;&nbsp;&nbsp; <label style=" font-size: small">DD/MM/YYYY</label><br />
CPF:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtCPF"
runat="server" Width="101px" MaxLength="11"/><br />
Sexo:*&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RdBMasc" runat="server" Text=" Feminino"
GroupName="Sexo" /><asp:RadioButton ID="RdBFem" runat="server" Text=" Masculino"
GroupName="Sexo" /><br />
Estado Civil:*&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RdBCas" runat="server" Text=" Casado(a)"
GroupName="EstadoCivil" /><asp:RadioButton ID="RdBSol" runat="server" Text=" Solteiro(a)"
GroupName="EstadoCivil" /><asp:RadioButton ID="RdBDiv" runat="server" Text=" Divorciado(a)"
GroupName="EstadoCivil" /><asp:RadioButton ID="RdBViu" runat="server" Text=" Viúvo(a)"
GroupName="EstadoCivil" /><br />
Telefone fixo:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtTelFix" runat="server" Width="99px"></asp:TextBox><br />
Telefone móvel:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtTelMov" runat="server" Width="114px"></asp:TextBox><br />
E-mail:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtEmail" runat="server" Width="318px"></asp:TextBox><br />
UF:*&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLUF" runat="server" Width="328px" OnLoad="ComboEstado"
OnSelectedIndexChanged="ComboCidade" AutoPostBack="True">
</asp:DropDownList>
<br />
Cidade:*&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLCid" runat="server" Width="295px">
</asp:DropDownList>
<br />
Bairro:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtBairro" runat="server" Width="308px"></asp:TextBox><br />
Rua:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtRua" runat="server" Width="323px"></asp:TextBox>&nbsp;&nbsp;&nbsp;
n°:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtNum" runat="server" Width="59px"></asp:TextBox>&nbsp;&nbsp;&nbsp;
<br />
Comp.:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtComp" runat="server" Width="203px"></asp:TextBox><br />
CEP:*&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtCEP" runat="server" Width="87px" 
MaxLength='8'></asp:TextBox><br />
<br />
<asp:Button ID="Btncad" runat="server" Text="Cadastrar" Height="62px" Width="122px"
BackColor="#D5DEE7" Font-Names="Gabriola" ForeColor="Black" Style="font-size: x-large;"
OnClick="Cad_Cli" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BtnLimp" runat="server" Text="Limpar" Height="61px" Width="127px"
BackColor="#D5DEE7" Font-Names="Gabriola" Style="font-size: x-large" OnClick="LimpaCampos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</td>
</tr>
</td>
</tr>
<tr>
<td style="width: 200px;">
</td>
<td align="center" colspan="3">
<hr />
Nosso horário de funcionamento é de segunda a sexta das 8h às 18h.
<br />
Aos sábados das 8h às 14h.<br />
Rua Grupo Bandeirante, 1204 - Barueri - SP<br />
Telefone para contato: 4291-1892
<br />
E-mail: papelaria_narjo@hotmail.com.
</td>
</tr>
</table>
</form>
</body>
</html>
