CREATE TABLE [dbo].[PARAMETROS] (
    [IdParametro]   INT                 NOT NULL,
    [NomParametro]  VARCHAR (100)       NULL,
    [DescParametro] VARCHAR (200)       NULL,
    [ParValor]      VARCHAR (200)       NULL,
    [IdUsuario]     INT                 NULL,
    [IdEstado]      INT                 NULL,
    [Modificado]    DATETIME            NULL,
    [Creado]        DATETIME            NULL
);

