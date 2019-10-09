Imports System.Data.SqlClient
Public Class ClsFornecedor

    Private mCod_For As Integer
    Private mNome_Fantasia_For As String
    Private mRazao_For As String
    Private mCNPJ_For As String
    Private mSite_For As String
    Private mEmail_Emp_For As String
    Private mTelefone_For As String
    Private mUF_For As String
    Private mCidade_For As String
    Private mBairro_For As String
    Private mRua_For As String
    Private mNum_For As String
    Private mComple_For As String
    Private mCEP_For As String

    Dim Cone As New cls_Conexao

    Public Property Cod_For() As Integer
        Get
            Return mCod_For
        End Get
        Set(ByVal value As Integer)
            mCod_For = value
        End Set
    End Property
    Public Property Nome_Fantasia_For() As String
        Get
            Return mNome_Fantasia_For
        End Get
        Set(ByVal value As String)
            mNome_Fantasia_For = value
        End Set
    End Property
    Public Property Razao_For() As String
        Get
            Return mRazao_For
        End Get
        Set(ByVal value As String)
            mRazao_For = value
        End Set
    End Property

    Public Property CNPJ_For() As String
        Get
            Return mCNPJ_For
        End Get
        Set(ByVal value As String)
            mCNPJ_For = value
        End Set
    End Property

    Public Property Site_For() As String
        Get
            Return mSite_For
        End Get
        Set(ByVal value As String)
            mSite_For = value
        End Set
    End Property
    Public Property Email_Emp_For() As String
        Get
            Return mEmail_Emp_For
        End Get
        Set(ByVal value As String)
            mEmail_Emp_For = value
        End Set
    End Property
    Public Property Telefone_For() As String
        Get
            Return mTelefone_For
        End Get
        Set(ByVal value As String)
            mTelefone_For = value
        End Set
    End Property
    'Public Property Est_Civil_For() As String
    '    Get
    '        Return mEst_Civil_For
    '    End Get
    '    Set(ByVal value As String)
    '        mEst_Civil_For = value
    '    End Set
    'End Property
    Public Property UF_For() As String
        Get
            Return mUF_For
        End Get
        Set(ByVal value As String)
            mUF_For = value
        End Set
    End Property
    Public Property Cidade_For() As String
        Get
            Return mCidade_For
        End Get
        Set(ByVal value As String)
            mCidade_For = value
        End Set
    End Property
    Public Property Bairro_For() As String
        Get
            Return mBairro_For
        End Get
        Set(ByVal value As String)
            mBairro_For = value
        End Set
    End Property
    Public Property Rua_For() As String
        Get
            Return mRua_For
        End Get
        Set(ByVal value As String)
            mRua_For = value
        End Set
    End Property
    Public Property Num_For() As String
        Get
            Return mNum_For
        End Get
        Set(ByVal value As String)
            mNum_For = value
        End Set
    End Property
    Public Property Comple_For() As String
        Get
            Return mComple_For
        End Get
        Set(ByVal value As String)
            mComple_For = value
        End Set
    End Property
    Public Property CEP_For() As String
        Get
            Return mCEP_For
        End Get
        Set(ByVal value As String)
            mCEP_For = value
        End Set
    End Property
    Public Sub InsertFor()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_insert_Forn"
                .Parameters.AddWithValue("@Nome_Fantasia", mNome_Fantasia_For)
                .Parameters.AddWithValue("@Razao_Social", mRazao_For)
                .Parameters.AddWithValue("@CNPJ", mCNPJ_For)
                .Parameters.AddWithValue("@Site_empresa", mSite_For)
                .Parameters.AddWithValue("@Endereco", mRua_For)
                .Parameters.AddWithValue("@Numero", mNum_For)
                .Parameters.AddWithValue("@Complemento", mComple_For)
                .Parameters.AddWithValue("@CEP", mCEP_For)
                .Parameters.AddWithValue("@Bairro", mBairro_For)
                .Parameters.AddWithValue("@E_mail_Empresa", mEmail_Emp_For)
                .Parameters.AddWithValue("@Telefone_Empresa", mTelefone_For)
                .Parameters.AddWithValue("@CodCidade", mCidade_For)
                .Parameters.AddWithValue("@CodEstado", mUF_For)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub UpdateFor()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_Alterar_Fornecedor"
                .Parameters.AddWithValue("@Nome_Fantasia", mNome_Fantasia_For)
                .Parameters.AddWithValue("@Razao_Social", mRazao_For)
                .Parameters.AddWithValue("@CNPJ", mCNPJ_For)
                .Parameters.AddWithValue("@Site_empresa", mSite_For)
                .Parameters.AddWithValue("@Endereco", mRua_For)
                .Parameters.AddWithValue("@Numero", mNum_For)
                .Parameters.AddWithValue("@Complemento", mComple_For)
                .Parameters.AddWithValue("@CEP", mCEP_For)
                .Parameters.AddWithValue("@Bairro", mBairro_For)
                .Parameters.AddWithValue("@E_mail_Empresa", mEmail_Emp_For)
                .Parameters.AddWithValue("@Telefone_Empresa", mTelefone_For)
                .Parameters.AddWithValue("@CodCidade", mCidade_For)
                .Parameters.AddWithValue("@CodEstado", mUF_For)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub SelecionaFor(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleForneNome_Fan"
                        .Parameters.AddWithValue("@Nome_Fantasia", mNome_Fantasia_For)
                    Case 1
                        .CommandText = "SeleForneRazao_Social"
                        .Parameters.AddWithValue("@Razao_Social", mRazao_For)
                    Case 2
                        .CommandText = "SeleForneCNPJ"
                        .Parameters.AddWithValue("@CNPJ", mCNPJ_For)
                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            Fornecedor.dt1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub ComboCidade(ByVal Combo As ComboBox, ByVal combo2 As ComboBox)
        'GetEstado(Combo)
        Try
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand
                command.Connection = conn
                command.CommandText = "SELECT codestado from estados_tbl where uf_estado = @pUf"
                command.Parameters.AddWithValue("@pUf", Combo.SelectedItem)
                conn.Open()
                UF_For = command.ExecuteScalar()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "Select Nome_Cidade from cidades_tbl where CodEstado='" & UF_For & "'"
                    .CommandType = CommandType.Text
                End With
                combo2.Items.Clear()
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read
                    combo2.Items.Add(mr("Nome_Cidade").ToString)
                End While
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub ComboEstado()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select UF_Estado from estados_tbl"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cadastro_Fornecedor.CB_UF.Items.Add(mr("UF_Estado").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Cod_Forn()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Empresa)  as 'Cod_Empresa' from Fornecedor "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cadastro_Fornecedor.Cod_Forn.Text = mr!Cod_Empresa + 1
        End While
        ' somente leitura - select
    End Sub

    Public Sub SelecionaForCampos()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        GetCidade(Cadastro_Fornecedor.CB_Cidade)
        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "SeleForCod"
                    .Parameters.AddWithValue("@Cod_Emp", Cadastro_Fornecedor.Cod_Forn.Text)
                    .CommandType = CommandType.StoredProcedure
                End With
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read

                    With Cadastro_Fornecedor
                        .Nome_Fanta.Text = mr!Nome_Fantasia
                        .Razao_social.Text = mr!Razao_Social
                        .M_CNPJ.Text = mr!CNPJ
                        .Site_For.Text = mr!Site_empresa
                        .Bairro.Text = mr!Bairro
                        .Endere.Text = mr!Endereco
                        .Numero.Text = mr!Numero
                        .Comple.Text = mr!Complemento
                        .M_CEP.Text = mr!CEP
                        .M_Telefone.Text = mr!Telefone_Empresa
                        .Email.Text = mr!E_mail_Empresa
                        '.CB_UF.SelectedText = mr!Estado
                        '.CB_Cidade.SelectedText = mr!Nome_Cidade

                        For Each o As Object In .CB_UF.Items
                            If o.ToString() = mr!UF_Estado Then
                                .CB_UF.SelectedItem = o
                            End If
                        Next

                        For Each o As Object In .CB_Cidade.Items
                            If o.ToString() = mr!Nome_Cidade Then
                                .CB_Cidade.SelectedItem = o
                            End If
                        Next

                        Cadastro_Fornecedor.BtnCadastrar.Enabled = False
                        Cadastro_Fornecedor.BtnNovo.Enabled = False
                        Cadastro_Fornecedor.BtnLimpar.Enabled = False
                        Cadastro_Fornecedor.btn_Alterar.Enabled = True

                    End With
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Ativa_For()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtivaFor"
                .Parameters.AddWithValue("@Cod_Empresa", mCod_For)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Fornecedor Ativado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Desativa_For()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DesativaFor"
                .Parameters.AddWithValue("@Cod_Empresa", mCod_For)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Fornecedor Desativado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Function GetCidade(ByVal Combo As ComboBox)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select CodCidade from cidades_tbl where Nome_Cidade='" & Combo.Text & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                mCidade_For = mr!CodCidade
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return mCidade_For
    End Function


    Public Function GetEstado(ByVal Combo As ComboBox)
        'Try
        '    Cone.Conectar()
        '    With Cone.cmd
        '        .Connection = Cone.cnn
        '        .CommandText = "Select CodEstado from estados_tbl where UF_Estado='" & Combo.SelectedItem & "' "
        '        .CommandType = CommandType.Text
        '    End With
        '    Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
        '    While mr.Read

        '        UF_Cli = mr!CodEstado

        '    End While
        'Catch ex As SqlException
        '    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    Cone.Desconectar()
        'End Try
        Return mUF_For
    End Function

    Public Function GetForne(ByVal Combo As ComboBox)
        Dim CodForne As Integer
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Cod_Empresa from Fornecedor where Nome_Fantasia = '" & Combo.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                CodForne = mr!Cod_Empresa
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return CodForne
    End Function

End Class
