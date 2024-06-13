CREATE TABLE [dbo].[ENTRADAS] (
    [IdEntrada]  INT      NOT NULL,
    [IdCliente]  INT      NULL,
    [IdUsuario]  INT      NULL,
    [IdTipoMov]  INT      NULL,
    [IdEstado]   INT      NULL,
    [Modificado] DATETIME NULL,
    [Creado]     DATETIME NULL,
    PRIMARY KEY CLUSTERED ([IdEntrada] ASC)
);

