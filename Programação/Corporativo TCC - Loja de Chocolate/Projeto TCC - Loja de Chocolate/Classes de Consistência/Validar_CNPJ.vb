Public Class Validar_CNPJ
    Public Function ValidaCNPJ(ByVal CNPJ As String)
        Dim Numero(13) As Integer
        Dim soma As Integer
        Dim i As Integer
        Dim resultado1 As Integer
        Dim resultado2 As Integer
        For i = 0 To Numero.Length - 1
            Numero(i) = CInt(CNPJ.Substring(i, 1))
        Next
        soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 + _
        Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2
        soma = soma - (11 * (Int(soma / 11)))
        If soma = 0 Or soma = 1 Then
            resultado1 = 0
        Else
            resultado1 = 11 - soma
        End If
        If resultado1 = Numero(12) Then
            soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + _
            Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            soma = soma - (11 * (Int(soma / 11)))
            If soma = 0 Or soma = 1 Then
                resultado2 = 0
            Else
                resultado2 = 11 - soma
            End If
            If resultado2 = Numero(13) Then
                Return True
            Else
                MsgBox("CNPJ inválido.")
                Return False
            End If
        Else
            MsgBox("CNPJ inválido.")
            Return False
        End If
    End Function

End Class
