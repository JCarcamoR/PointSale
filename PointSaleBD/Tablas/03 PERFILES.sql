CREATE TABLE PERFILES(
	IdPerfil		INT PRIMARY KEY,
	NomcPerfil		VARCHAR(50),
	DescPerfil		VARCHAR(300),
	IdUsuario		INT,
	IdEstado		INT,
	Modificado		DATETIME,
	Creado			DATETIME
) 
GO