﻿CREATE TABLE ROLES(
	IdRol		INT PRIMARY KEY,
	DescRol		VARCHAR(100),
	IdEstado	INT,
	IdUsuario	INT,
	Modificado	DATETIME,
	Creado		DATETIME
) 
GO