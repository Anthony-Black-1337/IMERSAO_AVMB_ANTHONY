create table livros
(
	ISBN int CONSTRAINT pk_isbn_livros PRIMARY KEY,
	Titulo varchar(50) NOT NULL,
	Autor_Nacioalidade varchar(50) NOT NULL,
	Editora varchar(30) NOT NULL,
	Ano integer,
	Categoria varchar(30) NOT NULL
);

Insert into livros values (123456789, 'Abacate', 'Zeca(Inglaterra)','Pindaiba',2009,'ACAO');
Insert into livros values (681751943, 'Maracuja', 'Paulo(Portugal)','Leupoudo',2008,'AVENTURA');
Insert into livros values (126476768, 'Mausoleu', 'Maria(Marte)','Arco',2006,'DRAMA');
Insert into livros values (123425778, 'Ferrou', 'Abreu(Argentina)','Assis',2003,'AMOR');
Insert into livros values (121316878, 'AVMB', 'Felipe(EUA)','Nao sei',2004,'ACAO');
Insert into livros values (514614572, 'Chinguiling', 'Chico(Jeck Chan)','Pindaiba',2001,'COMEDIA');
Insert into livros values (879725145, 'Frutas', 'Mars(Venus)','Lotus',2056,'DRAMA');

select * from livros