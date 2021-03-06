ALTER proc [dbo].[sp_ConsultaTierras]
@IdTierra int 
as
select Ti.IdTierra
	  ,Ti.Lote
	  ,Ti.Colonia
	  ,Ti.Propietario
	  ,Cl.RfcFisica
	  ,Cl.CurpFisica
	  ,Ti.RegistroAlterno
	  ,Ti.SuperficieTotal
	  ,Ti.SuperficieCultivable
	  ,Ti.LatitudGrados
	  ,Ti.LatitudHoras
	  ,Ti.LatitudMinutos
	  ,Ti.LongitudGrados
	  ,Ti.LongitudHoras
	  ,Ti.LongitudMinutos
	  ,Ti.NumeroRpp
	  ,Ti.FolioRpp
	  ,Ti.LibroRpp
	  ,Ti.Fecha
	  ,Ti.TituloAgua
	  ,Ti.RegimenHidrico
	  ,Ti.FechaTituloAgua
	  ,Ti.IdEstatus
	  ,Ti.IdUsuarioCreacion
	  ,Ti.FechaCreacion 
from Tierras Ti, clientes Cl
where IdTierra = @IdTierra and ti.Propietario = cl.IdCliente