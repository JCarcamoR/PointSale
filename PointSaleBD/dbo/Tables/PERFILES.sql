CREATE TABLE [dbo].[PERFILES] (
    [IdPerfil]   INT           NOT NULL,
    [NomcPerfil] VARCHAR (50)  NULL,
    [DescPerfil] VARCHAR (300) NULL,
    [IdUsuario]  INT           NULL,
    [IdEstado]   INT           NULL,
    [Modificado] DATETIME      NULL,
    [Creado]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdPerfil] ASC)
);

