Imports System.Data.SqlClient
Public Class Cadastro_Cliente
    Public cn As New cls_Conexao
    Dim objCli As New ClsCliente
    Dim Cone As New cls_Conexao
    Dim objLimpar As New Cls_Limpar
    Dim objBlo_Des As New Cls_Blo_Des
    Public D As Integer = 0

    Dim m As Integer = 0
    Dim m2 As Integer = 0

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cadastrar_Cli.Click
        Try
            With objCli

            
                If Nome_Cliente.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Nome_Cliente.Select()
                    m2 = 1

                ElseIf Endereco.Text = "" Then
                    MsgBox("Campo inválido")
                    Endereco.Select()
                    m2 = 1

                ElseIf Bairro.Text = "" Then
                    MsgBox("Campo inválido")
                    Bairro.Select()
                    m2 = 1
                ElseIf Numero.Text = "" Then
                    MsgBox("Campo inválido")
                    Numero.Select()
                    m2 = 1
                ElseIf Complemento.Text = "" Then
                    MsgBox("Campo inválido")
                    Complemento.Select()
                    m2 = 1
                ElseIf CEP.Text = "" Then
                    MsgBox("Campo inválido")
                    CEP.Select()
                    m2 = 1
                ElseIf CPF.Text = "" Then
                    MsgBox("Campo Inválido")
                    CPF.Select()
                    m2 = 1

                ElseIf RB_Casado.Checked = False And RB_Divor.Checked = False And RB_Solt.Checked = False And RB_Viuvo.Checked = False Then
                    MsgBox("Escolha o Estado Civil")
                    m2 = 1

                ElseIf RB_Feminino.Checked = False And RB_Masculino.Checked = False Then
                    MsgBox("Escolha o Sexo")
                    m2 = 1

                ElseIf EMAIL.Text = "" Then
                    MsgBox("Campo inválido")
                    EMAIL.Select()
                    m2 = 1

                ElseIf Numero.Text = "" Then
                    MsgBox("Campo inválido")
                    Numero.Select()
                    m2 = 1

                ElseIf Numero.Text = "" Then
                    MsgBox("Campo inválido")
                    Numero.Select()
                    m2 = 1

                ElseIf CB_Cidade.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Cidade.Select()
                    m2 = 1

                ElseIf UF.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Cidade.Select()
                    m2 = 1
                End If


                If m2 = 0 Then
                    .CPF_Cli = CPF.Text
                    .Nome_Cli = Nome_Cliente.Text()

                    If RB_Feminino.Checked = True Then
                        .Sexo_Cli = "F"
                    ElseIf RB_Masculino.Checked = True Then
                        .Sexo_Cli = "M"
                    End If

                    .Data_Nasc_Cli = DTP_Cliente.Value

                    If RB_Casado.Checked = True Then
                        .Est_Civil_Cli = "Casado(a)"
                    End If
                    If RB_Solt.Checked = True Then
                        .Est_Civil_Cli = "Solteiro(a)"
                    End If
                    If RB_Divor.Checked = True Then
                        .Est_Civil_Cli = "Divorciado(a)"
                    End If
                    If RB_Viuvo.Checked = True Then
                        .Est_Civil_Cli = "Viuvo(a)"
                    End If
                    .UF_Cli = objCli.GetEstado(UF)
                    .Cidade_Cli = objCli.GetCidade(CB_Cidade)
                    .Bairro_Cli = Bairro.Text
                    .Rua_Cli = Endereco.Text
                    .Num_Cli = CInt(Numero.Text)
                    .Comple_Cli = Complemento.Text
                    .CEP_Cli = CEP.Text
                    .Tel_Fix_Cli = Telefone.Text
                    .Email_Cli = EMAIL.Text


                    '---------------------------------------------
                    Dim vemail As New Validar_Email

                    If vemail.ValEMail(EMAIL.Text) = True Then
                    Else
                        MsgBox("E-mail inválido")
                        m = 1
                    End If
                    '----------------------------------------------

                    Dim objCPF As New Validar_CPF

                    If objCPF.ValidaCPF(CPF.Text) = False Then
                        m = 1
                    End If
                    If m = 0 Then
                        .InsertCli()
                        Cod_Cliente.Text += 1
                        objLimpar.LimpaCampos(Me)
                        objBlo_Des.GBDisabled(Me)
                        BtnNovo.Enabled = True
                        BtnLimpar.Enabled = False
                        Cadastrar_Cli.Enabled = False
                    End If
                End If
            End With


            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
            m = 0
            m2 = 0
        End Try
    End Sub
    Private Sub Cadastro_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCli.ComboEstado()
        If D = 0 Then
            objBlo_Des.GBDisabled(Me)
            BtnNovo.Enabled = True

        ElseIf D = 1 Then
            Mos_Cod_Clie()
            Alterar_Cli.Enabled = True
            D = 0
        End If
    End Sub

    Private Sub UF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UF.SelectedIndexChanged
        '  objCli.ComboCidade(UF, CB_Cidade)
    End Sub
    Public Sub Mos_Cod_Clie()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Codigo_do_Cliente)  as 'CodigoCliente' from Cadastro_Cliente "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cod_Cliente.Text = mr!CodigoCliente + 1
        End While
        ' somente leitura - select

    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpar.Click
        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
        Nome_Cliente.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alterar_Cli.Click

        Try
            With objCli
                .Cod_Cli = Cod_Cliente.Text
                .CPF_Cli = CPF.Text
                .Nome_Cli = Nome_Cliente.Text()

                If RB_Feminino.Checked = True Then
                    .Sexo_Cli = "F"
                ElseIf RB_Masculino.Checked = True Then
                    .Sexo_Cli = "M"
                End If

                .Data_Nasc_Cli = DTP_Cliente.Value

                If RB_Casado.Checked = True Then
                    .Est_Civil_Cli = "Casado(a)"
                End If
                If RB_Solt.Checked = True Then
                    .Est_Civil_Cli = "Solteiro(a)"
                End If
                If RB_Divor.Checked = True Then
                    .Est_Civil_Cli = "Divorciado(a)"
                End If
                If RB_Viuvo.Checked = True Then
                    .Est_Civil_Cli = "Viuvo(a)"
                End If
                .UF_Cli = CInt(UF.SelectedIndex + 1)

                .Cidade_Cli = objCli.GetCidade(CB_Cidade)
                .Bairro_Cli = Bairro.Text
                .Rua_Cli = Endereco.Text
                .Num_Cli = CInt(Numero.Text)
                .Comple_Cli = Complemento.Text
                .CEP_Cli = CEP.Text
                .Tel_Fix_Cli = Telefone.Text
                .Email_Cli = EMAIL.Text

                '---------------------------------------------
                Dim vemail As New Validar_Email

                If vemail.ValEMail(EMAIL.Text) = True Then
                Else
                    MsgBox("E-mail inválido")
                    m = 1
                End If
                '----------------------------------------------

                Dim objCPF As New Validar_CPF

                If objCPF.ValidaCPF(CPF.Text) = False Then
                    m = 1
                End If

                If m = 0 Then
                    .UpdateCli()
                    MsgBox("Registro Atualizado!")
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try





        'Dim cn As SqlConnection
        'Dim cmd As New SqlCommand

        'Dim mr As Integer
        'cn = New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'cn.Open()
        'With cmd
        '    .Connection = cn
        '    .CommandTimeout = 0
        '    .CommandText = "SP_Alterar_Cliente"
        '    .CommandType = CommandType.Text
        'End With

        'mr = cmd.ExecuteNonQuery   ' somente leitura - select
        'MsgBox("Registro Atualizado", 32, "inclusão")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        objBlo_Des.GBEnabled(Me)
        Cadastrar_Cli.Enabled = True
        BtnLimpar.Enabled = True
        BtnNovo.Enabled = False
        Nome_Cliente.Focus()
        Mos_Cod_Clie()
        Cod_Cliente.Text = Cod_Cliente.Text
    End Sub

    Private Sub Cod_Cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Cliente.TextChanged
        objCli.SelecionaCliCampos()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub
    Private Sub UF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UF.TextChanged
        objCli.ComboCidade(UF, CB_Cidade)
    End Sub
End Class