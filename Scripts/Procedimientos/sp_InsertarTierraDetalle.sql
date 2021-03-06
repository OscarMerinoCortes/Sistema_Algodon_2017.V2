create proc [dbo].[sp_InsertarTierraDetalle]
@IdTierraDetalle int output,
@IdTierraEncabezado int,
@SuperficieRestante decimal(6,2)
as
begin
set nocount on
merge TierraDetalle as target
using (select @IdTierraDetalle,@IdTierraEncabezado,@SuperficieRestante) 
as source (IdTierraDetalle,IdTierraEncabezado,SuperficieRestante)
ON (target.IdTierraDetalle = source.IdTierraDetalle)
WHEN MATCHED THEN
UPDATE SET IdTierraEncabezado = source.IdTierraEncabezado,
		   SuperficieRestante = source.SuperficieRestante
WHEN NOT MATCHED THEN
INSERT (IdTierraEncabezado,SuperficieRestante)
VALUES (source.IdTierraEncabezado,source.SuperficieRestante);
END