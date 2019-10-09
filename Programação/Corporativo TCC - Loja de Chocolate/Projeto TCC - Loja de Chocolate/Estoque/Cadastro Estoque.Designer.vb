<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controle_Estoque
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Cadastro_Forn = New System.Windows.Forms.Button
        Me.BtnAterar = New System.Windows.Forms.Button
        Me.BtnCadastrar = New System.Windows.Forms.Button
        Me.Sair = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.QuantMax = New System.Windows.Forms.TextBox
        Me.QuantMin = New System.Windows.Forms.TextBox
        Me.Descri = New System.Windows.Forms.TextBox
        Me.Valor_Venda = New System.Windows.Forms.TextBox
        Me.CB_Unidade = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CB_Produto = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DG = New System.Windows.Forms.DataGridView
        Me.CB_Fornecedor = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.codigo_Produto = New System.Windows.Forms.TextBox
        Me.GroupBox4.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Valor de Venda *"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Cadastro_Forn)
        Me.GroupBox4.Controls.Add(Me.BtnAterar)
        Me.GroupBox4.Controls.Add(Me.BtnCadastrar)
        Me.GroupBox4.Controls.Add(Me.Sair)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(15, 235)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(495, 71)
        Me.GroupBox4.TabIndex = 163
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
        '
        'Cadastro_Forn
        '
        Me.Cadastro_Forn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastro_Forn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cadastro_Forn.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.Cadastro_Forn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cadastro_Forn.Location = New System.Drawing.Point(123, 21)
        Me.Cadastro_Forn.Name = "Cadastro_Forn"
        Me.Cadastro_Forn.Size = New System.Drawing.Size(136, 40)
        Me.Cadastro_Forn.TabIndex = 8
        Me.Cadastro_Forn.Text = "Cadastrar Fornecedor"
        Me.Cadastro_Forn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cadastro_Forn.UseVisualStyleBackColor = True
        '
        'BtnAterar
        '
        Me.BtnAterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.BtnAterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAterar.Location = New System.Drawing.Point(265, 21)
        Me.BtnAterar.Name = "BtnAterar"
        Me.BtnAterar.Size = New System.Drawing.Size(93, 40)
        Me.BtnAterar.TabIndex = 6
        Me.BtnAterar.Text = "Alterar"
        Me.BtnAterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAterar.UseVisualStyleBackColor = True
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCadastrar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCadastrar.Location = New System.Drawing.Point(6, 21)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(111, 40)
        Me.BtnCadastrar.TabIndex = 5
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'Sair
        '
        Me.Sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Sair.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Sair.Location = New System.Drawing.Point(364, 21)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(98, 40)
        Me.Sair.TabIndex = 7
        Me.Sair.Text = "Limpar*"
        Me.Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Unidade *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Quantidade Máxima *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Quantidade Mínima *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Sabor *"
        '
        'QuantMax
        '
        Me.QuantMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QuantMax.Location = New System.Drawing.Point(151, 101)
        Me.QuantMax.Name = "QuantMax"
        Me.QuantMax.Size = New System.Drawing.Size(70, 23)
        Me.QuantMax.TabIndex = 2
        Me.QuantMax.Text = "0"
        '
        'QuantMin
        '
        Me.QuantMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QuantMin.Location = New System.Drawing.Point(151, 130)
        Me.QuantMin.Name = "QuantMin"
        Me.QuantMin.Size = New System.Drawing.Size(70, 23)
        Me.QuantMin.TabIndex = 3
        Me.QuantMin.Text = "0"
        '
        'Descri
        '
        Me.Descri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descri.Location = New System.Drawing.Point(151, 159)
        Me.Descri.Name = "Descri"
        Me.Descri.Size = New System.Drawing.Size(171, 22)
        Me.Descri.TabIndex = 4
        '
        'Valor_Venda
        '
        Me.Valor_Venda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Valor_Venda.Location = New System.Drawing.Point(151, 187)
        Me.Valor_Venda.Name = "Valor_Venda"
        Me.Valor_Venda.Size = New System.Drawing.Size(80, 23)
        Me.Valor_Venda.TabIndex = 5
        '
        'CB_Unidade
        '
        Me.CB_Unidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_Unidade.FormattingEnabled = True
        Me.CB_Unidade.Items.AddRange(New Object() {"Pacote", "Gramas", "Unidade"})
        Me.CB_Unidade.Location = New System.Drawing.Point(151, 71)
        Me.CB_Unidade.Name = "CB_Unidade"
        Me.CB_Unidade.Size = New System.Drawing.Size(102, 24)
        Me.CB_Unidade.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 15)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Campos Obrigatórios ( * )"
        '
        'CB_Produto
        '
        Me.CB_Produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_Produto.FormattingEnabled = True
        Me.CB_Produto.Location = New System.Drawing.Point(151, 41)
        Me.CB_Produto.Name = "CB_Produto"
        Me.CB_Produto.Size = New System.Drawing.Size(90, 24)
        Me.CB_Produto.TabIndex = 175
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(12, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "Produto *"
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG.DefaultCellStyle = DataGridViewCellStyle8
        Me.DG.Location = New System.Drawing.Point(347, 12)
        Me.DG.Name = "DG"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG.Size = New System.Drawing.Size(431, 175)
        Me.DG.TabIndex = 182
        '
        'CB_Fornecedor
        '
        Me.CB_Fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_Fornecedor.FormattingEnabled = True
        Me.CB_Fornecedor.Location = New System.Drawing.Point(634, 198)
        Me.CB_Fornecedor.Name = "CB_Fornecedor"
        Me.CB_Fornecedor.Size = New System.Drawing.Size(144, 24)
        Me.CB_Fornecedor.TabIndex = 183
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(547, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Fornecedor"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(408, 200)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 185
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(344, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 186
        Me.Label9.Text = "Produto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(688, 284)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 181
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(12, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 16)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "Código do Produto"
        '
        'codigo_Produto
        '
        Me.codigo_Produto.Enabled = False
        Me.codigo_Produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.codigo_Produto.Location = New System.Drawing.Point(151, 11)
        Me.codigo_Produto.Name = "codigo_Produto"
        Me.codigo_Produto.Size = New System.Drawing.Size(44, 23)
        Me.codigo_Produto.TabIndex = 188
        '
        'Controle_Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 340)
        Me.Controls.Add(Me.codigo_Produto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CB_Fornecedor)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CB_Produto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CB_Unidade)
        Me.Controls.Add(Me.Valor_Venda)
        Me.Controls.Add(Me.Descri)
        Me.Controls.Add(Me.QuantMin)
        Me.Controls.Add(Me.QuantMax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Controle_Estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro do Estoque"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCadastrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnAterar As System.Windows.Forms.Button
    Friend WithEvents QuantMax As System.Windows.Forms.TextBox
    Friend WithEvents QuantMin As System.Windows.Forms.TextBox
    Friend WithEvents Descri As System.Windows.Forms.TextBox
    Friend WithEvents Valor_Venda As System.Windows.Forms.TextBox
    Friend WithEvents CB_Unidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_Produto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cadastro_Forn As System.Windows.Forms.Button
    Friend WithEvents DG As System.Windows.Forms.DataGridView
    Friend WithEvents CB_Fornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Sair As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents codigo_Produto As System.Windows.Forms.TextBox
End Class
