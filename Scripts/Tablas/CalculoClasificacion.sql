create table CalculoClasificacion(
IdCalculoClasificacion int not null primary key identity(1,1),
IdPaqueteEncabezado int not null,
IdHviDetalle int not null,
BaleId int,
Mic float,
ColorGrade varchar(4),
TrashId int,
Clase varchar(4),
UHML float,
Strength float,
SCI int,
FlagTerminado bit
)