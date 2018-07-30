CREATE proc Sp_ActualizaBoletaPesoAuto
@IdBoleta as int ,
@NoTransporte as int,
@PesoBruto as float ,
@Tara as float ,
@Neto as float ,
@FechaActualizacion as datetime,
@TipoFlete as varchar(9) 
as
IF @TipoFlete = 'INBOUND' and (select Bruto from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) = 0 and (select notransporte from BoletasPorOrden where IdBoleta = @IdBoleta) = 0
BEGIN
	update [dbo].[BoletasPorOrden]
	set NoTransporte = @NoTransporte,
		Bruto = @PesoBruto,
		fechaorden = @FechaActualizacion
	where IdBoleta = @IdBoleta 
END
ELSE IF @TipoFlete = 'INBOUND' and (select Bruto from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) <> 0 or (select NoTransporte from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) <> @NoTransporte
BEGIN
	INSERT INTO [dbo].[IncidenciaCamiones] (IdBoleta,NoTransporte,Bruto,Tara,Neto,TipoFlete,FechaCreacion) values (@IdBoleta,@NoTransporte,@PesoBruto,@Tara,@Neto,@TipoFlete,@FechaActualizacion)
END
ELSE IF @TipoFlete = 'RECALLED' and (select Tara from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) = 0 and (select Total from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) = 0 and (select NoTransporte from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) = @NoTransporte
BEGIN
	update [dbo].[BoletasPorOrden]
	set Tara = @Tara,
		Total = @Neto,
		fechaorden = @FechaActualizacion
	where IdBoleta = @IdBoleta
END
ELSE IF @TipoFlete = 'RECALLED' and (select Tara from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) <> 0 and (select Total from [dbo].[BoletasPorOrden] a where a.IdBoleta = @IdBoleta) <> 0
BEGIN
	INSERT INTO [dbo].[IncidenciaCamiones] (IdBoleta,NoTransporte,Bruto,Tara,Neto,TipoFlete,FechaCreacion) values (@IdBoleta,@NoTransporte,@PesoBruto,@Tara,@Neto,@TipoFlete,@FechaActualizacion)
END