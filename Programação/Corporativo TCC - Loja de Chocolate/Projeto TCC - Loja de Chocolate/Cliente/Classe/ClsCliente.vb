Imports System.Data.SqlClient
Public Class ClsCliente
    Private mCod_Cli As Integer
    Private mCPF_Cli As String
    Private mNome_Cli As String
    Private mSexo_Cli As String
    Private mData_Nasc_Cli As Date
    Private mEst_Civil_Cli As String
    Private mUF_Cli As Integer
    Private mCidade_Cli As Integer
    Private mBairro_Cli As String
    Private mRua_Cli As String
    Private mNum_Cli As Integer
    Private mComple_Cli As String
    Private mCEP_Cli As String
    Private mTel_Fix_Cli As String
    Private mEmail_Cli As String
    'Private mData_Cad_Cli As Date
    'Private mEstado As String
    Private mStatus_Cli As String
    Public Cidade As String

    Dim Cone As New cls_Conexao
    Public Property Cod_Cli() As Integer
        Get
            Return mCod_Cli
        End Get
        Set(ByVal value As Integer)
            mCod_Cli = value
        End Set
    End Property
    Public Property CPF_Cli()
        Get
            Return mCPF_Cli
        End Get
        Set(ByVal value)
            mCPF_Cli = value
        End Set
    End Property
    Public Property Nome_Cli() As String
        Get
            Return mNome_Cli
        End Get
        Set(ByVal value As String)
            mNome_Cli = value
        End Set
    End Property
    Public Property Sexo_Cli() As String
        Get
            Return mSexo_Cli
        End Get
        Set(ByVal value As String)
            mSexo_Cli = value
        End Set
    End Property
    Public Property Data_Nasc_Cli() As Date
        Get
            Return mData_Nasc_Cli
        End Get
        Set(ByVal value As Date)
            mData_Nasc_Cli = value
        End Set
    End Property
    Public Property Est_Civil_Cli() As String
        Get
            Return mEst_Civil_Cli
        End Get
        Set(ByVal value As String)
            mEst_Civil_Cli = value
        End Set
    End Property
    Public Property UF_Cli() As Integer
        Get
            Return mUF_Cli
        End Get
        Set(ByVal value As Integer)
            mUF_Cli = value
        End Set
    End Property
    Public Property Cidade_Cli() As Integer
        Get
            Return mCidade_Cli
        End Get
        Set(ByVal value As Integer)
            mCidade_Cli = value
        End Set
    End Property
    Public Property Bairro_Cli() As String
        Get
            Return mBairro_Cli
        End Get
        Set(ByVal value As String)
            mBairro_Cli = value
        End Set
    End Property
    Public Property Rua_Cli() As String
        Get
            Return mRua_Cli
        End Get
        Set(ByVal value As String)
            mRua_Cli = value
        End Set
    End Property
    Public Property Num_Cli() As Integer
        Get
            Return mNum_Cli
        End Get
        Set(ByVal value As Integer)
            mNum_Cli = value
        End Set
    End Property
    Public Property Comple_Cli() As String
        Get
            Return mComple_Cli
        End Get
        Set(ByVal value As String)
            mComple_Cli = value
        End Set
    End Property
    Public Property CEP_Cli() As String
        Get
            Return mCEP_Cli
        End Get
        Set(ByVal value As String)
            mCEP_Cli = value
        End Set
    End Property
    Public Property Tel_Fix_Cli() As String
        Get
            Return mTel_Fix_Cli
        End Get
        Set(ByVal value As String)
            mTel_Fix_Cli = value
        End Set
    End Property
    Public Property Email_Cli() As String
        Get
            Return mEmail_Cli
        End Get
        Set(ByVal value As String)
            mEmail_Cli = value
        End Set
    End Property
    'Public Property Data_Cad_Cli() As Date
    '    Get
    '        Return mData_Cad_Cli
    '    End Get
    '    Set(ByVal value As Date)
    '        mData_Cad_Cli = value
    '    End Set
    'End Property
    'Public Property Estado() As String
    '    Get
    '        Return mEstado
    '    End Get
    '    Set(ByVal value As String)
    '        mEstado = value
    '    End Set
    'End Property
    Public Property Status_() As String
        Get
            Return mStatus_Cli
        End Get
        Set(ByVal value As String)
            mStatus_Cli = value
        End Set
    End Property
    Public Sub InsertCli()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_insert_clien"
                .Parameters.AddWithValue("@Nome", mNome_Cli)
                .Parameters.AddWithValue("@Data_de_Nascimento", mData_Nasc_Cli)
                .Parameters.AddWithValue("@CPF", mCPF_Cli)
                .Parameters.AddWithValue("@Estado_Civil", mEst_Civil_Cli)
                .Parameters.AddWithValue("@Sexo", mSexo_Cli)
                .Parameters.AddWithValue("@Endereco", mRua_Cli)
                .Parameters.AddWithValue("@Numero", mNum_Cli)
                .Parameters.AddWithValue("@Complemento", mComple_Cli)
                .Parameters.AddWithValue("@CEP", mCEP_Cli)
                .Parameters.AddWithValue("@Bairro", mBairro_Cli)
                .Parameters.AddWithValue("@E_mail", mEmail_Cli)
                .Parameters.AddWithValue("@Numero_Tel", mTel_Fix_Cli)
                .Parameters.AddWithValue("@CodEstado", mUF_Cli)
                .Parameters.AddWithValue("@CodCidade", mCidade_Cli)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Cliente Cadastrado!")

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
                UF_Cli = command.ExecuteScalar()
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
                    .CommandText = "Select Nome_Cidade from cidades_tbl where CodEstado='" & UF_Cli & "'"
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
                Cadastro_Cliente.UF.Items.Add(mr("UF_Estado").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

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
        Return UF_Cli
    End Function
    Public Sub SelecionaCli(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleClieCod"
                        .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                    Case 1
                        .CommandText = "SeleCliNome"
                        .Parameters.AddWithValue("@Nome_Cli", mNome_Cli)
                    Case 2
                        .CommandText = "SeleCliCPF"
                        .Parameters.AddWithValue("@CPF_Cli", mCPF_Cli)
                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure

            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            Cliente.dt1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Dim N As Boolean = True
    Public Sub SelecionaCliCampos()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        GetCidade(Cadastro_Cliente.CB_Cidade)
        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "SeleCliCod"
                    .Parameters.AddWithValue("@Cod_Cli", Cadastro_Cliente.Cod_Cliente.Text)
                    .CommandType = CommandType.StoredProcedure
                End With
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read

                    With Cadastro_Cliente

                        .CPF.Text = mr!CPF
                        .Nome_Cliente.Text = mr!Nome

                        If mr!Sexo = "F" Then
                            .RB_Feminino.Checked = True
                        ElseIf mr!Sexo = "M" Then
                            .RB_Masculino.Checked = True
                        End If

                        .DTP_Cliente.Value = mr!Data_de_Nascimento

                        If mr!Estado_Civil = "Casado(a)" Then
                            .RB_Casado.Checked = True
                        End If
                        If mr!Estado_Civil = "Solteiro(a)" Then
                            .RB_Solt.Checked = True
                        End If
                        If mr!Estado_Civil = "Divorciado(a)" Then
                            .RB_Divor.Checked = True
                        End If
                        If mr!Estado_Civil = "Viuvo(a)" Then
                            .RB_Viuvo.Checked = True
                        End If

                        .Bairro.Text = mr!Bairro
                        .Endereco.Text = mr!Endereco
                        .Numero.Text = mr!Numero
                        .Complemento.Text = mr!Complemento
                        .CEP.Text = mr!CEP
                        .Telefone.Text = mr!Numero_Tel
                        .EMAIL.Text = mr!E_mail

                        For Each o As Object In .UF.Items
                            If o.ToString() = mr!UF_Estado Then
                                .UF.SelectedItem = o
                            End If
                        Next

                        For Each o As Object In .CB_Cidade.Items
                            If o.ToString() = mr!Nome_Cidade Then
                                .CB_Cidade.SelectedItem = o
                            End If
                        Next

                        '.UF.Items.Add(mr!UF_Estado)
                        '.CB_Cidade.Items.Add(mr!Nome_Cidade)

                        ' .UF.SelectedItem = .UF.FindString(mr!UF_Estado)
                        ' .CB_Cidade.SelectedItem = .CB_Cidade.FindString(mr!Nome_Cidade)

                        Cadastro_Cliente.Cadastrar_Cli.Enabled = False
                        Cadastro_Cliente.BtnNovo.Enabled = False
                        Cadastro_Cliente.BtnLimpar.Enabled = False
                        Cadastro_Cliente.Alterar_Cli.Enabled = True

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

    Public Sub UpdateCli()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_Alterar_Cliente"
                .Parameters.AddWithValue("@Codigo_do_Cliente", mCod_Cli)
                .Parameters.AddWithValue("@Nome", mNome_Cli)
                .Parameters.AddWithValue("@Data_de_Nascimento", mData_Nasc_Cli)
                .Parameters.AddWithValue("@CPF", mCPF_Cli)
                .Parameters.AddWithValue("@Estado_Civil", mEst_Civil_Cli)
                .Parameters.AddWithValue("@Sexo", mSexo_Cli)
                .Parameters.AddWithValue("@Endereco", mRua_Cli)
                .Parameters.AddWithValue("@Numero", mNum_Cli)
                .Parameters.AddWithValue("@Complemento", mComple_Cli)
                .Parameters.AddWithValue("@CEP", mCEP_Cli)
                .Parameters.AddWithValue("@Bairro", mBairro_Cli)
                .Parameters.AddWithValue("@E_mail", mEmail_Cli)
                .Parameters.AddWithValue("@Numero_Tel", mTel_Fix_Cli)
                .Parameters.AddWithValue("@CodEstado", mUF_Cli)
                .Parameters.AddWithValue("@CodCidade", mCidade_Cli)
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

    Public Sub Desativa_Cli()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DesativaCli"
                .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Cliente Desativado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Ativa_Cli()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtivaCli"
                .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Cliente Ativado!")
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
                Cidade = mr!CodCidade
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return Cidade
    End Function
End Class
