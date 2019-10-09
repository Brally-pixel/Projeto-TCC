Imports System.Data.SqlClient
Public Class Criar_um_Departamento
    Public cn As New cls_Conexao
    Dim Cone As New cls_Conexao
    Dim objDep As New ClsDepartamento
    Dim objBlo_Des As New Cls_Blo_Des
    Dim objLimpar As New Cls_Limpar
    Public D As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With objDep
                .Descricao = descricao.Text
                .InsertDep()
                MsgBox("Departamento Cadastrado!")
                Cod_Dep.Text += 1

            End With
        Catch ex As Exception

            objLimpar.LimpaCampos(Me)
            descricao.Focus()
        End Try
    End Sub
    Public Sub Cod_Depar()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Departamento)  as 'CodigoDepartamento' from Departamento "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cod_Dep.Text = mr!CodigoDepartamento + 1
        End While
        ' somente leitura - select
    End Sub

    Private Sub Criar_um_Departamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cod_Depar()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Departamento.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objBlo_Des.GBEnabled(Me)
    End Sub
End Class