<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contato_Empresa
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Codigo_Contato = New System.Windows.Forms.TextBox
        Me.Nome = New System.Windows.Forms.TextBox
        Me.Email_Con = New System.Windows.Forms.TextBox
        Me.GB_Acoes = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_Feminino = New System.Windows.Forms.RadioButton
        Me.RB_Masculino = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.CB_Empresa = New System.Windows.Forms.ComboBox
        Me.M_Fax = New System.Windows.Forms.MaskedTextBox
        Me.M_Numero_Conta = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnNovo = New System.Windows.Forms.Button
        Me.BtnLimpar = New System.Windows.Forms.Button
        Me.BtnAlterar = New System.Windows.Forms.Button
        Me.BtnCadastrar = New System.Windows.Forms.Button
        Me.GB_Acoes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código do Contato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome* :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(16, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(16, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Contato* :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(16, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Número Contato* :"
        '
        'Codigo_Contato
        '
        Me.Codigo_Contato.Enabled = False
        Me.Codigo_Contato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Contato.Location = New System.Drawing.Point(151, 13)
        Me.Codigo_Contato.Name = "Codigo_Contato"
        Me.Codigo_Contato.Size = New System.Drawing.Size(52, 22)
        Me.Codigo_Contato.TabIndex = 5
        '
        'Nome
        '
        Me.Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.Location = New System.Drawing.Point(151, 68)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(146, 22)
        Me.Nome.TabIndex = 2
        '
        'Email_Con
        '
        Me.Email_Con.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Con.Location = New System.Drawing.Point(150, 124)
        Me.Email_Con.Name = "Email_Con"
        Me.Email_Con.Size = New System.Drawing.Size(147, 22)
        Me.Email_Con.TabIndex = 4
        '
        'GB_Acoes
        '
        Me.GB_Acoes.BackColor = System.Drawing.Color.Transparent
        Me.GB_Acoes.Controls.Add(Me.BtnNovo)
        Me.GB_Acoes.Controls.Add(Me.BtnLimpar)
        Me.GB_Acoes.Controls.Add(Me.BtnAlterar)
        Me.GB_Acoes.Controls.Add(Me.BtnCadastrar)
        Me.GB_Acoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Acoes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GB_Acoes.Location = New System.Drawing.Point(12, 202)
        Me.GB_Acoes.Name = "GB_Acoes"
        Me.GB_Acoes.Size = New System.Drawing.Size(410, 71)
        Me.GB_Acoes.TabIndex = 151
        Me.GB_Acoes.TabStop = False
        Me.GB_Acoes.Text = "Ações"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RB_Feminino)
        Me.GroupBox2.Controls.Add(Me.RB_Masculino)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(335, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 81)
        Me.GroupBox2.TabIndex = 156
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'RB_Feminino
        '
        Me.RB_Feminino.AutoSize = True
        Me.RB_Feminino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Feminino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Feminino.Location = New System.Drawing.Point(6, 42)
        Me.RB_Feminino.Name = "RB_Feminino"
        Me.RB_Feminino.Size = New System.Drawing.Size(81, 20)
        Me.RB_Feminino.TabIndex = 8
        Me.RB_Feminino.TabStop = True
        Me.RB_Feminino.Text = "Feminino"
        Me.RB_Feminino.UseVisualStyleBackColor = True
        '
        'RB_Masculino
        '
        Me.RB_Masculino.AutoSize = True
        Me.RB_Masculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Masculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Masculino.Location = New System.Drawing.Point(6, 20)
        Me.RB_Masculino.Name = "RB_Masculino"
        Me.RB_Masculino.Size = New System.Drawing.Size(87, 20)
        Me.RB_Masculino.TabIndex = 7
        Me.RB_Masculino.TabStop = True
        Me.RB_Masculino.Text = "Masculino"
        Me.RB_Masculino.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(16, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 16)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Nome da Empresa* :"
        '
        'CB_Empresa
        '
        Me.CB_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Empresa.FormattingEnabled = True
        Me.CB_Empresa.Location = New System.Drawing.Point(151, 38)
        Me.CB_Empresa.Name = "CB_Empresa"
        Me.CB_Empresa.Size = New System.Drawing.Size(100, 24)
        Me.CB_Empresa.TabIndex = 1
        '
        'M_Fax
        '
        Me.M_Fax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.M_Fax.Location = New System.Drawing.Point(151, 94)
        Me.M_Fax.Mask = "(00)00000-9999"
        Me.M_Fax.Name = "M_Fax"
        Me.M_Fax.Size = New System.Drawing.Size(100, 23)
        Me.M_Fax.TabIndex = 3
        Me.M_Fax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'M_Numero_Conta
        '
        Me.M_Numero_Conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.M_Numero_Conta.Location = New System.Drawing.Point(150, 152)
        Me.M_Numero_Conta.Mask = "(00)00000-9999"
        Me.M_Numero_Conta.Name = "M_Numero_Conta"
        Me.M_Numero_Conta.Size = New System.Drawing.Size(100, 23)
        Me.M_Numero_Conta.TabIndex = 5
        Me.M_Numero_Conta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.M_Numero_Conta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.M_Fax)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CB_Empresa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Codigo_Contato)
        Me.GroupBox1.Controls.Add(Me.Nome)
        Me.GroupBox1.Controls.Add(Me.Email_Con)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 184)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 15)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Campos Obrigatórios ( * )"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(431, 229)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 164
        Me.PictureBox1.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNovo.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNovo.Location = New System.Drawing.Point(6, 21)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(86, 40)
        Me.BtnNovo.TabIndex = 13
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpar.Location = New System.Drawing.Point(314, 21)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(91, 40)
        Me.BtnLimpar.TabIndex = 11
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Enabled = False
        Me.BtnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAlterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlterar.Location = New System.Drawing.Point(218, 21)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(90, 40)
        Me.BtnAlterar.TabIndex = 10
        Me.BtnAlterar.Text = "Aterar "
        Me.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCadastrar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCadastrar.Location = New System.Drawing.Point(98, 21)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(114, 40)
        Me.BtnCadastrar.TabIndex = 9
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'Contato_Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(525, 299)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Acoes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contato_Empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Contato Empresa"
        Me.GB_Acoes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Codigo_Contato As System.Windows.Forms.TextBox
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Email_Con As System.Windows.Forms.TextBox
    Friend WithEvents GB_Acoes As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents BtnAlterar As System.Windows.Forms.Button
    Friend WithEvents BtnCadastrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Feminino As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Masculino As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents M_Fax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents M_Numero_Conta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnNovo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
