CREATE procedure [dbo].[sp_ConsultaModulos]
as
select 
	   Bo.IdBoleta,
	   Bo.IdPlanta, 
	   Bo.FechaOrden, 
	   Bo.Bruto, 
	   Bo.Tara, 
	   Bo.Total, 
	   cl.Nombre, 
	   bo.IdOrdenTrabajo, 
	   bo.FlagCancelada, 
	   bo.FlagRevisada 
from [dbo].[BoletasPorOrden] Bo inner join [dbo].[Clientes] Cl  on Bo.IdProductor = Cl.IdCliente