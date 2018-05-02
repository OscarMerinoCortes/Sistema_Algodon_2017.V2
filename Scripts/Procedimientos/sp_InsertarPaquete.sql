USE [ALGODON_2V]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarMaquinaria]    Script Date: 11/04/2018 03:29:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertarPaquete]
@IdPaquete int output,
@IdPlanta int,
@Clase int,
@CantidadPacas int,
@Descripcion varchar(20),
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdEstatus int
as
begin
set nocount on
merge PaquetesEnc as target
using (select @IdPaquete,@IdPlanta,@Clase,@CantidadPacas,@Descripcion,@IdUsuarioCreacion,@FechaCreacion,@IdEstatus) 
as source (IdPaquete,IdPlanta,Clase,CantidadPacas,Descripcion,IdUsuarioCreacion,FechaCreacion,IdEstatus)
ON (target.IdPaquete = source.IdPaquete)
WHEN MATCHED THEN
UPDATE SET IdPlanta = source.IdPlanta,		
		   Clase = source.Clase,
		   CantidadPacas = source.CantidadPacas,
		   Descripcion = source.Descripcion,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (IdPlanta,Clase,CantidadPacas,Descripcion,IdUsuarioCreacion,FechaCreacion,IdEstatus)
VALUES (source.IdPlanta,source.Clase,source.CantidadPacas,source.Descripcion,source.IdUsuarioCreacion,source.FechaCreacion,source.IdEstatus);
SET @IdPaquete = SCOPE_IDENTITY()
END
RETURN @IdPaquete