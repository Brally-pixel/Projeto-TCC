<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encerramento_Vendas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Gb_Dinheiro = New System.Windows.Forms.GroupBox
        Me.LblTroco = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDinheiro = New System.Windows.Forms.TextBox
        Me.Valor_Total_Enc = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GB_Cartao = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtValoor = New System.Windows.Forms.TextBox
        Me.RB_Credito = New System.Windows.Forms.RadioButton
        Me.RB_Debito = New System.Windows.Forms.RadioButton
        Me.RB_Pg_Dinheiro = New System.Windows.Forms.RadioButton
        Me.RB_Pg_Cartao = New System.Windows.Forms.RadioButton
        Me.RB_Pg_Misto = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblVlPago = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboParcela = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Gb_Dinheiro.SuspendLayout()
        Me.GB_Cartao.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb_Dinheiro
        '
        Me.Gb_Dinheiro.Controls.Add(Me.Label6)
        Me.Gb_Dinheiro.Controls.Add(Me.LblTroco)
        Me.Gb_Dinheiro.Controls.Add(Me.Button1)
        Me.Gb_Dinheiro.Controls.Add(Me.Label3)
        Me.Gb_Dinheiro.Controls.Add(Me.TxtDinheiro)
        Me.Gb_Dinheiro.Enabled = False
        Me.Gb_Dinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Gb_Dinheiro.ForeColor = System.Drawing.Color.White
        Me.Gb_Dinheiro.Location = New System.Drawing.Point(13, 65)
        Me.Gb_Dinheiro.Margin = New System.Windows.Forms.Padding(4)
        Me.Gb_Dinheiro.Name = "Gb_Dinheiro"
        Me.Gb_Dinheiro.Padding = New System.Windows.Forms.Padding(4)
        Me.Gb_Dinheiro.Size = New System.Drawing.Size(477, 105)
        Me.Gb_Dinheiro.TabIndex = 0
        Me.Gb_Dinheiro.TabStop = False
        Me.Gb_Dinheiro.Text = "Dinheiro"
        '
        'LblTroco
        '
        Me.LblTroco.AutoSize = True
        Me.LblTroco.Location = New System.Drawing.Point(290, 51)
        Me.LblTroco.Name = "LblTroco"
        Me.LblTroco.Size = New System.Drawing.Size(13, 17)
        Me.LblTroco.TabIndex = 5
        Me.LblTroco.Text = "-"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_ok_032x032
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(365, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Encerar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor Recebido :"
        '
        'TxtDinheiro
        '
        Me.TxtDinheiro.Location = New System.Drawing.Point(127, 45)
        Me.TxtDinheiro.Name = "TxtDinheiro"
        Me.TxtDinheiro.Size = New System.Drawing.Size(100, 23)
        Me.TxtDinheiro.TabIndex = 2
        '
        'Valor_Total_Enc
        '
        Me.Valor_Total_Enc.AutoSize = True
        Me.Valor_Total_Enc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Valor_Total_Enc.Location = New System.Drawing.Point(161, 358)
        Me.Valor_Total_Enc.Name = "Valor_Total_Enc"
        Me.Valor_Total_Enc.Size = New System.Drawing.Size(29, 31)
        Me.Valor_Total_Enc.TabIndex = 1
        Me.Valor_Total_Enc.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor Total :"
        '
        'GB_Cartao
        '
        Me.GB_Cartao.Controls.Add(Me.Label7)
        Me.GB_Cartao.Controls.Add(Me.ComboParcela)
        Me.GB_Cartao.Controls.Add(Me.Button2)
        Me.GB_Cartao.Controls.Add(Me.Label5)
        Me.GB_Cartao.Controls.Add(Me.txtValoor)
        Me.GB_Cartao.Controls.Add(Me.RB_Credito)
        Me.GB_Cartao.Controls.Add(Me.RB_Debito)
        Me.GB_Cartao.Enabled = False
        Me.GB_Cartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GB_Cartao.ForeColor = System.Drawing.Color.White
        Me.GB_Cartao.Location = New System.Drawing.Point(12, 178)
        Me.GB_Cartao.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_Cartao.Name = "GB_Cartao"
        Me.GB_Cartao.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_Cartao.Size = New System.Drawing.Size(477, 136)
        Me.GB_Cartao.TabIndex = 1
        Me.GB_Cartao.TabStop = False
        Me.GB_Cartao.Text = "Cartão"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_ok_032x032
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(366, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Encerar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Valor Pago :"
        '
        'txtValoor
        '
        Me.txtValoor.Location = New System.Drawing.Point(150, 97)
        Me.txtValoor.Name = "txtValoor"
        Me.txtValoor.Size = New System.Drawing.Size(100, 23)
        Me.txtValoor.TabIndex = 4
        '
        'RB_Credito
        '
        Me.RB_Credito.AutoSize = True
        Me.RB_Credito.Location = New System.Drawing.Point(150, 23)
        Me.RB_Credito.Name = "RB_Credito"
        Me.RB_Credito.Size = New System.Drawing.Size(71, 21)
        Me.RB_Credito.TabIndex = 1
        Me.RB_Credito.TabStop = True
        Me.RB_Credito.Text = "Credito"
        Me.RB_Credito.UseVisualStyleBackColor = True
        '
        'RB_Debito
        '
        Me.RB_Debito.AutoSize = True
        Me.RB_Debito.Location = New System.Drawing.Point(11, 23)
        Me.RB_Debito.Name = "RB_Debito"
        Me.RB_Debito.Size = New System.Drawing.Size(67, 21)
        Me.RB_Debito.TabIndex = 0
        Me.RB_Debito.TabStop = True
        Me.RB_Debito.Text = "Debito"
        Me.RB_Debito.UseVisualStyleBackColor = True
        '
        'RB_Pg_Dinheiro
        '
        Me.RB_Pg_Dinheiro.AutoSize = True
        Me.RB_Pg_Dinheiro.Location = New System.Drawing.Point(18, 19)
        Me.RB_Pg_Dinheiro.Name = "RB_Pg_Dinheiro"
        Me.RB_Pg_Dinheiro.Size = New System.Drawing.Size(133, 21)
        Me.RB_Pg_Dinheiro.TabIndex = 2
        Me.RB_Pg_Dinheiro.TabStop = True
        Me.RB_Pg_Dinheiro.Text = "Pagar a Dinheiro"
        Me.RB_Pg_Dinheiro.UseVisualStyleBackColor = True
        '
        'RB_Pg_Cartao
        '
        Me.RB_Pg_Cartao.AutoSize = True
        Me.RB_Pg_Cartao.Location = New System.Drawing.Point(168, 19)
        Me.RB_Pg_Cartao.Name = "RB_Pg_Cartao"
        Me.RB_Pg_Cartao.Size = New System.Drawing.Size(135, 21)
        Me.RB_Pg_Cartao.TabIndex = 3
        Me.RB_Pg_Cartao.TabStop = True
        Me.RB_Pg_Cartao.Text = "Pagar com Catão"
        Me.RB_Pg_Cartao.UseVisualStyleBackColor = True
        '
        'RB_Pg_Misto
        '
        Me.RB_Pg_Misto.AutoSize = True
        Me.RB_Pg_Misto.Location = New System.Drawing.Point(327, 19)
        Me.RB_Pg_Misto.Name = "RB_Pg_Misto"
        Me.RB_Pg_Misto.Size = New System.Drawing.Size(135, 21)
        Me.RB_Pg_Misto.TabIndex = 4
        Me.RB_Pg_Misto.TabStop = True
        Me.RB_Pg_Misto.Text = "Pagamento Misto"
        Me.RB_Pg_Misto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Pg_Dinheiro)
        Me.GroupBox3.Controls.Add(Me.RB_Pg_Misto)
        Me.GroupBox3.Controls.Add(Me.RB_Pg_Cartao)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 46)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipos de Pagamento"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logos_completos___Cópia
        Me.PictureBox1.Location = New System.Drawing.Point(12, 401)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox2.Location = New System.Drawing.Point(398, 410)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Valor Pago :"
        '
        'lblVlPago
        '
        Me.lblVlPago.AutoSize = True
        Me.lblVlPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlPago.Location = New System.Drawing.Point(161, 320)
        Me.lblVlPago.Name = "lblVlPago"
        Me.lblVlPago.Size = New System.Drawing.Size(29, 31)
        Me.lblVlPago.TabIndex = 9
        Me.lblVlPago.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Troco"
        '
        'ComboParcela
        '
        Me.ComboParcela.FormattingEnabled = True
        Me.ComboParcela.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboParcela.Location = New System.Drawing.Point(150, 62)
        Me.ComboParcela.Name = "ComboParcela"
        Me.ComboParcela.Size = New System.Drawing.Size(121, 24)
        Me.ComboParcela.TabIndex = 6
        Me.ComboParcela.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Parcelas"
        Me.Label7.Visible = False
        '
        'Encerramento_Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(498, 471)
        Me.Controls.Add(Me.lblVlPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GB_Cartao)
        Me.Controls.Add(Me.Valor_Total_Enc)
        Me.Controls.Add(Me.Gb_Dinheiro)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Encerramento_Vendas"
        Me.Text = "Encerramento Vendas"
        Me.Gb_Dinheiro.ResumeLayout(False)
        Me.Gb_Dinheiro.PerformLayout()
        Me.GB_Cartao.ResumeLayout(False)
        Me.GB_Cartao.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gb_Dinheiro As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Cartao As System.Windows.Forms.GroupBox
    Friend WithEvents Valor_Total_Enc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDinheiro As System.Windows.Forms.TextBox
    Friend WithEvents RB_Pg_Dinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Pg_Cartao As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Pg_Misto As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtValoor As System.Windows.Forms.TextBox
    Friend WithEvents RB_Credito As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Debito As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTroco As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVlPago As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboParcela As System.Windows.Forms.ComboBox
End Class
