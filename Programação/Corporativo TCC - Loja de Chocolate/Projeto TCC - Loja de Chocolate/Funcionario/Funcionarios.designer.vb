<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionario
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
        Me.dt1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nome = New System.Windows.Forms.TextBox
        Me.CPF = New System.Windows.Forms.TextBox
        Me.RG = New System.Windows.Forms.TextBox
        Me.RB_Ativo = New System.Windows.Forms.RadioButton
        Me.RB_Desativo = New System.Windows.Forms.RadioButton
        Me.RB_Masculino = New System.Windows.Forms.RadioButton
        Me.RB_Feminino = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Departa = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Btn_Alterar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt1
        '
        Me.dt1.AllowUserToAddRows = False
        Me.dt1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt1.Location = New System.Drawing.Point(12, 144)
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt1.Size = New System.Drawing.Size(621, 245)
        Me.dt1.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Btn_Alterar)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 395)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 70)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ações"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(199, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "RG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(199, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Departamento"
        '
        'Nome
        '
        Me.Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.Location = New System.Drawing.Point(63, 6)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(100, 22)
        Me.Nome.TabIndex = 32
        '
        'CPF
        '
        Me.CPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPF.Location = New System.Drawing.Point(63, 34)
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(100, 22)
        Me.CPF.TabIndex = 33
        '
        'RG
        '
        Me.RG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RG.Location = New System.Drawing.Point(313, 6)
        Me.RG.Name = "RG"
        Me.RG.Size = New System.Drawing.Size(100, 22)
        Me.RG.TabIndex = 34
        '
        'RB_Ativo
        '
        Me.RB_Ativo.AutoSize = True
        Me.RB_Ativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Ativo.Location = New System.Drawing.Point(6, 15)
        Me.RB_Ativo.Name = "RB_Ativo"
        Me.RB_Ativo.Size = New System.Drawing.Size(56, 20)
        Me.RB_Ativo.TabIndex = 36
        Me.RB_Ativo.TabStop = True
        Me.RB_Ativo.Text = "Ativo"
        Me.RB_Ativo.UseVisualStyleBackColor = True
        '
        'RB_Desativo
        '
        Me.RB_Desativo.AutoSize = True
        Me.RB_Desativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Desativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Desativo.Location = New System.Drawing.Point(6, 38)
        Me.RB_Desativo.Name = "RB_Desativo"
        Me.RB_Desativo.Size = New System.Drawing.Size(80, 20)
        Me.RB_Desativo.TabIndex = 37
        Me.RB_Desativo.TabStop = True
        Me.RB_Desativo.Text = "Desativo"
        Me.RB_Desativo.UseVisualStyleBackColor = True
        '
        'RB_Masculino
        '
        Me.RB_Masculino.AutoSize = True
        Me.RB_Masculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Masculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Masculino.Location = New System.Drawing.Point(6, 15)
        Me.RB_Masculino.Name = "RB_Masculino"
        Me.RB_Masculino.Size = New System.Drawing.Size(87, 20)
        Me.RB_Masculino.TabIndex = 38
        Me.RB_Masculino.TabStop = True
        Me.RB_Masculino.Text = "Masculino"
        Me.RB_Masculino.UseVisualStyleBackColor = True
        '
        'RB_Feminino
        '
        Me.RB_Feminino.AutoSize = True
        Me.RB_Feminino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Feminino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Feminino.Location = New System.Drawing.Point(6, 38)
        Me.RB_Feminino.Name = "RB_Feminino"
        Me.RB_Feminino.Size = New System.Drawing.Size(81, 20)
        Me.RB_Feminino.TabIndex = 39
        Me.RB_Feminino.TabStop = True
        Me.RB_Feminino.Text = "Feminino"
        Me.RB_Feminino.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Masculino)
        Me.GroupBox2.Controls.Add(Me.RB_Feminino)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(122, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 68)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Ativo)
        Me.GroupBox3.Controls.Add(Me.RB_Desativo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 65)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'Departa
        '
        Me.Departa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departa.Location = New System.Drawing.Point(313, 34)
        Me.Departa.Name = "Departa"
        Me.Departa.Size = New System.Drawing.Size(100, 22)
        Me.Departa.TabIndex = 43
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(545, 421)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(413, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 40)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Limpar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 40)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Listar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_ok_032x032
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(187, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Reativar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Alterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Alterar.Location = New System.Drawing.Point(95, 21)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.Size = New System.Drawing.Size(86, 40)
        Me.Btn_Alterar.TabIndex = 5
        Me.Btn_Alterar.Text = "Alterar"
        Me.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Alterar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_remove_032x032
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(295, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Desativar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 476)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Departa)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RG)
        Me.Controls.Add(Me.CPF)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Funcionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionario"
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents CPF As System.Windows.Forms.TextBox
    Friend WithEvents RG As System.Windows.Forms.TextBox
    Friend WithEvents RB_Ativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Desativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Masculino As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Feminino As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Departa As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
