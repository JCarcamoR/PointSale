CREATE TABLE USUARIOS(
	IdUsuario	INT PRIMARY KEY,
	Clave		VARCHAR(20),
	Contrasenia VARCHAR(20),
	Firma		VARCHAR(20),
	IdUusario	INT,
	IdRol		INT,
	IdPerfil	INT,
	IdPersona	INT,
	IdEstado	INT,
	Modificado	DATETIME,
	Creado		DATETIME
) 
GO