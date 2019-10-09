Imports System.Data.SqlClient
Public Class Cliente
    Dim objBlo_Des As New Cls_Blo_Des
    Dim Cone As New cls_Conexao
    Dim estado As String = "A"
    Dim m As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "SP_Listar_Clie"

            If RB_Ativo.Checked = True Then
                .CommandText = "Listar_Status"
                .CommandType = CommandType.StoredProcedure

            ElseIf RB_Desativo.Checked = True Then
                .CommandText = "Listar_Status_2"
                .CommandType = CommandType.StoredProcedure

            End If

            If RB_Feminino.Checked = True Then
                .CommandText = "Selec_SexoF"
                .CommandType = CommandType.StoredProcedure

            ElseIf RB_Masculino.Checked = True Then
                .CommandText = "Selec_SexoM"
                .CommandType = CommandType.StoredProcedure

            End If

        End With
        m = 0
        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid
    End Sub
    Dim objCli As New ClsCliente

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Alterar.Click
        Cadastro_Cliente.D = 1

        Cadastro_Cliente.Show()
        objBlo_Des.GBEnabled(Cadastro_Cliente)
        Cadastro_Cliente.Cod_Cliente.Text = CInt(dt1.CurrentRow.Cells(0).Value)

        Cadastro_Cliente.BtnNovo.Enabled = False
        Cadastro_Cliente.BtnLimpar.Enabled = False
        Cadastro_Cliente.Cadastrar_Cli.Enabled = False
        Cadastro_Cliente.Alterar_Cli.Enabled = True

        Me.Close()

    End Sub

    Private Sub Cod_List_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cod_List.KeyDown
        Try
            With objCli
                .Cod_Cli = CInt(Cod_List.Text)
                .SelecionaCli(0, "A")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desativar.Click
        objCli.Cod_Cli = dt1.CurrentRow.Cells(0).Value
        objCli.Desativa_Cli()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reativar.Click
        objCli.Cod_Cli = dt1.CurrentRow.Cells(0).Value
        objCli.Ativa_Cli()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Limpar.Click
        Dim dt As DataTable
        dt = dt1.DataSource
        dt.Rows.Clear()

        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtNome_list_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNome_list.TextChanged
        Try
            With objCli
                .Nome_Cli = TxtNome_list.Text
                .SelecionaCli(1, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub
    Private Sub Cod_List_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_List.TextChanged
        If Cod_List.Text <> "" Then
            With objCli
                .Cod_Cli = Cod_List.Text
                .SelecionaCli(0, estado)
            End With
        Else
            objCli.SelecionaCli(0, estado)
        End If
    End Sub

    Private Sub M_TxtCPFlist_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles M_TxtCPFlist.TextChanged
        If M_TxtCPFlist.Text.ToString.Replace("_", "").Replace(",", "").Replace("-", "").Trim.Count > 0 Then
            If M_TxtCPFlist.Text.ToString.Replace("_", "").Replace(",", "").Replace("-", "").Trim.Count = 11 Then
                Try
                    With objCli
                        .CPF_Cli = M_TxtCPFlist.Text
                        .SelecionaCli(2, estado)
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

    Private Sub M_TxtCPFlist_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles M_TxtCPFlist.MaskInputRejected

    End Sub

    Private Sub RB_Feminino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Feminino.CheckedChanged
        If RB_Feminino.Checked Then
            If RB_Ativo.Checked = True Then
                estado = "A"
            ElseIf RB_Desativo.Checked = True Then
                estado = "I"
            End If
        End If
    End Sub

    Private Sub RB_Masculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Masculino.CheckedChanged
        If RB_Masculino.Checked Then
            If RB_Ativo.Checked = True Then
                estado = "A"
            ElseIf RB_Desativo.Checked = True Then
                estado = "I"
            End If

        End If
    End Sub
End Class