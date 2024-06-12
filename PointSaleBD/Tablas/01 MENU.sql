CREATE TABLE MENU(
	IdMenu		INT PRIMARY KEY,
	DesMenu		VARCHAR(100),
	MenIcono	VARCHAR(50),
	UrlMenu		VARCHAR(300),
	MenPadre	INT,
	MenOrden	INT,
	MenNivel	INT,
	MenTipo		INT,
	IdUsuario	INT,
	IdEstado	INT,
	Modificado	DATETIME,
	Creado		DATETIME
) 
GO