Imports System.Data.SqlClient
Public Class Cadastrar_Funcionario
    Public cn As New cls_Conexao
    Dim objFun As New ClsFuncionario
    Dim Cone As New cls_Conexao
    Dim objLimpar As New Cls_Limpar
    Public D As Integer = 0
    Dim objBlo_Des As New Cls_Blo_Des


    Private Sub Cadastrar_Funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objFun.ComboEstado()
        If D = 0 Then
            objBlo_Des.GBDisabled(Me)
            btnNovo.Enabled = True
            objFun.ComboDepartamento()
        ElseIf D = 1 Then
            objFun.Cod_Funci()


        End If
        D = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Departamento.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cadastrar_Senha.Click
        Cadastro_de_Senha.Show()
    End Sub
    Dim m As Integer = 0
    Dim m2 As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cadastrar.Click


        Try
            With objFun


                If Nome.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Nome.Select()
                    m2 = 1

                ElseIf txtender.Text = "" Then
                    MsgBox("Campo inválido")
                    txtender.Select()
                    m2 = 1

                ElseIf TxtBairro.Text = "" Then
                    MsgBox("Campo inválido")
                    TxtBairro.Select()
                    m2 = 1

                ElseIf txtNumero.Text = "" Then
                    MsgBox("Campo inválido")
                    txtNumero.Select()
                    m2 = 1

                ElseIf txtComp.Text = "" Then
                    MsgBox("Campo inválido")
                    txtComp.Select()
                    m2 = 1

                ElseIf MtxtCEP.Text = "" Then
                    MsgBox("Campo inválido")
                    MtxtCEP.Select()
                    m2 = 1

                ElseIf MtxtCPF.Text = "" Then
                    MsgBox("Campo Inválido")
                    MtxtCPF.Select()
                    m2 = 1

                ElseIf RB_Casado.Checked = False And RB_Divor.Checked = False And RB_Solt.Checked = False And RB_Viuvo.Checked = False Then
                    MsgBox("Escolha o Estado Civil")
                    m2 = 1

                ElseIf RB_Feminino.Checked = False And RB_Masculino.Checked = False Then
                    MsgBox("Escolha o Sexo")
                    m2 = 1

                ElseIf txtemail.Text = "" Then
                    MsgBox("Campo inválido")
                    txtemail.Select()
                    m2 = 1

                ElseIf txtNumero.Text = "" Then
                    MsgBox("Campo inválido")
                    txtNumero.Select()
                    m2 = 1

                ElseIf MtxtTelefone.Text = "" Then
                    MsgBox("Campo inválido")
                    MtxtTelefone.Select()
                    m2 = 1

                ElseIf CB_Cidade.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Cidade.Select()
                    m2 = 1

                ElseIf CB_UF.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Cidade.Select()
                    m2 = 1
                End If


                If m = 0 Then
                    .CPF_Fun = MtxtCPF.Text
                    .Nome_Fun = Nome.Text()

                    If RBtnFund.Checked = True Then
                        .Escolaridade_Fun = "Fundamental"
                    End If
                    If Rbtnmedio.Checked = True Then
                        .Escolaridade_Fun = "Medio"
                    End If
                    If RBtnsup.Checked = True Then
                        .Escolaridade_Fun = "Superior"
                    End If
                    If Rbtntec.Checked = True Then
                        .Escolaridade_Fun = "Técnico"
                    End If


                    If RB_Feminino.Checked = True Then
                        .Sexo_Fun = "F"
                    ElseIf RB_Masculino.Checked = True Then
                        .Sexo_Fun = "M"
                    End If

                    .Data_Nasc_Fun = DTP_Funcionario.Value

                    If RB_Casado.Checked = True Then
                        .Est_Civil_Fun = "Casado(a)"
                    End If
                    If RB_Solt.Checked = True Then
                        .Est_Civil_Fun = "Solteiro(a)"
                    End If
                    If RB_Divor.Checked = True Then
                        .Est_Civil_Fun = "Divorciado(a)"
                    End If
                    If RB_Viuvo.Checked = True Then
                        .Est_Civil_Fun = "Viuvo(a)"
                    End If

                    If RB_Manha.Checked = True Then
                        .Turno = "M"
                    End If

                    If RB_Tarde.Checked = True Then
                        .Turno = "T"
                    End If


                    .RG_Fun = MtxtRG.Text
                    .UF_Fun = CInt(CB_Cidade.SelectedIndex + 1)
                    .Cidade_Fun = CInt(CB_UF.SelectedIndex + 1)
                    .Bairro_Fun = TxtBairro.Text
                    .Rua_Fun = txtender.Text
                    .Num_Fun = txtNumero.Text
                    .Comple_Fun = txtComp.Text
                    .CEP_Fun = MtxtCEP.Text
                    .Tel_Fix_Fun = MtxtTelefone.Text
                    .Email_Fun = txtemail.Text
                    .Cod_Departamento_Fun = CInt(CB_Departamento.SelectedIndex + 1)

                    '---------------------------------------------------------------
                    Dim vemail As New Validar_Email

                    If vemail.ValEMail(txtemail.Text) = True Then
                    Else
                        MsgBox("E-mail inválido")
                        m = 1
                    End If
                    '---------------------------------------------------------------
                    Dim objCPF As New Validar_CPF

                    If objCPF.ValidaCPF(CPF:=Text) = False Then
                        m = 1
                    End If

                    If m = 0 Then
                        .InsertFun()
                        MsgBox("Funcionario Cadastrado!")
                        objLimpar.LimpaCampos(Me)
                        btnNovo.Enabled = True
                        Cadastrar.Enabled = False
                        Limpar.Enabled = False

                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            m = 0
            m2 = 0
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub CB_UF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_UF.SelectedIndexChanged
        'objFun.ComboCidade()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alterar.Click
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand

        Dim mr As Integer
        cn = New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "SP_Alterar_Funcionario"
            .CommandType = CommandType.Text
        End With

        mr = cmd.ExecuteNonQuery   ' somente leitura - select
        MsgBox("Registro Atualizado", 32, "inclusão")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        objBlo_Des.GBEnabled(Me)
        Cadastrar.Enabled = True
        Limpar.Enabled = True
        Cadastrar_Senha.Enabled = True
        btnNovo.Enabled = False
        Nome.Focus()
        objFun.Cod_Funci()
        Cod_Fun.Text = Cod_Fun.Text + 1
    End Sub

    Private Sub Cod_Fun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Fun.TextChanged
        objFun.SelecionaFunCampos()
    End Sub

    Private Sub CB_UF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_UF.TextChanged
        objFun.ComboCidade(CB_UF, CB_Cidade)
    End Sub
End Class