Public Class Cls_Backup
    Dim cone As New cls_Conexao
    Public Sub Backup(ByVal Local As String)
        Try
            If Cone.Conectar = True Then
                Cone.Desconectar()
            End If
            Dim sc As New Data.SqlClient.SqlCommand
            With sc
                '.CommandText = "backup database TCC to disk = 'D:\Dalilla\Back1.bak'"
                .CommandText = "backup database TCC to disk = '" & Local & "'"
                .Connection = Cone.cnn
                Cone.cnn.Open()
                .ExecuteNonQuery()
                Cone.cnn.Close()
            End With
            MsgBox("Backup realizado com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
    End Sub
    Public Sub Restore(ByVal Local As String)
        Try
            Dim sc As New Data.SqlClient.SqlCommand
            If Dir("C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Data\Loja_Chocolicia.mdf") = vbNullString Then
                cone.Desconectar()
                With sc
                    .CommandText = "use [master]" & vbCrLf _
                    & "restore database TCC from disk = '" & Local & "' with replace"
                    .Connection = cone.cnn
                    cone.cnn.Open()
                    .ExecuteNonQuery()
                    MsgBox("Restore realizado com sucesso!")
                    cone.cnn.Close()
                End With
            Else
                With sc
                    .CommandText = "use [master]" & vbCrLf _
                    & "restore database TCC from disk = '" & Local & "' with replace"
                    .Connection = cone.cnnrestore
                    cone.cnnrestore.Open()
                    .ExecuteNonQuery()
                    MsgBox("Restore realizado com sucesso!")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
            Cone.cnn.Close()
            Cone.cnnrestore.Close()
        End Try
    End Sub
    Public Sub Backup2(ByVal Local As String)
        Try
            If cone.Conectar = True Then
                cone.Desconectar()
            End If
            Dim sc As New Data.SqlClient.SqlCommand
            With sc
                '.CommandText = "backup database TCC to disk = 'D:\Dalilla\Back1.bak'"
                .CommandText = "backup database TCC to disk = '" & Local & "'"
                .Connection = cone.cnn
                cone.cnn.Open()
                .ExecuteNonQuery()
                cone.cnn.Close()
            End With
            MsgBox("Backup realizado com sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
    End Sub
    Public Sub Restore2(ByVal Local As String)
        Try
            Dim sc As New Data.SqlClient.SqlCommand
            If cone.Conectar = True Then
                cone.Desconectar()
                With sc
                    .CommandText = "use [master]" & vbCrLf _
                    & "restore database TCC from disk = '" & Local & "' with replace"
                    .Connection = cone.cnn
                    cone.cnn.Open()
                    .ExecuteNonQuery()
                    cone.cnn.Close()
                End With
            Else
                With sc
                    .CommandText = "use [master]" & vbCrLf _
                    & "restore database TCC from disk = '" & Local & "' with replace"
                    .Connection = cone.cnnrestore
                    cone.cnnrestore.Open()
                    .ExecuteNonQuery()
                    MsgBox("Restore realizado com sucesso!")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
            cone.cnn.Close()
            cone.cnnrestore.Close()
        End Try
    End Sub

End Class