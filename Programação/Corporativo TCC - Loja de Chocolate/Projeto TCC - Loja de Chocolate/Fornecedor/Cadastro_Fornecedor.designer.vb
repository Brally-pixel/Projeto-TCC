<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Fornecedor
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cod_Forn = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.M_Telefone = New System.Windows.Forms.MaskedTextBox
        Me.GB_Acoes = New System.Windows.Forms.GroupBox
        Me.Nome_Fanta = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Site_For = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Email = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.M_CNPJ = New System.Windows.Forms.MaskedTextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Razao_social = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CB_Cidade = New System.Windows.Forms.ComboBox
        Me.Endere = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Bairro = New System.Windows.Forms.TextBox
        Me.Numero = New System.Windows.Forms.TextBox
        Me.CB_UF = New System.Windows.Forms.ComboBox
        Me.Comple = New System.Windows.Forms.TextBox
        Me.M_CEP = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnNovo = New System.Windows.Forms.Button
        Me.BtnLimpar = New System.Windows.Forms.Button
        Me.btn_Alterar = New System.Windows.Forms.Button
        Me.BtnCadastrar = New System.Windows.Forms.Button
        Me.GB_Acoes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Telefone da Empresa* :"
        '
        'Cod_Forn
        '
        Me.Cod_Forn.Enabled = False
        Me.Cod_Forn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_Forn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cod_Forn.Location = New System.Drawing.Point(147, 243)
        Me.Cod_Forn.Name = "Cod_Forn"
        Me.Cod_Forn.Size = New System.Drawing.Size(37, 22)
        Me.Cod_Forn.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Código da Empresa :"
        '
        'M_Telefone
        '
        Me.M_Telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_Telefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.M_Telefone.Location = New System.Drawing.Point(158, 159)
        Me.M_Telefone.Mask = "(00) 9999-9999"
        Me.M_Telefone.Name = "M_Telefone"
        Me.M_Telefone.Size = New System.Drawing.Size(100, 22)
        Me.M_Telefone.TabIndex = 6
        Me.M_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'GB_Acoes
        '
        Me.GB_Acoes.BackColor = System.Drawing.Color.Transparent
        Me.GB_Acoes.Controls.Add(Me.BtnNovo)
        Me.GB_Acoes.Controls.Add(Me.BtnLimpar)
        Me.GB_Acoes.Controls.Add(Me.btn_Alterar)
        Me.GB_Acoes.Controls.Add(Me.BtnCadastrar)
        Me.GB_Acoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Acoes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GB_Acoes.Location = New System.Drawing.Point(12, 278)
        Me.GB_Acoes.Name = "GB_Acoes"
        Me.GB_Acoes.Size = New System.Drawing.Size(428, 72)
        Me.GB_Acoes.TabIndex = 150
        Me.GB_Acoes.TabStop = False
        Me.GB_Acoes.Text = "Ações"
        '
        'Nome_Fanta
        '
        Me.Nome_Fanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_Fanta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nome_Fanta.Location = New System.Drawing.Point(158, 19)
        Me.Nome_Fanta.Name = "Nome_Fanta"
        Me.Nome_Fanta.Size = New System.Drawing.Size(127, 22)
        Me.Nome_Fanta.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 16)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "Nome Fantasia*  :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.M_Telefone)
        Me.GroupBox2.Controls.Add(Me.Site_For)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Email)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.M_CNPJ)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Razao_social)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Nome_Fanta)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 214)
        Me.GroupBox2.TabIndex = 156
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Gerais"
        '
        'Site_For
        '
        Me.Site_For.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Site_For.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Site_For.Location = New System.Drawing.Point(158, 103)
        Me.Site_For.Name = "Site_For"
        Me.Site_For.Size = New System.Drawing.Size(143, 22)
        Me.Site_For.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(6, 106)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 162
        Me.Label21.Text = "Site* :"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Email.Location = New System.Drawing.Point(158, 131)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(164, 22)
        Me.Email.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(8, 134)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 16)
        Me.Label22.TabIndex = 160
        Me.Label22.Text = "Email Empresa* :"
        '
        'M_CNPJ
        '
        Me.M_CNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_CNPJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.M_CNPJ.Location = New System.Drawing.Point(158, 75)
        Me.M_CNPJ.Mask = "00,000,000/0000-00"
        Me.M_CNPJ.Name = "M_CNPJ"
        Me.M_CNPJ.Size = New System.Drawing.Size(127, 22)
        Me.M_CNPJ.TabIndex = 3
        Me.M_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(6, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 16)
        Me.Label20.TabIndex = 158
        Me.Label20.Text = "CNPJ* :"
        '
        'Razao_social
        '
        Me.Razao_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Razao_social.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Razao_social.Location = New System.Drawing.Point(158, 47)
        Me.Razao_social.Name = "Razao_social"
        Me.Razao_social.Size = New System.Drawing.Size(127, 22)
        Me.Razao_social.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(6, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 156
        Me.Label19.Text = "Razão Social* :"
        '
        'CB_Cidade
        '
        Me.CB_Cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_Cidade.FormattingEnabled = True
        Me.CB_Cidade.Location = New System.Drawing.Point(110, 179)
        Me.CB_Cidade.Name = "CB_Cidade"
        Me.CB_Cidade.Size = New System.Drawing.Size(121, 24)
        Me.CB_Cidade.TabIndex = 13
        '
        'Endere
        '
        Me.Endere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endere.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Endere.Location = New System.Drawing.Point(110, 13)
        Me.Endere.Name = "Endere"
        Me.Endere.Size = New System.Drawing.Size(199, 22)
        Me.Endere.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(6, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "CEP* :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Bairro* :"
        '
        'Bairro
        '
        Me.Bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bairro.Location = New System.Drawing.Point(110, 121)
        Me.Bairro.Name = "Bairro"
        Me.Bairro.Size = New System.Drawing.Size(143, 22)
        Me.Bairro.TabIndex = 11
        '
        'Numero
        '
        Me.Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Numero.Location = New System.Drawing.Point(110, 39)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(67, 22)
        Me.Numero.TabIndex = 8
        '
        'CB_UF
        '
        Me.CB_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_UF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_UF.FormattingEnabled = True
        Me.CB_UF.Location = New System.Drawing.Point(110, 149)
        Me.CB_UF.Name = "CB_UF"
        Me.CB_UF.Size = New System.Drawing.Size(64, 24)
        Me.CB_UF.TabIndex = 12
        '
        'Comple
        '
        Me.Comple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Comple.Location = New System.Drawing.Point(110, 65)
        Me.Comple.Name = "Comple"
        Me.Comple.Size = New System.Drawing.Size(171, 22)
        Me.Comple.TabIndex = 9
        '
        'M_CEP
        '
        Me.M_CEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_CEP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.M_CEP.Location = New System.Drawing.Point(110, 93)
        Me.M_CEP.Mask = "99999-999"
        Me.M_CEP.Name = "M_CEP"
        Me.M_CEP.Size = New System.Drawing.Size(81, 22)
        Me.M_CEP.TabIndex = 10
        Me.M_CEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Endereço* :"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.CB_Cidade)
        Me.GroupBox5.Controls.Add(Me.Endere)
        Me.GroupBox5.Controls.Add(Me.M_CEP)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.CB_UF)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Bairro)
        Me.GroupBox5.Controls.Add(Me.Numero)
        Me.GroupBox5.Controls.Add(Me.Comple)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox5.Location = New System.Drawing.Point(356, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(319, 216)
        Me.GroupBox5.TabIndex = 157
        Me.GroupBox5.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Cidade* :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Número* :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(6, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "UF* :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 16)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Complemento :"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(208, 237)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 35)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Cadastrar Contato"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Campos Obrigatório ( * )"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(587, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNovo.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNovo.Location = New System.Drawing.Point(6, 24)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(86, 40)
        Me.BtnNovo.TabIndex = 20
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
        Me.BtnLimpar.Location = New System.Drawing.Point(316, 24)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(89, 40)
        Me.BtnLimpar.TabIndex = 18
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'btn_Alterar
        '
        Me.btn_Alterar.Enabled = False
        Me.btn_Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Alterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Alterar.Location = New System.Drawing.Point(215, 24)
        Me.btn_Alterar.Name = "btn_Alterar"
        Me.btn_Alterar.Size = New System.Drawing.Size(95, 40)
        Me.btn_Alterar.TabIndex = 17
        Me.btn_Alterar.Text = "Alterar"
        Me.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Alterar.UseVisualStyleBackColor = True
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Enabled = False
        Me.BtnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCadastrar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCadastrar.Location = New System.Drawing.Point(98, 24)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(111, 40)
        Me.BtnCadastrar.TabIndex = 16
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'Cadastro_Fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 378)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Acoes)
        Me.Controls.Add(Me.Cod_Forn)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastro_Fornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro do Fornecedor"
        Me.GB_Acoes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnCadastrar As System.Windows.Forms.Button
    Friend WithEvents Cod_Forn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GB_Acoes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents Nome_Fanta As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Razao_social As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents M_CNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Site_For As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents M_Telefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CB_Cidade As System.Windows.Forms.ComboBox
    Friend WithEvents Endere As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bairro As System.Windows.Forms.TextBox
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents CB_UF As System.Windows.Forms.ComboBox
    Friend WithEvents Comple As System.Windows.Forms.TextBox
    Friend WithEvents M_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnNovo As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
