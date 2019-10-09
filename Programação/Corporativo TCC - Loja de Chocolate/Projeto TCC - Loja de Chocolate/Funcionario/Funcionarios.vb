Imports System.Data.SqlClient
Public Class Funcionario
    Dim objBlo_Des As New Cls_Blo_Des
    Dim Cone As New cls_Conexao
    Dim objFun As New ClsFuncionario
    Dim estado As String = "A"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Alterar.Click
        Cadastrar_Funcionario.D = 1

        Cadastrar_Funcionario.Show()
        objBlo_Des.GBEnabled(Cadastrar_Funcionario)
        Cadastrar_Funcionario.Cod_Fun.Text = CInt(dt1.CurrentRow.Cells(0).Value)

        Cadastrar_Funcionario.Alterar.Enabled = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "exec Listar_Funcionario"

            If RB_Ativo.Checked Then
                .CommandText = "Listar_Status_Fun1"
            ElseIf RB_Desativo.Checked Then
                .CommandText = "Listar_Status_Fun2"
            End If

            If RB_Feminino.Checked Then
                .CommandText = "Selec_Sexo_FunF"

            ElseIf RB_Masculino.Checked Then
                .CommandText = "Selec_Sexo_FunM"
            End If

            .CommandType = CommandType.Text

        End With

        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dt As DataTable
        dt = dt1.DataSource
        dt.Rows.Clear()
    End Sub

    Private Sub CPF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CPF.KeyDown
        Try
            With objFun
                .CPF_Fun = CPF.Text
                .SelecionaFun(0, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub
    Private Sub Funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objFun.ComboDepartamento()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objFun.Cod_Fun = dt1.CurrentRow.Cells(0).Value
        objFun.Desativa_Fun()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objFun.Cod_Fun = dt1.CurrentRow.Cells(0).Value
        objFun.Ativa_Fun()
    End Sub

    Private Sub Nome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Nome.TextChanged
        Try
            With objFun
                .Nome_Fun = Nome.Text
                .SelecionaFun(1, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub RG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RG.TextChanged
        Try
            With objFun
                .RG_Fun = RG.Text
                .SelecionaFun(2, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Departa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Departa.TextChanged
        Try
            With objFun
                .descricao = Departa.Text
                .SelecionaFun(3, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub RB_Ativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ativo.CheckedChanged
        If RB_Ativo.Checked Then
            estado = "A"
        End If

    End Sub

    Private Sub RB_Desativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Desativo.CheckedChanged
        If RB_Desativo.Checked Then
            estado = "I"
        End If
    End Sub

    Private Sub CPF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPF.TextChanged

    End Sub
End Class