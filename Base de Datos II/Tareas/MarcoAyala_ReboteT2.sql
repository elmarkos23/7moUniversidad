CREATE DATABASE CAMPEONATO
GO
USE CAMPEONATO
GO

CREATE TABLE Jugador
(
	IdJugador int not null,
	IdEquipo varchar(10) not null,
	NomJugador varchar(30) not null,
	FecNacJugador date not null,
	CedJugador varchar(10),
	CiuJugador varchar(50),
	EstJugador bit,
	EmaJugador varchar(50)
)
GO

CREATE TABLE Equipo
(
	IdEquipo varchar(10) not null,
	NomEquipo  varchar(50) not null,
	FecCreaEquipo date,
	EstEquipo bit,
	EmaEquipo varchar(50)
)
GO

ALTER TABLE Equipo
ADD CONSTRAINT PK_Equipo primary key clustered(IdEquipo)
GO

ALTER TABLE Jugador
ADD
CONSTRAINT FK_Jugador_Equipo foreign key(IdEquipo) references Equipo(IdEquipo),
CONSTRAINT PK_Jugador primary key clustered(IdJugador)
GO