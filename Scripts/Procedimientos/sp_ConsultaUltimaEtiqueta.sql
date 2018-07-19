alter procedure sp_ConsultaUltimaEtiqueta
--declare
@IdPlantaOrigen int --= 1
as
DECLARE @Etiqueta int = 
(select MAX(FolioCIA)
from [dbo].[ProduccionDetalle] a
where a.IdPlantaOrigen = @IdPlantaOrigen)
--print @Etiqueta
IF @Etiqueta = (select Secuencia from [dbo].[FolioEtiqueta] WHERE IdplantaOrigen = @IdPlantaOrigen)
BEGIN
   UPDATE [dbo].[FolioEtiqueta]
 SET     Secuencia = Secuencia + 1
 WHERE  IdPlantaOrigen = @IdPlantaOrigen
END
ELSE IF @Etiqueta = 1 
BEGIN
 INSERT INTO [dbo].[FolioEtiqueta] (Etiqueta,Secuencia,IdPlantaOrigen,Observacion) values (@Etiqueta,@Etiqueta+1,@IdPlantaOrigen,'')
END
ELSE
BEGIN
 UPDATE [dbo].[FolioEtiqueta]
 SET    Etiqueta  = @Etiqueta,
        Secuencia = Secuencia + 1
 WHERE  IdPlantaOrigen = @IdPlantaOrigen
END