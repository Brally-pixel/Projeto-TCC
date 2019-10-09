<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterarOCadastroDoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CadastroDoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContasAPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerificarEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelecionarOProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Nome_Funcio = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ContasAPagarToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(548, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarOCadastroDoClienteToolStripMenuItem, Me.CadastroDoClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "&Cliente"
        '
        'AlterarOCadastroDoClienteToolStripMenuItem
        '
        Me.AlterarOCadastroDoClienteToolStripMenuItem.Name = "AlterarOCadastroDoClienteToolStripMenuItem"
        Me.AlterarOCadastroDoClienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AlterarOCadastroDoClienteToolStripMenuItem.Text = "Cadastro do Cliente"
        '
        'CadastroDoClienteToolStripMenuItem
        '
        Me.CadastroDoClienteToolStripMenuItem.Name = "CadastroDoClienteToolStripMenuItem"
        Me.CadastroDoClienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CadastroDoClienteToolStripMenuItem.Text = "Cliente"
        '
        'ContasAPagarToolStripMenuItem
        '
        Me.ContasAPagarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendasToolStripMenuItem1})
        Me.ContasAPagarToolStripMenuItem.Name = "ContasAPagarToolStripMenuItem"
        Me.ContasAPagarToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ContasAPagarToolStripMenuItem.Text = "&Vendas"
        '
        'VendasToolStripMenuItem1
        '
        Me.VendasToolStripMenuItem1.Name = "VendasToolStripMenuItem1"
        Me.VendasToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.VendasToolStripMenuItem1.Text = "Vendas"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerificarEstoqueToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EstoqueToolStripMenuItem.Text = "&Estoque"
        '
        'VerificarEstoqueToolStripMenuItem
        '
        Me.VerificarEstoqueToolStripMenuItem.Name = "VerificarEstoqueToolStripMenuItem"
        Me.VerificarEstoqueToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.VerificarEstoqueToolStripMenuItem.Text = "Verificar Estoque"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelecionarOProdutoToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ProdutosToolStripMenuItem.Text = "&Produtos"
        '
        'SelecionarOProdutoToolStripMenuItem
        '
        Me.SelecionarOProdutoToolStripMenuItem.Name = "SelecionarOProdutoToolStripMenuItem"
        Me.SelecionarOProdutoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SelecionarOProdutoToolStripMenuItem.Text = "Selecionar o Produto"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "&Logoff"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 352)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(548, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de Vendas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(317, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(339, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(447, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(10, 36)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Funcionario:"
        '
        'Nome_Funcio
        '
        Me.Nome_Funcio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Nome_Funcio.AutoSize = True
        Me.Nome_Funcio.BackColor = System.Drawing.Color.Transparent
        Me.Nome_Funcio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_Funcio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Nome_Funcio.Location = New System.Drawing.Point(99, 321)
        Me.Nome_Funcio.Name = "Nome_Funcio"
        Me.Nome_Funcio.Size = New System.Drawing.Size(12, 16)
        Me.Nome_Funcio.TabIndex = 8
        Me.Nome_Funcio.Text = "-"
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.BackgroundImage = Global.Projeto_TCC___Loja_de_Chocolate.My.Resources.Resources.chocolate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(548, 374)
        Me.Controls.Add(Me.Nome_Funcio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Principal"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarOCadastroDoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContasAPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelecionarOProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Nome_Funcio As System.Windows.Forms.Label
End Class
