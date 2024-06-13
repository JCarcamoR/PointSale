﻿CREATE TABLE [dbo].[ENTRADAS] (
    [IdEntrada]  INT IDENTITY(1,1)  NOT NULL,
    [IdCliente]  INT                NULL,
    [IdUsuario]  INT                NULL,
    [IdTipoMov]  INT                NULL,
    [IdEstado]   INT                NULL,
    [Modificado] DATETIME           NULL,
    [Creado]     DATETIME           NULL,
    PRIMARY KEY CLUSTERED ([IdEntrada] ASC)
);

