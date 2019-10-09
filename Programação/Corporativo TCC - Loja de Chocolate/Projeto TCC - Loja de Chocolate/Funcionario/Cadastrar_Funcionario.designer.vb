<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastrar_Funcionario
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
        Me.CB_UF = New System.Windows.Forms.ComboBox
        Me.TxtBairro = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RBtnsup = New System.Windows.Forms.RadioButton
        Me.Rbtntec = New System.Windows.Forms.RadioButton
        Me.RBtnFund = New System.Windows.Forms.RadioButton
        Me.Rbtnmedio = New System.Windows.Forms.RadioButton
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtComp = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.txtender = New System.Windows.Forms.TextBox
        Me.Nome = New System.Windows.Forms.TextBox
        Me.Cod_Fun = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cadastrar_Senha = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.MtxtCPF = New System.Windows.Forms.MaskedTextBox
        Me.CB_Cidade = New System.Windows.Forms.ComboBox
        Me.MtxtTelefone = New System.Windows.Forms.MaskedTextBox
        Me.MtxtCEP = New System.Windows.Forms.MaskedTextBox
        Me.MtxtRG = New System.Windows.Forms.MaskedTextBox
        Me.GB_Acoes = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RB_Casado = New System.Windows.Forms.RadioButton
        Me.RB_Divor = New System.Windows.Forms.RadioButton
        Me.RB_Viuvo = New System.Windows.Forms.RadioButton
        Me.RB_Solt = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_Feminino = New System.Windows.Forms.RadioButton
        Me.RB_Masculino = New System.Windows.Forms.RadioButton
        Me.CB_Departamento = New System.Windows.Forms.ComboBox
        Me.DTP_Funcionario = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.RB_Tarde = New System.Windows.Forms.RadioButton
        Me.RB_Manha = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnNovo = New System.Windows.Forms.Button
        Me.Limpar = New System.Windows.Forms.Button
        Me.Alterar = New System.Windows.Forms.Button
        Me.Cadastrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GB_Acoes.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_UF
        '
        Me.CB_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_UF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_UF.FormattingEnabled = True
        Me.CB_UF.Location = New System.Drawing.Point(414, 13)
        Me.CB_UF.Name = "CB_UF"
        Me.CB_UF.Size = New System.Drawing.Size(64, 24)
        Me.CB_UF.TabIndex = 11
        '
        'TxtBairro
        '
        Me.TxtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtBairro.Location = New System.Drawing.Point(125, 125)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(143, 22)
        Me.TxtBairro.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RBtnsup)
        Me.GroupBox1.Controls.Add(Me.Rbtntec)
        Me.GroupBox1.Controls.Add(Me.RBtnFund)
        Me.GroupBox1.Controls.Add(Me.Rbtnmedio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(11, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 120)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escolaridade *"
        '
        'RBtnsup
        '
        Me.RBtnsup.AutoSize = True
        Me.RBtnsup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnsup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBtnsup.Location = New System.Drawing.Point(8, 90)
        Me.RBtnsup.Name = "RBtnsup"
        Me.RBtnsup.Size = New System.Drawing.Size(121, 20)
        Me.RBtnsup.TabIndex = 7
        Me.RBtnsup.TabStop = True
        Me.RBtnsup.Text = "Ensino Superior"
        Me.RBtnsup.UseVisualStyleBackColor = True
        '
        'Rbtntec
        '
        Me.Rbtntec.AutoSize = True
        Me.Rbtntec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtntec.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbtntec.Location = New System.Drawing.Point(8, 67)
        Me.Rbtntec.Name = "Rbtntec"
        Me.Rbtntec.Size = New System.Drawing.Size(160, 20)
        Me.Rbtntec.TabIndex = 6
        Me.Rbtntec.TabStop = True
        Me.Rbtntec.Text = "Ensino Médio Técnico"
        Me.Rbtntec.UseVisualStyleBackColor = True
        '
        'RBtnFund
        '
        Me.RBtnFund.AutoSize = True
        Me.RBtnFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnFund.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RBtnFund.Location = New System.Drawing.Point(8, 19)
        Me.RBtnFund.Name = "RBtnFund"
        Me.RBtnFund.Size = New System.Drawing.Size(148, 20)
        Me.RBtnFund.TabIndex = 4
        Me.RBtnFund.TabStop = True
        Me.RBtnFund.Text = "Ensino Fundamental"
        Me.RBtnFund.UseVisualStyleBackColor = True
        '
        'Rbtnmedio
        '
        Me.Rbtnmedio.AutoSize = True
        Me.Rbtnmedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtnmedio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rbtnmedio.Location = New System.Drawing.Point(8, 45)
        Me.Rbtnmedio.Name = "Rbtnmedio"
        Me.Rbtnmedio.Size = New System.Drawing.Size(108, 20)
        Me.Rbtnmedio.TabIndex = 5
        Me.Rbtnmedio.TabStop = True
        Me.Rbtnmedio.Text = "Ensino Médio"
        Me.Rbtnmedio.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtemail.Location = New System.Drawing.Point(414, 128)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(160, 22)
        Me.txtemail.TabIndex = 15
        '
        'txtComp
        '
        Me.txtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtComp.Location = New System.Drawing.Point(125, 69)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(196, 22)
        Me.txtComp.TabIndex = 8
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNumero.Location = New System.Drawing.Point(125, 41)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(67, 22)
        Me.txtNumero.TabIndex = 7
        '
        'txtender
        '
        Me.txtender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtender.Location = New System.Drawing.Point(125, 13)
        Me.txtender.Name = "txtender"
        Me.txtender.Size = New System.Drawing.Size(199, 22)
        Me.txtender.TabIndex = 6
        '
        'Nome
        '
        Me.Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nome.Location = New System.Drawing.Point(173, 65)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(265, 22)
        Me.Nome.TabIndex = 3
        '
        'Cod_Fun
        '
        Me.Cod_Fun.Enabled = False
        Me.Cod_Fun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_Fun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cod_Fun.Location = New System.Drawing.Point(173, 37)
        Me.Cod_Fun.Name = "Cod_Fun"
        Me.Cod_Fun.Size = New System.Drawing.Size(47, 22)
        Me.Cod_Fun.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(343, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Email * :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(343, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "CPF * :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(343, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 16)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "RG * :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(343, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "UF * :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(343, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Cidade * :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(16, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Bairro * :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(16, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "CEP * :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(16, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 16)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Complemento :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(16, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Número * :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(16, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Endereço * :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nome * :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Código do Funcionário :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(340, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Telefone * :"
        '
        'Cadastrar_Senha
        '
        Me.Cadastrar_Senha.Enabled = False
        Me.Cadastrar_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastrar_Senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cadastrar_Senha.Location = New System.Drawing.Point(312, 232)
        Me.Cadastrar_Senha.Name = "Cadastrar_Senha"
        Me.Cadastrar_Senha.Size = New System.Drawing.Size(165, 35)
        Me.Cadastrar_Senha.TabIndex = 5
        Me.Cadastrar_Senha.Text = "Cadastrar uma Senha"
        Me.Cadastrar_Senha.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.MtxtCPF)
        Me.GroupBox5.Controls.Add(Me.CB_Cidade)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.MtxtTelefone)
        Me.GroupBox5.Controls.Add(Me.txtender)
        Me.GroupBox5.Controls.Add(Me.MtxtCEP)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.MtxtRG)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.CB_UF)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TxtBairro)
        Me.GroupBox5.Controls.Add(Me.txtNumero)
        Me.GroupBox5.Controls.Add(Me.txtComp)
        Me.GroupBox5.Controls.Add(Me.txtemail)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(592, 190)
        Me.GroupBox5.TabIndex = 117
        Me.GroupBox5.TabStop = False
        '
        'MtxtCPF
        '
        Me.MtxtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MtxtCPF.Location = New System.Drawing.Point(414, 100)
        Me.MtxtCPF.Mask = "999,999,999-99"
        Me.MtxtCPF.Name = "MtxtCPF"
        Me.MtxtCPF.Size = New System.Drawing.Size(100, 22)
        Me.MtxtCPF.TabIndex = 14
        Me.MtxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'CB_Cidade
        '
        Me.CB_Cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_Cidade.FormattingEnabled = True
        Me.CB_Cidade.Location = New System.Drawing.Point(414, 44)
        Me.CB_Cidade.Name = "CB_Cidade"
        Me.CB_Cidade.Size = New System.Drawing.Size(160, 24)
        Me.CB_Cidade.TabIndex = 12
        '
        'MtxtTelefone
        '
        Me.MtxtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MtxtTelefone.Location = New System.Drawing.Point(414, 156)
        Me.MtxtTelefone.Mask = " (99)9999-9999"
        Me.MtxtTelefone.Name = "MtxtTelefone"
        Me.MtxtTelefone.Size = New System.Drawing.Size(100, 22)
        Me.MtxtTelefone.TabIndex = 16
        Me.MtxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'MtxtCEP
        '
        Me.MtxtCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtCEP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MtxtCEP.Location = New System.Drawing.Point(125, 97)
        Me.MtxtCEP.Mask = "99999-999"
        Me.MtxtCEP.Name = "MtxtCEP"
        Me.MtxtCEP.Size = New System.Drawing.Size(76, 22)
        Me.MtxtCEP.TabIndex = 9
        Me.MtxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'MtxtRG
        '
        Me.MtxtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtRG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MtxtRG.Location = New System.Drawing.Point(414, 72)
        Me.MtxtRG.Mask = "99,999,999-9"
        Me.MtxtRG.Name = "MtxtRG"
        Me.MtxtRG.Size = New System.Drawing.Size(100, 22)
        Me.MtxtRG.TabIndex = 13
        Me.MtxtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'GB_Acoes
        '
        Me.GB_Acoes.BackColor = System.Drawing.Color.Transparent
        Me.GB_Acoes.Controls.Add(Me.btnNovo)
        Me.GB_Acoes.Controls.Add(Me.Limpar)
        Me.GB_Acoes.Controls.Add(Me.Alterar)
        Me.GB_Acoes.Controls.Add(Me.Cadastrar)
        Me.GB_Acoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Acoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GB_Acoes.Location = New System.Drawing.Point(11, 469)
        Me.GB_Acoes.Name = "GB_Acoes"
        Me.GB_Acoes.Size = New System.Drawing.Size(419, 65)
        Me.GB_Acoes.TabIndex = 118
        Me.GB_Acoes.TabStop = False
        Me.GB_Acoes.Text = "Ações"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(6, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Nome do Departamento * :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(339, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Data de Nascimento *"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 558)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(617, 22)
        Me.StatusStrip1.TabIndex = 120
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RB_Casado)
        Me.GroupBox3.Controls.Add(Me.RB_Divor)
        Me.GroupBox3.Controls.Add(Me.RB_Viuvo)
        Me.GroupBox3.Controls.Add(Me.RB_Solt)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(191, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(114, 120)
        Me.GroupBox3.TabIndex = 158
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado Civil *"
        '
        'RB_Casado
        '
        Me.RB_Casado.AutoSize = True
        Me.RB_Casado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Casado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Casado.Location = New System.Drawing.Point(7, 90)
        Me.RB_Casado.Name = "RB_Casado"
        Me.RB_Casado.Size = New System.Drawing.Size(90, 20)
        Me.RB_Casado.TabIndex = 11
        Me.RB_Casado.TabStop = True
        Me.RB_Casado.Text = "Casado(a)"
        Me.RB_Casado.UseVisualStyleBackColor = True
        '
        'RB_Divor
        '
        Me.RB_Divor.AutoSize = True
        Me.RB_Divor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Divor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Divor.Location = New System.Drawing.Point(7, 67)
        Me.RB_Divor.Name = "RB_Divor"
        Me.RB_Divor.Size = New System.Drawing.Size(108, 20)
        Me.RB_Divor.TabIndex = 10
        Me.RB_Divor.TabStop = True
        Me.RB_Divor.Text = "Divorciado(a)"
        Me.RB_Divor.UseVisualStyleBackColor = True
        '
        'RB_Viuvo
        '
        Me.RB_Viuvo.AutoSize = True
        Me.RB_Viuvo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Viuvo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Viuvo.Location = New System.Drawing.Point(7, 45)
        Me.RB_Viuvo.Name = "RB_Viuvo"
        Me.RB_Viuvo.Size = New System.Drawing.Size(76, 20)
        Me.RB_Viuvo.TabIndex = 9
        Me.RB_Viuvo.TabStop = True
        Me.RB_Viuvo.Text = "Viúvo(a)"
        Me.RB_Viuvo.UseVisualStyleBackColor = True
        '
        'RB_Solt
        '
        Me.RB_Solt.AutoSize = True
        Me.RB_Solt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Solt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Solt.Location = New System.Drawing.Point(7, 19)
        Me.RB_Solt.Name = "RB_Solt"
        Me.RB_Solt.Size = New System.Drawing.Size(88, 20)
        Me.RB_Solt.TabIndex = 8
        Me.RB_Solt.TabStop = True
        Me.RB_Solt.Text = "Solteiro(a)"
        Me.RB_Solt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RB_Feminino)
        Me.GroupBox2.Controls.Add(Me.RB_Masculino)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(312, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 81)
        Me.GroupBox2.TabIndex = 157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo *"
        '
        'RB_Feminino
        '
        Me.RB_Feminino.AutoSize = True
        Me.RB_Feminino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Feminino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Feminino.Location = New System.Drawing.Point(9, 46)
        Me.RB_Feminino.Name = "RB_Feminino"
        Me.RB_Feminino.Size = New System.Drawing.Size(81, 20)
        Me.RB_Feminino.TabIndex = 13
        Me.RB_Feminino.TabStop = True
        Me.RB_Feminino.Text = "Feminino"
        Me.RB_Feminino.UseVisualStyleBackColor = True
        '
        'RB_Masculino
        '
        Me.RB_Masculino.AutoSize = True
        Me.RB_Masculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Masculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Masculino.Location = New System.Drawing.Point(9, 21)
        Me.RB_Masculino.Name = "RB_Masculino"
        Me.RB_Masculino.Size = New System.Drawing.Size(87, 20)
        Me.RB_Masculino.TabIndex = 12
        Me.RB_Masculino.TabStop = True
        Me.RB_Masculino.Text = "Masculino"
        Me.RB_Masculino.UseVisualStyleBackColor = True
        '
        'CB_Departamento
        '
        Me.CB_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Departamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_Departamento.FormattingEnabled = True
        Me.CB_Departamento.Location = New System.Drawing.Point(173, 93)
        Me.CB_Departamento.Name = "CB_Departamento"
        Me.CB_Departamento.Size = New System.Drawing.Size(143, 24)
        Me.CB_Departamento.TabIndex = 4
        '
        'DTP_Funcionario
        '
        Me.DTP_Funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Funcionario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Funcionario.Location = New System.Drawing.Point(476, 91)
        Me.DTP_Funcionario.Name = "DTP_Funcionario"
        Me.DTP_Funcionario.Size = New System.Drawing.Size(107, 22)
        Me.DTP_Funcionario.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.DTP_Funcionario)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Cod_Fun)
        Me.GroupBox4.Controls.Add(Me.CB_Departamento)
        Me.GroupBox4.Controls.Add(Me.Nome)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(593, 129)
        Me.GroupBox4.TabIndex = 114
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RB_Tarde)
        Me.GroupBox6.Controls.Add(Me.RB_Manha)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Location = New System.Drawing.Point(311, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(205, 40)
        Me.GroupBox6.TabIndex = 160
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Turno *"
        '
        'RB_Tarde
        '
        Me.RB_Tarde.AutoSize = True
        Me.RB_Tarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Tarde.Location = New System.Drawing.Point(104, 18)
        Me.RB_Tarde.Name = "RB_Tarde"
        Me.RB_Tarde.Size = New System.Drawing.Size(63, 20)
        Me.RB_Tarde.TabIndex = 117
        Me.RB_Tarde.TabStop = True
        Me.RB_Tarde.Text = "Tarde"
        Me.RB_Tarde.UseVisualStyleBackColor = True
        '
        'RB_Manha
        '
        Me.RB_Manha.AutoSize = True
        Me.RB_Manha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Manha.Location = New System.Drawing.Point(16, 17)
        Me.RB_Manha.Name = "RB_Manha"
        Me.RB_Manha.Size = New System.Drawing.Size(67, 20)
        Me.RB_Manha.TabIndex = 116
        Me.RB_Manha.TabStop = True
        Me.RB_Manha.Text = "Manhã"
        Me.RB_Manha.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 537)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 15)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Campos Obrigatórios ( * )"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(517, 508)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 160
        Me.PictureBox1.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNovo.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(6, 19)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(82, 40)
        Me.btnNovo.TabIndex = 21
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Limpar
        '
        Me.Limpar.Enabled = False
        Me.Limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Limpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Limpar.Location = New System.Drawing.Point(314, 19)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(92, 40)
        Me.Limpar.TabIndex = 19
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'Alterar
        '
        Me.Alterar.Enabled = False
        Me.Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Alterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Alterar.Location = New System.Drawing.Point(216, 19)
        Me.Alterar.Name = "Alterar"
        Me.Alterar.Size = New System.Drawing.Size(92, 40)
        Me.Alterar.TabIndex = 18
        Me.Alterar.Text = "Alterar"
        Me.Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Alterar.UseVisualStyleBackColor = True
        '
        'Cadastrar
        '
        Me.Cadastrar.Enabled = False
        Me.Cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cadastrar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cadastrar.Location = New System.Drawing.Point(94, 19)
        Me.Cadastrar.Name = "Cadastrar"
        Me.Cadastrar.Size = New System.Drawing.Size(116, 40)
        Me.Cadastrar.TabIndex = 17
        Me.Cadastrar.Text = "Cadastrar"
        Me.Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cadastrar.UseVisualStyleBackColor = True
        '
        'Cadastrar_Funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(617, 580)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GB_Acoes)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Cadastrar_Senha)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastrar_Funcionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Funcionario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GB_Acoes.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_UF As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBairro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtnsup As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtntec As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnFund As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnmedio As System.Windows.Forms.RadioButton
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtComp As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtender As System.Windows.Forms.TextBox
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Fun As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cadastrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cadastrar_Senha As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Acoes As System.Windows.Forms.GroupBox
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents Alterar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MtxtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MtxtRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CB_Cidade As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Casado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Divor As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Viuvo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Solt As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Feminino As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Masculino As System.Windows.Forms.RadioButton
    Friend WithEvents CB_Departamento As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_Funcionario As System.Windows.Forms.DateTimePicker
    Friend WithEvents MtxtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Tarde As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Manha As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
