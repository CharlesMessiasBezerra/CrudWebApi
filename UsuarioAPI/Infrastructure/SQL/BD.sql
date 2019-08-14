
CREATE DATABASE HAWKSOFTWARES
GO
USE HAWKSOFTWARES
GO

CREATE  TABLE TAB_ESTADOS 
(
  ID INT IDENTITY,
  NOME_ESTADO VARCHAR(300),
  ABREVIACAO VARCHAR(3),
  PRIMARY KEY (ID)    
)

CREATE  TABLE TAB_CIDADES 
(
  ID INT IDENTITY,
  NOME_CIDADE VARCHAR(300),
  IDESTADO INT,
  PRIMARY KEY (ID),
    FOREIGN KEY (IDESTADO) REFERENCES TAB_ESTADOS(ID)
)
GO
CREATE TABLE TAB_USUARIOS 
(
  ID INT IDENTITY,
  NOME VARCHAR(300),
  IDADE INT,
  SEXO CHAR(1),
  IDCIDADE INT,
  PRIMARY KEY (ID),
  FOREIGN KEY (IDCIDADE) REFERENCES TAB_CIDADES(ID)
)


INSERT INTO  TAB_ESTADOS (NOME_ESTADO, ABREVIACAO)
VALUES ('S�O PAULO', 'SP')

GO

INSERT INTO  TAB_ESTADOS (NOME_ESTADO, ABREVIACAO)
VALUES ('MINAS GERAIS', 'MG')

GO
INSERT INTO  TAB_ESTADOS (NOME_ESTADO, ABREVIACAO)
VALUES ('RIO DE JANEIRO', 'RJ')

GO
INSERT INTO TAB_CIDADES (NOME_CIDADE,IDESTADO )
VALUES ('SERRANA', 1)

GO
INSERT INTO TAB_CIDADES (NOME_CIDADE,IDESTADO )
VALUES ('RIBEIR�O PRETO', 1)

GO
INSERT INTO TAB_CIDADES (NOME_CIDADE,IDESTADO )
VALUES ('CAJURU', 1)
GO

INSERT INTO TAB_USUARIOS (NOME,IDADE,SEXO,IDCIDADE)
VALUES ('CHARLES',30, 'M',1)
GO

INSERT INTO TAB_USUARIOS (NOME,IDADE,SEXO,IDCIDADE)
VALUES ('JOAO',20, 'M',1)
GO 
INSERT INTO TAB_USUARIOS (NOME,IDADE,SEXO,IDCIDADE)
VALUES ('MARIA',20, 'F',2)
GO 
INSERT INTO TAB_USUARIOS (NOME,IDADE,SEXO,IDCIDADE)
VALUES ('PEDRO',25, 'M',3)
GO
SELECT * FROM TAB_ESTADOS
SELECT * FROM TAB_CIDADES
SELECT * FROM TAB_USUARIOS