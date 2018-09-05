alter proc sp_InsertarLiquidacionPorRomaneaje
@IdLiquidacion int output,
@IdOrdenTrabajo int,
@Fecha datetime,
@Comentarios varchar(100),
@TotalHueso float,
@TotalPluma float,
@PorcentajePluma float,
@PorcentajeSemilla float,
@TotalSemilla float,
@PorcentajeMerma float,
@TotalMerma float,
@TotalPacas int,
@TotalBoletas int,
@TotalBorregos int,
@TotalPlumaBorregos float,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[LiquidacionesPorRomaneaje] as target
using (select @IdLiquidacion,@IdOrdenTrabajo,@Fecha,@Comentarios,@TotalHueso,@TotalPluma,@PorcentajePluma,@PorcentajeSemilla,@TotalSemilla,@PorcentajeMerma,@TotalMerma,@TotalPacas,@TotalBoletas,@TotalBorregos,
@TotalPlumaBorregos,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) AS SOURCE 
(IdLiquidacion,IdOrdenTrabajo,Fecha,Comentarios,TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas,TotalBoletas,TotalBorregos,
TotalPlumaBorregos,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdLiquidacion = SOURCE.IdLiquidacion)
WHEN MATCHED THEN
UPDATE SET IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion
		WHEN NOT MATCHED THEN
		  INSERT (IdOrdenTrabajo,Fecha,Comentarios,TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas,TotalBoletas,TotalBorregos,
TotalPlumaBorregos,IdEstatus,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
          VALUES (source.IdOrdenTrabajo,source.Fecha,source.Comentarios,source.TotalHueso,source.TotalPluma,source.PorcentajePluma,source.PorcentajeSemilla,source.TotalSemilla,source.PorcentajeMerma,source.TotalMerma,source.TotalPacas,source.TotalBoletas,source.TotalBorregos,
source.TotalPlumaBorregos,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
		  SET @IdLiquidacion = SCOPE_IDENTITY()
		  END
RETURN @IdLiquidacion