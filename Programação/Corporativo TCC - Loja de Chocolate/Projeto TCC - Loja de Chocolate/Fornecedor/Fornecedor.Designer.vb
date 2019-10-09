<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedor
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dt1 = New System.Windows.Forms.DataGridView
        Me.TxtNome = New System.Windows.Forms.TextBox
        Me.txtRazao = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.M_CNPJ = New System.Windows.Forms.MaskedTextBox
        Me.GB_Fornecedor = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RB_Ativo = New System.Windows.Forms.RadioButton
        Me.RB_Desativo = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Fornecedor.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 77)
        Me.GroupBox4.TabIndex = 167
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
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
        Me.dt1.Size = New System.Drawing.Size(626, 248)
        Me.dt1.TabIndex = 166
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(116, 16)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(124, 20)
        Me.TxtNome.TabIndex = 5
        '
        'txtRazao
        '
        Me.txtRazao.Location = New System.Drawing.Point(116, 41)
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.Size = New System.Drawing.Size(124, 20)
        Me.txtRazao.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Nome Fantasia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Razão Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "CNPJ"
        '
        'M_CNPJ
        '
        Me.M_CNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.M_CNPJ.Location = New System.Drawing.Point(116, 68)
        Me.M_CNPJ.Mask = "00,000,000/0000-00"
        Me.M_CNPJ.Name = "M_CNPJ"
        Me.M_CNPJ.Size = New System.Drawing.Size(124, 23)
        Me.M_CNPJ.TabIndex = 7
        '
        'GB_Fornecedor
        '
        Me.GB_Fornecedor.Controls.Add(Me.Label1)
        Me.GB_Fornecedor.Controls.Add(Me.TxtNome)
        Me.GB_Fornecedor.Controls.Add(Me.txtRazao)
        Me.GB_Fornecedor.Controls.Add(Me.Label2)
        Me.GB_Fornecedor.Controls.Add(Me.Label3)
        Me.GB_Fornecedor.Controls.Add(Me.M_CNPJ)
        Me.GB_Fornecedor.Location = New System.Drawing.Point(132, 12)
        Me.GB_Fornecedor.Name = "GB_Fornecedor"
        Me.GB_Fornecedor.Size = New System.Drawing.Size(255, 106)
        Me.GB_Fornecedor.TabIndex = 181
        Me.GB_Fornecedor.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Ativo)
        Me.GroupBox2.Controls.Add(Me.RB_Desativo)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 72)
        Me.GroupBox2.TabIndex = 185
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
        Me.PictureBox1.Location = New System.Drawing.Point(551, 411)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 186
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(415, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Limpar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_remove_032x032
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(302, 24)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 40)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Desativar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(98, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Alterar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 40)
        Me.Button4.TabIndex = 16
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
        Me.Button3.Location = New System.Drawing.Point(195, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 40)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Reativar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Fornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(651, 467)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Fornecedor)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dt1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fornecedor"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Fornecedor.ResumeLayout(False)
        Me.GB_Fornecedor.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtRazao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents M_CNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GB_Fornecedor As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Ativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Desativo As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
