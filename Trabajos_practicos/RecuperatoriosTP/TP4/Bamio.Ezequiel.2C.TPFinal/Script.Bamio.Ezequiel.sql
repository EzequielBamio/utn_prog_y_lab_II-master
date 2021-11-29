USE MASTER
GO
CREATE DATABASE [Fabrica]
GO
USE [Fabrica]
GO
Create table Reportes
(
	ReporteId int primary key identity(1,1) NOT NULL,
	cantidadPedidos int NOT NULL,
	cantidadEntregados int NOT NULL,
	cantidadNoEntregados int NOT NULL,
	totalVenta int NOT NULL,
	fecha varchar(50) NOT NULL,
)