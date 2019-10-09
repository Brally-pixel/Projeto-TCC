    <%@ Import Namespace="system.data" %>
    <%@ Import Namespace="system.data.sqlclient" %>
    <%@ Page Language="vb"%>

<script runat="server">
    Dim Estado As Integer
    Dim Cidade As Integer
    Sub ComboEstado()
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        cn = New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "Select UF_Estado from estados_tbl"
            .CommandType = CommandType.Text
        End With
        Dim mr As SqlDataReader = cmd.ExecuteReader()
        If DDLUF.Items.Count = 0 Then
            DDLUF.Items.Add("Selecione um Estado")
            While mr.Read
                DDLUF.Items.Add(mr("UF_Estado").ToString)
            End While
        End If
        cn.Close()
    End Sub
    
    Function GetEstado() As Integer
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        cn = New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")

        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "Select CodEstado from estados_tbl where UF_Estado = '" + DDLUF.SelectedItem.ToString + "'"
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
        cn = New SqlConnection("Data Source=.;Initial Catalog=Loja_Chocolicia;Persist Security Info=True;User ID=sa;Password=123456;")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandText = "Select CodCidade from cidades_tbl where Nome_Cidade = '" + DDLCid.SelectedItem.Text.ToString + "'"
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
        cn = New SqlConnection("Data Source=.;Initial Catalog=Loja_Chocolicia;Persist Security Info=True;User ID=sa;Password=123456;")
        If DDLUF.SelectedItem.Text <> "Selecione um Estado" Then
            GetEstado()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandText = "Select Nome_Cidade from cidades_tbl where CodEstado='" & Estado & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = cmd.ExecuteReader()
            DDLCid.Items.Clear()
            While mr.Read
                DDLCid.Items.Add(mr("Nome_Cidade").ToString)
            End While
            cn.Close()
        Else
            DDLCid.Items.Clear()
        End If
    End Sub
    Sub Cad_Cli()
        Dim tM As Integer = 0
        If TxtNome.Text.ToString.Trim = "" Then
            MsgBox("Preencha o campo Nome.")
            tM = 1
        ElseIf TxtDataNascimento.Text.ToString = "" Then
            MsgBox("Preencha o campo Data.")
            tM = 1
        ElseIf TxtCPF.Text.ToString.Replace("_", "").Trim = "" Then
            MsgBox("Preencha o campo CPF.")
            tM = 1
        ElseIf F.Checked = False And M.Checked = False Then
            MsgBox("Selecione o Sexo.")
            tM = 1
        ElseIf C.Checked = False And D.Checked = False And S.Checked = False And V.Checked = False Then
            MsgBox("Selecione o Estado Civil.")
            tM = 1
        ElseIf DDLUF.SelectedIndex = -1 Then
            MsgBox("Selecione um Estado.")
            tM = 1
        ElseIf DDLUF.SelectedIndex = -1 Then
            MsgBox("Selecione uma Cidade.")
            tM = 1
        ElseIf TxtBai.Text.ToString.Trim = "" Then
            MsgBox("Preencha o campo Bairro.")
            tM = 1
        ElseIf TxtEnd.Text.ToString.Trim = "" Then
            MsgBox("Preencha o campo Rua.")
            tM = 1
        ElseIf TxtNum.Text.ToString.Trim = "" Then
            MsgBox("Preencha o campo Número.")
            tM = 1
        ElseIf TxtCEP.Text.ToString.Replace("_", "").Trim = "" Then
            MsgBox("Preencha o campo CEP.")
            tM = 1
        End If
        If tM = 0 Then
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
                cn = New SqlConnection("Data Source=.;Initial Catalog=Loja_Chocolicia;Persist Security Info=True;User ID=sa;Password=123456;")
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandText = "SP_insert_clien"
                    .Parameters.AddWithValue("@CPF", (TxtCPF.Text.ToString.Substring(0, 3) + TxtCPF.Text.ToString.Substring(4, 3) + TxtCPF.Text.ToString.Substring(8, 3) + TxtCPF.Text.ToString.Substring(12, 2)).ToString)
                    .Parameters.AddWithValue("@Nome", TxtNome.Text)
                    If M.Checked = True Then
                        .Parameters.AddWithValue("@Sexo", "M")
                    ElseIf F.Checked = True Then
                        .Parameters.AddWithValue("@Sexo", "F")
                    End If
                    .Parameters.AddWithValue("@Data_de_Nascimento", CDate(TxtDataNascimento.Text))
                    If C.Checked = True Then
                        .Parameters.AddWithValue("@Estado_Civil", "Casado(a)")
                    ElseIf S.Checked = True Then
                        .Parameters.AddWithValue("@Estado_Civil", "Solteiro(a)")
                    ElseIf D.Checked = True Then
                        .Parameters.AddWithValue("@Estado_Civil", "Divorciado(a)")
                    ElseIf V.Checked = True Then
                        .Parameters.AddWithValue("@Estado_Civil", "Viuvo(a)")
                    End If
                    .Parameters.AddWithValue("@CodEstado", Convert.ToInt16(DDLUF.SelectedIndex) + 1)
                    .Parameters.AddWithValue("@CodCidade", Cidade)
                    .Parameters.AddWithValue("@Bairro", TxtBai.Text)
                    .Parameters.AddWithValue("@Endereco", TxtEnd.Text)
                    .Parameters.AddWithValue("@Numero", TxtNum.Text)
                    .Parameters.AddWithValue("@Complemento", TxtComp.Text)
                    .Parameters.AddWithValue("@CEP", (TxtCEP.Text.Substring(0, 5) + TxtCEP.Text.Substring(6, 3)).ToString)
                    .Parameters.AddWithValue("@Numero_Tel", (TxtTelFix.Text.Substring(1, 2) + TxtTelFix.Text.Substring(4, 4) + TxtTelFix.Text.Substring(9, 4)).ToString)
                    .Parameters.AddWithValue("@E_mail", TxtEmail.Text)
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
        F.Checked = False
        M.Checked = False
        C.Checked = False
        D.Checked = False
        S.Checked = False
        V.Checked = False
        TxtTelFix.Text = ""
        TxtEmail.Text = ""
        DDLUF.Items.Clear()
        DDLCid.Items.Clear()
        TxtBai.Text = ""
        Txtend.Text = ""
        TxtNum.Text = ""
        TxtComp.Text = ""
        TxtCEP.Text = ""
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title>Chocolícia</title>
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
        
        </style>
</head>
<body style="background-image:url(/Fundo4.png)">
    <form id="form1" runat="server">

    <table width="100%" border="1" style="height: 704px">
    <tr>
        <td valign="bottom" class="style3"> 
    
                <a href="http://localhost:58584/index.aspx"><img alt="" src="LOGO OFICIAL.png" 
                style="width: 223px; margin-top: 40px; margin-left: 17px; height: 110px" /></a>
                &nbsp;
                </td>
                <td rowspan="2" class="style2" valign="top">  
                <br />
                <br />
                
                 <a href="http://localhost:58584/Promocao.aspx">
                 <img alt="" src="otra2.png" 
                 style="width: 535px; height: 204px; margin-left: 198px" /></a><br />
                 <br />
                 <br />                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                    
                    &nbsp;<div>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label2" runat="server" Font-Bold="True" 
                        Font-Italic="True" Font-Size="XX-Large" ForeColor="#482400" Text="     Cadastre-se "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
<div style="height: 360px">


                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label3" runat="server" text="Nome:" Font-Size="X-Large" Font-Bold="True" />                                                                                
                            &nbsp;<asp:TextBox ID="TxtNome" runat="server" 
                        Width="292px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            &nbsp;&nbsp;
                                             <asp:Label ID="Label10" runat="server" text="C.P.F:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;<asp:TextBox ID="TxtCPF" runat="server" width="140px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                             <asp:Label ID="Label4" runat="server" text="Sexo:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                    
                            &nbsp;<asp:RadioButton 
                            ID="M" runat="server" Text="Masculino" />
                            &nbsp;<asp:RadioButton 
                            ID="F" runat="server" Text="Feminino" />
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             <asp:Label ID="Label5" runat="server" text="Estado Civil:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                    
                            &nbsp;<asp:RadioButton ID="S" runat="server" Text="Solteiro" />
&nbsp;
                        <asp:RadioButton ID="C" runat="server" Text="Casado" />
&nbsp;
                        <asp:RadioButton ID="D" runat="server" Text="Divorciado" />
&nbsp;
                        <asp:RadioButton ID="V" runat="server" Text="Viúvo" />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             <asp:Label ID="Label6" runat="server" text="Endereço:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;                                                                
                            <asp:TextBox ID="TxtEnd" runat="server"
                        width="248px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                             <asp:Label ID="Label15" runat="server" text="Número:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;&nbsp;<asp:TextBox ID="TxtNum" runat="server"
                        width="140px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label8" runat="server" text="Complemento:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                &nbsp;&nbsp;<asp:TextBox ID="TxtComp" runat="server"
                        width="140px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="Label9" runat="server" text="CEP:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;          <asp:TextBox ID="TxtCEP" runat="server" width="140px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                                           <asp:Label ID="Label11" runat="server" text="Bairro:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;                                                                
                            <asp:TextBox ID="TxtBai" runat="server"
                        width="220px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                           <asp:Label ID="Label17" runat="server" text="Estado:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;&nbsp;<asp:DropDownList 
                            ID="DDLUF" runat="server" Height="22px" Width="220px" 
        style="margin-left: 0px"   onload="ComboEstado" 
         AutoPostBack="True" OnSelectedIndexChanged="ComboCidade">
                        </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                           <asp:Label ID="Label12" runat="server" text="Cidade:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp; 
                            <asp:DropDownList 
                            ID="DDLCid" runat="server" Height="22px" Width="220px">
                        </asp:DropDownList>
                            &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                            <asp:Label ID="Label13" runat="server" text="Telefone Fixo:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;&nbsp;<asp:TextBox ID="TxtTelFix" runat="server" width="140px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

                                            <asp:Label ID="Label14" runat="server" text="Email:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                
                            &nbsp;&nbsp;<asp:TextBox ID="TxtEmail" runat="server"
                        width="226px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                                             <asp:Label ID="Label7" runat="server" text="Data de Nascimento:" 
                        Font-Size="X-Large" Font-Bold="True" />                                                                    
                            &nbsp;&nbsp;<asp:TextBox ID="TxtDataNascimento" runat="server" Width="140px"/>&nbsp;&nbsp;&nbsp; DD/MM/AAAA</div>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                                                               &nbsp;&nbsp;&nbsp;&nbsp;<br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" style="background-color:" Height="37px" Text="Efetuar Cadastro" 
                            Width="169px" Font-Bold="True" Font-Italic="True" Font-Size="Medium" onclick="Cad_Cli" 
                            />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     </div>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <div style="width: 194px; margin-left: 195px";>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Aceitamos:
                    </div>
                    <br />
                    <img alt="" src="images/logos%20completos.jpg" 
                        style="width: 484px; height: 72px; margin-left: 1px" /><br />
                        <br />
                        <br />
            </td></tr>
    <tr>
      
      <td class="style1" valign="top" style="margin-left: 50px">
        <asp:Menu ID="Menu1" runat="server" BackColor="Transparent" 
            DynamicHorizontalOffset="10" Font-Bold="True" Font-Names="Kokila" 
            Font-Size="XX-Large" ForeColor="#482400" Height="200px" Orientation="Vertical" 
            PathSeparator="|" StaticSubMenuIndent="300px" Width="323px" 
            Font-Italic="True" 
            Font-Strikeout="False" Font-Underline="False">
            <StaticSelectedStyle BackColor="#1C5E55" />
            <StaticMenuItemStyle HorizontalPadding="50px" VerticalPadding="2px" />
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <Items>
              
                <asp:MenuItem NavigateUrl="~/QuemSomos.aspx" Text="Quem Somos" Value="    Quem Somos"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/localizacao.aspx" Text="Localização" Value="    Localização"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/fale_conosco.aspx" Text="Fale Conosco" Value="    Fale Conosco"></asp:MenuItem>
                <asp:menuitem NavigateUrl="~/cadastro.aspx" text="Cadastro" Value="    Cadastro"></asp:menuitem>
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    </table>
       </form>
       </body>
</html>