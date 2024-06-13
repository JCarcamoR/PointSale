CREATE TABLE [dbo].[PRECIOS] (
    [IdPrecio]       INT      NOT NULL,
    [IdProducto]     INT      NULL,
    [PrecioUnitario] INT      NULL,
    [FecInicio]      DATETIME NULL,
    [FecFin]         DATETIME NULL,
    [IdTipPrecio]    INT      NULL,
    [IdUsuario]      INT      NULL,
    [IdEstado]       INT      NULL,
    [Modificado]     DATETIME NULL,
    [Created]        DATETIME NULL,
    PRIMARY KEY CLUSTERED ([IdPrecio] ASC)
);

