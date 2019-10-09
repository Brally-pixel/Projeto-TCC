<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produto
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
        Me.Dt1 = New System.Windows.Forms.DataGridView
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Dt2 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Listar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Nome_prod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RB_Desativo_Mar = New System.Windows.Forms.RadioButton
        Me.RB_Ativo_Mar = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cod_Barra = New System.Windows.Forms.TextBox
        Me.RB_Desativo = New System.Windows.Forms.RadioButton
        Me.RB_Ativo = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.Dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dt1
        '
        Me.Dt1.AllowUserToAddRows = False
        Me.Dt1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt1.Location = New System.Drawing.Point(6, 42)
        Me.Dt1.Name = "Dt1"
        Me.Dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dt1.Size = New System.Drawing.Size(712, 183)
        Me.Dt1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_remove_032x032
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(190, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 40)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Limpar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 67)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ações Produtos"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 40)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Listar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(98, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Alterar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dt2
        '
        Me.Dt2.AllowUserToAddRows = False
        Me.Dt2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dt2.Location = New System.Drawing.Point(6, 38)
        Me.Dt2.Name = "Dt2"
        Me.Dt2.ReadOnly = True
        Me.Dt2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dt2.Size = New System.Drawing.Size(559, 187)
        Me.Dt2.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Listar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(571, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 206)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ações Marca"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_remove_032x032
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(6, 65)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 40)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Limpar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Listar
        '
        Me.Listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Listar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Listar.Location = New System.Drawing.Point(6, 19)
        Me.Listar.Name = "Listar"
        Me.Listar.Size = New System.Drawing.Size(86, 40)
        Me.Listar.TabIndex = 2
        Me.Listar.Text = "Listar"
        Me.Listar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Listar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nome do Produto"
        '
        'Nome_prod
        '
        Me.Nome_prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Nome_prod.Location = New System.Drawing.Point(137, 13)
        Me.Nome_prod.Name = "Nome_prod"
        Me.Nome_prod.Size = New System.Drawing.Size(100, 23)
        Me.Nome_prod.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(203, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Marca"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Desativo_Mar)
        Me.GroupBox3.Controls.Add(Me.RB_Ativo_Mar)
        Me.GroupBox3.Controls.Add(Me.Dt2)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(718, 238)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        '
        'RB_Desativo_Mar
        '
        Me.RB_Desativo_Mar.AutoSize = True
        Me.RB_Desativo_Mar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Desativo_Mar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Desativo_Mar.Location = New System.Drawing.Point(93, 12)
        Me.RB_Desativo_Mar.Name = "RB_Desativo_Mar"
        Me.RB_Desativo_Mar.Size = New System.Drawing.Size(80, 20)
        Me.RB_Desativo_Mar.TabIndex = 35
        Me.RB_Desativo_Mar.TabStop = True
        Me.RB_Desativo_Mar.Text = "Desativo"
        Me.RB_Desativo_Mar.UseVisualStyleBackColor = True
        '
        'RB_Ativo_Mar
        '
        Me.RB_Ativo_Mar.AutoSize = True
        Me.RB_Ativo_Mar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ativo_Mar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Ativo_Mar.Location = New System.Drawing.Point(9, 12)
        Me.RB_Ativo_Mar.Name = "RB_Ativo_Mar"
        Me.RB_Ativo_Mar.Size = New System.Drawing.Size(56, 20)
        Me.RB_Ativo_Mar.TabIndex = 34
        Me.RB_Ativo_Mar.TabStop = True
        Me.RB_Ativo_Mar.Text = "Ativo"
        Me.RB_Ativo_Mar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Cod_Barra)
        Me.GroupBox4.Controls.Add(Me.RB_Desativo)
        Me.GroupBox4.Controls.Add(Me.RB_Ativo)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.Dt1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Nome_prod)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(733, 319)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(639, 254)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(243, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Código de Barra"
        '
        'Cod_Barra
        '
        Me.Cod_Barra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cod_Barra.Location = New System.Drawing.Point(368, 13)
        Me.Cod_Barra.Name = "Cod_Barra"
        Me.Cod_Barra.Size = New System.Drawing.Size(162, 23)
        Me.Cod_Barra.TabIndex = 35
        '
        'RB_Desativo
        '
        Me.RB_Desativo.AutoSize = True
        Me.RB_Desativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Desativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Desativo.Location = New System.Drawing.Point(639, 16)
        Me.RB_Desativo.Name = "RB_Desativo"
        Me.RB_Desativo.Size = New System.Drawing.Size(80, 20)
        Me.RB_Desativo.TabIndex = 33
        Me.RB_Desativo.TabStop = True
        Me.RB_Desativo.Text = "Desativo"
        Me.RB_Desativo.UseVisualStyleBackColor = True
        '
        'RB_Ativo
        '
        Me.RB_Ativo.AutoSize = True
        Me.RB_Ativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Ativo.Location = New System.Drawing.Point(555, 16)
        Me.RB_Ativo.Name = "RB_Ativo"
        Me.RB_Ativo.Size = New System.Drawing.Size(56, 20)
        Me.RB_Ativo.TabIndex = 32
        Me.RB_Ativo.TabStop = True
        Me.RB_Ativo.Text = "Ativo"
        Me.RB_Ativo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(203, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Produto"
        '
        'Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(757, 630)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Produto"
        Me.Text = "Produto/Marca"
        CType(Me.Dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Dt2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Listar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nome_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RB_Desativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Ativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Desativo_Mar As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Ativo_Mar As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cod_Barra As System.Windows.Forms.TextBox
End Class
