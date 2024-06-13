CREATE TABLE [dbo].[TIPO_PRECIOS] (
    [IdTipPrecio] INT           NOT NULL,
    [DescPrecio]  VARCHAR (100) NULL,
    [IdUsuario]   INT           NULL,
    [IdEstado]    INT           NULL,
    [Modificado]  DATETIME      NULL,
    [Creado]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdTipPrecio] ASC)
);

