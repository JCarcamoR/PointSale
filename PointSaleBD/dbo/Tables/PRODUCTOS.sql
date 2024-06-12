CREATE TABLE [dbo].[PRODUCTOS] (
    [IdProducto]  INT           NOT NULL,
    [DesProducto] VARCHAR (150) NULL,
    [IdUmedida]   INT           NULL,
    [IdMarca]     INT           NULL,
    [IdEstado]    INT           NULL,
    [Modificado]  DATETIME      NULL,
    [Creado]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);



