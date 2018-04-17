alter procedure sp_InsertarProduccion
@IdProduccion int output,
@IdPlantaOrigen int,
@IdPlantaDestino int,
@IdOrdenTrabajo int,
@Tipo varchar(20),
@IdCliente int,
@Fecha datetime,
@IdEstatus int,

@TotalHueso float,
@Pacas int,
@PlumaPacas float,
@PlumaBorregos float,
@Pluma float,
@Semilla float,
@Merma float,
@Borra float,
@PorcentajePluma float,
@PorcentajeSemilla float,
@PorcentajeMerma float,

@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[Produccion] as target
using (select @IdProduccion,@IdPlantaOrigen,@IdPlantaDestino,@IdOrdenTrabajo,@Tipo,@IdCliente,@Fecha,@IdEstatus,
@TotalHueso,
@Pacas,
@PlumaPacas,
@PlumaBorregos,
@Pluma,
@Semilla,
@Merma,
@Borra,
@PorcentajePluma,
@PorcentajeSemilla,
@PorcentajeMerma,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) as source (IdProduccion,IdPlantaOrigen,IdPlantaDestino,IdOrdenTrabajo,Tipo,IdCliente,Fecha,IdEstatus,
TotalHueso,
Pacas,
PlumaPacas,
PlumaBorregos,
Pluma,
Semilla,
Merma,
Borra,
PorcentajePluma,
PorcentajeSemilla,
PorcentajeMerma,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdProduccion = source.IdProduccion)
WHEN MATCHED THEN
UPDATE SET 
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (IdPlantaOrigen,IdPlantaDestino,IdOrdenTrabajo,Tipo,IdCliente,Fecha,IdEstatus,
TotalHueso,
Pacas,
PlumaPacas,
PlumaBorregos,
Pluma,
Semilla,
Merma,
Borra,
PorcentajePluma,
PorcentajeSemilla,
PorcentajeMerma,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
VALUES (source.IdPlantaOrigen,source.IdPlantaDestino,source.IdOrdenTrabajo,source.Tipo,source.IdCliente,source.Fecha,source.IdEstatus,
source.TotalHueso,
source.Pacas,
source.PlumaPacas,
source.PlumaBorregos,
source.Pluma,
source.Semilla,
source.Merma,
source.Borra,
source.PorcentajePluma,
source.PorcentajeSemilla,
source.PorcentajeMerma,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
SET @IdProduccion = SCOPE_IDENTITY()
END
RETURN @IdProduccion
