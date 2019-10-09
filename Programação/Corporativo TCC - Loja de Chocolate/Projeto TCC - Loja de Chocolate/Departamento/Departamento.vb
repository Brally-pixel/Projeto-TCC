Imports System.Data.SqlClient
Public Class Departamento
    Dim objDep As New ClsDepartamento
    Public cn As New cls_Conexao
    Dim Cone As New cls_Conexao
    Dim objBlo_Des As New Cls_Blo_Des
    Public D As Integer = 0
    Dim estado As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "exec Listar_Departamento"
            ' If RB_Ativo_Dep.Checked Then
            '.CommandText = "Listar_Status_Dep_Ativo"
            ''ElseIf RB_Inativo_Dep.Checked Then
            '.CommandText = "Listar_Status_Dep_Desativo"

            'End If
            .CommandType = CommandType.Text
        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Criar_um_Departamento.D = 1
        objBlo_Des.GBEnabled(Criar_um_Departamento)
        Criar_um_Departamento.Show()
        Criar_um_Departamento.Cod_Dep.Text = CInt(dt1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Criar_um_Departamento.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Descricao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descricao.TextChanged
        Try
            With objDep
                .Descricao = Descricao.Text
                .SelecionaDep(0, Estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim dt As DataTable
        dt = dt1.DataSource
        dt.Rows.Clear()
    End Sub

    Private Sub RB_Ativo_Dep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RB_Ativo_Dep.Checked = True Then
        '    estado = "A"
        'End If
    End Sub

    Private Sub RB_Inativo_Dep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RB_Inativo_Dep.Checked = True Then
        '    estado = "I"
        'End If
    End Sub
End Class