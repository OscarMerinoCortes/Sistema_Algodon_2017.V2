alter procedure sp_ConsultaBasProdDet
--declare
@IdProduccion int-- = 1
as
select [IdProduccionDetalle],
       [IdProduccion],
	   [IdOrdenTrabajo],
	   [FolioCIA],
       [Tipo],
       [Kilos],
       [Fecha]
from [dbo].[ProduccionDetalle] a
where a.IdEstatus = 1
and   a.IdProduccion = @IdProduccion
