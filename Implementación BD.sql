create database ProyectoFinalDCU
GO
use ProyectoFinalDCU
GO
---- Creación de tablas
Drop table if exists Estudiantes
GO
Create table Estudiantes(
idEstudiante int identity(1,1),
Nombre varchar(50),
Apellido varchar(50),
Edad int,
Matricula varchar(50) unique,
Telefono varchar(50) unique,
Direccion varchar(100) unique,
email varchar(50) unique,
Usuario varchar(50) unique,
Contraseña varchar(50),
Curso int
)
GO
Drop table if exists Maestros
GO
Create table Maestros(
idMaestro int identity(1,1),
Nombre varchar(50),
Apellido varchar(50),
Edad int,
Telefono varchar(50) unique,
Direccion varchar(100) unique,
email varchar(50) unique,
Usuario varchar(50) unique,
Contraseña varchar(50),
)
GO
Drop table if exists Directores
GO
Create table Directores(
idDirector int identity(1,1),
Nombre varchar(50),
Apellido varchar(50),
Edad int,
Telefono varchar(50) unique,
Direccion varchar(100) unique,
email varchar(50) unique,
Usuario varchar(50) unique,
Contraseña varchar(50),
)
GO
Drop table if exists Cursos
GO
Create table Cursos(
idCurso int identity(1,1),
Nombre varchar(50),
idMaestro int
)
GO
Drop table if exists Calificaciones
GO
Create table Calificaciones(
idCalificacion int identity(1,1),
idCurso int,
idEstudiante int,
notaFinal int
)
GO
-- Restricciones
alter table Estudiantes add 
	primary key(idEstudiante)
GO
alter table Maestros add 
	primary key(idMaestro)
GO
alter table Directores add 
	primary key(idDirector)
GO
alter table Cursos add 
	primary key(idCurso)
GO
alter table Calificaciones add 
	primary key(idCalificacion)
GO
alter table Estudiantes add 
	foreign key(Curso) references Cursos(idCurso)
GO
alter table Cursos add 
	foreign key(idMaestro) references Maestros(idMaestro)
GO
alter table Calificaciones add 
	foreign key(idCurso) references Cursos(idCurso)
GO
alter table Calificaciones add 
	foreign key(idEstudiante) references Estudiantes(idEstudiante)
GO
-- Procedimientos Almacenados
-- Tabla Estudiantes
CREATE PROCEDURE SpEstudiantesInsertar
@Nombre AS VARCHAR(50),
@Apellido AS VARCHAR(50),
@Edad AS INT,
@Matricula AS VARCHAR(50),
@Telefono AS VARCHAR(50),
@Direccion AS VARCHAR(100),
@email AS VARCHAR(50),
@Usuario AS VARCHAR(50),
@Contraseña AS VARCHAR(50),
@Curso AS INT
AS
BEGIN
INSERT INTO Estudiantes (Nombre,Apellido,Edad,Matricula,Telefono,Direccion,email,Usuario,Contraseña,Curso)
VALUES (@Nombre,@Apellido,@Edad,@Matricula,@Telefono,@Direccion,@email,@Usuario,@Contraseña,@Curso)
END
GO
CREATE PROCEDURE SpEstudiantesActualizar
@idEstudiante AS INT,
@Nombre AS VARCHAR(50),
@Apellido AS VARCHAR(50),
@Edad AS INT,
@Matricula AS VARCHAR(50),
@Telefono AS VARCHAR(50),
@Direccion AS VARCHAR(100),
@email AS VARCHAR(50),
@Usuario AS VARCHAR(50),
@Contraseña AS VARCHAR(50),
@Curso AS INT
AS
BEGIN
UPDATE Estudiantes
SET Nombre = @Nombre,
Apellido = @Apellido,
Edad = @Edad,
Matricula = @Matricula,
Telefono = @Telefono,
Direccion = @Direccion,
email = @email,
Usuario = @Usuario,
Contraseña = @Contraseña,
Curso = @Curso
WHERE idEstudiante = @idEstudiante
END
GO

CREATE PROCEDURE SpEstudiantesEliminar
@Usuario AS VARCHAR(50)
AS
BEGIN
DELETE FROM Estudiantes
WHERE Usuario = @Usuario
END
GO
CREATE PROCEDURE SpEstudiantesListar
AS
BEGIN
SELECT idEstudiante,
Nombre,
Apellido,
Edad,
Matricula,
Telefono,
Direccion,
email,
Usuario,
Contraseña,
Curso
FROM Estudiantes
END
GO
-- Tabla Maestros
CREATE PROCEDURE SpMaestrosInsertar
@Nombre AS VARCHAR(50),
@Apellido AS VARCHAR(50),
@Edad AS INT,
@Telefono AS VARCHAR(50),
@Direccion AS VARCHAR(100),
@email AS VARCHAR(50),
@Usuario AS VARCHAR(50),
@Contraseña AS VARCHAR(50)
AS
BEGIN
INSERT INTO Maestros (Nombre,Apellido,Edad,Telefono,Direccion,email,Usuario,Contraseña)
VALUES (@Nombre,@Apellido,@Edad,@Telefono,@Direccion,@email,@Usuario,@Contraseña)
END
GO

CREATE PROCEDURE SpMaestrosActualizar
@idMaestro AS INT,
@Nombre AS VARCHAR(50),
@Apellido AS VARCHAR(50),
@Edad AS INT,
@Telefono AS VARCHAR(50),
@Direccion AS VARCHAR(100),
@email AS VARCHAR(50),
@Usuario AS VARCHAR(50),
@Contraseña AS VARCHAR(50)
AS
BEGIN
UPDATE Maestros
SET Nombre = @Nombre,
Apellido = @Apellido,
Edad = @Edad,
Telefono = @Telefono,
Direccion = @Direccion,
email = @email,
Usuario = @Usuario,
Contraseña = @Contraseña
WHERE idMaestro = @idMaestro
END
GO

CREATE PROCEDURE SpMaestrosEliminar
@Usuario AS VARCHAR(50)
AS
BEGIN
DELETE FROM Maestros
WHERE Usuario = @Usuario
END
GO

CREATE PROCEDURE SpMaestrosListar
AS
BEGIN
SELECT idMaestro,
Nombre,
Apellido,
Edad,
Telefono,
Direccion,
email,
Usuario,
Contraseña
FROM Maestros
END
GO
-- Tabla Cursos
CREATE PROCEDURE SpCursosInsertar
@Nombre AS VARCHAR(50),
@idMaestro AS INT
AS
BEGIN
INSERT INTO Cursos (Nombre,idMaestro)
VALUES (@Nombre,@idMaestro)
END
GO

CREATE PROCEDURE SpCursosActualizar
@idCurso AS INT,
@Nombre AS VARCHAR(50),
@idMaestro AS INT
AS
BEGIN
UPDATE Cursos
SET Nombre = @Nombre,
idMaestro = @idMaestro
WHERE idCurso = @idCurso
END
GO

CREATE PROCEDURE SpCursosEliminar
@IdCurso AS INT
AS
BEGIN
DELETE FROM Cursos
WHERE IdCurso = @IdCurso
END
GO
drop procedure SpCursosListar
AS
BEGIN
SELECT idCurso,
c.Nombre,
c.idMaestro,
CONCAT(m.Nombre, ' ', m.Apellido) AS 'Nombre Profesor'
FROM Cursos c inner join Maestros m on (c.idMaestro = m.idMaestro)
END
GO
-- Tabla Calificaciones
CREATE PROCEDURE SpCalificacionesInsertar
@idCurso AS INT,
@idEstudiante AS INT,
@notaFinal AS INT
AS
BEGIN
INSERT INTO Calificaciones (idCurso,idEstudiante,notaFinal)
VALUES (@idCurso,@idEstudiante,@notaFinal)
END
GO
CREATE PROCEDURE SpCalificacionesActualizar
@idCalificacion AS INT,
@notaFinal AS INT
AS
BEGIN
UPDATE Calificaciones
SET notaFinal = @notaFinal
WHERE idCalificacion = @idCalificacion
END
GO

CREATE PROCEDURE SpCalificacionesEliminar
@IdCalificacion AS INT
AS
BEGIN
DELETE FROM Calificaciones
WHERE IdCalificacion = @IdCalificacion
END
GO
CREATE PROCEDURE SpCalificacionesListar
@idMaestro int
AS
BEGIN
SELECT c.idCalificacion,
concat(e.nombre, ' ', e.Apellido) as 'Nombre',
e.Matricula,
cu.Nombre as 'Curso',
notaFinal
FROM Calificaciones c inner join Cursos cu on (c.idCurso = cu.idCurso)
inner join Estudiantes e on (c.idEstudiante = e.idEstudiante)
where cu.idMaestro = @idMaestro
END
GO
-- Para form estudiantes: curso, maestro, Calificación
CREATE PROCEDURE spCalificacionesEstudiantes
@idEstudiante int
AS
BEGIN
SELECT c.nombre as 'Curso',
concat(m.Nombre, ' ', m.Apellido) as 'Docente',
ca.notaFinal as 'Calificación'
FROM Calificaciones ca inner join Cursos c on (ca.idCurso = c.idCurso)
inner join Maestros m on (c.idMaestro = m.idMaestro) where (ca.idEstudiante = @idEstudiante)
END
GO
-- Trigger para poner registro de estudiante en calificación
Create trigger trg_ins_estudiante_calificacion on Estudiantes
After insert
as
begin
	declare @idEstudiante int
	declare @idCurso int

	declare cDatos cursor for
		select i.idEstudiante,i.Curso from inserted i

	open cDatos
	while 1=1
	begin

		fetch next from cDatos into @idEstudiante,@idCurso
		if @@FETCH_STATUS!=0
		begin
			break
		end

		insert into Calificaciones
		values(@idCurso, @idEstudiante, 0)
	end

	close cDatos
	deallocate cDatos
end
GO
-- Para form Maestros: curso, Cantidad de estudiante
CREATE PROCEDURE spCursosMaestros
@idMaestro int
AS
BEGIN
declare @nombreCurso varchar(100)
declare @idCurso int
declare @cantidad int

Drop table if exists CursosMaestros;

Create table CursosMaestros(
nombre varchar(100),
cantidad int
)

Declare cDatos cursor for
	Select idCurso, nombre
	from Cursos where idMaestro = @idMaestro

	open cDatos

	while 1=1
	begin
		fetch next from cDatos into @idCurso, @nombreCurso
		if @@FETCH_STATUS !=0
		begin
			break
		end

		select @cantidad = (select COUNT(*) from Estudiantes where Curso = @idCurso)
		insert into CursosMaestros 
		values(@nombreCurso, @cantidad)
	end
	CLOSE cDatos
	Deallocate cDatos

	Select nombre AS 'Cursos activos', cantidad AS 'Cantidad de estudiantes' from CursosMaestros

END
GO
--- Pruebas
Insert into Estudiantes values ('Maria','Alvarez',23,'2020-1111','8092237744','briisisiss','maraa@hotmail.com','MAR22','mmmm2234',1)
Insert into Estudiantes values ('Marco','Madrigal',24,'2020-15412','8292437984','Los Frailes','marco@gmail.com','marco14','mm322234',2)
insert into Maestros values ('Juan','Lopez',40,'8092789772','Brisas del Este, skskk,ss','juanlopez12@gmail.com','jlopez','jjjj2222')
insert into cursos values ('Electricidad básica', 1)
insert into cursos values ('Electricidad II', 1)
insert into Maestros values ('Trinidad','Perez',50,'8092709772','Brisas del Este, ddssk,ss','trinidadz12@gmail.com','tri','trrr4422')
insert into Directores values ('David N.','de la Rosa L.',50,'8092788772','Brisas del Este, Callae Santiago,#81','delarosadavid377@gmail.com','david15','ddl#1508')
update Calificaciones set notaFinal = 96 where idEstudiante = 4;
select * FROM Cursos;
select * from Maestros;
select * from Estudiantes;
GO
exec spCursosMaestros 1;
exec spCalificacionesEstudiantes 4;
exec SpCalificacionesListar 1;
select * from Estudiantes
exec SpCursosEliminar 4