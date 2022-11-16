/* Modelo3_Logico: */

CREATE TABLE DINOSSAURO (
    Nome_Dino VARCHAR PRIMARY KEY,
    Toneladas FLOAT,
    Data_Descoberto DATE,
    Nome_Descobridor VARCHAR,
    Pais_Descoberto VARCHAR,
    FK_ERA_Nome_Era VARCHAR,
    FK_GRUPO_Nome_Grupo VARCHAR
);

CREATE TABLE ERA (
    Nome_Era VARCHAR PRIMARY KEY,
    Ano_Inicial DATE,
    Ano_Final DATE
);

CREATE TABLE GRUPO (
    Nome_Grupo VARCHAR PRIMARY KEY
);
 
ALTER TABLE DINOSSAURO ADD CONSTRAINT FK_DINOSSAURO_2
    FOREIGN KEY (FK_ERA_Nome_Era)
    REFERENCES ERA (Nome_Era)
    ON DELETE RESTRICT;
 
ALTER TABLE DINOSSAURO ADD CONSTRAINT FK_DINOSSAURO_3
    FOREIGN KEY (FK_GRUPO_Nome_Grupo)
    REFERENCES GRUPO (Nome_Grupo)
    ON DELETE RESTRICT;



Insert into ERA values ('MESOSOICA','1645-02-02','1745-02-02');
Insert into ERA values ('PALOICA','1745-02-02','1845-02-02');
Insert into ERA values ('VELOICA','1845-02-02','1945-02-02');
Insert into ERA values ('ALOICA','1945-02-02','2000-02-02');

select * from ERA

Insert into GRUPO values ('PREDADORES');
Insert into GRUPO values ('ERBIVAROS');
Insert into GRUPO values ('ONIVAROS');

select * from GRUPO

Insert into DINOSSAURO values ('CACAU', 120.56, '1946-11-10','Anthony Silva','Brasil','MESOSOICA','PREDADORES');
Insert into DINOSSAURO values ('PITERODATICO', 180.56, '2004-11-10','Diego Silva','Argentina','ALOICA','ERBIVAROS');
Insert into DINOSSAURO values ('VELOCIRAPTOR', 50.56, '2005-11-10','Joao Silva','Franca','VELOICA','PREDADORES');
Insert into DINOSSAURO values ('ESQUISOFRANICO', 520.56, '2001-01-02','Alabama Silva','Mangolia','PALOICA','ONIVAROS');

select * from DINOSSAURO

SELECT * FROM DINOSSAURO ORDER BY Nome_Dino;

SELECT * FROM DINOSSAURO ORDER BY Nome_Descobridor;

SELECT FK_GRUPO_Nome_Grupo,Data_Descoberto  
FROM DINOSSAURO
WHERE
ORDER BY Data_Descoberto;

