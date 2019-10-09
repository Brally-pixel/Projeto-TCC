Public Class Encerramento_Vendas
    Dim valorRecebimento As Decimal


    '    Private Sub TxtDinheiro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDinheiro.KeyDown
    '        If e.KeyCode = 13 Then
    '            If TxtDinheiro.Text <> "" Then
    '                Try
    '                    With objReceb
    '                        .Cod_Venda = objUTL.CodVenda
    '                        .Cod_Receb = .SeleCodRecebimento + 1
    '                        .CodForma_Pag = 1
    '                        .DataReceb = Date.Today
    '                        If CDbl(TxtDinheiro.Text) > Valor - ValorRecebimento Then
    '                            LblTroco.Text = FormatCurrency(CDbl(TxtDinheiro.Text) - (Valor - ValorRecebimento))
    '                            .ValorReceb = Valor - ValorRecebimento
    '                        Else
    '                            LblTroco.Text = FormatCurrency(0)
    '                            .ValorReceb = CDbl(TxtDinheiro.Text)
    '                        End If
    '                        .Status_Pag = "Pa"
    '                        .InsertRecebimento()
    '                        ValorRecebimento += .ValorReceb
    '                        LblVlPago.Text = FormatCurrency(Math.Round(CDbl(ValorRecebimento), 2))
    '                        GBDinheiro.Enabled = False
    '                    End With
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Finally

    '                End Try
    '            End If
    '        End If
    '    End Sub

    Private Sub Encerramento_Vendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Pg_Dinheiro.CheckedChanged
        If RB_Pg_Dinheiro.Checked = True Then
            Gb_Dinheiro.Enabled = True
        Else
            Gb_Dinheiro.Enabled = False
        End If
    End Sub

    Private Sub RB_Pg_Cartao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Pg_Cartao.CheckedChanged
        If RB_Pg_Cartao.Checked = True Then
            GB_Cartao.Enabled = True
        Else
            GB_Cartao.Enabled = False
        End If
    End Sub

    Private Sub RB_Pg_Misto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Pg_Misto.CheckedChanged
        If RB_Pg_Misto.Checked = True Then
            GB_Cartao.Enabled = True
            Gb_Dinheiro.Enabled = True
        Else
            GB_Cartao.Enabled = False
            Gb_Dinheiro.Enabled = False
        End If
    End Sub
    Dim objReceb As New ClsRecebimento
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TxtDinheiro.Text <> "" Then
            If RB_Pg_Dinheiro.Checked = True And CInt(TxtDinheiro.Text) < CInt(Valor_Total_Enc.Text) Then
                MsgBox("Dinheiro Insuficiente")
            Else
                Try
                    With objReceb
                        .Cod_Venda = Vendas.CodVenda
                        .Cod_Receb = .SeleCodRecebimento + 1
                        .CodForma_Pag = 1
                        .DataReceb = Date.Today
                        If CDbl(TxtDinheiro.Text) > Valor_Total_Enc.Text - valorRecebimento Then
                            LblTroco.Text = FormatCurrency(CDbl(TxtDinheiro.Text) - Valor_Total_Enc.Text)
                            .ValorReceb = Valor_Total_Enc.Text - valorRecebimento


                        Else

                            LblTroco.Text = FormatCurrency(0)
                            .ValorReceb = CDbl(TxtDinheiro.Text)
                        End If
                        .Status_Pag = "Pa"

                        .InsertRecebimento()

                        valorRecebimento += .ValorReceb
                        lblVlPago.Text = FormatCurrency(Math.Round(CDbl(valorRecebimento), 2))
                        If lblVlPago.Text = Valor_Total_Enc.Text Then
                            MsgBox("Venda Finalizada!")
                            Me.Close()
                        End If
                    End With
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally

                End Try
            End If
        End If
    End Sub
    Dim x As Integer = 0
    Dim y As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TxtValoor.Text <> "" Then
            If RB_Pg_Cartao.Checked = True And CInt(txtValoor.Text) < CInt(Valor_Total_Enc.Text) Then
                MsgBox("Dinheiro Insuficiente")
            Else
                If ComboParcela.SelectedIndex <> -1 Then
                    If Math.Round(CDbl(txtValoor.Text), 2) > (Valor_Total_Enc.Text - valorRecebimento) Then
                        x = 1
                    End If
                Else
                    If CDbl(txtValoor.Text) > Valor_Total_Enc.Text - valorRecebimento Then
                        x = 1
                    End If
                End If
                If x = 1 Then
                    MsgBox("O valor não deve passar do valor pago.")
                    txtValoor.Text = Valor_Total_Enc.Text - valorRecebimento
                    x = 0
                Else
                    y = 1
                    If MsgBox("A transação Aprovada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            With objReceb
                                .Cod_Venda = Vendas.CodVenda
                                .Status_Pag = "Pa"
                                If RB_Debito.Checked = True Then
                                    .Cod_Receb = .SeleCodRecebimento + 1
                                    .Status_Pag = "Pa"
                                    .CodForma_Pag = 2
                                    .DataReceb = Date.Today
                                    .ValorReceb = CDbl(txtValoor.Text)
                                    valorRecebimento += .ValorReceb
                                    .InsertRecebimento()

                                ElseIf RB_Credito.Checked = True Then
                                    .Status_Pag = "Pa"
                                    .CodForma_Pag = 3
                                    .ValorReceb = Math.Round(CDbl(txtValoor.Text) / (ComboParcela.SelectedIndex + 1), 2)
                                    For a As Integer = 1 To (ComboParcela.SelectedIndex + 1)
                                        .Cod_Receb = .SeleCodRecebimento + 1
                                        .DataReceb = DateAdd(DateInterval.Month, a, Date.Today)
                                        .InsertRecebimento()

                                    Next a
                                    valorRecebimento += .ValorReceb * (ComboParcela.SelectedIndex + 1)
                                End If
                                lblVlPago.Text = FormatCurrency(Math.Round(CDbl(valorRecebimento), 2))
                                If lblVlPago.Text = Valor_Total_Enc.Text Then
                                    MsgBox("Venda Finalizada!")
                                    Me.Close()
                                End If
                            End With
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            y = 0
                        End Try
                    End If
                End If
            End If
            End If

    End Sub

    Private Sub RB_Debito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Debito.CheckedChanged
        If RB_Debito.Checked = True Then
            ComboParcela.Visible = False
            Label7.Visible = False
        Else
            ComboParcela.Visible = True
            Label7.Visible = True
        End If
    End Sub

    Private Sub TxtDinheiro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDinheiro.TextChanged

    End Sub

    Private Sub RB_Credito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Credito.CheckedChanged
        If RB_Credito.Checked = True Then
            ComboParcela.Visible = True
            Label7.Visible = True
        Else
            ComboParcela.Visible = False
            Label7.Visible = False
        End If

    End Sub
End Class