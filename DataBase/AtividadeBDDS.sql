#Alunos: Filipe Maciel, Gabriel Maturana Teixeira, Thamiris Maria Souza de Oliveira, Maria Eduarda Braz, Natália da Silva Fernandes
#Turma: 3B


drop database FAD;
create database FAD;
use  FAD;

create table Endereco (
id_end  int not null primary key auto_increment,
logradouro_end varchar (100),
numero_end  varchar (10),
bairro_end  varchar (100),
cep_end  varchar(10)
);

create table Funcionario (
id_Func int not null primary key auto_increment,
rg_func varchar (10),
cpf_func varchar (8),
nome_func varchar (100),
sexo_func varchar (20),
dat_nasc_func date,
ctps_func varchar (10),
pis_pasep_func varchar (10),
id_End_fk int not null, 
foreign key (id_End_fk) references Endereco (id_End)
);

create table cliente (
id_cli int not null primary key auto_increment,
sexo_cli varchar (20),
nome_razao_social_cliente varchar (100),
renda_cli float,
rg_cli varchar (10),
dat_nas_cli date,
email varchar (150),
cpf_cnpj_cli varchar (20),
id_Endereco_fk int not null,
foreign key (id_Endereco_fk) references Endereco (id_End)
);

Create table fornecedor(
Id_Forn int primary key not null auto_increment,
Id_end_fk int NOT NULL,
Email_Forn  varchar(200),
RazãoSocial_Nome_forn varchar(100),
Fax_Forn  varchar(100),
Telefone_Forn  varchar(100) NOT NULL,
Inscrição_Estadual_Forn  varchar(200),
Inscrição_Munipal_Forn  varchar(200),
Contato_Representante_Forn  varchar(200),
Tipo_contribuinte_Forn  varchar(200),
Observacao_Forn  varchar(200),
foreign key (Id_end_fk) references endereco(id_end)
);

Create table Caixa(
Id_Caixa int primary key not null auto_increment,
DataAbertura_caixa date,
DataFechamento_caixa date,
Creditos_caixa float,
debitos_caixa float,
SaldoInicial_caixa float NOT NULL,
saldoFinal_caixa float,
id_func_fk int,
foreign key (id_func_fk) references Funcionario(id_func)
);

Create table Venda(
Id_Vend int primary key not null auto_increment,
Data_Vend date,
Subtotal_Vend float,
Desconto_Vend float,
Troco_Vend float,
Valor_Total_Vend float not null,
FormaPag_Vend varchar(200),
Qtd_parcelas_Vend int not null,
Id_cli_fk int NOT NULL,
id_func_fk int not null,
foreign key (Id_cli_fk) references Cliente (id_cli),
foreign key (id_func_fk) references Funcionario (id_func)
);

#////////
create table Produto(
id_prod int primary key not null auto_increment,
descricao_prod varchar (200),
tipo_prod varchar(200),
preco_prod float,
quantidade_prod float,
id_forn_fk int not null,
foreign key (id_forn_fk) references Fornecedor (id_forn)
);

create table Venda_Produto(
id_vend_prod int primary key not null auto_increment,
id_vend_fk int not null,
id_prod_fk int not null,
QTD_vend_prod int,
valorUnitario__vend_prod int,
valorTotal__vend_prod float,
foreign key (id_vend_fk)references Venda (id_vend),
foreign key (id_prod_fk)references Produto(id_prod)
);

create table Conta_A_Receber(
id_cont_receb int primary key not null auto_increment,
data_cont_receb date,
desconto_cont_receb float,
valorTotal__cont_receb float,
id_vend_fk int,
foreign key (id_vend_fk)references venda(id_vend)
);
#////////

create table recebimento (
id_receb int not null primary key auto_increment,
valor_total float,
fk_caixa int not null,
foreign key (fk_caixa) references caixa (id_caixa) ,
id_cont_receb_fk int not null,
foreign key (id_cont_receb_fk) references conta_a_receber (id_cont_receb)
);

create table pedido (
id_ped int not null primary key auto_increment,
data_ped date
);

#///////////
create table Conta_A_Pagar(
id_cont_a_pagar int primary key not null auto_increment,
data_cont_a_pagar date,
subtotal_cont_a_pagar float,
desconto_cont_a_pagar float,
valorTotal_cont_a_pagar float,
id_ped_fk int,
foreign key (id_ped_fk) references Pedido (id_ped)
);

create table Pagamento(
id_pag int primary key not null auto_increment,
valorTotal_pag float,
id_caixa_fk int,
id_func_fk int,
id_cont_pagar_fk int,
foreign key (id_caixa_fk) references caixa(id_caixa),
foreign key (id_func_fk) references Funcionario(id_func),
foreign key (id_cont_pagar_fk) references conta_a_pagar(id_cont_a_pagar)
);


create table pedido_produto (
id_ped_prod int not null primary key auto_increment,
qtd_ped_prod int,
val_unit_ped_prod float,
val_tot_ped_prod float,
id_ped_fk int not null,
foreign key (id_ped_fk) references pedido (id_ped),
id_prod_fk int not null,
foreign key (id_prod_fk) references produto (id_prod)
);
  
DELIMITER $$
CREATE PROCEDURE inserirEndereco( logradouro varchar (100), numero varchar (10), bairro varchar (100), cep  varchar(10))
BEGIN
		insert into Endereco values (null, logradouro, numero, bairro, cep);
       select "Resgistro inserido com sucesso" as confirmação;
  
END;
$$ DELIMITER ;

drop PROCEDURE inserirFuncionario;
DELIMITER $$
CREATE PROCEDURE inserirFuncionario(rg varchar (10), cpf varchar (8), nome varchar (100), sexo  varchar (20), dat_nasc date, ctps varchar (10), pis_pasep varchar (10))
BEGIN

insert into funcionario values ( null, rg, cpf, nome, sexo, dat_nasc, ctps, pis_pasep);
select 'O funcionário foi cadastrado com Sucesso!' as Confirmação;

END;
$$ DELIMITER ;


DELIMITER $$
CREATE PROCEDURE inserirfornecedor(Email varchar(200), RazãoSocial_Nome varchar(100), Fax varchar(100), Telefone varchar(100), Inscrição_Estadual varchar(200), Inscrição_Munipal  varchar(200), Contato_Representante  varchar(200), Tipo_contribuinte  varchar(200), Observacao varchar(200))
BEGIN
	insert into fornecedor values ( null,null, Email, cpf, nome, sexo, dat_nasc, ctps, pis_pasep, null);
	select 'O funcionário foi cadastrado com Sucesso!' as Confirmação;
END;
$$ DELIMITER ;

delimiter $$
create procedure inserirCaixa (DataAbertura date, DataFechamento date, Creditos float, debitos float, SaldoInicial float, saldoFinal float)
begin

insert into caixa values (null, DataAbertura , DataFechamento, Creditos, debitos, SaldoInicial, saldoFinal, null);
select 'Caixa inserido com Sucesso!' as Confirmação;

end;
$$ delimiter ;






