CREATE TABLE [dbo].[DETALLE_ENTRADAS] (
    [IdDetalleEntrada] INT           NOT NULL,
    [IdEntrada]        INT           NULL,
    [IdProducto]       INT           NULL,
    [Cantidad]         INT           NULL,
    [Observacion]      VARCHAR (500) NULL,
    [IdPrecio]         INT           NULL,
    [IdEstado]         INT           NULL,
    [Modificado]       DATETIME      NULL,
    [Creado]           DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdDetalleEntrada] ASC)
);

