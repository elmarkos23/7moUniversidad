create function NotasCalcularEstado
(@Nota decimal(2,1), @Asistencia decimal(3,2))
returns varchar(15)
as
begin
declare @estado varchar(15)
if....
else


return @estado
end


create procedure sp_InsertarNotas
(@IdEstudiate int,
@IdMateria nchar(5),
@NumNota tinyint,
@valNota decimal(2,1),
@valAsis decimal(3,2))
as
begin
begin try
declare @estado varchar(15)
select @estado=dbo.NotasCalcularEstado(@valNota,@valAsis)
insert into notas(...)
values(@IdEstudiate,@IdMateria,@NumNota,@valNota,@valAsis,@estado)
end try
begin catch
---error
end catch

end


create procedure sp_ActualizarNotas
(@IdEstudiate int,
@IdMateria nchar(5),
@NumNota tinyint,
@valNota decimal(2,1),
@valAsis decimal(3,2))
as
begin
begin try
declare @estado varchar(15)
select @estado=dbo.NotasCalcularEstado(@valNota,@valAsis)

update notas
set valNota=@valNota, valAsis=@valAsis, EstNota=@estado
where IdEstudiate=@IdEstudiate
and IdMateria=@IdMateria and NumNota=@NumNota
end try
begin catch
---error
end catch

end

