Imports System.Data.SqlClient

Public Class Menu_Principal_Gerente
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ToolStripStatusLabel1.Text = TimeOfDay
        ToolStripStatusLabel2.Text = DateString
    End Sub

    Private Sub CadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadasToolStripMenuItem.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem2.Click
        Cliente.Show()
    End Sub

    Private Sub CadastroDoFuncionarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDoFuncionarioToolStripMenuItem_.Click
        Cadastrar_Funcionario.Show()
    End Sub

    Private Sub FuncionarioToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionarioToolStripMenuItem4.Click
        Funcionario.Show()
    End Sub

    Private Sub CadastrarSenhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarSenhaToolStripMenuItem_Senha.Click
        Cadastro_de_Senha.Show()
    End Sub

    Private Sub CadastrarContatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarContatoToolStripMenuItem.Click

        Contato_Empresa.Show()
    End Sub

    Private Sub CadastrarFornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarFornecedorToolStripMenuItem.Click
        Cadastro_Fornecedor.Show()
    End Sub

    Private Sub ContatoFornecedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoFornecedorToolStripMenuItem1.Click
        Fornecedor.Show()
    End Sub

    Private Sub ContasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContasToolStripMenuItem.Click
        Cadastrar_Tipo_de_Conta.Show()
    End Sub

    Private Sub CriarDepartamentoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriarDepartamentoToolStripMenuItem1.Click
        Criar_um_Departamento.Show()
    End Sub

    Private Sub DepartamentoToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentoToolStripMenuItem4.Click
        Departamento.Show()
    End Sub

    Private Sub CadastrarProdutoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarProdutoToolStripMenuItem1.Click
        Cadastrar_o_Produto.Show()
    End Sub

    Private Sub LoginToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
    End Sub


    Private Sub ContatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoToolStripMenuItem.Click
        Contato.Show()
    End Sub

    Private Sub EfetuarVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EfetuarVendaToolStripMenuItem.Click
        Vendas.Show()

    End Sub

    Private Sub ProdutoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem3.Click
        Produto.Show()
    End Sub

    Private Sub CadastrarNoEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarNoEstoqueToolStripMenuItem.Click
        Controle_Estoque.Show()
    End Sub

    Private Sub CompraToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompraToolStripMenuItem1.Click
        Compras.Show()

    End Sub
    Dim Cone As New cls_Conexao
    Dim objFun As New ClsFuncionario

    Public Sub Mostrar_Vendas()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Count(codigo_venda)'CodigoVenda' from Vendas where  Codigo_do_funcionario = '" & objFun.GetFuncionario(Nome_Funcio.Text) & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Label5.Text = mr!CodigoVenda
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
    

    
    Private Sub LoginToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem_Login.Click
        Login.Show()
    End Sub

    Private Sub EstoqueToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoqueToolStripMenuItem3.Click
        Listar_Estoque.Show()
    End Sub

    Private Sub EstoqueFornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LagoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LagoutToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub Menu_Principal_Gerente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Dim objMeni As New ClsMenu
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Mostrar_Vendas()
        'Label6.Text = objMeni.Nivel

    End Sub

    Private Sub BackupToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_Backup.Show()
    End Sub
End Class