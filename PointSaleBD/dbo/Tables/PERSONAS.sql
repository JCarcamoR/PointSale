CREATE TABLE [dbo].[PERSONAS] (
    [IdPersona]   INT          NOT NULL,
    [Nombre]      VARCHAR (50) NULL,
    [ApePaterno]  VARCHAR (50) NULL,
    [ApeMaterno]  VARCHAR (50) NULL,
    [TipoPersona] INT          NULL,
    [IdUsuario]   INT          NULL,
    [IdEstado]    INT          NULL,
    [Modificado]  DATETIME     NULL,
    [Creado]      DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([IdPersona] ASC)
);

