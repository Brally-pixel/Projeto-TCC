use master
go
Drop database Loja_Chocolicia
go
create database Loja_Chocolicia
go
use Loja_Chocolicia
go

create table estados_tbl (
CodEstado int primary key,
UF_Estado varchar (20),
Estado varchar(25),
)

go

create table cidades_tbl (
CodCidade int primary key,
CodEstado int,
Nome_Cidade varchar (40)
Constraint FK_Chave0 Foreign Key (CodEstado) References estados_tbl (CodEstado)
)

go

create table Cadastro_Cliente(
Codigo_do_Cliente int identity (1,1) primary key, --Codigo do Cliente
Nome varchar(40) not null, --Nome do Cliente
Data_de_Nascimento date not null, --Data de Nascimento do Cliente
Data_Cadastro datetime default getdate(),--Data de Nascimento do Cliente
CPF varchar (12) not null, --CPF do Cliente
Estado_Civil varchar(13) check (Estado_Civil in ('Solteiro(a)','Casado(a)','Viuvo(a)','Divorciado(a)')) not null,
Sexo varchar(1) check (Sexo in ('F','M')) not null, --Sexo do Cliente sendo F "Feminino" e M "Masculino"
Endereco varchar(50) not null, --Endereço do Cliente
Numero varchar(4) not null, --Numero da Casa do Cliente
Complemento varchar(40), --Complemento do endereço do cliente
CEP varchar (8) not null, --CEP da Rua do Cliente
Bairro varchar (20) not null, --Bairro do Cliente
E_mail varchar(40), --Email para contatos
Numero_Tel varchar (10)not null, --Número de Telefone do Cliente
Status_Cli varchar(1) check (Status_Cli in ('A','I')) default('A'), --Status do Cliente sendo A "Ativo" e I "Inativo"
CodCidade int,--Código da Cidade 
CodEstado int,--Código do Estado
Constraint FK_Chave1 Foreign Key (CodCidade) References cidades_tbl (CodCidade),
Constraint FK_Chave2 Foreign Key (CodEstado) References estados_tbl (CodEstado)
)

go
Create table Fornecedor(
Cod_Empresa int identity(1,1),
Nome_Fantasia varchar (20) not null, 
Razao_Social varchar (40) not null, -- 40
CNPJ varchar (14), -- tamanho 14
Site_empresa varchar(50) null,
Endereco varchar(50) not null, --Endereço do Cliente
Numero varchar(4) not null, --Numero da Casa do Cliente
Complemento varchar(40) not null, --Complemento do endereço do cliente
CEP varchar (8) not null, --CEP da Rua do Cliente -- tamanho 8
Bairro varchar (30) not null, --Bairro do Cliente
E_mail_Empresa varchar(40)not null, --Email para contatos
Telefone_Empresa varchar  (10)not null,
CodCidade int,
CodEstado int,
Data_Cadastro datetime default getdate(),
Status_For varchar(1) check (Status_For in ('A','I'))default('A'),
Constraint PK_Cod_Empre Primary Key (Cod_Empresa),
Constraint FK_Chave3 Foreign Key (CodCidade) References cidades_tbl (CodCidade),
Constraint FK_Chave4 Foreign Key (CodEstado) References estados_tbl (CodEstado)
)

go
create table Contato_Fornecedor(
Codigo_do_contato int identity (1,1) primary key, --Codigo do Fornecedor
codigo_Empresa int , -- código do contato -- chave estrangeira
Nome varchar (40) not null, --Nome do Fornecedor
Sexo varchar(1) check (Sexo in ('F','M')) not null, --sexo do fornecedor sendo F""
Fax varchar(10)  null,
Data_Cadastro datetime default getdate(),
E_mail_Fornecedor varchar(40) null,
numero_Tel varchar(10) not null,
Status_Cont varchar(1) check (Status_Cont in ('A','I'))default('A'), -- verificar nome da coluna
Constraint FK_Chave5 Foreign Key (codigo_Empresa) References Fornecedor (Cod_Empresa)
)

go

Create Table Marca
(
Cod_Marca Int Identity(1,1), --Código da Marca do Produto
Nome_Marca Varchar(30) Not Null, --Nome da Marca do Produto
Data_Cadastro datetime default getdate(),
Status_Marca varchar(1) check (Status_Marca in ('A','I'))default('A') -- verificar nome da coluna
Constraint PK_Cod_Marca Primary Key (Cod_Marca)
)



go
Create table Cad_Produto
(
Cod_Produto Int Identity(1,1) not null, -- Código do produto
Cod_Barra_Prod VarChar(13) Not Null, --Código de barra do produto
COd_Marca int,
Data_Cadastro datetime default getdate(),
--Data_Validade datetime,
Descricao_Prod Varchar (50) Not Null, -- Descrição do Produto
Status_Prod Char(1) Check(Status_Prod in ('A','I')) Default 'A' Not Null, --Status do Produto(Ativo ou Inativo)
Constraint PK_Cod_Prod Primary Key (Cod_Produto),
Constraint FK_Chave54 Foreign Key (COd_Marca) References Marca (Cod_Marca)
)

select Cod_Barra_Prod from Cad_Produto
go

Create table Estoque(
Cod_Estoque Int, -- Código do Estoque
Cod_Prod Int Not Null, -- Código do Produto
Estoque_Max Int Not Null, -- Estoque Máximo
Estoque_Min Int Not Null, -- Estoque Minimo
Estoque_Atual Int Default(0), -- Estoque Atual
Sabor Varchar(50), -- Característica
Unidade varchar(10), -- Unidade do produto (L Litro, P Pacote, U Unidade, G Gramas)
Vl_Venda_Prod Decimal(15,2) Not Null, --Valor de Venda do Produto
Constraint PK_Cod_Estoque Primary Key(Cod_Prod,Cod_Estoque),
Constraint FK_Chave8 Foreign Key (Cod_Prod) References Cad_Produto (Cod_Produto)
)
go

Create Procedure Mostrar_Produt
@Cod_Fornecedor int
as
begin
select Descricao_Prod  from Cad_Produto inner join Estoque_For on Cad_Produto.Cod_Produto = Estoque_For .Cod_Produto 
where Cod_Fornecedor = @Cod_Fornecedor 
end

go

Create table Estoque_For(
CodEstoque int,
Cod_Fornecedor int,
Cod_Produto int,
constraint pk primary key (CodEstoque,Cod_Fornecedor,Cod_Produto),
Constraint FK_Chave7 Foreign Key (Cod_Produto,CodEstoque) References Estoque (Cod_Prod,Cod_Estoque),
Constraint F_Chave7 Foreign Key (Cod_Fornecedor) References  Fornecedor(Cod_Empresa)
)
go

Create Procedure Cadas_Estoque_For
@CodEstoque int,
@Cod_Fornecedor int,
@Cod_Produto int
as
begin
insert into Estoque_For (CodEstoque,Cod_Fornecedor,Cod_Produto) values (@CodEstoque,@Cod_Fornecedor,@Cod_Produto)
end

go

create table Departamento(
Cod_Departamento int identity (1,1) primary key not null,
Descricao varchar(40) not null,
Data_Cadastro datetime default getdate(),
Status_Dep varchar(1) check (Status_Dep in ('A','I')) Default('A'),
)
go

create table Cadastro_Funcionario(
Codigo_do_funcionario int identity (1,1) primary key,
Nome varchar(40) not null,
CPF varchar (12) not null,
RG varchar (12) not null,
Endereco varchar (40) not null,
Numero varchar (5) null,
Complemento varchar (50) null,
CEP varchar(8) not null,
Bairro varchar (20) not null,
Codigo_Departamento int not null,
Turno_Funci Char(1) Check(Turno_Funci in('M', 'T')) Not Null,-- Turno do funcionário
E_mail varchar (40) null,
Nivel_de_Ensino varchar(12) check (Nivel_de_Ensino in ('Fundamental','Medio ','Técnico','Superior')) not null,
Sexo varchar(1) check (Sexo in ('F','M')) not null,
Data_de_Nascimento date not null,
Estado_Civil varchar(14) check (Estado_Civil in ('Solteiro(a)','Casado(a)','Viuvo(a)','Divorciado(a)')) not null,
numero_Tel varchar (10)not null,
Status_Func varchar(1) check (Status_Func in ('A','I'))default('A'),
CodCidade int,
CodEstado int,
Data_Cadastro datetime default getdate(),
Constraint FK_Chave9 Foreign Key (CodCidade) References cidades_tbl (CodCidade),
Constraint FK_Chave10 Foreign Key (CodEstado) References estados_tbl (CodEstado),
Constraint FK_Chave11 Foreign Key (Codigo_Departamento) References Departamento(Cod_Departamento)
)

go
create table Pagamento_Func(
Codigo_Pag int primary key,
Cod_Func int,
Valor int,
Data date,
Situacao varchar
Constraint FK_Chave12 Foreign Key (Cod_Func) References Cadastro_Funcionario(Codigo_do_funcionario)
)
go

create table Contas_Pagar(
Codigo_Conta int identity (1,1),
Descricao_conta varchar (30) not null,
Responsavel varchar (20) not null,
Data_de_Pagamento date not null, 
Data_de_Vencimento date not null, 
Valor_da_Conta Money not null,
Valor_Pago money,
StatsPag Char(2) Check(StatsPag in('Pa','Pe','At')) Default('Pe') Not Null,--Status de pagamento(Pago, Pendente ou Atrasado)
Status_Cont char(1) Check (Status_Cont in ('A','I')) Default ('A'),
constraint PK_Con primary key (Codigo_Conta),
)
go
create table Vendas(
codigo_venda int identity (1,1)  primary key not null,
Codigo_do_funcionario int not null,
Codigo_do_Cliente int not null,
data_venda Datetime default (getdate()),
Valor_final Money not null, 
Status_Venda varchar(1) check (Status_Venda in ('A','F'))default('A'),
Constraint FK_Chave14 Foreign Key (Codigo_do_funcionario) References Cadastro_Funcionario (Codigo_do_funcionario),
Constraint FK_Chave15 Foreign Key (Codigo_do_Cliente) References cadastro_cliente (Codigo_do_Cliente)
)
go

Create Table Forma_Pag
(
Cod_FormPag int identity,
Tipo_FormPag varchar(8) Not Null
Constraint PK_Cod_FormPag Primary Key (Cod_FormPag)
)


go

insert into Forma_Pag values('Dinheiro')
insert into Forma_Pag values('Débito')
insert into Forma_Pag values('Credito')
go
Create Table Recebimento
(
Cod_Receb Int Not Null, --Código do Recebimento
Cod_Venda Int Not Null, --Código da Venda
CodForma_Pag Int Not Null, --Código da Forma Pagamento
DataReceb Datetime Null, --Data de Recebimento
ValorReceb Decimal(15,2) Not Null, --Valor Recebido
Status_Pag Char(2) Check(Status_Pag in('Pa','Pe','At')) Not Null, --Status do Pagamento, Pa(Pago) Pe(Pendente) At(Atrasado)
Satatus_Recebimento Char(1) Check(Satatus_Recebimento in ('A','I')) Default 'A' Not Null, --Status do Pagamento(Ativo ou Inativo)
Constraint PK_CodRecebVenda Primary Key (Cod_Receb,Cod_Venda),
Constraint FK_VendaReceb Foreign Key (Cod_Venda) References Vendas (codigo_venda),
Constraint FK_FormaPagReceb Foreign Key (CodForma_Pag) References Forma_Pag (Cod_FormPag)
)

go

create table Detalhes_Venda(
codigo_venda int  not null,
Codigo_do_Detalhe int not null,
Codigo_do_Produto int not null,
cod_estoque int,
Quantidade int not null,
Valor_Unitário Money not null,
Status_Item_Venda Char(1) Check(Status_Item_Venda in ('A','I')) Default 'A' Not Null,
constraint PK_detalhe primary key (codigo_venda,Codigo_do_Detalhe), 
Constraint FK_Chave16 Foreign Key (Codigo_venda) References vendas (codigo_venda),
Constraint FK_Chave17 Foreign Key (Codigo_do_Produto,cod_estoque) References estoque (Cod_Prod,Cod_Estoque)
)

go

Create table Cad_Login(
Cod_fun int not null,
cad_login varchar (20)not null, 
senha varchar (20) not null,
Data_Cadastro datetime default getdate(),
Nivel  varchar(15) check (Nivel in ('1','2'))default('2'),
Status_Log varchar(1) check (Status_Log in ('A','I'))default('A'),
Constraint FK_Chave19 Foreign Key (cod_fun) References Cadastro_Funcionario (Codigo_do_funcionario)
)
go


Create table Compra (
Cod_Compra Int Identity primary key,-- Código da Compra
Cod_Forne Int Not Null, --Código do Fornecedor
Vl_Compra Money Not Null,-- Valor da compra
Data_Compra Datetime Default(GetDate()) Not Null,--Data de compra
Status_Com Char(1) Check(Status_Com in ('A','I')) Default 'A' Not Null, --Status da Compra(Ativo ou Inativo)
Constraint FK_Cod_Forne Foreign Key(Cod_Forne) References Fornecedor(Cod_Empresa)
)
go

create Procedure Sele_Compra
@Cod_Prod int
as
begin
Select Compra.Cod_Compra'Código da Compra',Cod_Forne'Código Fornecedor' ,Vl_Compra'Valor de Compra' ,Data_Compra'Data da Compra',Cod_Prod'Código do Produto',Cod_Estoque'Código do Estoque' ,Qtd_Prod'Quantidade Comprada' ,Vl_Unitario'Valor Unitário' ,Unidade 
from  Compra inner join Item_Compra on Compra.Cod_Compra=Item_Compra.Cod_Compra where Cod_Prod=@Cod_Prod
end

go

Create table Item_Compra(
Cod_Item_Compra int, --Código do Item Compra
Cod_Compra int Not Null, -- Código da Compra
Cod_Prod int Not Null, -- Código do Produto
Cod_Estoque int Not Null, -- Código do Estoque
Qtd_Prod int Not Null, -- Quantidade do Produto
Vl_Unitario money Not Null, -- Valor Unitário do Produto
Unidade varchar(10) Not Null,-- Unidade do produto (L Litro, P Pacote, U Unidade, G Gramas)
Status_Item_Com Char(1) Check(Status_Item_Com in ('A','I')) Default 'A' Not Null, --Status do Item(Ativo ou Inativo)
Constraint PK_Cod_Item_Compra primary key(Cod_Item_Compra, Cod_Compra),
Constraint FK_Cod_Compra Foreign Key(Cod_Compra) References Compra(Cod_Compra),
Constraint FK_Cod_Prod foreign key (Cod_Prod) references Cad_Produto (Cod_Produto)
)
go
create table Fale_Conosco2 (
cod_Fale int identity (1,1),
Nome varchar(40),
email varchar(40),
Descricao varchar(2048)
)
go

Create Procedure IncluiFaleConosco 
@nome varchar(40),
@email varchar(40),
@recado varchar(2048)
as
insert into Fale_Conosco2 (nome,Email,Descricao) values (@nome,@email,@recado)