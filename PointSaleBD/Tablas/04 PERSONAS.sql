CREATE TABLE PERSONAS(
	IdPersona		INT PRIMARY KEY,
	Nombre			VARCHAR(50),
	ApePaterno		VARCHAR(50),
	ApeMaterno		VARCHAR(50),
	TipoPersona		INT,
	IdUsuario		INT,
	IdEstado		INT,
	Modificado		DATETIME,
	Creado			DATETIME
) 
GO