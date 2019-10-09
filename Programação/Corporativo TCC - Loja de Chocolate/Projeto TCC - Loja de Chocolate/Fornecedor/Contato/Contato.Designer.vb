<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contato
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_Limpar = New System.Windows.Forms.Button
        Me.Btn_Reativar = New System.Windows.Forms.Button
        Me.Btn_Alterar = New System.Windows.Forms.Button
        Me.Btn_Listar = New System.Windows.Forms.Button
        Me.Btn_Ativar = New System.Windows.Forms.Button
        Me.GB_Fornecedor = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Nome = New System.Windows.Forms.TextBox
        Me.Nome_Empresa = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.M_Numero = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_Ativo = New System.Windows.Forms.RadioButton
        Me.RB_Desativo = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GB_Fornecedor.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt1
        '
        Me.dt1.AllowUserToAddRows = False
        Me.dt1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt1.Location = New System.Drawing.Point(12, 124)
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt1.Size = New System.Drawing.Size(627, 202)
        Me.dt1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Btn_Limpar)
        Me.GroupBox4.Controls.Add(Me.Btn_Reativar)
        Me.GroupBox4.Controls.Add(Me.Btn_Alterar)
        Me.GroupBox4.Controls.Add(Me.Btn_Listar)
        Me.GroupBox4.Controls.Add(Me.Btn_Ativar)
        Me.GroupBox4.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 332)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(523, 77)
        Me.GroupBox4.TabIndex = 168
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Limpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpar.Location = New System.Drawing.Point(421, 24)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(92, 40)
        Me.Btn_Limpar.TabIndex = 11
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpar.UseVisualStyleBackColor = True
        '
        'Btn_Reativar
        '
        Me.Btn_Reativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reativar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Reativar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_remove_032x032
        Me.Btn_Reativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Reativar.Location = New System.Drawing.Point(307, 24)
        Me.Btn_Reativar.Name = "Btn_Reativar"
        Me.Btn_Reativar.Size = New System.Drawing.Size(108, 40)
        Me.Btn_Reativar.TabIndex = 13
        Me.Btn_Reativar.Text = "Desativar"
        Me.Btn_Reativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Reativar.UseVisualStyleBackColor = True
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Alterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Alterar.Location = New System.Drawing.Point(98, 24)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.Size = New System.Drawing.Size(91, 40)
        Me.Btn_Alterar.TabIndex = 14
        Me.Btn_Alterar.Text = "Alterar"
        Me.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Alterar.UseVisualStyleBackColor = True
        '
        'Btn_Listar
        '
        Me.Btn_Listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Listar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Listar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Btn_Listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Listar.Location = New System.Drawing.Point(6, 24)
        Me.Btn_Listar.Name = "Btn_Listar"
        Me.Btn_Listar.Size = New System.Drawing.Size(86, 40)
        Me.Btn_Listar.TabIndex = 16
        Me.Btn_Listar.Text = "Listar"
        Me.Btn_Listar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Listar.UseVisualStyleBackColor = True
        '
        'Btn_Ativar
        '
        Me.Btn_Ativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ativar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Ativar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_ok_032x032
        Me.Btn_Ativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ativar.Location = New System.Drawing.Point(195, 24)
        Me.Btn_Ativar.Name = "Btn_Ativar"
        Me.Btn_Ativar.Size = New System.Drawing.Size(106, 40)
        Me.Btn_Ativar.TabIndex = 12
        Me.Btn_Ativar.Text = "Reativar"
        Me.Btn_Ativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Ativar.UseVisualStyleBackColor = True
        '
        'GB_Fornecedor
        '
        Me.GB_Fornecedor.Controls.Add(Me.Label1)
        Me.GB_Fornecedor.Controls.Add(Me.Nome)
        Me.GB_Fornecedor.Controls.Add(Me.Nome_Empresa)
        Me.GB_Fornecedor.Controls.Add(Me.Label2)
        Me.GB_Fornecedor.Controls.Add(Me.Label3)
        Me.GB_Fornecedor.Controls.Add(Me.M_Numero)
        Me.GB_Fornecedor.Location = New System.Drawing.Point(12, 12)
        Me.GB_Fornecedor.Name = "GB_Fornecedor"
        Me.GB_Fornecedor.Size = New System.Drawing.Size(255, 106)
        Me.GB_Fornecedor.TabIndex = 182
        Me.GB_Fornecedor.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Nome"
        '
        'Nome
        '
        Me.Nome.Location = New System.Drawing.Point(116, 16)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(124, 20)
        Me.Nome.TabIndex = 5
        '
        'Nome_Empresa
        '
        Me.Nome_Empresa.Location = New System.Drawing.Point(116, 41)
        Me.Nome_Empresa.Name = "Nome_Empresa"
        Me.Nome_Empresa.Size = New System.Drawing.Size(124, 20)
        Me.Nome_Empresa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Nome Empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Número"
        '
        'M_Numero
        '
        Me.M_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.M_Numero.Location = New System.Drawing.Point(116, 68)
        Me.M_Numero.Mask = "(00)0000-9999"
        Me.M_Numero.Name = "M_Numero"
        Me.M_Numero.Size = New System.Drawing.Size(97, 23)
        Me.M_Numero.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Ativo)
        Me.GroupBox2.Controls.Add(Me.RB_Desativo)
        Me.GroupBox2.Location = New System.Drawing.Point(302, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 72)
        Me.GroupBox2.TabIndex = 186
        Me.GroupBox2.TabStop = False
        '
        'RB_Ativo
        '
        Me.RB_Ativo.AutoSize = True
        Me.RB_Ativo.Checked = True
        Me.RB_Ativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Ativo.Location = New System.Drawing.Point(6, 19)
        Me.RB_Ativo.Name = "RB_Ativo"
        Me.RB_Ativo.Size = New System.Drawing.Size(56, 20)
        Me.RB_Ativo.TabIndex = 3
        Me.RB_Ativo.TabStop = True
        Me.RB_Ativo.Text = "Ativo"
        Me.RB_Ativo.UseVisualStyleBackColor = True
        '
        'RB_Desativo
        '
        Me.RB_Desativo.AutoSize = True
        Me.RB_Desativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Desativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Desativo.Location = New System.Drawing.Point(6, 45)
        Me.RB_Desativo.Name = "RB_Desativo"
        Me.RB_Desativo.Size = New System.Drawing.Size(80, 20)
        Me.RB_Desativo.TabIndex = 4
        Me.RB_Desativo.TabStop = True
        Me.RB_Desativo.Text = "Desativo"
        Me.RB_Desativo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(551, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 187
        Me.PictureBox1.TabStop = False
        '
        'Contato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(645, 432)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Fornecedor)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dt1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contato"
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GB_Fornecedor.ResumeLayout(False)
        Me.GB_Fornecedor.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Limpar As System.Windows.Forms.Button
    Friend WithEvents Btn_Reativar As System.Windows.Forms.Button
    Friend WithEvents Btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents Btn_Listar As System.Windows.Forms.Button
    Friend WithEvents Btn_Ativar As System.Windows.Forms.Button
    Friend WithEvents GB_Fornecedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Nome_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents M_Numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Ativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Desativo As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
