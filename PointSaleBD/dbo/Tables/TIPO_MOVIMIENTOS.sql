CREATE TABLE [dbo].[TIPO_MOVIMIENTOS] (
    [IdTipoMov]  INT IDENTITY(1,1)  NOT NULL,
    [DescMov]    VARCHAR (100)      NULL,
    [IdEstado]   INT                NULL,
    [Modificado] DATETIME           NULL,
    [Creado]     DATETIME           NULL,
    PRIMARY KEY CLUSTERED ([IdTipoMov] ASC)
);

