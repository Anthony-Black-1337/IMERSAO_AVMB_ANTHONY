/*Exercicio 1
CREATE TABLE livro
(
	ID_livro integer CONSTRAINT pk_id_livro PRIMARY KEY,
	Nome varchar(30),
	Autor varchar(30),
	Edicao integer,
	Categoria varchar(30)
	
);*/
/*Exercicio 2
CREATE TABLE Veiculo
(
	Num_chassis varchar(17) CONSTRAINT pk_num_chassis PRIMARY KEY,
	Modelo varchar(30),
	Fabricante varchar(30),
	Placa varchar(7),
	Numero_Eixos int,
	Cor varchar(30),
	Categoria varchar(30)
	
);*/
/*Exercicio 3
DROP TABLE Veiculo
ALTER TABLE Veiculo
DROP DATABASE Aula01
*/
/*Exercicio 4

CREATE TABLE tbl_autores
(
	ID_Autor integer CONSTRAINT pk_id_autor PRIMARY KEY
);

CREATE TABLE tbl_livros 
(
	ID_Livro SERIAL CONSTRAINT pk_id_livros PRIMARY KEY,
	Nome_Livro varchar(50) NOT NULL,
	Autor integer NOT NULL,
	Editora integer NOT NULL,
	Data_Pub date,
	Genero integer NOT NULL,
	Preco_Livro money,
	FOREIGN KEY (Autor) REFERENCES tbl_autores (ID_Autor)
);*/

/*Exercicio 5

ALTER TABLE tbl_livros ADD COLUMN ISBN int NOT NULL

*/
/*Exercicio 6

ALTER TABLE  veiculo DROP COLUMN cor

*/
/*Exercicio 7
ALTER TABLE tbl_livros ALTER COLUMN ISBN type varchar(25) 

ALTER TABLE tbl_livros ALTER COLUMN ISBN set NOT NULL

*/ 
/*Exercicio 8
Insert into contatos values ('Sherlock Holmes', 'abacate@gmail.com', '2022-11-10',51998840861);
*/

select * from contatos











