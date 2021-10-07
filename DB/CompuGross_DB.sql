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

create table OrdenesTrabajo(
	ID bigint primary key not null identity(1,1),
	IdCliente bigint not null foreign key references Clientes(ID),
	FechaRecepcion date not null,
	Equipo varchar(300) not null,
	NumSerie varchar(200) null,
	IdTipo int not null foreign key references TiposServicio(ID),
	Descripcion varchar(500) not null,
	CostoRepuestos money not null default(0),
	CostoTerceros money not null default(0),
	CostoCG money not null default(0),
	CostoTotal money not null default(0),
	Devolucion date null,
	Ganancia money null
)
GO

create alter view ExportClientes
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
	values(@DNI, @Nombres, @Direccion, @Localidad, @Telefono, @Mail)
end
GO