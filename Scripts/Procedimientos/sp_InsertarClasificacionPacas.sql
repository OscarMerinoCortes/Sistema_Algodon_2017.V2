alter procedure sp_InsertarClasificacionPacas
@IdCalculoClasificacion int,
@BaleId int,
@Mic float,
@ColorGrade varchar(4),
@TrashId int,
@Clase varchar(4),
@UHML float,
@Strength float,
@SCI int,
@IdHviDetalle int
as 
begin 
set nocount on
merge [dbo].[CalculoClasificacion] as target
using (select @IdCalculoClasificacion,@BaleId,@Mic,@ColorGrade,@TrashId,@Clase,@UHML,@Strength,@SCI,@IdHviDetalle) AS SOURCE (IdCalculoClasificacion,BaleId,Mic,ColorGrade,TrashId,Clase,UHML,Strength,SCI,IdHviDetalle)
ON (target.BaleId = SOURCE.BaleId)
WHEN MATCHED THEN
UPDATE SET Mic = Source.Mic,
		   ColorGrade = source.ColorGrade,
		   TrashId = source.TrashId,
		   UHML = source.UHML,
		   Strength = source.Strength
WHEN NOT MATCHED THEN
INSERT (BaleId,Mic,ColorGrade,TrashId,Clase,UHML,Strength,SCI,IdHviDetalle)
        VALUES (source.BaleId,source.Mic,source.ColorGrade,source.TrashId,source.Clase,source.UHML,source.Strength,source.SCI,source.IdHviDetalle);		
END