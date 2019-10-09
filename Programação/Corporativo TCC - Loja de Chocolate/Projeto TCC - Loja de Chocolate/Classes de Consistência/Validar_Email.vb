Public Class Validar_Email
    Public Function ValEMail(ByVal sEMail As String) As Boolean

        Dim nCharacter As Integer
        Dim Count As Integer
        Dim sLetra As String

        If Len(sEMail) < 5 Then
            ValEMail = False
            Exit Function
        End If

        For nCharacter = 1 To Len(sEMail)

            If Mid(sEMail, nCharacter, 1) = "@" Then
                Count = Count + 1
            End If
        Next

        If Count <> 1 Then
            ValEMail = False
            Exit Function
        Else
            If InStr(sEMail, "@") = 1 Then
                ValEMail = False
                Exit Function

            ElseIf InStr(sEMail, "@") = Len(sEMail) Then
                ValEMail = False
                Exit Function
            End If
        End If

        nCharacter = 0
        Count = 0

        For nCharacter = 1 To Len(sEMail)
            If Mid(sEMail, nCharacter, 1) = "." Then
                Count = Count + 1
            End If
        Next

        If Count < 1 Then
            ValEMail = False
            Exit Function
        Else
            If InStr(sEMail, ".") = 1 Then
                ValEMail = False
                Exit Function

            ElseIf InStr(sEMail, ".") = Len(sEMail) Then
                ValEMail = False
                Exit Function

            ElseIf InStr(InStr(sEMail, "@"), sEMail, ".") = 0 Then
                ValEMail = False
                Exit Function
            End If
        End If

        nCharacter = 0
        Count = 0

        If InStr(sEMail, "..") > InStr(sEMail, "@") Then
            ValEMail = False
            Exit Function
        End If

        For nCharacter = 1 To Len(sEMail)
            sLetra = Mid$(sEMail, nCharacter, 1)
            If Not (LCase(sLetra) Like "[a-z]" Or sLetra = _
                "@" Or sLetra = "." Or sLetra = "-" Or _
                sLetra = "_" Or IsNumeric(sLetra)) Then
                ValEMail = False
                Exit Function
            End If
        Next

        If Mid$(sEMail, 1) = "." Then
            ValEMail = False
            Exit Function
        End If

        nCharacter = 0
        ValEMail = True

    End Function
End Class
