Imports System.Data.SqlClient
Public Class frm_Backup
    Public StringConexao As String = "Server=.;Database=Loja_Chocolicia;UID=sa;PWD=123456;"

    Private Sub form_BACKUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cn As New SqlConnection

        With cn
            .ConnectionString = StringConexao
            .Open()
        End With
    End Sub
    Dim objBack As New Cls_Backup
    Private Sub btn_backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_backup.Click
        If Dir("C:\Nova pasta (2)\BackupLoja.bak") <> vbNullString Then
            objBack.Backup("C:\Nova pasta (2)\BackupLoja" + (Date.Today).ToString.Replace("/", ".").Replace(" 00:00:00", "") + ".bak")
        Else
            MkDir("C:\Nova pasta (2)")
            objBack.Backup("C:\Nova pasta (2)\BackupLoja" + (Date.Today).ToString.Replace("/", ".").Replace(" 00:00:00", "") + ".bak")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objBack.Restore(TxtLocal.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class