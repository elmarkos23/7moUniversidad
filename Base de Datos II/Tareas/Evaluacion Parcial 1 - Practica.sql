--Nombre: Marco Ayala
-- Curso: 7mo A
--Evaluación Parcial 1 (Practica)
--DDL
create database EP1MarcoAyala
go
use EP1MarcoAyala
go

create table Estudiante(
IdEstudiante int Identity(1,1) not null,
Cedula nchar(10) not null,
Nombre varchar(20) not null,
Apellido varchar(20) not null,
FechaNacimiento date not null,
Direccion nchar(50),
constraint PK_IdEstudiante primary key clustered(idEstudiante),
constraint U_Cedula unique nonclustered(Cedula),
constraint CK_fechaNacimiento CHECK(FechaNacimiento>='19000101' AND FechaNacimiento<=GETDATE())-- mi criterio es que la fecha de nacimiento no deberia ser mayor a la fecha actual y que sea mayor a 1900
)
go

create table Materia(
IdMateria nchar(5) not null,
Nombre nchar(10) not null,
Descripcion nchar(10),
Activa bit not null,
constraint PK_Materia primary key clustered(IdMateria)
)
go

alter table Materia
add
constraint DF_Activa default(1) for Activa
go

create table Notas(
IdNota bigint not null,
IdEstudiante int not null,
IdMateria nchar(5) not null,
NumNota tinyint not null,
ValNota decimal(5,1) not null,
AsiNota decimal(5,1) not null,
EstNota varchar(15) not null,
constraint PK_Notas primary key clustered(IdNota),
constraint CK_NumNota check(NumNota>=1 AND NumNota<=4),
constraint CK_ValNota check(ValNota>'0.1' AND ValNota<=10),
constraint CK_AsiNota check(AsiNota>'0.1' AND AsiNota<='99.9'),
)
go

alter table Notas
add
constraint FK_Estudiante foreign key(IdEstudiante) references Estudiante(IdEstudiante),
constraint FK_Materia foreign key(IdMateria) references Materia(IdMateria) ON UPDATE CASCADE

--DML
insert into Estudiante values('1721481586','Marco','Ayala','19900323','Quito')

select *
from Estudiante

insert into Materia values ('BDD01','BASE DATOS','VIRTUAL',1)

select * from Materia

insert into Notas values (123456,1,'BDD01',1,2,2,'APROBADO')

select * from Notas

update Materia set
IdMateria='BDD02'
where IdMateria='BDD01'

--consultamos de nuevo y ahora ya tiene el nuevo id en la tabla notas
select * from Notas
