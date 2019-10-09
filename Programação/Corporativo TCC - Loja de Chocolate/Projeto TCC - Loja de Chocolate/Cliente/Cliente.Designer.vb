<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dt1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Limpar = New System.Windows.Forms.Button
        Me.Btn_Alterar = New System.Windows.Forms.Button
        Me.Reativar = New System.Windows.Forms.Button
        Me.Desativar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNome_list = New System.Windows.Forms.TextBox
        Me.Cod_List = New System.Windows.Forms.TextBox
        Me.M_TxtCPFlist = New System.Windows.Forms.MaskedTextBox
        Me.RB_Ativo = New System.Windows.Forms.RadioButton
        Me.RB_Desativo = New System.Windows.Forms.RadioButton
        Me.RB_Feminino = New System.Windows.Forms.RadioButton
        Me.RB_Masculino = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
        Me.dt1.AllowUserToDeleteRows = False
        Me.dt1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dt1.DefaultCellStyle = DataGridViewCellStyle4
        Me.dt1.Location = New System.Drawing.Point(12, 126)
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt1.Size = New System.Drawing.Size(619, 270)
        Me.dt1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Limpar)
        Me.GroupBox1.Controls.Add(Me.Btn_Alterar)
        Me.GroupBox1.Controls.Add(Me.Reativar)
        Me.GroupBox1.Controls.Add(Me.Desativar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(19, 402)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ações"
        '
        'Limpar
        '
        Me.Limpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Limpar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_cancel_032x032
        Me.Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Limpar.Location = New System.Drawing.Point(416, 24)
        Me.Limpar.Name = "Limpar"
        Me.Limpar.Size = New System.Drawing.Size(91, 40)
        Me.Limpar.TabIndex = 5
        Me.Limpar.Text = "Limpar"
        Me.Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Limpar.UseVisualStyleBackColor = True
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Alterar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_reload_032x032
        Me.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Alterar.Location = New System.Drawing.Point(95, 24)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.Size = New System.Drawing.Size(92, 40)
        Me.Btn_Alterar.TabIndex = 3
        Me.Btn_Alterar.Text = "Alterar"
        Me.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Alterar.UseVisualStyleBackColor = True
        '
        'Reativar
        '
        Me.Reativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reativar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Reativar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_ok_032x032
        Me.Reativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reativar.Location = New System.Drawing.Point(193, 24)
        Me.Reativar.Name = "Reativar"
        Me.Reativar.Size = New System.Drawing.Size(100, 40)
        Me.Reativar.TabIndex = 2
        Me.Reativar.Text = "Reativar"
        Me.Reativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Reativar.UseVisualStyleBackColor = True
        '
        'Desativar
        '
        Me.Desativar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desativar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Desativar.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_remove_032x032
        Me.Desativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Desativar.Location = New System.Drawing.Point(299, 24)
        Me.Desativar.Name = "Desativar"
        Me.Desativar.Size = New System.Drawing.Size(111, 40)
        Me.Desativar.TabIndex = 1
        Me.Desativar.Text = "Desativar"
        Me.Desativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Desativar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.icontexto_webdev_search_032x032
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Listar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(377, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(226, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CPF :"
        '
        'TxtNome_list
        '
        Me.TxtNome_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtNome_list.Location = New System.Drawing.Point(62, 18)
        Me.TxtNome_list.Name = "TxtNome_list"
        Me.TxtNome_list.Size = New System.Drawing.Size(158, 23)
        Me.TxtNome_list.TabIndex = 6
        '
        'Cod_List
        '
        Me.Cod_List.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cod_List.Location = New System.Drawing.Point(435, 18)
        Me.Cod_List.Name = "Cod_List"
        Me.Cod_List.Size = New System.Drawing.Size(45, 23)
        Me.Cod_List.TabIndex = 8
        '
        'M_TxtCPFlist
        '
        Me.M_TxtCPFlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.M_TxtCPFlist.Location = New System.Drawing.Point(266, 18)
        Me.M_TxtCPFlist.Mask = "999,999,999,99"
        Me.M_TxtCPFlist.Name = "M_TxtCPFlist"
        Me.M_TxtCPFlist.Size = New System.Drawing.Size(100, 23)
        Me.M_TxtCPFlist.TabIndex = 9
        Me.M_TxtCPFlist.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'RB_Ativo
        '
        Me.RB_Ativo.AutoSize = True
        Me.RB_Ativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RB_Ativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Ativo.Location = New System.Drawing.Point(6, 12)
        Me.RB_Ativo.Name = "RB_Ativo"
        Me.RB_Ativo.Size = New System.Drawing.Size(57, 21)
        Me.RB_Ativo.TabIndex = 12
        Me.RB_Ativo.Text = "Ativo"
        Me.RB_Ativo.UseVisualStyleBackColor = True
        '
        'RB_Desativo
        '
        Me.RB_Desativo.AutoSize = True
        Me.RB_Desativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RB_Desativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Desativo.Location = New System.Drawing.Point(6, 35)
        Me.RB_Desativo.Name = "RB_Desativo"
        Me.RB_Desativo.Size = New System.Drawing.Size(89, 21)
        Me.RB_Desativo.TabIndex = 13
        Me.RB_Desativo.Text = "Destivado"
        Me.RB_Desativo.UseVisualStyleBackColor = True
        '
        'RB_Feminino
        '
        Me.RB_Feminino.AutoSize = True
        Me.RB_Feminino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RB_Feminino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Feminino.Location = New System.Drawing.Point(6, 10)
        Me.RB_Feminino.Name = "RB_Feminino"
        Me.RB_Feminino.Size = New System.Drawing.Size(83, 21)
        Me.RB_Feminino.TabIndex = 14
        Me.RB_Feminino.Text = "Feminino"
        Me.RB_Feminino.UseVisualStyleBackColor = True
        '
        'RB_Masculino
        '
        Me.RB_Masculino.AutoSize = True
        Me.RB_Masculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RB_Masculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RB_Masculino.Location = New System.Drawing.Point(6, 37)
        Me.RB_Masculino.Name = "RB_Masculino"
        Me.RB_Masculino.Size = New System.Drawing.Size(89, 21)
        Me.RB_Masculino.TabIndex = 15
        Me.RB_Masculino.Text = "Masculino"
        Me.RB_Masculino.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_Feminino)
        Me.GroupBox2.Controls.Add(Me.RB_Masculino)
        Me.GroupBox2.Location = New System.Drawing.Point(131, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 71)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Ativo)
        Me.GroupBox3.Controls.Add(Me.RB_Desativo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 71)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.logoooooooo2
        Me.PictureBox1.Location = New System.Drawing.Point(543, 431)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(644, 490)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.M_TxtCPFlist)
        Me.Controls.Add(Me.Cod_List)
        Me.Controls.Add(Me.TxtNome_list)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
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
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents Reativar As System.Windows.Forms.Button
    Friend WithEvents Desativar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNome_list As System.Windows.Forms.TextBox
    Friend WithEvents Cod_List As System.Windows.Forms.TextBox
    Friend WithEvents M_TxtCPFlist As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RB_Ativo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Desativo As System.Windows.Forms.RadioButton
    Friend WithEvents Limpar As System.Windows.Forms.Button
    Friend WithEvents RB_Feminino As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Masculino As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
