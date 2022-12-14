/* Exercicios_Livro2_Logico: */
CREATE DATABASE BIBLIOTECA_CT
CREATE TABLE AUTOR (
    ID INTEGER UNIQUE,
    NOME VARCHAR,
    NACIONALIDADE VARCHAR
);
 
ALTER TABLE AUTOR ADD CONSTRAINT ID PRIMARY KEY (ID);

CREATE TABLE LIVRO (
    ISBN INTEGER PRIMARY KEY UNIQUE,
    TITULO VARCHAR,
    ANO_PUBLICADO DATE,
    fk_EDITORA VARCHAR,
    fk_CATEGORIA VARCHAR
);

CREATE TABLE LIVROAUTOR (
    ID INTEGER PRIMARY KEY UNIQUE,
    fk_LIVRO VARCHAR,
    fk_AUTOR VARCHAR
);

CREATE TABLE EDITORA (
    ID INTEGER PRIMARY KEY UNIQUE,
    NOME VARCHAR
);

CREATE TABLE CATEGORIA (
    ID INTEGER PRIMARY KEY,
    TIPO_CATEGORIA VARCHAR,
    FK_CATEGORIA_TIPO_CATEGORIA VARCHAR,
    UNIQUE (TIPO_CATEGORIA, ID)
);
 
ALTER TABLE LIVRO ADD CONSTRAINT FK_LIVRO_3
    FOREIGN KEY (fk_EDITORA???, fk_CATEGORIA)
    REFERENCES ??? (???);
 
ALTER TABLE LIVROAUTOR ADD CONSTRAINT FK_LIVROAUTOR_3
    FOREIGN KEY (fk_LIVRO???, fk_AUTOR???)
    REFERENCES ??? (???);
 
ALTER TABLE CATEGORIA ADD CONSTRAINT FK_CATEGORIA_3
    FOREIGN KEY (FK_CATEGORIA_TIPO_CATEGORIA, ???)
    REFERENCES CATEGORIA (TIPO_CATEGORIA, ???);