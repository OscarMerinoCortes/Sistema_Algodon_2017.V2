create procedure sp_ConsultaProdPorPorOrden
--declare
@IdOrdenTrabajo int --= 1
as
select a.IdProduccion
from [dbo].[Produccion] a
where a.IdOrdenTrabajo = @IdOrdenTrabajo
and a.IdEstatus = 1