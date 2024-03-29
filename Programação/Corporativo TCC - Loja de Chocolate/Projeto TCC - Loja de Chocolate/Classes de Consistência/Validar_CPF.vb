﻿Public Class Validar_CPF
    Public dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44", _
                                         "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}

    Public Const msgErro As String = "Dados Inválidos"
    Public bValida As Boolean
    Public sCPF As String
    Public sCNPJ As String

    Public Property cpf() As String
        Get
            Return sCPF
        End Get
        Set(ByVal Valor As String)
            bValida = ValidaCPF(Valor)
            If bValida Then
                sCPF = Valor
            Else
                sCPF = Valor
            End If
        End Set
    End Property

    Public ReadOnly Property isCpfValido() As Boolean
        Get
            bValida = ValidaCPF(cpf)
            If bValida = True Then
                Return True
            ElseIf bValida = False Then
                Return False
            End If
        End Get
    End Property

    'Public Function ValidaCPF(ByVal CPF As String) As Boolean

    '    Dim i, x, n1, n2 As Integer


    '    CPF = CPF.Trim

    '    For i = 0 To dadosArray.Length - 1
    '        If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then
    '            Return False
    '        End If
    '    Next

    '    'remove a maskara
    '    CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)

    '    For x = 0 To 1
    '        n1 = 0

    '        For i = 0 To 8 + x
    '            n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
    '        Next

    '        n2 = 11 - (n1 - (Int(n1 / 11) * 11))

    '        If n2 = 10 Or n2 = 11 Then n2 = 0

    '        If n2 <> Val(CPF.Substring(9 + x, 1)) Then
    '            Return False
    '        End If
    '    Next

    '    Return True
    'End Function

    Public Function ValidaCPF(ByVal CPF As String) As Boolean
        Dim i, x, n1, n2 As Integer
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                MsgBox("CPF inválido.")
                Return False
            End If
        Next
        Return True
    End Function
End Class
