Imports System.Data.SqlClient
Public Class Cls_FaleConosco
    Dim cone As New cls_Conexao
    Public Sub ComboEstado()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Descricao from Fale_Conosco"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cadastro_Cliente.UF.Items.Add(mr("UF_Estado").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

End Class
