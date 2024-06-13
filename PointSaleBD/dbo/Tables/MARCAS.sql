CREATE TABLE [dbo].[MARCAS] (
    [IdMarca]    INT IDENTITY(1,1)  NOT NULL,
    [DesMarca]   VARCHAR (100)      NULL,
    [IdEstado]   INT                NULL,
    [Modificado] DATETIME           NULL,
    [Creado]     DATETIME           NULL,
    PRIMARY KEY CLUSTERED ([IdMarca] ASC)
);

