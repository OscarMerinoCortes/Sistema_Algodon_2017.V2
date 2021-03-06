CREATE procedure Sp_InsertaConfiguracionParametros
@IdConfiguracion int output,
@NombrePC varchar(30),
@DireccionIP varchar(15),
@NombrePuerto varchar(6),
@InicialModulo int,
@NoCaracterModulo int,
@InicialTransporte int,
@NoCaracterTransporte int,
@InicialBoletasBruto int,
@NoCaracterBoletasBruto int,
@InicialBoletasTara int,
@NoCaracterBoletasTara int,
@InicialBoletasNeto int,
@NoCaracterBoletasNeto int,
@InicialPacas int,
@NoCaracteresPacas int
as
begin
set nocount on
merge dbo.configuracionparametros as target
using (select @IdConfiguracion,@NombrePC,@DireccionIP,@NombrePuerto,@InicialModulo,@NoCaracterModulo,@InicialTransporte,@NoCaracterTransporte,@InicialBoletasBruto,@NoCaracterBoletasBruto,@InicialBoletasTara,@NoCaracterBoletasTara,@InicialBoletasNeto,@NoCaracterBoletasNeto,@InicialPacas,@NoCaracteresPacas) as source (IdConfiguracion,NombrePC,DireccionIP,NombrePuerto,InicialModulo,NoCaracterModulo,InicialTransporte,NoCaracterTransporte,InicialBoletasBruto,NoCaracterBoletasBruto,InicialBoletasTara,NoCaracterBoletasTara,InicialBoletasNeto,NoCaracterBoletasNeto,InicialPacas,NoCaracteresPacas)
ON (target.IdConfiguracion = source.IdConfiguracion)
WHEN MATCHED THEN
UPDATE SET NombrePC = source.NombrePC,
		   DireccionIP = source.DireccionIP,
		   NombrePuerto = source.NombrePuerto,
		   InicialModulo = source.InicialModulo,
		   NoCaracterModulo = source.NoCaracterModulo,
		   InicialTransporte = source.InicialTransporte,
		   NoCaracterTransporte = source.NoCaracterTransporte,
		   InicialBoletasBruto = source.InicialBoletasBruto,
		   NoCaracterBoletasBruto = source.NoCaracterBoletasBruto,
		   InicialBoletasTara = source.InicialBoletasTara,
		   NoCaracterBoletasTara = source.NoCaracterBoletasTara,
		   InicialBoletasNeto = source.InicialBoletasNeto,
		   NoCaracterBoletasNeto = source.NoCaracterBoletasNeto,
		   InicialPacas = source.InicialPacas,
		   NoCaracteresPacas = source.NoCaracteresPacas
WHEN NOT MATCHED THEN
INSERT (NombrePC,DireccionIP,NombrePuerto,InicialModulo,NoCaracterModulo,InicialTransporte,NoCaracterTransporte,InicialBoletasBruto,NoCaracterBoletasBruto,InicialBoletasTara,NoCaracterBoletasTara,InicialBoletasNeto,NoCaracterBoletasNeto,InicialPacas,NoCaracteresPacas)
VALUES (source.NombrePC,source.DireccionIP,source.NombrePuerto,source.InicialModulo,source.NoCaracterModulo,source.InicialTransporte,source.NoCaracterTransporte,source.InicialBoletasBruto,source.NoCaracterBoletasBruto,source.InicialBoletasTara,source.NoCaracterBoletasTara,source.InicialBoletasNeto,source.NoCaracterBoletasNeto,source.InicialPacas,source.NoCaracteresPacas);
		SET @IdConfiguracion = SCOPE_IDENTITY()
END
RETURN  @IdConfiguracion