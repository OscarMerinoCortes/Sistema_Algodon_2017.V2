create procedure [dbo].[sp_ConsultaRendimientos]
as
select a.IdRendimiento,
		a.Pluma,
		a.Semilla
from [dbo].[Rendimientos] a
where a.IdEstatus = 1