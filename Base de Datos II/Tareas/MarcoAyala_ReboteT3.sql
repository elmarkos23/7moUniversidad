CREATE DATABASE CAMPEONATO
GO
USE CAMPEONATO
GO

CREATE TABLE Equipo(
	IdEquipo varchar(10) NOT NULL,
	NomEquipo varchar(50) NOT NULL,
	FecCreaEquipo date,
	EstEquipo bit CONSTRAINT DF_EQUIPO_ESTADO default(1),
	EmaEquipo varchar(50) NULL,
 CONSTRAINT PK_Equipo PRIMARY KEY CLUSTERED(IdEquipo),
 CONSTRAINT U_EQUIPO_NOM_EQUIPO UNIQUE NONCLUSTERED(NomEquipo),
 CONSTRAINT CK_EQUIPO_FECHA_CREACION CHECK(FecCreaEquipo < getdate()),
 CONSTRAINT U_EQUIPO_EMAIL UNIQUE NONCLUSTERED(EmaEquipo),
) 
GO

CREATE TABLE Jugador(
	IdJugador int IDENTITY(1,1) NOT NULL,
	IdEquipo varchar(10) NOT NULL,
	NomJugador varchar(30) NOT NULL,
	FecNacJugador date NOT NULL,
	CedJugador varchar(10) NULL,
	CiuJugador varchar(50) NULL,
	EstJugador bit NULL,
	EmaJugador varchar(50) NULL,
 
) 
GO

--ADD RESTRICCIONES 
ALTER TABLE Jugador
ADD
CONSTRAINT PK_JUGADOR PRIMARY KEY CLUSTERED (IdJugador),
CONSTRAINT CK_JUGADOR_FEC_NAC_JUGADOR CHECK(FecnacJugador>=dateadd(year,-35,getdate()) and  FecnacJugador<=dateadd(year,-18,getdate())),
CONSTRAINT U_JUGADOR UNIQUE NONCLUSTERED(CedJugador),
CONSTRAINT DF_JUGADOR_CIUDAD DEFAULT('*POR CONFIRMAR*') FOR CiuJugador,
CONSTRAINT U_EMAJUGADOR UNIQUE NONCLUSTERED(EmaJugador),
CONSTRAINT DF_ESTADO_JUGADOR DEFAULT(1) FOR EstJugador,
CONSTRAINT FK_JUGADR_EQUIPO FOREIGN KEY(IdEquipo) REFERENCES Equipo(IdEquipo) ON UPDATE CASCADE
GO

