<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar_Estoque
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DG_Compra = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_Limpar = New System.Windows.Forms.Button
        Me.Btn_Reativar = New System.Windows.Forms.Button
        Me.Btn_Alterar = New System.Windows.Forms.Button
        Me.Btn_Listar = New System.Windows.Forms.Button
        Me.Btn_Ativar = New System.Windows.Forms.Button
        Me.DG_Estoque = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DT_Produto = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Descricao = New System.Windows.Forms.TextBox
        Me.Cod_Prod = New System.Windows.Forms.TextBox
        CType(Me.DG_Compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DG_Estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DT_Produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Compra
        '
        Me.DG_Compra.AllowUserToAddRows = False
        Me.DG_Compra.AllowUserToDeleteRows = False
        Me.DG_Compra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Compra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Compra.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Compra.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DG_Compra.Location = New System.Drawing.Point(6, 19)
        Me.DG_Compra.Name = "DG_Compra"
        Me.DG_Compra.ReadOnly = True
        Me.DG_Compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Compra.Size = New System.Drawing.Size(770, 187)
        Me.DG_Compra.TabIndex = 0
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 502)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(523, 77)
        Me.GroupBox4.TabIndex = 169
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
        'DG_Estoque
        '
        Me.DG_Estoque.AllowUserToAddRows = False
        Me.DG_Estoque.AllowUserToDeleteRows = False
        Me.DG_Estoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Estoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Estoque.DefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Estoque.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DG_Estoque.Location = New System.Drawing.Point(6, 19)
        Me.DG_Estoque.Name = "DG_Estoque"
        Me.DG_Estoque.ReadOnly = True
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DG_Estoque.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_Estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Estoque.Size = New System.Drawing.Size(372, 187)
        Me.DG_Estoque.TabIndex = 170
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_Estoque)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(410, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 214)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estoque"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DG_Compra)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(784, 216)
        Me.GroupBox3.TabIndex = 174
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compras"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DT_Produto)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(392, 216)
        Me.GroupBox5.TabIndex = 175
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Produto"
        '
        'DT_Produto
        '
        Me.DT_Produto.AllowUserToAddRows = False
        Me.DT_Produto.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DT_Produto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DT_Produto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DT_Produto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DT_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DT_Produto.DefaultCellStyle = DataGridViewCellStyle8
        Me.DT_Produto.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DT_Produto.Location = New System.Drawing.Point(6, 21)
        Me.DT_Produto.Name = "DT_Produto"
        Me.DT_Produto.ReadOnly = True
        Me.DT_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DT_Produto.Size = New System.Drawing.Size(372, 187)
        Me.DT_Produto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Descrição"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(195, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Código do Produto"
        '
        'Descricao
        '
        Me.Descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Descricao.Location = New System.Drawing.Point(86, 22)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(100, 23)
        Me.Descricao.TabIndex = 178
        '
        'Cod_Prod
        '
        Me.Cod_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cod_Prod.Location = New System.Drawing.Point(327, 22)
        Me.Cod_Prod.Name = "Cod_Prod"
        Me.Cod_Prod.Size = New System.Drawing.Size(100, 23)
        Me.Cod_Prod.TabIndex = 179
        '
        'Listar_Estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(811, 595)
        Me.Controls.Add(Me.Cod_Prod)
        Me.Controls.Add(Me.Descricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Listar_Estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        CType(Me.DG_Compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DG_Estoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DT_Produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_Compra As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Limpar As System.Windows.Forms.Button
    Friend WithEvents Btn_Reativar As System.Windows.Forms.Button
    Friend WithEvents Btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents Btn_Listar As System.Windows.Forms.Button
    Friend WithEvents Btn_Ativar As System.Windows.Forms.Button
    Friend WithEvents DG_Estoque As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_Produto As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Descricao As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Prod As System.Windows.Forms.TextBox
End Class
