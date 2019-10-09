Imports System.Data.SqlClient

Public Class Menu_Principal
    Dim Cone As New cls_Conexao
    Dim objFun As New ClsFuncionario

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Restart()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
        Label4.Text = DateString
    End Sub
    Public Sub Mostrar_Vendas_1()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Count(codigo_venda)'CodigoVenda' from Vendas where  Codigo_do_funcionario = '" & objFun.GetFuncionario(Nome_Funcio.Text) & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Label2.Text = mr!CodigoVenda
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Mostrar_Vendas_1()
    End Sub

    Private Sub Menu_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub AlterarOCadastroDoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarOCadastroDoClienteToolStripMenuItem.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub CadastroDoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDoClienteToolStripMenuItem.Click
        Cliente.Show()
    End Sub

    Private Sub VendasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasToolStripMenuItem1.Click
        Vendas.Show()
    End Sub

    Private Sub SelecionarOProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarOProdutoToolStripMenuItem.Click
        Produto.Show()
    End Sub

    Private Sub VerificarEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarEstoqueToolStripMenuItem.Click
        Listar_Estoque.Show()
    End Sub
End Class