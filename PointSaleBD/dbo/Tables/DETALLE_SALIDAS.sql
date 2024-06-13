CREATE TABLE [dbo].[DETALLE_SALIDAS] (
    [IdDetalleSalida] INT IDENTITY(1,1) NOT NULL,
    [IdSalida]        INT               NULL,
    [IdProducto]      INT               NULL,
    [Cantidad]        INT               NULL,
    [Observacion]     VARCHAR (500)     NULL,
    [IdPrecio]        INT               NULL,
    [IdEstado]        INT               NULL,
    [Modificado]      DATETIME          NULL,
    [Creado]          DATETIME          NULL,
    PRIMARY KEY CLUSTERED ([IdDetalleSalida] ASC)
);

