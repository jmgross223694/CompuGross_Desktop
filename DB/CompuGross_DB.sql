
create database CompuGross
GO

use CompuGross
GO

create table Usuarios(
	ID int primary key not null identity(1,1),
	Apellido varchar(50) not null,
	Nombre varchar(50) not null,
	Username varchar(10) unique not null,
	Mail varchar(100) unique not null,
	Clave varbinary(max) not null,
	CodigoRecuperarClave int not null default(0)
)
GO

create table Localidades(
	ID bigint primary key not null identity(1,1),
	Descripcion varchar(100) unique not null,
	Estado bit not null default(1)
)
GO

create table Clientes(
	ID bigint primary key not null identity(1,1),
	Nombres varchar(200) not null,
	DNI varchar(11) null default(''),
	Direccion varchar(100) null,
	IdLocalidad bigint null foreign key references Localidades(ID),
	Telefono varchar(50) null,
	Mail varchar(100) null default('')
)
GO

create table TiposServicio(
	ID int primary key not null identity(1,1),
	Descripcion varchar(30) unique not null,
	Estado bit not null default(1)
)
GO

create table TiposEquipo(
	ID int primary key not null identity(1,1),
	Descripcion varchar(30) unique not null,
	Estado bit not null default(1)
)
GO

create table OrdenesTrabajo(
	ID bigint primary key not null identity(1,1),
	IdCliente bigint not null foreign key references Clientes(ID),
	FechaRecepcion date not null,
	IdTipoEquipo int null foreign key references TiposEquipo(ID),
	DatosEquipo varchar(2000) not null,
	IdTipo int not null foreign key references TiposServicio(ID),
	Descripcion varchar(1000) not null,
	CostoRepuestos money not null default(0),
	CostoTerceros money not null default(0),
	CostoCG money not null default(0),
	CostoTotal money not null default(0),
	FechaDevolucion date not null,
	Ganancia money not null,
	Estado bit not null default(1)
)
GO

create view ExportClientes
as
	select C.ID as ID, C.Nombres as 'Cliente', isnull(C.DNI,'-') as DNI, isnull(C.Direccion, '-') as Direccion,
	isnull((select L.Descripcion from Localidades L where C.IdLocalidad = L.ID), '-') as Localidad,
	isnull(C.IdLocalidad, '-') as IdLocalidad, isnull(C.Telefono, '-') as Telefono, isnull(C.Mail, '-') as Mail from Clientes C
GO

create procedure SP_NUEVO_CLIENTE(
	@DNI varchar(11),
	@Nombres varchar(200),
	@Direccion varchar(100),
	@Localidad varchar(100),
	@Telefono varchar(50),
	@Mail varchar(100)
)
as
begin
	insert into Clientes(DNI, Nombres, Direccion, IdLocalidad, Telefono, Mail)
	values(@DNI, @Nombres, @Direccion, (select ID from Localidades where Descripcion = @Localidad), @Telefono, @Mail)
end
GO

create table ListaPrecios(
	ID int not null identity(1,1),
	Descripcion varchar(200) unique not null,
	Precio int not null default(0)
)
GO

--INSERT PRECIOS
insert into ListaPrecios(Descripcion, Precio) values('Back-up de disco HDD o SSD (hasta 50Gb, sino adicional $12 por Gb)', 13)
insert into ListaPrecios(Descripcion, Precio) values('Formateo', 20)
insert into ListaPrecios(Descripcion, Precio) values('Formateo + Back-up', 24)
insert into ListaPrecios(Descripcion, Precio) values('Copia de datos (CD; PenDrive; HDD; SSD)', 10)
insert into ListaPrecios(Descripcion, Precio) values('Limpieza y optimización de software', 10)
insert into ListaPrecios(Descripcion, Precio) values('Limpieza de hardware CPU (suciedad interna)', 15)
insert into ListaPrecios(Descripcion, Precio) values('Limpieza de hardware Notebook / Netbook', 20)
insert into ListaPrecios(Descripcion, Precio) values('Cambio de pila CPU', 4)
insert into ListaPrecios(Descripcion, Precio) values('Cambio de pila Notebook / Netbook', 10)
insert into ListaPrecios(Descripcion, Precio) values('Reparación electronica de Placas madre (costo base)', 14)
insert into ListaPrecios(Descripcion, Precio) values('Instalación de hardware', 10)
insert into ListaPrecios(Descripcion, Precio) values('Instalación  de software (básico) / (no básico +$300)', 7)
insert into ListaPrecios(Descripcion, Precio) values('Servicio de armado e instalación de S.O. de equipo nuevo', 30)
insert into ListaPrecios(Descripcion, Precio) values('Armado e instalación de cable de red (precio  por metro)', 2)
insert into ListaPrecios(Descripcion, Precio) values('Instalación y/o configuración de Modem / Router / A.P. (costo por hora)', 11)
insert into ListaPrecios(Descripcion, Precio) values('Adicional domingo y feriados', 5)
insert into ListaPrecios(Descripcion, Precio) values('Adicional servicio a domicilio (hasta 15kms, sino adicional $10 por km)', 5)
insert into ListaPrecios(Descripcion, Precio) values('Instalación de cámaras (precio por cámara)', 27)
insert into ListaPrecios(Descripcion, Precio) values('Servicio técnico / mantenimiento de sistema de cámaras', 12)
insert into ListaPrecios(Descripcion, Precio) values('Recuperación de datos (hasta 100gb)', 16)
GO

--INSERT TIPOS DE EQUIPO
insert into TiposEquipo(Descripcion) values('PC de Escritorio')
insert into TiposEquipo(Descripcion) values('All in One')
insert into TiposEquipo(Descripcion) values('Notebook')
insert into TiposEquipo(Descripcion) values('Netbook')
insert into TiposEquipo(Descripcion) values('Tablet')
insert into TiposEquipo(Descripcion) values('Impresora')
insert into TiposEquipo(Descripcion) values('Televisor')
insert into TiposEquipo(Descripcion) values('Monitor')
insert into TiposEquipo(Descripcion) values('Celular')
insert into TiposEquipo(Descripcion) values('Consola')
insert into TiposEquipo(Descripcion) values('Cámaras')
GO

create view ExportIngresos
as
	select count(*) as Cant1, 
	(select convert(int,sum(Ganancia)) from OrdenesTrabajo where IdTipo = 1) as Ganancia1,
	(select convert(int,avg(Ganancia)) from OrdenesTrabajo where IdTipo = 1) as PromGanancia1,
	(select count(*) from OrdenesTrabajo where IdTipo = 2) as Cant2, 
	(select convert(int,sum(Ganancia)) from OrdenesTrabajo where IdTipo = 2) as Ganancia2,
	(select convert(int,avg(Ganancia)) from OrdenesTrabajo where IdTipo = 2) as PromGanancia2,
	(select count(*) from OrdenesTrabajo where IdTipo = 3) as Cant3, 
	(select convert(int,sum(Ganancia)) from OrdenesTrabajo where IdTipo = 3) as Ganancia3,
	(select convert(int,avg(Ganancia)) from OrdenesTrabajo where IdTipo = 3) as PromGanancia3,
	(select convert(int, getdate()) - convert(int,convert(datetime, (select FechaRecepcion from 
	OrdenesTrabajo where FechaRecepcion = '28-06-2017')))) as TotalDiasServicio
	from OrdenesTrabajo where IdTipo = 1
GO

create view ExportOrdenesTrabajo
as
	select OT.ID, (select C.Nombres from Clientes C where C.ID = OT.IdCLiente) Cliente,
	CONVERT(varchar(10), OT.FechaRecepcion, 105) FechaRecepcion,
	CONVERT(varchar(10), OT.FechaDevolucion, 105) FechaDevolucion,
	(select TE.Descripcion from TiposEquipo TE where TE.ID = OT.IdTipoEquipo) TipoEquipo,
	OT.DatosEquipo, (select TS.Descripcion from TiposServicio TS where TS.ID = OT.IdTipo) TipoServicio,
	OT.Descripcion, CONVERT(varchar(10),OT.CostoRepuestos) CostoRepuestos, 
	CONVERT(varchar(10),OT.CostoTerceros) CostoTerceros, CONVERT(varchar(10),OT.CostoCG) CostoCG, 
	CONVERT(varchar(10),OT.CostoTotal) CostoTotal,
	CONVERT(varchar(10),OT.Ganancia) Ganancia, OT.Estado
	from OrdenesTrabajo OT
GO

create procedure SP_UPDATE_ORDEN_TRABAJO(
	@ID bigint,
	@Cliente varchar(200),
	@FechaRecepcion varchar(10),
	@TipoEquipo varchar(30),
	@DatosEquipo varchar(800),
	@TipoServicio varchar(30),
	@Descripcion varchar(500),
	@CostoRepuestos money,
	@CostoTerceros money,
	@CostoCG money,
	@CostoTotal money,
	@FechaDevolucion varchar(10),
	@Ganancia money,
	@Estado bit
)as
begin
	update OrdenesTrabajo set
							IdCliente = (select ID from Clientes where Nombres = @Cliente),
							FechaRecepcion = @FechaRecepcion,
							IdTipoEquipo = (select ID from TiposEquipo where Descripcion = @TipoEquipo),
							DatosEquipo = @DatosEquipo,
							IdTipo = (select ID from TiposServicio where Descripcion = @TipoServicio),
							Descripcion = @Descripcion,
							CostoRepuestos = @CostoRepuestos,
							CostoTerceros = @CostoTerceros,
							CostoCG = @CostoCG,
							CostoTotal = @CostoTotal,
							FechaDevolucion = @FechaDevolucion,
							Ganancia = @Ganancia,
							Estado = @Estado
	where ID = @ID
end
GO

create trigger TR_BAJA_LOGICA_ORDEN_TRABAJO on OrdenesTrabajo
instead of delete
as
begin
	declare @IdOrden bigint = (select ID from deleted)
	
	update OrdenesTrabajo set Estado = 0 where ID = @IdOrden
end
GO