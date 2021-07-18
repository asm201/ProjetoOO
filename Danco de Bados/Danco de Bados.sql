CREATE TABLE usuario (
	u_id INTEGER NOT NULL auto_increment PRIMARY KEY,
	u_cpf VARCHAR(15) NOT NULL,
    u_rg VARCHAR(12) NOT NULL,
	u_senha VARCHAR(30) NOT NULL,
	u_nome VARCHAR(100) NOT NULL,
	u_id_funcionario INTEGER, -- FOREIGN KEY -> "funcionario"
	u_id_cliente INTEGER, -- FOREIGN KEY -> "cliente"
	u_ctt_id INTEGER
);
CREATE TABLE contato(
	ctt_id INTEGER NOT NULL auto_increment PRIMARY KEY,
    ctt_id_usuario INTEGER, -- FOREIGN KEY -> "cliente"
	ctt_tel VARCHAR(20),
	ctt_cel VARCHAR(20),
	ctt_email VARCHAR(100)
);
CREATE TABLE cliente(
	c_id INTEGER NOT NULL auto_increment PRIMARY KEY,
    c_id_usuario INTEGER NOT NULL, -- FOREIGN KEY -> "cliente"
	c_profissao VARCHAR(50)
);
CREATE TABLE conta_bancaria(
	cb_id INT NOT NULL auto_increment PRIMARY KEY,
	cb_agencia INT,
	cb_id_cliente INT, -- FOREIGN KEY -> "cliente"
	cb_id_conta_corrente INT, -- FOREIGN KEY -> "conta_corrente"
	cb_id_conta_poupanca INT -- FOREIGN KEY -> "conta_poupança"
);
CREATE TABLE conta_corrente( -- Herda Conta Bancária
	cc_id INTEGER NOT NULL auto_increment PRIMARY KEY,
	cc_id_conta_bancaria INTEGER, -- FOREIGN KEY -> "conta_bancaria"
	cc_nr_conta_corrente INTEGER,
	cc_saldo FLOAT
);
CREATE TABLE conta_poupanca( -- Herda Conta Bancaria
	cp_id INTEGER NOT NULL auto_increment PRIMARY KEY,
	cp_id_conta_bancaria INTEGER, -- FOREIGN KEY -> "conta_bancaria"
	cp_nr_conta_poupanca INTEGER,
	cp_valor FLOAT
);
CREATE TABLE funcionario(
	f_id INTEGER NOT NULL auto_increment PRIMARY KEY,
    f_id_usuario INTEGER NOT NULL, -- FOREIGN KEY -> "usuario"
	f_salario FLOAT NOT NULL,
	f_departamento VARCHAR(100),
	f_funcao VARCHAR(20),
    f_id_gerente INTEGER, -- FOREIGN KEY -> "gerente"
    f_id_diretor INTEGER -- FOREIGN KEY -> "diretor"
);
CREATE TABLE gerente(
	g_id INTEGER NOT NULL auto_increment PRIMARY KEY, 
    g_id_funcionario INTEGER NOT NULL -- FOREIGN KEY -> "funcionario"
);
CREATE TABLE desenvolvedor(
	de_id INTEGER NOT NULL auto_increment PRIMARY KEY,
    de_id_funcionario INTEGER NOT NULL -- FOREIGN KEY -> "funcionario"
);
CREATE TABLE diretor(
	di_id INTEGER NOT NULL auto_increment PRIMARY KEY,
    di_id_funcionario INTEGER NOT NULL -- FOREIGN KEY -> "funcionario"
);
CREATE TABLE estagiario(
	e_id INTEGER NOT NULL auto_increment PRIMARY KEY,
    e_id_funcionario INTEGER NOT NULL -- FOREIGN KEY -> "funcionario"
);

ALTER TABLE usuario
ADD FOREIGN KEY (u_id_cliente) REFERENCES cliente(c_id);
ALTER TABLE usuario
ADD FOREIGN KEY (u_id_funcionario) REFERENCES funcionario(f_id);
ALTER TABLE usuario
ADD FOREIGN KEY (u_ctt_id) REFERENCES contato(ctt_id);
ALTER TABLE contato
ADD FOREIGN KEY (ctt_id_usuario) REFERENCES usuario(u_id);
ALTER TABLE cliente
ADD FOREIGN KEY (c_id_usuario) REFERENCES usuario(u_id);
ALTER TABLE conta_bancaria
ADD FOREIGN KEY (cb_id_cliente) REFERENCES cliente(c_id);
ALTER TABLE conta_bancaria
ADD FOREIGN KEY (cb_id_conta_corrente) REFERENCES conta_corrente(cc_id);
ALTER TABLE conta_bancaria
ADD FOREIGN KEY (cb_id_conta_poupanca) REFERENCES conta_poupanca(cp_id);
ALTER TABLE conta_corrente
ADD FOREIGN KEY (cc_id_conta_bancaria) REFERENCES conta_bancaria(cb_id);
ALTER TABLE conta_poupanca
ADD FOREIGN KEY (cp_id_conta_bancaria) REFERENCES conta_bancaria(cb_id);
ALTER TABLE funcionario
ADD FOREIGN KEY (f_id_usuario) REFERENCES usuario(u_id);
ALTER TABLE funcionario
ADD FOREIGN KEY (f_id_gerente) REFERENCES gerente(g_id);
ALTER TABLE funcionario
ADD FOREIGN KEY (f_id_diretor) REFERENCES diretor(di_id);
ALTER TABLE gerente
ADD FOREIGN KEY (g_id_funcionario) REFERENCES funcionario(f_id);
ALTER TABLE desenvolvedor
ADD FOREIGN KEY (de_id_funcionario) REFERENCES funcionario(f_id);
ALTER TABLE diretor
ADD FOREIGN KEY (di_id_funcionario) REFERENCES funcionario(f_id);
ALTER TABLE estagiario
ADD FOREIGN KEY (e_id_funcionario) REFERENCES funcionario(f_id);