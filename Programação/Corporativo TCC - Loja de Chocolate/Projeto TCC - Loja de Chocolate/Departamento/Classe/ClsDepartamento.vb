Imports System.Data.SqlClient
Public Class ClsDepartamento
    Private mCod_Departamento As Integer
    Private mDescricao As String
    Dim Cone As New cls_Conexao

    Public Property Cod_Departamento() As Integer
        Get
            Return mCod_Departamento
        End Get
        Set(ByVal value As Integer)
            mCod_Departamento = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Return mDescricao
        End Get
        Set(ByVal value As String)
            mDescricao = value
        End Set
    End Property
    Public Sub InsertDep()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_Criar_Departame"
                .Parameters.AddWithValue("@Descricao", mDescricao)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub SelecionaDep(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleDepDes"
                        .Parameters.AddWithValue("@Descricao", mDescricao)

                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            Cliente.dt1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    
End Class
