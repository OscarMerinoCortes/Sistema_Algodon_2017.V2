--alter procedure sp_ConsultaOrdenTrabajo
declare
@IdOrdenTrabajo int = 2
--as
Declare @Modulos VARCHAR(MAX) = '' 
SELECT @Modulos =  @Modulos +'-' + convert(varchar(10),a.IdBoleta) from [dbo].[BoletasPorOrden] a where a.IdOrdenTrabajo = @IdOrdenTrabajo
SET @Modulos = SUBSTRING(@Modulos,2,LEN(@Modulos))
--SELECT @Modulos as 'Modulos'
select a.IdPlanta as IdPlantaElabora,
       b.IdCliente,
	   b.Nombre,
	   @Modulos as Modulos,
	   a.NumeroModulos
from [dbo].[OrdenTrabajo] a,
     [dbo].[Clientes] b	
where a.IdOrdenTrabajo = @IdOrdenTrabajo
and   a.IdProductor = b.IdCliente




--select*from [dbo].[OrdenTrabajo]
--select*from [dbo].[BoletasPorOrden]