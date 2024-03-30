create database CompuGross
GO

--drop trigger TR_BAJA_LOGICA_SERVICIO
--drop trigger TR_BAJA_LOGICA_CLIENTE
--drop trigger TR_BAJA_LOGICA_LOCALIDAD
--drop trigger TR_BAJA_LOGICA_Proveedores

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
	pass varbinary(max)
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
	Estado bit default(1),
	Validez date not null default(getdate()+365)
)
GO

insert into Licencias(Serial) values(pwdencrypt('9687-9367-9819-6821-2419-7850'))
insert into Licencias(Serial) values(pwdencrypt('4214-1810-8064-6539-7738-1505'))
insert into Licencias(Serial) values(pwdencrypt('8259-5919-3923-7237-4899-8042'))
insert into Licencias(Serial) values(pwdencrypt('4681-2234-7293-1081-5156-4060'))
insert into Licencias(Serial) values(pwdencrypt('7587-5505-3692-8846-7458-6196'))
insert into Licencias(Serial) values(pwdencrypt('6549-5139-9932-6621-7375-1543'))
GO

insert into Activado(IdLicencia, Validez) values((select top 1 ID from Licencias), getdate()-366)
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

insert into UsuarioLogueado(Tipo, Username) values('test', 'test')

create table Localidades(
	ID bigint primary key not null identity(1,1),
	Descripcion varchar(100) unique not null,
	Estado bit not null default(1)
)
GO

create table Clientes(
	ID bigint primary key not null identity(1,1),
	Nombres varchar(200) not null,
	DNI varchar(11) null default('-'),
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

create table UnidadesOpticas(
	ID bigint not null identity(1,1),
	Descripcion varchar(50) not null unique,
	Estado bit not null default(1)
)
GO

insert into UnidadesOpticas(Descripcion) values('-')
insert into UnidadesOpticas(Descripcion) values('Lectora CD')
insert into UnidadesOpticas(Descripcion) values('Lectora CD/DVD')
insert into UnidadesOpticas(Descripcion) values('Lectograbadora CD/DVD')
insert into UnidadesOpticas(Descripcion) values('No tiene')
insert into UnidadesOpticas(Descripcion) values('No aplica')

create table OrdenesTrabajo(
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
	isnull(C.IdLocalidad, '-') as IdLocalidad, isnull(L.Descripcion, '-') as Localidad,
	isnull(C.Telefono, '-') as Telefono, isnull(C.Mail, '-') as Mail, C.FechaAlta, C.Estado
	from Clientes C join Localidades L on C.IdLocalidad = L.ID
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
	set @IdClienteExistente = (select ID from Clientes where Nombres = @Nombres and Estado = 0)

	if (@IdClienteExistente <> 0)
		begin
			update Clientes set Estado = 1 where Nombres = @Nombres
		end
	else
		begin
			insert into Clientes(DNI, Nombres, Direccion, IdLocalidad, Telefono, Mail)
			values(@DNI, @Nombres, @Direccion, (select ID from Localidades where Descripcion = @Localidad), @Telefono, @Mail)
		end
end
GO

create or alter procedure SP_MODIFICAR_CLIENTE(
	@ID bigint,
	@DNI varchar(11),
	@ApeNom varchar(200),
	@Direccion varchar(100),
	@Localidad varchar(100),
	@Telefono varchar(50),
	@Mail varchar(100),
	@Estado bit
)
as
begin
	update Clientes set DNI = @DNI,
						Nombres = @ApeNom,
						Direccion = @Direccion,
						IdLocalidad = (select ID from Localidades where Descripcion = @Localidad),
						Telefono = @Telefono,
						Mail = @Mail,
						Estado = @Estado
	where ID = @ID
end
GO

create or alter procedure SP_NUEVA_LOCALIDAD(
	@Descripcion varchar(200)
)
as
begin
	declare @IdLocalidadExistente bigint = 0
	set @IdLocalidadExistente = (select ID from Localidades where Descripcion = @Descripcion and Estado = 0)

	if (@IdLocalidadExistente <> 0)
		begin
			update Localidades set Estado = 1 where Descripcion = @Descripcion
		end
	else
		begin
			insert into Localidades(Descripcion) values(@Descripcion)
		end
end
GO

create or alter trigger TR_BAJA_LOGICA_LOCALIDAD on Localidades
instead of delete
as
begin
	declare @IdLocalidad bigint = (select ID from deleted)
	
	update Localidades set Estado = 0 where ID = @IdLocalidad
end
GO

create table ListaPrecios(
	ID int not null identity(1,1),
	Codigo varchar(8) unique not null,
	Descripcion varchar(85) unique not null,
	Aclaraciones varchar(200) null,
	Precio_Dolares money not null default(0),
	Estado bit not null default(1)
)
GO

create or alter view ExportIngresos
as
	select 'ArmadoGabinete' 'ID', isnull(count(*), 0) Cant, convert(int,isnull(sum(OT.Ganancia),0)) Ganancia, 
	convert(int,isnull(avg(OT.Ganancia),0)) PromGanancia
	from OrdenesTrabajo OT
	inner Join TiposServicio TS 
	on TS.ID = OT.IdTipoServicio and OT.IdTipoServicio = 1 and OT.Estado = 1 and OT.FechaDevolucion is not null
	union
	select 'CamarasSeguridad' 'ID', isnull(count(*), 0) Cant, convert(int,isnull(sum(OT.Ganancia),0)) Ganancia, 
	convert(int,isnull(avg(OT.Ganancia),0)) PromGanancia
	from OrdenesTrabajo OT
	inner Join TiposServicio TS 
	on TS.ID = OT.IdTipoServicio and OT.IdTipoServicio = 2 and OT.Estado = 1 and OT.FechaDevolucion is not null
	union
	select 'ServicioTecnico' 'ID', isnull(count(*), 0) Cant, convert(int,isnull(sum(OT.Ganancia),0)) Ganancia, 
	convert(int,isnull(avg(OT.Ganancia),0)) PromGanancia
	from OrdenesTrabajo OT
	inner Join TiposServicio TS
	on TS.ID = OT.IdTipoServicio and OT.IdTipoServicio = 3 and OT.Estado = 1 and FechaDevolucion is not null
	union
	select 'TotalDiasServicio' 'ID', 
	datediff(day, 
			(select FechaRecepcion from OrdenesTrabajo where Estado = 1 and FechaRecepcion = Convert(Datetime, '2017-06-28')), 
			getdate()) Cant, 0, 0
GO

create or alter view ExportModificarOrdenTrabajo
as
	select OT.ID, OT.IdCliente IdCliente,
	C.Nombres Cliente,
	OT.FechaRecepcion FechaRecepcion,
	isnull(OT.FechaDevolucion, '') FechaDevolucion,
	TE.ID IdTipoEquipo,
	TE.Descripcion TipoEquipo,
	OT.RAM, OT.PlacaMadre, OT.MarcaModelo, OT.Microprocesador, OT.Almacenamiento, 
	UO.ID IdUnidadOptica,
	OT.UnidadOptica,
	OT.Alimentacion, OT.Adicionales, OT.NumSerie,
	TS.ID IdTipoServicio,
	TS.Descripcion TipoServicio,
	OT.Descripcion, 
	CONVERT(int,OT.CostoRepuestos) CostoRepuestos, 
	CONVERT(int,OT.CostoTerceros) CostoTerceros, CONVERT(int,OT.CostoCG) Honorarios, 
	CONVERT(int,OT.CostoTotal) CostoTotal, OT.Estado
	from OrdenesTrabajo OT join TiposEquipo TE on TE.ID = OT.IdTipoEquipo
	join Clientes C on C.ID = OT.IdCliente
	join TiposServicio TS on TS.ID = OT.IdTipoServicio
	join UnidadesOpticas UO on UO.Descripcion = OT.UnidadOptica COLLATE MODERN_SPANISH_CI_AS
	where OT.Estado = 1
GO

create or alter view ExportListarOrdenTrabajo
as
	select OT.ID, C.Nombres Cliente,
	OT.FechaRecepcion FechaRecepcion,
	isnull(OT.FechaDevolucion, '') FechaDevolucion,
	TE.Descripcion TipoEquipo,
	TS.Descripcion TipoServicio,
	CONVERT(int,OT.CostoTotal) CostoTotal,
	CONVERT(int,OT.CostoCG) Ganancia
	from OrdenesTrabajo OT join TiposEquipo TE on TE.ID = OT.IdTipoEquipo
	join Clientes C on C.ID = OT.IdCliente
	join TiposServicio TS on TS.ID = OT.IdTipoServicio
	where OT.Estado = 1
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
	@UnidadOptica varchar(50),
	@Alimentacion varchar(50),
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
							UnidadOptica = @UnidadOptica,
							Alimentacion = @Alimentacion,
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
							   Almacenamiento, UnidadOptica, Alimentacion, Adicionales,
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
							   Almacenamiento, UnidadOptica, Alimentacion, Adicionales,
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
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Cámaras'))
Camaras,
(select CONVERT(int, isnull(sum(Ganancia),'-')) from OrdenesTrabajo OT where 
Estado = 1 and C.ID = OT.IdCliente and 
IdTipoServicio = (select ID from TiposServicio where Descripcion = 'Cámaras'))
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

create or alter view ExportUsuarios
as
	select U.ID, TU.ID IdTipo, TU.Tipo, U.Nombre, U.Apellido, U.Username, U.Mail 
	from Usuarios U inner join TiposUsuario TU on U.IdTipo = TU.ID
GO

create table TiposProveedor(
	ID int primary key not null identity(1,1),
	Descripcion varchar(200) not null,
	Estado bit not null default(1)
)
GO

create table Proveedores(
	ID int primary key not null identity(1,1),
	Nombre varchar(200) not null,
	Mail varchar(200) null,
	Telefono varchar(200) null,
	Direccion varchar(200) null,
	IdTipo int not null foreign key references TiposProveedor(ID),
	SitioWeb varchar(max) null,
	FechaAlta date not null default (getdate()),
	Estado bit not null default(1)
)
GO

create or alter view ExportProveedores
as
	select P.ID, Nombre, isnull(Mail, '-') Mail, isnull(Telefono, '-') Telefono, IdTipo, TP.Descripcion TipoProveedor, 
	isnull(SitioWeb, '-') SitioWeb, FechaAlta, P.Estado from Proveedores P join TiposProveedor TP on IdTipo = TP.ID
	where P.Estado = 1
GO

create trigger TR_BAJA_LOGICA_Proveedores on Proveedores
instead of delete
as
begin
	declare @ID bigint = (select ID from deleted)

	update Proveedores set Estado = 0 where ID = @ID
end
GO

create or alter trigger TR_BORRAR_LICENCIA_ANTERIOR on Activado after insert
as
begin
	delete from Activado where ID = (select top 1 ID from Activado order by ID asc)
end
GO