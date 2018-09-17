alter procedure sp_ConsultaCheckBoleta
@IdOrdenTrabajo int 
as
select a.FlagTerminado
from [dbo].[CalculoClasificacion] a
where a.IdOrdenTrabajo = @IdOrdenTrabajo
