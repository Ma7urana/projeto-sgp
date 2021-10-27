drop database if exists sgp;
create database sgp;

use sgp;

create table enderecos (
	id int auto_increment,
	logradouro varchar(80),
	numero varchar(20),
	bairro varchar(40),
	cep varchar(8),
	estado varchar(40),
	municipio varchar(40)
	primary key (id)
);

create table funcionarios (
	id int auto_increment,
	nome varchar(50),
	email varchar(100),
	cpf varchar(11),
	rg varchar(10),
	data_nascimento date,
	sexo varchar(20),
	cargo varchar(30),
	departamento varchar(30),
	data_admissao date,
	data_demissao date,
	vale_alimentacao enum('V', 'F'),
	vale_transporte enum('V', 'F'),
	endereco_id int not null,
	foreign key (endereco_id) references enderecos (id),
	primary key (id)
);

create table clientes (
	id int auto_increment,
	nome varchar(40),
	sexo varchar(20),
	renda float,
	rg varchar(10),
	data_nascimento date,
	email varchar(100),
	cpf varchar(11),
	endereco_id int,
	foreign key (endereco_id) references enderecos (id),
	primary key (id)
);

create table fornecedores (
	id int auto_increment,
	email varchar(100),
	nome varchar(100),
	fax varchar(100),
	telefone varchar(30) not null,
	inscricao_estadual varchar(200),
	inscricao_municipal varchar(200),
	representante varchar(100),
	observacao varchar(300),
	endereco_id int,
	foreign key (endereco_id) references enderecos (id),
	primary key (id)
);

create table caixas (
	id int auto_increment,
	data_abertura date,
	data_fechamento date,
	creditos float,
	debitos float,
	saldo_inicial float not null,
	saldo_final float,
	funcionario_id int,
	foreign key (funcionario_id) references funcionarios (id),
	primary key (id)
);

create table vendas (
	id int auto_increment,
	data date,
	subtotal float,
	desconto float,
	valor_pago float not null,
	valor_recebido float,
	troco float,
	cliente_id int,
	funcionario_id int,
	foreign key (cliente_id) references clientes (id),
	foreign key (funcionario_id) references funcionarios (id),
	primary key (id)
);

create table produtos (
	id int auto_increment,
	nome varchar(100),
	data date,
	marca varchar(40),
	preco_venda float,
	preco_compra float,
	quantidade float,
	fornecedor_id int not null,
	foreign key (fornecedor_id) references fornecedores (id),
	primary key (id)
);

create table vendas_produtos (
	id int auto_increment,
	valor_unitario int,
	valor_total int,
	quantidade int,
	venda_id int not null,
	produto_id int not null,
	foreign key (venda_id) references vendas (id),
	foreign key (produto_id) references produtos (id),
	primary key (id)
);

create table contas_receber (
	id int auto_increment,
	data date,
	desconto float,
	valor_total float,
	venda_id int,
	foreign key (venda_id) references vendas (id),
	primary key (id)
);

create table recebimentos (
	id int auto_increment,
	valor_total float,
	caixa_id int,
	conta_receber_id int,
	foreign key (caixa_id) references caixas (id),
	foreign key (conta_receber_id) references contas_receber (id),
	primary key (id)
);

create table pedidos (
	id int auto_increment,
	data date,
	primary key (id)
);

create table contas_pagar (
	id int auto_increment,
	data date,
	subtotal float,
	desconto float,
	valor_total float,
	pedido_id int,
	foreign key (pedido_id) references pedidos (id),
	primary key (id)
);

create table pagamentos (
	id int auto_increment,
	valor_total float,
	caixa int,
	funcionario_id int,
	conta_pagar_id int,
	foreign key (caixa) references caixas (id),
	foreign key (funcionario_id) references funcionarios (id),
	foreign key (conta_pagar_id) references contas_pagar (id),
	primary key (id)
);

create table pedidos_produtos (
	id int auto_increment,
	quantidade int,
	valor_unitario float,
	valor_total float,
	pedido_id int not null,
	produto_id int not null,
	foreign key (pedido_id) references pedidos (id),
	foreign key (produto_id) references produtos (id),
	primary key (id)
);
