CREATE TABLE PARAMETROS(
	IdParametro		INT PRIMARY KEY,
	NomParametro	VARCHAR(100),
	DescParametro	VARCHAR(200),
	IdParPadre		INT,
	ParValor		INT,
	IdUsuario		INT,
	IdEstado		INT,
	Modificado		DATETIME,
	Creado			DATETIME
) 
GO