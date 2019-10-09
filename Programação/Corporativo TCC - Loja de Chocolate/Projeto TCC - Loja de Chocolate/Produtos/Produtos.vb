Imports System.Data.SqlClient
Public Class Produto
    Dim estado As String
    Dim objProd As New Cls_Produto
    Dim Cone As New cls_Conexao

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Dim cmd As New SqlCommand
        'Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        ''Dim mr As SqlDataReader
        'Dim da As New SqlDataAdapter
        'Dim dt As New DataTable
        'cn.Open()
        'With cmd
        '    .Connection = cn
        '    .CommandTimeout = 0
        '    .CommandText = " Listar_Produto"
        '    If RB_Ativo.Checked = True Then
        '        .CommandText = "Listar_Status_Prod_Ati"
        '    ElseIf RB_Desativo.Checked = True Then
        '        .CommandText = "Listar_Status_Prod_Des"
        '    End If
        '    'where rm ='" & frm.Text & "'  "
        '    .CommandType = CommandType.Text

        'End With


        'da.SelectCommand = cmd
        'da.Fill(dt)
        'da.Dispose()       '  libera recursos ou melhora a performance  
        'Dt1.DataSource = dt        ' dt1 name do datagrid

    End Sub

    Public Sub Lista_Prod()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = " Listar_Produto"
            If RB_Ativo.Checked = True Then
                .CommandText = "Listar_Status_Prod_Ati"
            ElseIf RB_Desativo.Checked = True Then
                .CommandText = "Listar_Status_Prod_Des"
            End If
            'where rm ='" & frm.Text & "'  "
            .CommandType = CommandType.Text

        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        Dt1.DataSource = dt        ' dt1 name do datagrid

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_prod.TextChanged
        Try
            With objProd
                .Carac_Prod = Nome_prod.Text
                .SelecionaProd(0, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dt As DataTable
        dt = Dt1.DataSource
        dt.Rows.Clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim dt As DataTable
        dt = Dt2.DataSource
        dt.Rows.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listar.Click

        'Dim cmd As New SqlCommand
        'Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        ''Dim mr As SqlDataReader
        'Dim da As New SqlDataAdapter
        'Dim dt As New DataTable
        'cn.Open()
        'With cmd
        '    .Connection = cn
        '    .CommandTimeout = 0
        '    .CommandText = "Listar_Marca"

        '    If RB_Ativo_Mar.Checked Then
        '        .CommandText = "Listar_Status_Mar_Ati"
        '    ElseIf RB_Desativo_Mar.Checked Then
        '        .CommandText = "Listar_Status_Mar_Des"
        '    End If

        '    .CommandType = CommandType.Text

        'End With


        'da.SelectCommand = cmd
        'da.Fill(dt)
        'da.Dispose()       '  libera recursos ou melhora a performance  
        'Dt2.DataSource = dt        ' dt1 name do datagrid

    End Sub

    Public Sub Listar_Marca()

        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "Listar_Marca"

            If RB_Ativo_Mar.Checked Then
                .CommandText = "Listar_Status_Mar_Ati"
            ElseIf RB_Desativo_Mar.Checked Then
                .CommandText = "Listar_Status_Mar_Des"
            End If

            .CommandType = CommandType.Text

        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        Dt2.DataSource = dt        ' dt1 name do datagrid

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objProd.Cod_Prod = Dt1.CurrentRow.Cells(0).Value
        objProd.Ativa_Prod()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objProd.Cod_Prod = Dt1.CurrentRow.Cells(0).Value
        objProd.Desativa_Prod()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objProd.Cod_Marca = Dt2.CurrentRow.Cells(0).Value
        objProd.Ativa_Mar()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objProd.Cod_Marca = Dt2.CurrentRow.Cells(0).Value
        objProd.Desativa_Mar()
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Barra.TextChanged
        Try
            With objProd
                .Cod_Barra = Cod_Barra.Text
                .SelecionaProd(1, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub RB_Ativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ativo.CheckedChanged
        If RB_Ativo.Checked = True Then
            estado = "A"
        End If

    End Sub

    Private Sub RB_Desativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Desativo.CheckedChanged
        If RB_Desativo.Checked = True Then
            estado = "I"
        End If
    End Sub

    Private Sub Produto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lista_Prod()
        Listar_Marca()
    End Sub
    Dim D As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
    End Sub
End Class