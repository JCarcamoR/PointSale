CREATE TABLE [dbo].[PARAMETROS] (
    [IdParametro]   INT IDENTITY(1,1)   NOT NULL,
    [NomParametro]  VARCHAR (100)       NULL,
    [DescParametro] VARCHAR (200)       NULL,
    [IdParPadre]    INT                 NULL,
    [ParValor]      INT                 NULL,
    [IdUsuario]     INT                 NULL,
    [IdEstado]      INT                 NULL,
    [Modificado]    DATETIME            NULL,
    [Creado]        DATETIME            NULL,
    PRIMARY KEY CLUSTERED ([IdParametro] ASC)
);

