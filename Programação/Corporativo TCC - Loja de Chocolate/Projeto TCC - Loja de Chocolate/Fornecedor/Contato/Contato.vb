Imports System.Data.SqlClient

Public Class Contato
    Dim estado As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Listar.Click

        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()

        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "SeleConte "


            If RB_Ativo.Checked Then
                .CommandText = "Listar_Status_Con_Ativo "

            ElseIf RB_Desativo.Checked Then
                .CommandText = "Listar_Status_Con_Desativo"

            End If

            .CommandType = CommandType.Text

        End With


        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        dt1.DataSource = dt        ' dt1 name do datagrid

    End Sub
    Dim objcon As New ClsContato
    Dim cone As New cls_Conexao
    Private Sub Contato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        
    End Sub

    Private Sub Nome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            With objCon
                .Nome_Con = Nome.Text
                .SelecionaCont(1, "A")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
            Cone.cmd.Parameters.Clear()
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpar.Click
        Dim dt As DataTable
        dt = dt1.DataSource
        dt.Rows.Clear()

        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub Btn_Alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Alterar.Click
        Dim objBlo_Des As New Cls_Blo_Des

        Contato_Empresa.D = 1

        Contato_Empresa.Show()
        objBlo_Des.GBEnabled(Contato_Empresa)
        Contato_Empresa.Codigo_Contato.Text = CInt(dt1.CurrentRow.Cells(0).Value)
        Contato_Empresa.BtnAlterar.Enabled = True
        Contato_Empresa.BtnNovo.Enabled = False
        Contato_Empresa.BtnLimpar.Enabled = False
        Contato_Empresa.BtnCadastrar.Enabled = False
    End Sub

    Private Sub Btn_Ativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ativar.Click
        objcon.Codigo_Con = dt1.CurrentRow.Cells(0).Value
        objcon.Desativa_Con()
    End Sub

    Private Sub Btn_Reativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Reativar.Click
        objcon.Codigo_Con = dt1.CurrentRow.Cells(0).Value
        objcon.Ativa_Con()
    End Sub


    Private Sub M_Numero_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles M_Numero.TextChanged
        Try
            With objcon
                .Numero_Con = M_Numero.Text
                .SelecionaCont(2, "A")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cone.Desconectar()
            cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Nome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome.TextChanged
        Try
            With objcon
                .Nome_Con = Nome.Text
                .SelecionaCont(1, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cone.Desconectar()
            cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Nome_Empresa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_Empresa.TextChanged
        Try
            With objcon
                .Nome_Fantasia_For = Nome_Empresa.Text
                .SelecionaCont(0, estado)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cone.Desconectar()
            cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub M_Numero_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles M_Numero.MaskInputRejected
        If M_Numero.Text.ToString.Replace("-", "").Trim.Count > 0 Then
            If M_Numero.Text.ToString.Replace("-", "").Trim.Count = 10 Then

                Try
                    With objcon
                        .Numero_Con = M_Numero.Text
                        .SelecionaCont(2, estado)
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cone.Desconectar()
                    cone.cmd.Parameters.Clear()
                End Try
            End If
        End If

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
End Class