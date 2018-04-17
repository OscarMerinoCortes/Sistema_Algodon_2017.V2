create table LiquidacionesPorRomaneaje
(
IdLiquidacion int PRIMARY KEY IDENTITY (1,1),
IdOrdenTrabajo int,
Fecha datetime,
Comentarioas varchar(100),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)