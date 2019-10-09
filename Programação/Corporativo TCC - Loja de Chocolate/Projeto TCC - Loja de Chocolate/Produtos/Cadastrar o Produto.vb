Imports System.Data.SqlClient
Public Class Cadastrar_o_Produto
    Public cn As New cls_Conexao
    Dim objprod As New Cls_Produto
    Dim Cone As New cls_Conexao
    Dim objLimpar As New Cls_Limpar
    Public D As Integer = 0
    Public a As Integer

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpar.Click
        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Produto.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cadastrar_o_Produto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Controle_Estoque.cod_Prod = Codigo_Produto.Text
    End Sub

    Private Sub Cadastrar_o_Produto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mos_Cad_Cont()
        objprod.ComboMarca()
        objprod.Cod_Marca_()
    End Sub
    Public Sub Mos_Cad_Cont()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Produto)  as 'Cod_Produto' from Cad_Produto "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Codigo_Produto.Text = mr!Cod_Produto + 1
        End While
        ' somente leitura - select

    End Sub

    Dim objCon_Senha As New Senha__do_Gerente
    Dim m2 As Integer = 0
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarca.Click
        Try
            With objprod
                If Carac_Marca.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Carac_Marca.Select()
                    m2 = 1
                End If
                If m2 = 0 Then
                    .Nome_Marca = Carac_Marca.Text

                    .InsertMarca()
                End If

                CB_Marca.Items.Clear()
                objprod.ComboMarca()
            End With
            MsgBox("Marca Cadastrada!")
            objLimpar.LimpaCampos(Me)
            Carac_Marca.Focus()
            Codigo_marca.Text += 1
            objprod.ComboMarca()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            m2 = 0
        End Try
    End Sub


    Dim m As Integer = 0
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_produto.Click
        Try
            With objprod

                If Caracteristicas.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Caracteristicas.Select()
                    m2 = 1

                ElseIf CB_Marca.SelectedIndex = -1 Then
                    MsgBox("Campo inválido")
                    CB_Marca.Select()
                    m2 = 1

                ElseIf Cod_Barra.Text = "" Then
                    MsgBox("Campo inválido")
                    Cod_Barra.Select()
                    m2 = 1
                End If

                .Carac_Prod = Caracteristicas.Text
                .Nome_Marca = CInt(CB_Marca.SelectedIndex + 1)
                .Cod_Barra = Cod_Barra.Text
            End With
            With objprod
                .InsertProd()
            End With
            MsgBox("Produto Cadastrado!")
            Controle_Estoque.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub CB_Fornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class