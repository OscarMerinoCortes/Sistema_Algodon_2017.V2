create procedure [dbo].[sp_ConsultaCastigoPorQuintal]
as
select a.IdMicro,
		a.Rango1,
		a.Rango2,
		a.Castigo,
		a.IdEstatus
from [dbo].[Micros] a
where a.IdEstatus = 1