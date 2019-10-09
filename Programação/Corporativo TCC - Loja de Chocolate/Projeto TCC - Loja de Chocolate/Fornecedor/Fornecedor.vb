Imports System.Data.SqlClient
Public Class Fornecedor
    Dim objBlo_Des As New Cls_Blo_Des
    Dim Cone As New cls_Conexao
    Dim objFor As New ClsFornecedor
    Dim objCon As New ClsContato
    Dim estado As String = "A"

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
            .CommandText = "Listar_Fornecedor"

            If RB_Ativo.Checked Then
                .CommandText = "Listar_Status_For_Ativo "

            ElseIf RB_Desativo.Checked Then
                .CommandText = "Listar_Status_For_Desativo"

            End If

            .CommandType = CommandType.Text

        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Contato_Empresa.D = 1

        Cadastro_Fornecedor.Show()
        objBlo_Des.GBEnabled(Cadastro_Fornecedor)
        Cadastro_Fornecedor.Cod_Forn.Text = CInt(dt1.CurrentRow.Cells(0).Value)

        Cadastro_Fornecedor.BtnNovo.Enabled = False
        Cadastro_Fornecedor.BtnLimpar.Enabled = False
        Cadastro_Fornecedor.BtnCadastrar.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        objFor.Cod_For = dt1.CurrentRow.Cells(0).Value
        objFor.Desativa_For()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dt As DataTable
        dt = dt1.DataSource
        dt.Rows.Clear()

        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objFor.Cod_For = dt1.CurrentRow.Cells(0).Value
        objFor.Ativa_For()
    End Sub

    Private Sub M_CNPJ_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles M_CNPJ.TextChanged
        If M_CNPJ.Text.ToString.Replace("_", "").Replace(",", "").Replace("-", "").Trim.Count > 0 Then
            If M_CNPJ.Text.ToString.Replace("_", "").Replace(",", "").Replace("-", "").Trim.Count = 14 Then
                Try
                    With objFor
                        .CNPJ_For = M_CNPJ.Text
                        .SelecionaFor(2, estado)
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cone.Desconectar()
                    Cone.cmd.Parameters.Clear()

                End Try
            End If
        End If

    End Sub

    Private Sub TxtNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNome.TextChanged
        Try
            With objFor
                .Nome_Fantasia_For = TxtNome.Text
                .SelecionaFor(0, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub txtRazao_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazao.TextChanged
        Try
            With objFor
                .Razao_For = txtRazao.Text
                .SelecionaFor(1, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Fornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RB_Ativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Ativo.CheckedChanged
        If RB_Ativo.Checked Then
            estado = "A"
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RB_Desativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Desativo.CheckedChanged
        If RB_Desativo.Checked Then
            estado = "I"
        End If
    End Sub

    Private Sub M_CNPJ_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles M_CNPJ.MaskInputRejected

    End Sub
End Class