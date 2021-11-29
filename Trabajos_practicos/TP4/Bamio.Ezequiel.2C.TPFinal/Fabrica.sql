USE MASTER
GO
CREATE DATABASE [Fabrica]
GO
USE [Fabrica]
GO
CREATE TABLE [dbo].[Reportes](
	[id] [int] NOT NULL,
	[totalPedidos] [int] NOT NULL,
	[totalPagos] [int] NOT NULL,
	[totalNoPagos] [int] NOT NULL,
	[recaudado] [int] NOT NULL,
	[fecha] [varchar](50) NOT NULL
) ON [PRIMARY]
