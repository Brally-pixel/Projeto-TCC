<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastrar_Tipo_de_Conta
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
        Me.Descricao = New System.Windows.Forms.TextBox
        Me.Codigo_Conta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Valor_Conta = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.GB_Acoes = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Valor_Pago = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CB_Responsavel = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_Pendente = New System.Windows.Forms.RadioButton
        Me.RB_Pago = New System.Windows.Forms.RadioButton
        Me.DTData_Venci = New System.Windows.Forms.DateTimePicker
        Me.DTtxData_Pagamento = New System.Windows.Forms.DateTimePicker
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Limpar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.dt1 = New System.Windows.Forms.DataGridView
        Me.GB_Acoes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Descricao
        '
        Me.Descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Descricao.Location = New System.Drawing.Point(133, 45)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(123, 22)
        Me.Descricao.TabIndex = 1
        '
        'Codigo_Conta
        '
        Me.Codigo_Conta.Enabled = False
        Me.Codigo_Conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Conta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Codigo_Conta.Location = New System.Drawing.Point(133, 21)
        Me.Codigo_Conta.Name = "Codigo_Conta"
        Me.Codigo_Conta.Size = New System.Drawing.Size(43, 22)
        Me.Codigo_Conta.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código da Conta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(18, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Valor da Conta"
        '
        'Valor_Conta
        '
        Me.Valor_Conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor_Conta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Valor_Conta.Location = New System.Drawing.Point(133, 70)
        Me.Valor_Conta.Name = "Valor_Conta"
        Me.Valor_Conta.Size = New System.Drawing.Size(55, 22)
        Me.Valor_Conta.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(590, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GB_Acoes
        '
        Me.GB_Acoes.BackColor = System.Drawing.Color.Transparent
        Me.GB_Acoes.Controls.Add(Me.Limpar)
        Me.GB_Acoes.Controls.Add(Me.Button1)
        Me.GB_Acoes.Controls.Add(Me.Button2)
        Me.GB_Acoes.Controls.Add(Me.Button4)
        Me.GB_Acoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Acoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GB_Acoes.Location = New System.Drawing.Point(12, 375)
        Me.GB_Acoes.Name = "GB_Acoes"
        Me.GB_Acoes.Size = New System.Drawing.Size(386, 67)
        Me.GB_Acoes.TabIndex = 162
        Me.GB_Acoes.TabStop = False
        Me.GB_Acoes.Text = "Ações"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(285, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Responsavel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(285, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Data de Pagamento"
        '
        'Valor_Pago
        '
        Me.Valor_Pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor_Pago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Valor_Pago.Location = New System.Drawing.Point(133, 94)
        Me.Valor_Pago.Name = "Valor_Pago"
        Me.Valor_Pago.Size = New System.Drawing.Size(55, 22)
        Me.Valor_Pago.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(18, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "Valor Pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(285, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 16)
        Me.Label9.TabIndex = 177
        Me.Label9.Text = "Data de Vencimento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_Responsavel)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DTData_Venci)
        Me.GroupBox1.Controls.Add(Me.DTtxData_Pagamento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Codigo_Conta)
        Me.GroupBox1.Controls.Add(Me.Valor_Pago)
        Me.GroupBox1.Controls.Add(Me.Descricao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Valor_Conta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 191)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        '
        'CB_Responsavel
        '
        Me.CB_Responsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Responsavel.FormattingEnabled = True
        Me.CB_Responsavel.Location = New System.Drawing.Point(435, 21)
        Me.CB_Responsavel.Name = "CB_Responsavel"
        Me.CB_Responsavel.Size = New System.Drawing.Size(121, 24)
        Me.CB_Responsavel.TabIndex = 181
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Pendente)
        Me.GroupBox2.Controls.Add(Me.RB_Pago)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(21, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 66)
        Me.GroupBox2.TabIndex = 180
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status da Conta"
        '
        'RB_Pendente
        '
        Me.RB_Pendente.AutoSize = True
        Me.RB_Pendente.Location = New System.Drawing.Point(7, 42)
        Me.RB_Pendente.Name = "RB_Pendente"
        Me.RB_Pendente.Size = New System.Drawing.Size(84, 20)
        Me.RB_Pendente.TabIndex = 1
        Me.RB_Pendente.TabStop = True
        Me.RB_Pendente.Text = "Pendente"
        Me.RB_Pendente.UseVisualStyleBackColor = True
        '
        'RB_Pago
        '
        Me.RB_Pago.AutoSize = True
        Me.RB_Pago.Location = New System.Drawing.Point(7, 17)
        Me.RB_Pago.Name = "RB_Pago"
        Me.RB_Pago.Size = New System.Drawing.Size(59, 20)
        Me.RB_Pago.TabIndex = 0
        Me.RB_Pago.TabStop = True
        Me.RB_Pago.Text = "Pago"
        Me.RB_Pago.UseVisualStyleBackColor = True
        '
        'DTData_Venci
        '
        Me.DTData_Venci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTData_Venci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTData_Venci.Location = New System.Drawing.Point(435, 75)
        Me.DTData_Venci.Name = "DTData_Venci"
        Me.DTData_Venci.Size = New System.Drawing.Size(108, 22)
        Me.DTData_Venci.TabIndex = 179
        '
        'DTtxData_Pagamento
        '
        Me.DTtxData_Pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTtxData_Pagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTtxData_Pagamento.Location = New System.Drawing.Point(435, 49)
        Me.DTtxData_Pagamento.Name = "DTtxData_Pagamento"
        Me.DTtxData_Pagamento.Size = New System.Drawing.Size(108, 22)
        Me.DTtxData_Pagamento.TabIndex = 179
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(490, 401)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 179
        Me.PictureBox1.TabStop = False
        '
        'Limpar
        '
        Me.Limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Limpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Limpar.Location = New System.Drawing.Point(284, 19)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(91, 37)
        Me.Limpar.TabIndex = 179
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Novo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(100, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 37)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Inserir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(192, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 37)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Listar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dt1
        '
        Me.dt1.AllowUserToAddRows = False
        Me.dt1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt1.Location = New System.Drawing.Point(12, 208)
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt1.Size = New System.Drawing.Size(562, 162)
        Me.dt1.TabIndex = 174
        '
        'Cadastrar_Tipo_de_Conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(590, 474)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.GB_Acoes)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastrar_Tipo_de_Conta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Tipo de Conta"
        Me.GB_Acoes.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Descricao As System.Windows.Forms.TextBox
    Friend WithEvents Codigo_Conta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Valor_Conta As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GB_Acoes As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Valor_Pago As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents DTData_Venci As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTtxData_Pagamento As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Pendente As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Pago As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CB_Responsavel As System.Windows.Forms.ComboBox
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
End Class
