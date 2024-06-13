CREATE TABLE [dbo].[DETALLE_VENTAS] (
    [IdDetalleVenta] INT             NOT NULL,
    [IdVenta]        INT             NULL,
    [IdProducto]     INT             NULL,
    [Cantidad]       DECIMAL (18, 3) NULL,
    [Observacion]    VARCHAR (500)   NULL,
    [IdPrecio]       INT             NULL,
    [IdEstado]       INT             NULL,
    [Modificado]     DATETIME        NULL,
    [Creado]         DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([IdDetalleVenta] ASC)
);

