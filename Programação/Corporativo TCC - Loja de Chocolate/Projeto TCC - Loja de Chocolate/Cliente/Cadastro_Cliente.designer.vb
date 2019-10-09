<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Cliente
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_Cliente))
        Me.Label4 = New System.Windows.Forms.Label
        Me.UF = New System.Windows.Forms.ComboBox
        Me.Bairro = New System.Windows.Forms.TextBox
        Me.EMAIL = New System.Windows.Forms.TextBox
        Me.Complemento = New System.Windows.Forms.TextBox
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Endereco = New System.Windows.Forms.TextBox
        Me.Nome_Cliente = New System.Windows.Forms.TextBox
        Me.Cod_Cliente = New System.Windows.Forms.TextBox
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CB_Cidade = New System.Windows.Forms.ComboBox
        Me.CEP = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_Feminino = New System.Windows.Forms.RadioButton
        Me.RB_Masculino = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RB_Casado = New System.Windows.Forms.RadioButton
        Me.RB_Divor = New System.Windows.Forms.RadioButton
        Me.RB_Viuvo = New System.Windows.Forms.RadioButton
        Me.RB_Solt = New System.Windows.Forms.RadioButton
        Me.Telefone = New System.Windows.Forms.MaskedTextBox
        Me.CPF = New System.Windows.Forms.MaskedTextBox
        Me.GB_Acoes = New System.Windows.Forms.GroupBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.DTP_Cliente = New System.Windows.Forms.DateTimePicker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnNovo = New System.Windows.Forms.Button
        Me.Cadastrar_Cli = New System.Windows.Forms.Button
        Me.Alterar_Cli = New System.Windows.Forms.Button
        Me.BtnLimpar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GB_Acoes.SuspendLayout()
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
        Me.Label4.Location = New System.Drawing.Point(306, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Telefone :"
        '
        'UF
        '
        Me.UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UF.FormattingEnabled = True
        Me.UF.Location = New System.Drawing.Point(108, 153)
        Me.UF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.UF.Name = "UF"
        Me.UF.Size = New System.Drawing.Size(60, 24)
        Me.UF.TabIndex = 10
        '
        'Bairro
        '
        Me.Bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bairro.Location = New System.Drawing.Point(108, 128)
        Me.Bairro.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Bairro.Name = "Bairro"
        Me.Bairro.Size = New System.Drawing.Size(123, 22)
        Me.Bairro.TabIndex = 9
        '
        'EMAIL
        '
        Me.EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAIL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EMAIL.Location = New System.Drawing.Point(382, 44)
        Me.EMAIL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(152, 22)
        Me.EMAIL.TabIndex = 4
        '
        'Complemento
        '
        Me.Complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Complemento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Complemento.Location = New System.Drawing.Point(108, 72)
        Me.Complemento.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Complemento.Name = "Complemento"
        Me.Complemento.Size = New System.Drawing.Size(122, 22)
        Me.Complemento.TabIndex = 7
        '
        'Numero
        '
        Me.Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Numero.Location = New System.Drawing.Point(108, 44)
        Me.Numero.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(66, 22)
        Me.Numero.TabIndex = 6
        '
        'Endereco
        '
        Me.Endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Endereco.Location = New System.Drawing.Point(108, 17)
        Me.Endereco.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Endereco.Name = "Endereco"
        Me.Endereco.Size = New System.Drawing.Size(126, 22)
        Me.Endereco.TabIndex = 5
        '
        'Nome_Cliente
        '
        Me.Nome_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_Cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nome_Cliente.Location = New System.Drawing.Point(68, 13)
        Me.Nome_Cliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Nome_Cliente.Name = "Nome_Cliente"
        Me.Nome_Cliente.Size = New System.Drawing.Size(202, 22)
        Me.Nome_Cliente.TabIndex = 1
        '
        'Cod_Cliente
        '
        Me.Cod_Cliente.Enabled = False
        Me.Cod_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_Cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cod_Cliente.Location = New System.Drawing.Point(472, 303)
        Me.Cod_Cliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Cod_Cliente.Name = "Cod_Cliente"
        Me.Cod_Cliente.Size = New System.Drawing.Size(42, 22)
        Me.Cod_Cliente.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(306, 47)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Email * :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 47)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 16)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "CPF :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(8, 86)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 16)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "Data de Nascimento * :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(8, 156)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "UF* :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(8, 186)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "Cidade* :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(8, 131)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Bairro* :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(8, 103)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "CEP* :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 75)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 16)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Complemento :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 44)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Número* :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Endereço* :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Nome* :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(344, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Código do Cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CB_Cidade)
        Me.GroupBox1.Controls.Add(Me.CEP)
        Me.GroupBox1.Controls.Add(Me.Endereco)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Numero)
        Me.GroupBox1.Controls.Add(Me.Complemento)
        Me.GroupBox1.Controls.Add(Me.Bairro)
        Me.GroupBox1.Controls.Add(Me.UF)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(11, 123)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 216)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        '
        'CB_Cidade
        '
        Me.CB_Cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Cidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CB_Cidade.FormattingEnabled = True
        Me.CB_Cidade.Location = New System.Drawing.Point(108, 183)
        Me.CB_Cidade.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CB_Cidade.Name = "CB_Cidade"
        Me.CB_Cidade.Size = New System.Drawing.Size(187, 24)
        Me.CB_Cidade.TabIndex = 11
        '
        'CEP
        '
        Me.CEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CEP.Location = New System.Drawing.Point(108, 100)
        Me.CEP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CEP.Mask = "99999-999"
        Me.CEP.Name = "CEP"
        Me.CEP.Size = New System.Drawing.Size(71, 22)
        Me.CEP.TabIndex = 8
        Me.CEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RB_Feminino)
        Me.GroupBox2.Controls.Add(Me.RB_Masculino)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(322, 123)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(106, 81)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo *"
        '
        'RB_Feminino
        '
        Me.RB_Feminino.AutoSize = True
        Me.RB_Feminino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Feminino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Feminino.Location = New System.Drawing.Point(6, 42)
        Me.RB_Feminino.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
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
        Me.RB_Masculino.Location = New System.Drawing.Point(6, 20)
        Me.RB_Masculino.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RB_Masculino.Name = "RB_Masculino"
        Me.RB_Masculino.Size = New System.Drawing.Size(87, 20)
        Me.RB_Masculino.TabIndex = 12
        Me.RB_Masculino.TabStop = True
        Me.RB_Masculino.Text = "Masculino"
        Me.RB_Masculino.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(432, 123)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(114, 120)
        Me.GroupBox3.TabIndex = 156
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado Civil *"
        '
        'RB_Casado
        '
        Me.RB_Casado.AutoSize = True
        Me.RB_Casado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Casado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Casado.Location = New System.Drawing.Point(7, 90)
        Me.RB_Casado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RB_Casado.Name = "RB_Casado"
        Me.RB_Casado.Size = New System.Drawing.Size(90, 20)
        Me.RB_Casado.TabIndex = 17
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
        Me.RB_Divor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RB_Divor.Name = "RB_Divor"
        Me.RB_Divor.Size = New System.Drawing.Size(108, 20)
        Me.RB_Divor.TabIndex = 16
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
        Me.RB_Viuvo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RB_Viuvo.Name = "RB_Viuvo"
        Me.RB_Viuvo.Size = New System.Drawing.Size(76, 20)
        Me.RB_Viuvo.TabIndex = 15
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
        Me.RB_Solt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RB_Solt.Name = "RB_Solt"
        Me.RB_Solt.Size = New System.Drawing.Size(88, 20)
        Me.RB_Solt.TabIndex = 14
        Me.RB_Solt.TabStop = True
        Me.RB_Solt.Text = "Solteiro(a)"
        Me.RB_Solt.UseVisualStyleBackColor = True
        '
        'Telefone
        '
        Me.Telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Telefone.Location = New System.Drawing.Point(382, 16)
        Me.Telefone.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Telefone.Mask = "(00) 9999-9999"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Size = New System.Drawing.Size(102, 22)
        Me.Telefone.TabIndex = 2
        Me.Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'CPF
        '
        Me.CPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CPF.Location = New System.Drawing.Point(68, 41)
        Me.CPF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CPF.Mask = "999,999,999,99"
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(100, 22)
        Me.CPF.TabIndex = 3
        Me.CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'GB_Acoes
        '
        Me.GB_Acoes.BackColor = System.Drawing.Color.Transparent
        Me.GB_Acoes.Controls.Add(Me.BtnNovo)
        Me.GB_Acoes.Controls.Add(Me.Cadastrar_Cli)
        Me.GB_Acoes.Controls.Add(Me.Alterar_Cli)
        Me.GB_Acoes.Controls.Add(Me.BtnLimpar)
        Me.GB_Acoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Acoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GB_Acoes.Location = New System.Drawing.Point(11, 345)
        Me.GB_Acoes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GB_Acoes.Name = "GB_Acoes"
        Me.GB_Acoes.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GB_Acoes.Size = New System.Drawing.Size(404, 68)
        Me.GB_Acoes.TabIndex = 161
        Me.GB_Acoes.TabStop = False
        Me.GB_Acoes.Text = "Ações"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 451)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(567, 22)
        Me.StatusStrip1.TabIndex = 162
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DTP_Cliente
        '
        Me.DTP_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Cliente.Location = New System.Drawing.Point(154, 81)
        Me.DTP_Cliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DTP_Cliente.Name = "DTP_Cliente"
        Me.DTP_Cliente.Size = New System.Drawing.Size(103, 22)
        Me.DTP_Cliente.TabIndex = 163
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "LogoTeste.jpg")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.DTP_Cliente)
        Me.GroupBox5.Controls.Add(Me.EMAIL)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Telefone)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Nome_Cliente)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.CPF)
        Me.GroupBox5.Location = New System.Drawing.Point(11, -2)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(542, 119)
        Me.GroupBox5.TabIndex = 164
        Me.GroupBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 424)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Campos Obrigatórios ( * )"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(465, 395)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 166
        Me.PictureBox1.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNovo.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNovo.Location = New System.Drawing.Point(6, 19)
        Me.BtnNovo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(80, 40)
        Me.BtnNovo.TabIndex = 17
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNovo.UseVisualStyleBackColor = False
        '
        'Cadastrar_Cli
        '
        Me.Cadastrar_Cli.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cadastrar_Cli.Enabled = False
        Me.Cadastrar_Cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cadastrar_Cli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Cadastrar_Cli.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_file_032x032
        Me.Cadastrar_Cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cadastrar_Cli.Location = New System.Drawing.Point(89, 19)
        Me.Cadastrar_Cli.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Cadastrar_Cli.Name = "Cadastrar_Cli"
        Me.Cadastrar_Cli.Size = New System.Drawing.Size(108, 40)
        Me.Cadastrar_Cli.TabIndex = 13
        Me.Cadastrar_Cli.Text = "Cadastrar"
        Me.Cadastrar_Cli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cadastrar_Cli.UseVisualStyleBackColor = False
        '
        'Alterar_Cli
        '
        Me.Alterar_Cli.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Alterar_Cli.Enabled = False
        Me.Alterar_Cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alterar_Cli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Alterar_Cli.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Alterar_Cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Alterar_Cli.Location = New System.Drawing.Point(203, 19)
        Me.Alterar_Cli.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Alterar_Cli.Name = "Alterar_Cli"
        Me.Alterar_Cli.Size = New System.Drawing.Size(92, 40)
        Me.Alterar_Cli.TabIndex = 14
        Me.Alterar_Cli.Text = "Alterar"
        Me.Alterar_Cli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Alterar_Cli.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLimpar.Enabled = False
        Me.BtnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpar.Location = New System.Drawing.Point(302, 19)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(91, 40)
        Me.BtnLimpar.TabIndex = 15
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'Cadastro_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 473)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GB_Acoes)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cod_Cliente)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastro_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro do Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GB_Acoes.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cadastrar_Cli As System.Windows.Forms.Button
    Friend WithEvents UF As System.Windows.Forms.ComboBox
    Friend WithEvents Bairro As System.Windows.Forms.TextBox
    Friend WithEvents EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Complemento As System.Windows.Forms.TextBox
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Endereco As System.Windows.Forms.TextBox
    Friend WithEvents Nome_Cliente As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Alterar_Cli As System.Windows.Forms.Button
    Friend WithEvents GB_Acoes As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Telefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents DTP_Cliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents CB_Cidade As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNovo As System.Windows.Forms.Button
    Friend WithEvents RB_Feminino As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Masculino As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Casado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Divor As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Viuvo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Solt As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Protected Friend WithEvents Cod_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
