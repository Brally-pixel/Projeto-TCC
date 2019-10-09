Public Class Cls_Limpar
    Public Sub LimpaCampos(ByVal controle As Control)
        Dim objLimpar As New Cls_Limpar
        For Each c As Control In controle.Controls
            If c IsNot Contato_Empresa.Codigo_Contato And c IsNot Cadastro_Cliente.Cod_Cliente And c IsNot Cadastrar_Tipo_de_Conta.Codigo_Conta And c IsNot Criar_um_Departamento.Cod_Dep And c IsNot Cadastro_Fornecedor.Cod_Forn And c IsNot Cadastrar_Funcionario.Cod_Fun And c IsNot Cadastrar_o_Produto.Codigo_Produto And c IsNot Cadastrar_o_Produto.Codigo_marca Then
                If TypeOf c Is TextBox Then
                    DirectCast(c, TextBox).Clear()
                ElseIf TypeOf c Is DateTimePicker Then
                    DirectCast(c, DateTimePicker).Value = Date.Today
                ElseIf TypeOf c Is ComboBox Then
                    DirectCast(c, ComboBox).Text = ""
                ElseIf TypeOf c Is CheckBox Then
                    DirectCast(c, CheckBox).Checked = False
                ElseIf TypeOf c Is MaskedTextBox Then
                    DirectCast(c, MaskedTextBox).Text = ""
                ElseIf TypeOf c Is RadioButton Then
                    DirectCast(c, RadioButton).Checked = False
                ElseIf (c.Controls.Count > 0) Then
                    LimpaCampos(c)
                End If
            End If
        Next
    End Sub

End Class
