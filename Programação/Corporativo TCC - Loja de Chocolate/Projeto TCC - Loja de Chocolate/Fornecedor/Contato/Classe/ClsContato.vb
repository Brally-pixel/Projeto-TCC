Imports System.Data.SqlClient
Public Class ClsContato


    Private mCodigo_Con As Integer
    Private mNome_Con As String
    Private mFax_Con As String
    Private mEmail_Con As String
    Private mNumero_Con As String
    Private mSexo_Cli As String

    Private mNome_Fantasia_For As String

    Dim Cone As New cls_Conexao

    Public Property Nome_Fantasia_For() As String
        Get
            Return mNome_Fantasia_For
        End Get
        Set(ByVal value As String)
            mNome_Fantasia_For = value
        End Set
    End Property
    '------------------------------------------------------------
    Public Property Codigo_Con() As String
        Get
            Return mCodigo_Con
        End Get
        Set(ByVal value As String)
            mCodigo_Con = value
        End Set
    End Property


    Public Property Nome_Con() As String
        Get
            Return mNome_Con
        End Get
        Set(ByVal value As String)
            mNome_Con = value
        End Set
    End Property
    Public Property Fax_Con() As String
        Get
            Return mFax_Con
        End Get
        Set(ByVal value As String)
            mFax_Con = value
        End Set
    End Property
    Public Property Email_Con() As String
        Get
            Return mEmail_Con
        End Get
        Set(ByVal value As String)
            mEmail_Con = value
        End Set
    End Property
    Public Property Numero_Con() As String
        Get
            Return mNumero_Con
        End Get
        Set(ByVal value As String)
            mNumero_Con = value
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

    Public Sub InsertConta()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_insert_Contato_Forn"
                .Parameters.AddWithValue("@codigo_Empresa", mCodigo_Con)
                .Parameters.AddWithValue("@Nome", mNome_Con)
                .Parameters.AddWithValue("@Sexo", mSexo_Cli)
                .Parameters.AddWithValue("@Fax", mFax_Con)
                .Parameters.AddWithValue("@E_mail_Fornecedor", mEmail_Con)
                .Parameters.AddWithValue("@numero_Tel", mNumero_Con)
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

    Public Sub UpdateConta()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_Alterar_Cont_Fornecedor"
                .Parameters.AddWithValue("@Codigo_do_contato", mCodigo_Con)
                .Parameters.AddWithValue("@codigo_Empresa", mNome_Con)
                .Parameters.AddWithValue("@Nome", mSexo_Cli)
                .Parameters.AddWithValue("@Fax", mFax_Con)
                .Parameters.AddWithValue("@E_mail_Fornecedor", mEmail_Con)
                .Parameters.AddWithValue("@numero_Tel", mNumero_Con.ToString)
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

    Public Sub ComboEmpresa()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Nome_Fantasia from Fornecedor"
                .CommandType = CommandType.Text
            End With
            Contato_Empresa.CB_Empresa.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Contato_Empresa.CB_Empresa.Items.Add(mr("Nome_Fantasia").ToString)
            End While

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub SelecionaCont(ByVal C As Integer, ByVal Estado As String)
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
                        .CommandText = "SeleForneNome"
                        .Parameters.AddWithValue("@Nome", mNome_Con)
                    Case 2
                        .CommandText = "SeleCon_Nume"
                        .Parameters.AddWithValue("@Numero", mNumero_Con)
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
    Public Sub SelecionaConCampos()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "SeleConCod"
                    .Parameters.AddWithValue("@Cod_Con", Contato_Empresa.Codigo_Contato.Text)
                    .CommandType = CommandType.StoredProcedure
                End With
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read
                    With Contato_Empresa

                        .Nome.Text = mr!Nome
                        .M_Fax.Text = mr!Fax
                        .Email_Con.Text = mr!E_mail_Fornecedor
                        .M_Numero_Conta.Text = mr!numero_Tel
                        .CB_Empresa.SelectedItem = mr!Nome_Fantasia

                        Contato_Empresa.BtnAlterar.Enabled = True

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


    Public Sub Desativa_Con()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DesativaCon"
                .Parameters.AddWithValue("@Codigo_do_contato", mCodigo_Con)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Contato Desativado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Ativa_Con()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtivaCon"
                .Parameters.AddWithValue("@Codigo_do_contato", mCodigo_Con)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Contato Ativado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
End Class
