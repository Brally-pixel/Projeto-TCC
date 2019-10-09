<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastrar_o_Produto
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
        Me.Codigo_Produto = New System.Windows.Forms.TextBox
        Me.Caracteristicas = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.limpar = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Btn_produto = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cod_Barra = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CB_Marca = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnMarca = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Codigo_marca = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Carac_Marca = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo do Produto"
        '
        'Codigo_Produto
        '
        Me.Codigo_Produto.Enabled = False
        Me.Codigo_Produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Produto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Codigo_Produto.Location = New System.Drawing.Point(135, 13)
        Me.Codigo_Produto.Name = "Codigo_Produto"
        Me.Codigo_Produto.Size = New System.Drawing.Size(31, 22)
        Me.Codigo_Produto.TabIndex = 5
        '
        'Caracteristicas
        '
        Me.Caracteristicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caracteristicas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Caracteristicas.Location = New System.Drawing.Point(135, 38)
        Me.Caracteristicas.Name = "Caracteristicas"
        Me.Caracteristicas.Size = New System.Drawing.Size(139, 22)
        Me.Caracteristicas.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(8, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Nome Produto"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.limpar)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 71)
        Me.GroupBox4.TabIndex = 162
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
        '
        'limpar
        '
        Me.limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.limpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.limpar.Location = New System.Drawing.Point(125, 21)
        Me.limpar.Name = "limpar"
        Me.limpar.Size = New System.Drawing.Size(91, 40)
        Me.limpar.TabIndex = 160
        Me.limpar.Text = "Limpar"
        Me.limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.limpar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(11, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 40)
        Me.Button4.TabIndex = 159
        Me.Button4.Text = "Listar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Btn_produto
        '
        Me.Btn_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_produto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_produto.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.Btn_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_produto.Location = New System.Drawing.Point(293, 16)
        Me.Btn_produto.Name = "Btn_produto"
        Me.Btn_produto.Size = New System.Drawing.Size(182, 44)
        Me.Btn_produto.TabIndex = 161
        Me.Btn_produto.Text = "Gerar Novo Produto"
        Me.Btn_produto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_produto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cod_Barra)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CB_Marca)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Codigo_Produto)
        Me.GroupBox1.Controls.Add(Me.Caracteristicas)
        Me.GroupBox1.Controls.Add(Me.Btn_produto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 137)
        Me.GroupBox1.TabIndex = 165
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produto"
        '
        'Cod_Barra
        '
        Me.Cod_Barra.Location = New System.Drawing.Point(135, 96)
        Me.Cod_Barra.Name = "Cod_Barra"
        Me.Cod_Barra.Size = New System.Drawing.Size(157, 22)
        Me.Cod_Barra.TabIndex = 170
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Código de Barra"
        '
        'CB_Marca
        '
        Me.CB_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Marca.FormattingEnabled = True
        Me.CB_Marca.Location = New System.Drawing.Point(135, 66)
        Me.CB_Marca.Name = "CB_Marca"
        Me.CB_Marca.Size = New System.Drawing.Size(121, 24)
        Me.CB_Marca.TabIndex = 166
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(8, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Marca"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnMarca)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Codigo_marca)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Carac_Marca)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 81)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marca"
        '
        'BtnMarca
        '
        Me.BtnMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnMarca.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_add_032x032
        Me.BtnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMarca.Location = New System.Drawing.Point(290, 21)
        Me.BtnMarca.Name = "BtnMarca"
        Me.BtnMarca.Size = New System.Drawing.Size(166, 42)
        Me.BtnMarca.TabIndex = 168
        Me.BtnMarca.Text = "Gerar Nova Marca"
        Me.BtnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMarca.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Codigo da Marca"
        '
        'Codigo_marca
        '
        Me.Codigo_marca.Enabled = False
        Me.Codigo_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_marca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Codigo_marca.Location = New System.Drawing.Point(132, 13)
        Me.Codigo_marca.Name = "Codigo_marca"
        Me.Codigo_marca.Size = New System.Drawing.Size(31, 22)
        Me.Codigo_marca.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(6, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Caracteristica"
        '
        'Carac_Marca
        '
        Me.Carac_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carac_Marca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Carac_Marca.Location = New System.Drawing.Point(132, 41)
        Me.Carac_Marca.Name = "Carac_Marca"
        Me.Carac_Marca.Size = New System.Drawing.Size(139, 22)
        Me.Carac_Marca.TabIndex = 168
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(407, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'Cadastrar_o_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(507, 327)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastrar_o_Produto"
        Me.Text = "Cadastrar  Produto e Marca"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Codigo_Produto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents limpar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Btn_produto As System.Windows.Forms.Button
    Friend WithEvents Caracteristicas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnMarca As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Codigo_marca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Carac_Marca As System.Windows.Forms.TextBox
    Friend WithEvents CB_Marca As System.Windows.Forms.ComboBox
    Friend WithEvents Cod_Barra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
