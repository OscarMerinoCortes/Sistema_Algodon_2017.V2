create proc ActualizaBoletaPesoAuto
@IdBoleta as int,
@NoTransporte as int,
@PesoBruto as float,
@Tara as float,
@Neto as float,
@FechaActualizacion as datetime,
@TipoFlete as varchar(9)
as
if @TipoFlete = 'INBOUND'
BEGIN
	update [dbo].[BoletasPorOrden]
	set NoTransporte = @NoTransporte,
		Bruto = @PesoBruto,
		fechaorden = @FechaActualizacion
	where IdBoleta = @IdBoleta
END
ELSE IF @TipoFlete = 'RECALLED'
BEGIN
	update [dbo].[BoletasPorOrden]
	set Tara = @Tara,
		Total = @Neto,
		fechaorden = @FechaActualizacion
	where IdBoleta = @IdBoleta and NoTransporte = @NoTransporte
END