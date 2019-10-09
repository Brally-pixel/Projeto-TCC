Imports System.Data.SqlClient


Public Class Cadastrar_Tipo_de_Conta
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
            .CommandText = "SP_Listar_Contas_Pagar "
            .CommandType = CommandType.Text

        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid
    End Sub
    Public cn As New cls_Conexao
    Dim objContas As New ClsContas
    Dim Cone As New cls_Conexao
    Dim objBlo_Des As New Cls_Blo_Des
    Dim m As Integer = 0
    Dim m2 As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            With objContas

                If Descricao.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Descricao.Select()
                    m2 = 1

                ElseIf Valor_Conta.Text = "" Then
                    MsgBox("Campo inválido")
                    Valor_Conta.Select()
                    m2 = 1

                ElseIf Valor_Pago.Text = "" Then
                    MsgBox("Campo inválido")
                    Valor_Pago.Select()
                    m2 = 1

                ElseIf CB_Responsavel.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Responsavel.Select()
                    m2 = 1

                End If

                If m2 = 0 Then
                    .Descricao_Conta = Descricao.Text
                    .Valor_Conta = Valor_Conta.Text
                    .Valor_Pago_Conta = Valor_Pago.Text
                    .Data_Pag_Conta = DTtxData_Pagamento.Value
                    .Responsavel_Conta = CInt(CB_Responsavel.SelectedIndex + 1)
                    .Data_Ven_Conta = DTData_Venci.Value
                    If RB_Pago.Checked = True Then
                        .Status_Cont = "Pa"
                    End If
                    If RB_Pendente.Checked = True Then
                        .Status_Cont = "Pe"
                    End If
                End If

                .InsertContas()
            End With
            MsgBox("Conta Cadastrada!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
            m = 0
            m2 = 0
        End Try
    End Sub
    
    Private Sub Cadastrar_Tipo_de_Conta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objBlo_Des.GBDisabled(Me)
        objContas.Mostrar_Fun()
        Desc_Contas()
    End Sub

    Public Sub Desc_Contas()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Codigo_Conta)as 'Codigo_Conta' from Contas_Pagar "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Codigo_Conta.Text = mr!Codigo_Conta + 1
        End While
        ' somente leitura - select

    End Sub

    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objBlo_Des.GBEnabled(Me)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim dt As DataTable
        dt = dt1.DataSource
        dt.Rows.Clear()
    End Sub

    Private Sub Codigo_Fun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Codigo_Conta.Text <> "" Then
            With objContas
                .Cod_Conta = Codigo_Conta.Text
            End With
        End If
    End Sub

    Private Sub CB_Responsavel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Responsavel.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class