create database CompuGross
GO

--drop trigger TR_BAJA_LOGICA_SERVICIO
--drop trigger TR_BAJA_LOGICA_CLIENTE

/*
--Consultar Case Sensitive en BD
SELECT collation_name
FROM sys.databases
WHERE name = 'CompuGross';
GO

--Modificar Case Sensitive en BD (CI = "Case insensitive" / CS = "Case sensitive")
ALTER DATABASE CompuGross
COLLATE Latin1_General_CS_AS;
GO
*/

use CompuGross
GO

create table credencialesMail(
	ID int not null primary key identity(1,1),
	mail varchar(100), 
	pass varchar(20)
)
GO

create table Licencias(
	ID int not null primary key identity(347862,13),
	Serial varbinary(max) not null,
	Estado bit not null default(1)
)
GO

create table Activado(
	ID smallint primary key not null identity(1,1),
	IdLicencia int not null foreign key references Licencias(ID),
	Estado bit,
	Validez date not null default(getdate()+365)
)
GO

create table TiposUsuario(
	ID int not null primary key identity(1,1),
	Tipo varchar(10) not null unique check (Tipo IN('admin', 'user'))
)
GO

insert into TiposUsuario(Tipo) values('admin')
insert into TiposUsuario(Tipo) values('user')
GO

create table Usuarios(
	ID int primary key not null identity(1,1),
	IdTipo int not null foreign key references TiposUsuario(ID),
	Apellido varchar(50) not null,
	Nombre varchar(50) not null,
	Username varchar(15) unique not null,
	Mail varchar(100) unique not null,
	Clave varbinary(max) not null,
	CodigoRecuperarClave int not null default(0)
)
GO

create table UsuarioLogueado(
	ID int not null primary key identity(1,1),
	Username varchar(30) null,
	Tipo varchar(10) null
)
GO

begin try
	update UsuarioLogueado set Tipo = 'test', Username = 'test' where ID = 1
end try
begin catch
	drop table UsuarioLogueado

	create table UsuarioLogueado(
		ID int not null primary key identity(1,1),
		Username varchar(30) null,
		Tipo varchar(10) null
	)

	insert into UsuarioLogueado(Tipo, Username) values('test', 'test')
end catch
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
	DNI varchar(9) null default('-'),
	Direccion varchar(100) null,
	IdLocalidad bigint null foreign key references Localidades(ID),
	Telefono varchar(50) null,
	Mail varchar(100) null default('-'),
	FechaAlta date not null default(getdate()),
	Estado bit not null default(1)
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

create table Servicios(
	ID bigint primary key not null identity(1,1),
	IdCliente bigint not null foreign key references Clientes(ID),
	FechaRecepcion date not null,
	IdTipoEquipo int not null foreign key references TiposEquipo(ID),
	RAM varchar(50) not null default('-'),
	PlacaMadre varchar(50) not null default('-'),
	MarcaModelo varchar(50) not null default('-'),
	Microprocesador varchar(50) not null default('-'),
	Almacenamiento varchar(50) not null default('-'),
	UnidadOptica varchar(50) not null default('-'),
	Alimentacion varchar(50) not null default('-'),
	Adicionales varchar(50) not null default('-'),
	NumSerie varchar(100) not null default('-'),
	IdTipoServicio int not null foreign key references TiposServicio(ID),
	Descripcion varchar(1000) not null,
	CostoRepuestos money not null default(0),
	CostoTerceros money not null default(0),
	CostoCG money not null default(0),
	CostoTotal money not null default(0),
	FechaDevolucion date null,
	Ganancia money not null,
	Estado bit not null default(1)
)
GO

create or alter view ExportClientes
as
	select C.ID as ID, C.Nombres as 'Cliente', isnull(C.DNI,'-') as DNI, isnull(C.Direccion, '-') as Direccion,
	isnull((select L.Descripcion from Localidades L where C.IdLocalidad = L.ID), '-') as Localidad,
	isnull(C.IdLocalidad, '-') as IdLocalidad, isnull(C.Telefono, '-') as Telefono, isnull(C.Mail, '-') as Mail from Clientes C
GO

create or alter procedure SP_NUEVO_CLIENTE(
	@DNI varchar(11),
	@Nombres varchar(200),
	@Direccion varchar(100),
	@Localidad varchar(100),
	@Telefono varchar(50),
	@Mail varchar(100)
)
as
begin
	declare @IdClienteExistente bigint = 0
	set @IdClienteExistente = (select ID from Clientes where Nombres = @Nombres and DNI = @DNI and Estado = 0)

	if (@IdClienteExistente <> 0)
		begin
			update Clientes set Estado = 1 where DNI = @DNI
		end
	else
		begin
			insert into Clientes(DNI, Nombres, Direccion, IdLocalidad, Telefono, Mail)
			values(@DNI, @Nombres, @Direccion, (select ID from Localidades where Descripcion = @Localidad), @Telefono, @Mail)
		end
end
GO

create table ListaPrecios(
	ID int not null identity(1,1),
	Descripcion varchar(200) unique not null,
	Precio int not null default(0)
)
GO

create or alter view ExportIngresos
as
	select isnull(count(*),0) as Cant1, 
	(select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo where Estado = 1 and FechaDevolucion is not null and IdTipoServicio = 1) as Ganancia1,
	(select convert(int,isnull(avg(Ganancia),0)) from OrdenesTrabajo where Estado = 1 and FechaDevolucion is not null and IdTipoServicio = 1) as PromGanancia1,
	(select count(*) from OrdenesTrabajo where Estado = 1 and IdTipoServicio = 2) as Cant2, 
	(select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo where Estado = 1 and FechaDevolucion is not null and IdTipoServicio = 2) as Ganancia2,
	(select convert(int,isnull(avg(Ganancia),0)) from OrdenesTrabajo where Estado = 1 and FechaDevolucion is not null and IdTipoServicio = 2) as PromGanancia2,
	(select count(*) from OrdenesTrabajo where Estado = 1 and IdTipoServicio = 3) as Cant3, 
	(select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo where Estado = 1 and FechaDevolucion is not null and IdTipoServicio = 3) as Ganancia3,
	(select convert(int,isnull(avg(Ganancia),0)) from OrdenesTrabajo where Estado = 1 and FechaDevolucion is not null and IdTipoServicio = 3) as PromGanancia3,
	(select convert(int, getdate()) - convert(int,convert(datetime, (select FechaRecepcion from 
	OrdenesTrabajo where Estado = 1 and FechaRecepcion = '28-06-2017')))) as TotalDiasServicio
	from OrdenesTrabajo where IdTipoServicio = 1 AND FechaDevolucion is not null AND Estado = 1
GO

create or alter view ExportOrdenesTrabajo
as
	select OT.ID, (select C.Nombres from Clientes C where C.ID = OT.IdCliente) Cliente,
	OT.IdCliente IdCliente,
	OT.FechaRecepcion FechaRecepcion,
	isnull(OT.FechaDevolucion, '') FechaDevolucion,
	(select TE.Descripcion from TiposEquipo TE where TE.ID = OT.IdTipoEquipo) TipoEquipo,
	OT.RAM, OT.PlacaMadre, OT.MarcaModelo, OT.Microprocesador, OT.Almacenamiento, OT.CdDvd, 
	OT.Fuente, OT.Adicionales, OT.NumSerie,
	(select TS.Descripcion from TiposServicio TS where TS.ID = OT.IdTipoServicio) TipoServicio,
	OT.Descripcion, 
	CONVERT(int,OT.CostoRepuestos) CostoRepuestos, 
	CONVERT(int,OT.CostoTerceros) CostoTerceros, CONVERT(int,OT.CostoCG) CostoCG, 
	CONVERT(int,OT.CostoTotal) CostoTotal,
	CONVERT(int,OT.Ganancia) Ganancia, OT.Estado
	from OrdenesTrabajo OT where Estado = 1
GO

create or alter procedure SP_UPDATE_ORDEN_TRABAJO(
	@ID bigint,
	@Cliente varchar(200),
	@FechaRecepcion varchar(10),
	@TipoEquipo varchar(30),
	@RAM varchar(50),
	@PlacaMadre varchar(50),
	@MarcaModelo varchar(50),
	@Microprocesador varchar(50),
	@Almacenamiento varchar(50),
	@CdDvd varchar(50),
	@Fuente varchar(50),
	@Adicionales varchar(50),
	@NumSerie varchar(100),
	@TipoServicio varchar(30),
	@Descripcion varchar(500),
	@CostoRepuestos money,
	@CostoTerceros money,
	@CostoCG money,
	@FechaDevolucion varchar(10)
)as
begin
	update OrdenesTrabajo set
							IdCliente = (select ID from Clientes where Nombres = @Cliente),
							FechaRecepcion = @FechaRecepcion,
							IdTipoEquipo = (select ID from TiposEquipo where Descripcion = @TipoEquipo),
							RAM = @RAM,
							PlacaMadre = @PlacaMadre,
							MarcaModelo = @MarcaModelo,
							Microprocesador= @Microprocesador,
							Almacenamiento = @Almacenamiento,
							CdDvd = @CdDvd,
							Fuente = @Fuente,
							Adicionales = @Adicionales,
							NumSerie = @NumSerie,
							IdTipoServicio = (select ID from TiposServicio where Descripcion = @TipoServicio),
							Descripcion = @Descripcion,
							CostoRepuestos = @CostoRepuestos,
							CostoTerceros = @CostoTerceros,
							CostoCG = @CostoCG,
							CostoTotal = @CostoCG + @CostoTerceros + @CostoRepuestos,
							FechaDevolucion = @FechaDevolucion,
							Ganancia = @CostoCG
	where ID = @ID
end
GO

create or alter procedure SP_INSERT_ORDEN_TRABAJO(
	@Cliente varchar(200),
	@FechaRecepcion varchar(10),
	@TipoEquipo varchar(30),
	@RAM varchar(50),
	@PlacaMadre varchar(50),
	@MarcaModelo varchar(50),
	@Microprocesador varchar(50),
	@Almacenamiento varchar(50),
	@CdDvd varchar(50),
	@Fuente varchar(50),
	@Adicionales varchar(50),
	@NumSerie varchar(100),
	@TipoServicio varchar(30),
	@Descripcion varchar(500),
	@CostoRepuestos money,
	@CostoTerceros money,
	@CostoCG money,
	@FechaDevolucion varchar(10)
)as
begin
	if (@FechaDevolucion = '')
		begin
			insert into OrdenesTrabajo(IdCliente, FechaRecepcion, IdTipoEquipo, RAM, 
							   PlacaMadre, MarcaModelo, Microprocesador, 
							   Almacenamiento, CdDvd, Fuente, Adicionales,
							   NumSerie, IdTipoServicio, Descripcion,
							   CostoRepuestos, CostoTerceros, CostoCG,
							   Ganancia, CostoTotal)
							
			values((select ID from Clientes where Nombres = @Cliente), @FechaRecepcion, 
				   (select ID from TiposEquipo where Descripcion = @TipoEquipo), @RAM,
				   @PlacaMadre, @MarcaModelo, @Microprocesador, @Almacenamiento, @CdDvd,
				   @Fuente, @Adicionales, @NumSerie,
				   (select ID from TiposServicio where Descripcion = @TipoServicio),
				   @Descripcion, @CostoRepuestos, @CostoTerceros, @CostoCG,
				   @CostoCG, (@CostoRepuestos + @CostoCG + @CostoTerceros))
		end
	else
		begin
			insert into OrdenesTrabajo(IdCliente, FechaRecepcion, IdTipoEquipo, RAM, 
							   PlacaMadre, MarcaModelo, Microprocesador, 
							   Almacenamiento, CdDvd, Fuente, Adicionales,
							   NumSerie, IdTipoServicio, Descripcion,
							   CostoRepuestos, CostoTerceros, CostoCG,
							   FechaDevolucion, Ganancia, CostoTotal)
							
			values((select ID from Clientes where Nombres = @Cliente), @FechaRecepcion, 
				   (select ID from TiposEquipo where Descripcion = @TipoEquipo), @RAM,
				   @PlacaMadre, @MarcaModelo, @Microprocesador, @Almacenamiento, @CdDvd,
				   @Fuente, @Adicionales, @NumSerie,
				   (select ID from TiposServicio where Descripcion = @TipoServicio),
				   @Descripcion, @CostoRepuestos, @CostoTerceros, @CostoCG,
				   @FechaDevolucion, @CostoCG, (@CostoRepuestos + @CostoCG + @CostoTerceros))
		end
	
	
end
GO

create or alter trigger TR_BAJA_LOGICA_SERVICIO on OrdenesTrabajo
instead of delete
as
begin
	declare @IdOrden bigint = (select ID from deleted)
	
	update OrdenesTrabajo set Estado = 0 where ID = @IdOrden
end
GO

create or alter trigger TR_BAJA_LOGICA_CLIENTE on Clientes
instead of delete
as
begin
	if((select Estado from Clientes where ID = (select ID from deleted)) = 1)
	begin
		update Clientes set Estado = 0 where ID = (select ID from deleted)
	end
end
GO

create or alter view ExportIngresosServiciosPorCliente
as
select C.ID, C.Nombres,
(select CONVERT(int, isnull(sum(Ganancia),'-')) from OrdenesTrabajo OT where 
Estado = 1 and C.ID = OT.IdCliente)
TotalIngresos,
(select count(ID) from OrdenesTrabajo OT where Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Servicio técnico'))
ServicioTecnico,
(select CONVERT(int, isnull(sum(Ganancia),'-')) from OrdenesTrabajo OT where 
Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Servicio técnico'))
IngresoServicioTecnico,
(select count(ID) from OrdenesTrabajo OT where Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Cámaras de seguridad'))
Camaras,
(select CONVERT(int, isnull(sum(Ganancia),'-')) from OrdenesTrabajo OT where 
Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Cámaras de seguridad'))
IngresoCamaras,
(select count(ID) from OrdenesTrabajo OT where Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Armado de gabinete'))
ArmadoGabinete,
(select CONVERT(int, isnull(sum(Ganancia),'-')) from OrdenesTrabajo OT where 
Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Armado de gabinete'))
IngresoArmadoGabinete,
(select count(ID) from OrdenesTrabajo OT where Estado = 1 and C.ID = OT.IdCliente)
TotalServicios
from Clientes C where Estado = 1
GO

create view ExportUsuarios
as
	select ID as ID,
	(select TU.Tipo from TiposUsuario TU where ID = U.IdTipo) as Tipo,
	Nombre as Nombres,
	Apellido as Apellidos,
	Username as DNI,
	Mail as Mail
	from Usuarios U
GO