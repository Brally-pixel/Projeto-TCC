Imports System.Data.SqlClient
Public Class ClsFuncionario
    Private mCod_Fun As Integer
    Private mRG_Fun As String
    Private mCPF_Fun As String
    Private mNome_Fun As String
    Private mEscolaridade_Fun As String
    Private mSexo_Fun As String
    Private mData_Nasc_Fun As Date
    Private mEst_Civil_Fun As String
    Private mUF_Fun As Integer
    Private mCidade_Fun As Integer
    Private mBairro_Fun As String
    Private mRua_Fun As String
    Private mNum_Fun As Integer
    Private mComple_Fun As String
    Private mCEP_Fun As String
    Private mTel_Fix_Fun As String
    Private mEmail_Fun As String
    Private mStatus_Fun As String
    Private mCod_Departaento As Integer
    Private mTurno As String
    ' Dim objFun As New ClsFuncionario

    Dim Cone As New cls_Conexao

    Public Property Cod_Fun() As Integer
        Get
            Return mCod_Fun
        End Get
        Set(ByVal value As Integer)
            mCod_Fun = value
        End Set
    End Property
    Public Property CPF_Fun()
        Get
            Return mCPF_Fun
        End Get
        Set(ByVal value)
            mCPF_Fun = value
        End Set
    End Property
    Public Property RG_Fun() As String
        Get
            Return mRG_Fun
        End Get
        Set(ByVal value As String)
            mRG_Fun = value
        End Set
    End Property

    Public Property Escolaridade_Fun() As String
        Get
            Return mEscolaridade_Fun
        End Get
        Set(ByVal value As String)
            mEscolaridade_Fun = value
        End Set
    End Property

    Public Property Nome_Fun() As String
        Get
            Return mNome_Fun
        End Get
        Set(ByVal value As String)
            mNome_Fun = value
        End Set
    End Property
    Public Property Sexo_Fun() As String
        Get
            Return mSexo_Fun
        End Get
        Set(ByVal value As String)
            mSexo_Fun = value
        End Set
    End Property
    Public Property Data_Nasc_Fun() As Date
        Get
            Return mData_Nasc_Fun
        End Get
        Set(ByVal value As Date)
            mData_Nasc_Fun = value
        End Set
    End Property
    Public Property Est_Civil_Fun() As String
        Get
            Return mEst_Civil_Fun
        End Get
        Set(ByVal value As String)
            mEst_Civil_Fun = value
        End Set
    End Property
    Public Property UF_Fun() As Integer
        Get
            Return mUF_Fun
        End Get
        Set(ByVal value As Integer)
            mUF_Fun = value
        End Set
    End Property
    Public Property Cidade_Fun() As Integer
        Get
            Return mCidade_Fun
        End Get
        Set(ByVal value As Integer)
            mCidade_Fun = value
        End Set
    End Property
    Public Property Bairro_Fun() As String
        Get
            Return mBairro_Fun
        End Get
        Set(ByVal value As String)
            mBairro_Fun = value
        End Set
    End Property
    Public Property Rua_Fun() As String
        Get
            Return mRua_Fun
        End Get
        Set(ByVal value As String)
            mRua_Fun = value
        End Set
    End Property
    Public Property Num_Fun() As Integer
        Get
            Return mNum_Fun
        End Get
        Set(ByVal value As Integer)
            mNum_Fun = value
        End Set
    End Property
    Public Property Comple_Fun() As String
        Get
            Return mComple_Fun
        End Get
        Set(ByVal value As String)
            mComple_Fun = value
        End Set
    End Property
    Public Property CEP_Fun() As String
        Get
            Return mCEP_Fun
        End Get
        Set(ByVal value As String)
            mCEP_Fun = value
        End Set
    End Property
    Public Property Tel_Fix_Fun() As String
        Get
            Return mTel_Fix_Fun
        End Get
        Set(ByVal value As String)
            mTel_Fix_Fun = value
        End Set
    End Property
    Public Property Email_Fun() As String
        Get
            Return mEmail_Fun
        End Get
        Set(ByVal value As String)
            mEmail_Fun = value
        End Set
    End Property
    Public Property Status_Fun() As String
        Get
            Return mStatus_Fun
        End Get
        Set(ByVal value As String)
            mStatus_Fun = value
        End Set
    End Property
    Public Property Cod_Departamento_Fun() As Integer
        Get
            Return mCod_Departaento
        End Get
        Set(ByVal value As Integer)
            mCod_Departaento = value
        End Set
    End Property
    Public Property Turno() As String
        Get
            Return mTurno
        End Get
        Set(ByVal value As String)
            mTurno = value
        End Set
    End Property

    Dim mdescricao As String
    Public Property descricao() As String
        Get
            Return mdescricao
        End Get
        Set(ByVal value As String)
            mdescricao = value
        End Set
    End Property


    Public Sub InsertFun()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_insert_Funcio"

                .Parameters.AddWithValue("@Nome", mNome_Fun)
                .Parameters.AddWithValue("@CPF", mCPF_Fun)
                .Parameters.AddWithValue("@RG", mRG_Fun)
                .Parameters.AddWithValue("@Endereco", mRua_Fun)
                .Parameters.AddWithValue("@Numero", mNum_Fun)
                .Parameters.AddWithValue("@Complemento", mComple_Fun)
                .Parameters.AddWithValue("@CEP", mCEP_Fun)
                .Parameters.AddWithValue("@Bairro", mBairro_Fun)
                .Parameters.AddWithValue("@CodDepartamento", mCod_Departaento)
                .Parameters.AddWithValue("@E_mail", mEmail_Fun)
                .Parameters.AddWithValue("@Nivel_de_Ensino", mEscolaridade_Fun)
                .Parameters.AddWithValue("@Sexo", mSexo_Fun)
                .Parameters.AddWithValue("@Data_de_Nascimento", mData_Nasc_Fun)
                .Parameters.AddWithValue("@Estado_Civil", mEst_Civil_Fun)
                .Parameters.AddWithValue("@Numero_Tel", mTel_Fix_Fun)
                .Parameters.AddWithValue("@CodCidade", mCidade_Fun)
                .Parameters.AddWithValue("@CodEstado", mUF_Fun)
                .Parameters.AddWithValue("@turno", mTurno)

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
    Public Sub ComboCidade(ByVal Combo As ComboBox, ByVal combo2 As ComboBox)
        'GetEstado(Combo)
        Try
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand
                command.Connection = conn
                command.CommandText = "SELECT codestado from estados_tbl where uf_estado = @pUf"
                command.Parameters.AddWithValue("@pUf", Combo.SelectedItem)
                conn.Open()
                UF_Fun = command.ExecuteScalar()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            ' Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "Select Nome_Cidade from cidades_tbl where CodEstado='" & Cadastrar_Funcionario.CB_UF.SelectedIndex + 1 & "'"
                    .CommandType = CommandType.Text
                End With

                combo2.Items.Clear()
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read
                    Cadastrar_Funcionario.CB_Cidade.Items.Add(mr("Nome_Cidade").ToString)
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
                Cadastrar_Funcionario.CB_UF.Items.Add(mr("UF_Estado").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub ComboDepartamento()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Descricao from Departamento"
                .CommandType = CommandType.Text
            End With
            Cadastrar_Funcionario.CB_Departamento.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cadastrar_Funcionario.CB_Departamento.Items.Add(mr("Descricao").ToString)
            End While

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Cod_Funci()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Codigo_do_funcionario)  as 'Codigo_do_funcionario' from Cadastro_Funcionario "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cadastrar_Funcionario.Cod_Fun.Text = mr!Codigo_do_funcionario + 1
        End While
        ' somente leitura - select
    End Sub

    Public Sub SelecionaFun(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleFunCPF"
                        .Parameters.AddWithValue("@CPF", mCPF_Fun)
                    Case 1
                        .CommandText = "SeleFunNome"
                        .Parameters.AddWithValue("@Nome_Fun", mNome_Fun)
                    Case 2
                        .CommandText = "SeleFunRG"
                        .Parameters.AddWithValue("@RG", mRG_Fun)
                    Case 3
                        .CommandText = "SeleFunDep"
                        .Parameters.AddWithValue("@Depart", mdescricao)
                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            Funcionario.dt1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub SelecionaFunCampos()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        GetCidade(Cadastrar_Funcionario.CB_Cidade)
        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "SeleFunCod"
                    .Parameters.AddWithValue("@Cod_Fun", Cadastrar_Funcionario.Cod_Fun.Text)
                    .CommandType = CommandType.StoredProcedure
                End With
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read

                    With Cadastrar_Funcionario



                        .MtxtCPF.Text = mr!CPF
                        .Nome.Text = mr!Nome
                        .MtxtRG.Text = mr!RG


                        If mr!Turno_Funci = "M" Then
                            .RB_Manha.Checked = True

                        ElseIf mr!Turno_Funci = "T" Then
                            .RB_Tarde.Checked = True
                        End If


                        If mr!Nivel_de_Ensino = "Medio" Then
                            .Rbtnmedio.Checked = True
                        End If

                        If mr!Nivel_de_Ensino = "Superior" Then
                            .Rbtnmedio.Checked = True
                        End If

                        If mr!Nivel_de_Ensino = "Fundamental" Then
                            .Rbtnmedio.Checked = True
                        End If

                        If mr!Nivel_de_Ensino = "Técnico" Then
                            .Rbtnmedio.Checked = True
                        End If

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


                        If mr!Sexo = "F" Then
                            .RB_Feminino.Checked = True
                        End If

                        If mr!Sexo = "M" Then
                            .RB_Masculino.Checked = True
                        End If

                        .TxtBairro.Text = mr!Bairro
                        .txtender.Text = mr!Endereco
                        .txtNumero.Text = mr!Numero
                        .txtComp.Text = mr!Complemento
                        .MtxtCEP.Text = mr!CEP
                        .MtxtTelefone.Text = mr!Numero_Tel
                        .txtemail.Text = mr!E_mail
                        ' .CB_UF.SelectedItem = mr!CodEstado
                        ' .CB_Cidade.SelectedItem = mr!CodCidade

                        For Each o As Object In .CB_UF.Items
                            If o.ToString() = mr!UF_Estado Then
                                .CB_UF.SelectedItem = o
                            End If
                        Next

                        For Each o As Object In .CB_Departamento.Items
                            If o.ToString() = mr!Descricao Then
                                .CB_Departamento.SelectedItem = o
                            End If
                        Next

                        For Each o As Object In .CB_Cidade.Items
                            If o.ToString() = mr!Nome_Cidade Then
                                .CB_Cidade.SelectedItem = o
                            End If
                        Next


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

    Public Sub Desativa_Fun()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Listar_Status_Fun2"
                .Parameters.AddWithValue("@Codigo_do_funcionario", mCod_Fun)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Funcionario Desativado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Ativa_Fun()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Listar_Status_Fun1"
                .Parameters.AddWithValue("@Codigo_do_funcionario", mCod_Fun)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Funcionario Ativado!")
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
                Cidade_Fun = mr!CodCidade
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return Cidade_Fun
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
        Return UF_Fun
    End Function

    Public Function GetFuncionario(ByVal x As String)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Cod_fun from Cad_Login where cad_login = '" & x & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cod_Fun = mr!Cod_fun
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return Cod_Fun
    End Function
End Class
