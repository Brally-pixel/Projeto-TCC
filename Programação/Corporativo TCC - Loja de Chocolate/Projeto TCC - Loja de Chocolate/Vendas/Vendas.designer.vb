<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Quantidade")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Valor Unitário")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sub-Total")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Produto")
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Total = New System.Windows.Forms.Label
        Me.SubTotal = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cod_Barra = New System.Windows.Forms.TextBox
        Me.DGEstoque = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtQtde = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblUnit = New System.Windows.Forms.Label
        Me.CB_Cliente = New System.Windows.Forms.ComboBox
        Me.BtnNovoCli = New System.Windows.Forms.Button
        Me.LstQtde = New System.Windows.Forms.ListView
        Me.LstVlUnit = New System.Windows.Forms.ListView
        Me.LstSTotal = New System.Windows.Forms.ListView
        Me.LstProd = New System.Windows.Forms.ListView
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Sub-Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(10, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Total "
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox8.Location = New System.Drawing.Point(358, -282)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(130, 25)
        Me.TextBox8.TabIndex = 56
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.BackColor = System.Drawing.Color.Transparent
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Total.Location = New System.Drawing.Point(95, 104)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(18, 20)
        Me.Total.TabIndex = 58
        Me.Total.Text = "0"
        '
        'SubTotal
        '
        Me.SubTotal.AutoSize = True
        Me.SubTotal.BackColor = System.Drawing.Color.Transparent
        Me.SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SubTotal.Location = New System.Drawing.Point(95, 60)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(18, 20)
        Me.SubTotal.TabIndex = 59
        Me.SubTotal.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(23, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 16)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "F1 - Pagar a Dinheiro"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(163, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 16)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "F2 - Pagar com cartão de Credito"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(584, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(205, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "F4 - Deixar um Debito com a Loja"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(374, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(204, 16)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "F3 - Pagar com Cartão de Debito"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(798, 43)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Menu"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(14, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 16)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Codigo do Cliente :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(9, 502)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 74)
        Me.GroupBox4.TabIndex = 164
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(6, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 38)
        Me.Button2.TabIndex = 147
        Me.Button2.Text = "Encerar Venda"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(241, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 38)
        Me.Button5.TabIndex = 160
        Me.Button5.Text = "Sair"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(145, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 38)
        Me.Button4.TabIndex = 159
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 586)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(963, 22)
        Me.StatusStrip1.TabIndex = 165
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(14, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Código de Barra :"
        '
        'Cod_Barra
        '
        Me.Cod_Barra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cod_Barra.Location = New System.Drawing.Point(141, 83)
        Me.Cod_Barra.Name = "Cod_Barra"
        Me.Cod_Barra.Size = New System.Drawing.Size(132, 23)
        Me.Cod_Barra.TabIndex = 175
        '
        'DGEstoque
        '
        Me.DGEstoque.AllowUserToAddRows = False
        Me.DGEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGEstoque.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGEstoque.Location = New System.Drawing.Point(12, 112)
        Me.DGEstoque.Name = "DGEstoque"
        Me.DGEstoque.ReadOnly = True
        Me.DGEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGEstoque.Size = New System.Drawing.Size(500, 320)
        Me.DGEstoque.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 455)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Quantidade"
        '
        'txtQtde
        '
        Me.txtQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtde.Location = New System.Drawing.Point(97, 452)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(100, 22)
        Me.txtQtde.TabIndex = 179
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblUnit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SubTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 138)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Preço Unitario"
        '
        'LblUnit
        '
        Me.LblUnit.AutoSize = True
        Me.LblUnit.BackColor = System.Drawing.Color.Transparent
        Me.LblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblUnit.Location = New System.Drawing.Point(109, 17)
        Me.LblUnit.Name = "LblUnit"
        Me.LblUnit.Size = New System.Drawing.Size(18, 20)
        Me.LblUnit.TabIndex = 61
        Me.LblUnit.Text = "0"
        '
        'CB_Cliente
        '
        Me.CB_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_Cliente.FormattingEnabled = True
        Me.CB_Cliente.Location = New System.Drawing.Point(141, 53)
        Me.CB_Cliente.Name = "CB_Cliente"
        Me.CB_Cliente.Size = New System.Drawing.Size(132, 24)
        Me.CB_Cliente.TabIndex = 182
        '
        'BtnNovoCli
        '
        Me.BtnNovoCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNovoCli.Location = New System.Drawing.Point(279, 55)
        Me.BtnNovoCli.Name = "BtnNovoCli"
        Me.BtnNovoCli.Size = New System.Drawing.Size(74, 23)
        Me.BtnNovoCli.TabIndex = 183
        Me.BtnNovoCli.Text = "Novo"
        Me.BtnNovoCli.UseVisualStyleBackColor = True
        '
        'LstQtde
        '
        Me.LstQtde.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LstQtde.Location = New System.Drawing.Point(680, 112)
        Me.LstQtde.Name = "LstQtde"
        Me.LstQtde.Size = New System.Drawing.Size(102, 320)
        Me.LstQtde.TabIndex = 184
        Me.LstQtde.UseCompatibleStateImageBehavior = False
        '
        'LstVlUnit
        '
        Me.LstVlUnit.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.LstVlUnit.Location = New System.Drawing.Point(781, 112)
        Me.LstVlUnit.Name = "LstVlUnit"
        Me.LstVlUnit.Size = New System.Drawing.Size(90, 320)
        Me.LstVlUnit.TabIndex = 185
        Me.LstVlUnit.UseCompatibleStateImageBehavior = False
        '
        'LstSTotal
        '
        Me.LstSTotal.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.LstSTotal.Location = New System.Drawing.Point(870, 112)
        Me.LstSTotal.Name = "LstSTotal"
        Me.LstSTotal.Size = New System.Drawing.Size(90, 320)
        Me.LstSTotal.TabIndex = 186
        Me.LstSTotal.UseCompatibleStateImageBehavior = False
        '
        'LstProd
        '
        Me.LstProd.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4})
        Me.LstProd.Location = New System.Drawing.Point(531, 112)
        Me.LstProd.Name = "LstProd"
        Me.LstProd.Size = New System.Drawing.Size(151, 320)
        Me.LstProd.TabIndex = 187
        Me.LstProd.UseCompatibleStateImageBehavior = False
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(963, 608)
        Me.Controls.Add(Me.LstProd)
        Me.Controls.Add(Me.LstSTotal)
        Me.Controls.Add(Me.LstVlUnit)
        Me.Controls.Add(Me.LstQtde)
        Me.Controls.Add(Me.BtnNovoCli)
        Me.Controls.Add(Me.CB_Cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGEstoque)
        Me.Controls.Add(Me.Cod_Barra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBox8)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vendas"
        Me.Text = "Vendas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents SubTotal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CodProd As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cod_Barra As System.Windows.Forms.TextBox
    Friend WithEvents DGEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblUnit As System.Windows.Forms.Label
    Friend WithEvents CB_Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNovoCli As System.Windows.Forms.Button

    Private Sub BtnNovoCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNovoCli.Click
        Cadastro_Cliente.Show()

    End Sub
    Friend WithEvents LstQtde As System.Windows.Forms.ListView
    Friend WithEvents LstVlUnit As System.Windows.Forms.ListView
    Friend WithEvents LstSTotal As System.Windows.Forms.ListView
    Friend WithEvents LstProd As System.Windows.Forms.ListView
End Class
