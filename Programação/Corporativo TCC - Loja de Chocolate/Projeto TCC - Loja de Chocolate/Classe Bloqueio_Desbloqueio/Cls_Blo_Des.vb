Public Class Cls_Blo_Des
    Public Sub GBDisabled(ByVal Formulario As Form)
        Dim controle As Control
        Dim i As Integer
        For i = 0 To Formulario.Controls.Count - 1
            controle = Formulario.Controls(i)
            If TypeOf controle Is GroupBox And controle IsNot Cadastro_Cliente.GB_Acoes And controle IsNot Cadastrar_Tipo_de_Conta.GB_Acoes And controle IsNot Criar_um_Departamento.GB_Acoes And controle IsNot Cadastro_Fornecedor.GB_Acoes And controle IsNot Contato_Empresa.GB_Acoes And controle IsNot Cadastrar_Funcionario.GB_Acoes Then
                controle.Enabled = False
            End If
        Next i
    End Sub
    Public Sub GBEnabled(ByVal Formulario As Form)
        Dim controle As Control
        Dim i As Integer
        For i = 0 To Formulario.Controls.Count - 1
            controle = Formulario.Controls(i)
            If TypeOf controle Is GroupBox Then
                controle.Enabled = True
            End If
        Next i
    End Sub
End Class
