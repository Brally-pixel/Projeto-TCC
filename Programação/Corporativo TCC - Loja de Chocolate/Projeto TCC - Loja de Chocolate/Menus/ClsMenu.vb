Imports System.Data.SqlClient

Public Class ClsMenu
    Dim cone As New cls_Conexao
    Dim mNivel As Integer
    Public Property Nivel() As Integer
        Get
            Return mNivel
        End Get
        Set(ByVal value As Integer)
            mNivel = value
        End Set
    End Property
End Class
