CREATE TABLE [dbo].[VENTAS] (
    [IdVenta]    INT      NOT NULL,
    [IdCliente]  INT      NULL,
    [IdUsuario]  INT      NULL,
    [IdTipoMov]  INT      NULL,
    [IdMetPago]  INT      NULL,
    [IdEstado]   INT      NULL,
    [Modificado] DATETIME NULL,
    [Creado]     DATETIME NULL,
    PRIMARY KEY CLUSTERED ([IdVenta] ASC)
);

