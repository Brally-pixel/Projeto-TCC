Imports System.Data.SqlClient
Public Class Login

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
            .CommandText = "exec Listar_Login"
            If RB_Ativo_Log.Checked Then
                .CommandText = "Listar_Status_Log_Ati"
            ElseIf RB_Inativo_Log.Checked Then
                .CommandText = "Listar_Status_Log_Des"

            End If
            .CommandType = CommandType.Text
        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid

    End Sub
End Class