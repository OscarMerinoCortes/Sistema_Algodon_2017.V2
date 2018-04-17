create proc sp_InsertarLiquidacionPorRomaneaje
@IdLiquidacion int output,
@IdOrdenTrabajo int,
@Fecha datetime,
@Comentarios varchar(100),
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[LiquidacionesPorRomaneaje] as target
using (select @IdLiquidacion,@IdOrdenTrabajo,@Fecha,@Comentarios,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) AS SOURCE 
(IdLiquidacion,IdOrdenTrabajo,Fecha,Comentarios,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdLiquidacion = SOURCE.IdLiquidacion)
WHEN MATCHED THEN
UPDATE SET IdOrdenTrabajo = Source.IdOrdenTrabajo,
		   Fecha = source.Fecha,
		   Comentarios = source.Comentarios,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion
		WHEN NOT MATCHED THEN
		  INSERT (IdOrdenTrabajo,Fecha,Comentarios,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
          VALUES (source.IdOrdenTrabajo,source.Fecha,source.Comentarios,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
		  SET @IdLiquidacion = SCOPE_IDENTITY()
		  END
RETURN @IdLiquidacion