Imports System.Data.SqlClient
Public Class Cadastro_Fornecedor
    Public cn As New cls_Conexao
    Dim objFor As New ClsFornecedor
    Dim Cone As New cls_Conexao
    Dim objLimpar As New Cls_Limpar
    Dim objBlo_Des As New Cls_Blo_Des
    Public D As Integer = 0
    Private Sub Cadastrar_Fornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        objFor.ComboEstado()
        If D = 0 Then
            objBlo_Des.GBDisabled(Me)
            BtnNovo.Enabled = True
            objFor.Cod_Forn()
        ElseIf D = 1 Then

            D = 0
        End If
    End Sub

    Private Sub CB_UF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_UF.SelectedIndexChanged
        'objFor.ComboCidade()
    End Sub
    Dim m As Integer = 0
    Dim m2 As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCadastrar.Click
        Try
            With objFor

                If Nome_Fanta.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Nome_Fanta.Select()
                    m2 = 1

                ElseIf Razao_social.Text = "" Then
                    MsgBox("Campo inválido")
                    Razao_social.Select()
                    m2 = 1

                ElseIf M_CNPJ.Text = "" Then
                    MsgBox("Campo inválido")
                    M_CNPJ.Select()
                    m2 = 1

                ElseIf Site_For.Text = "" Then
                    MsgBox("Campo inválido")
                    Site_For.Select()
                    m2 = 1

                ElseIf Email.Text = "" Then
                    MsgBox("Campo inválido")
                    Email.Select()
                    m2 = 1

                ElseIf CB_Cidade.SelectedIndex = -1 Then
                    MsgBox("Campo inválido")
                    CB_Cidade.Select()
                    m2 = 1

                ElseIf CB_UF.SelectedIndex = -1 Then
                    MsgBox("Campo inválido")
                    CB_UF.Select()
                    m2 = 1

                ElseIf Bairro.Text = "" Then
                    MsgBox("Campo inválido")
                    Bairro.Select()
                    m2 = 1

                ElseIf Endere.Text = "" Then
                    MsgBox("Campo inválido")
                    Endere.Select()
                    m2 = 1

                ElseIf Numero.Text = "" Then
                    MsgBox("Campo inválido")
                    Numero.Select()
                    m2 = 1

                ElseIf M_CEP.Text = "" Then
                    MsgBox("Campo inválido")
                    M_CEP.Select()
                    m2 = 1
                End If
                If m2 = 0 Then
                    .Nome_Fantasia_For = Nome_Fanta.Text
                    .Razao_For = Razao_social.Text
                    .CNPJ_For = M_CNPJ.Text
                    .Site_For = Site_For.Text
                    .Email_Emp_For = Email.Text
                    .Telefone_For = M_Telefone.Text
                    .UF_For = CInt(CB_Cidade.SelectedIndex + 1)
                    .Cidade_For = CInt(CB_UF.SelectedIndex + 1)
                    .Bairro_For = Bairro.Text
                    .Rua_For = Endere.Text
                    .Num_For = Numero.Text
                    .Comple_For = Comple.Text
                    .CEP_For = M_CEP.Text

                    Dim objCNPJ As New Validar_CNPJ

                    If objCNPJ.ValidaCNPJ(M_CNPJ.Text) = False Then
                        m = 1
                    End If

                    .InsertFor()
                End If
                MsgBox("Fornecedor Cadastrado!")
            End With



            Cod_Forn.Text += 1
            objLimpar.LimpaCampos(Me)
            objBlo_Des.GBDisabled(Me)
            BtnNovo.Enabled = True
            BtnLimpar.Enabled = False
            BtnCadastrar.Enabled = False

            objLimpar.LimpaCampos(Me)
            objBlo_Des.GBDisabled(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

            
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
            m = 0
            m2 = 0
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpar.Click
        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub
    Public Sub Cod_For()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Empresa)  as 'CodigoCliente' from Fornecedor "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cod_Forn.Text = mr!Cod_Empresa + 1
        End While
        ' somente leitura - select
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Contato_Empresa.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        objBlo_Des.GBEnabled(Me)
        BtnCadastrar.Enabled = True
        BtnLimpar.Enabled = True
        BtnNovo.Enabled = False
        Nome_Fanta.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Alterar.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand

        Dim mr As Integer
        cn = New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "SP_Alterar_Fornecedor"
            .CommandType = CommandType.Text
        End With

        mr = cmd.ExecuteNonQuery   ' somente leitura - select
        MsgBox("Registro Atualizado", 32, "inclusão")
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Cod_Forn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Forn.TextChanged
        objFor.SelecionaForCampos()
    End Sub

    Private Sub CB_UF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_UF.TextChanged
        objFor.ComboCidade(CB_UF, CB_Cidade)
    End Sub
End Class