Imports System.Data.SqlClient
Public Class Contato_Empresa
    Public cn As New cls_Conexao
    Dim objCont As New ClsContato
    Dim Cone As New cls_Conexao
    Dim objLimpar As New Cls_Limpar
    Dim objBlo_Des As New Cls_Blo_Des
    Public D As Integer = 0

    Dim m As Integer = 0
    Dim m2 As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCadastrar.Click
        Try
            With objCont

                If Nome.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Nome.Select()
                    m2 = 1

                ElseIf M_Fax.Text = "" Then
                    MsgBox("Campo inválido")
                    M_Fax.Select()
                    m2 = 1

                ElseIf Email_Con.Text = "" Then
                    MsgBox("Campo inválido")
                    Email_Con.Select()
                    m2 = 1

                ElseIf M_Numero_Conta.Text = "" Then
                    MsgBox("Campo inválido")
                    M_Numero_Conta.Select()
                    m2 = 1

                ElseIf CB_Empresa.SelectedIndex = -1 Then
                    MsgBox("Campo inválido")
                    CB_Empresa.Select()
                    m2 = 1

                End If
                If m2 = 0 Then

                    If RB_Feminino.Checked = True Then
                        .Sexo_Cli = "F"
                    ElseIf RB_Masculino.Checked = True Then
                        .Sexo_Cli = "M"
                    End If
                    .Nome_Con = Nome.Text
                    .Fax_Con = M_Fax.Text
                    .Email_Con = Email_Con.Text
                    .Numero_Con = M_Numero_Conta.Text
                    .Codigo_Con = CInt(CB_Empresa.SelectedIndex + 1)
                End If

                .InsertConta()
                MsgBox("Contato fornecedor Cadastrado!")
                objLimpar.LimpaCampos(Me)
                Codigo_Contato.Text += 1
                BtnNovo.Enabled = True
                BtnCadastrar.Enabled = False
                BtnLimpar.Enabled = False

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
            m2 = 0
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpar.Click
        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub Contato_Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objBlo_Des.GBDisabled(Me)
        objCont.ComboEmpresa()
        Mos_Cod_Cont()
        BtnCadastrar.Enabled = False

    End Sub

    Public Sub Mos_Cod_Cont()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Codigo_do_contato)  as 'Codigo_do_contato' from Contato_Fornecedor "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Codigo_Contato.Text = mr!Codigo_do_contato + 1
        End While
        ' somente leitura - select

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovo.Click
        objBlo_Des.GBEnabled(Me)
        BtnNovo.Enabled = False
        BtnCadastrar.Enabled = True
    End Sub

    Private Sub Codigo_Contato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codigo_Contato.TextChanged
        objCont.SelecionaConCampos()
    End Sub

    Private Sub BtnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlterar.Click
        'ry
        With objCont
            .Codigo_Con = Codigo_Contato.Text
            .Nome_Con = Nome.Text
            .Email_Con = Email_Con.Text
            .Numero_Con = M_Numero_Conta.Text
            .Fax_Con = M_Fax.Text


            If RB_Feminino.Checked = True Then
                .Sexo_Cli = "F"
            ElseIf RB_Masculino.Checked = True Then
                .Sexo_Cli = "M"
            End If

            .Nome_Fantasia_For = CInt(CB_Empresa.SelectedIndex + 1)

            .UpdateConta()
        End With
        ' Catch ex As Exception
        ' MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' Finally
        cn.Desconectar()
        cn.cmd.Parameters.Clear()
        ' End Try
    End Sub
End Class