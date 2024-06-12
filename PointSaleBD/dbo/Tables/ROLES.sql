CREATE TABLE [dbo].[ROLES] (
    [IdRol]      INT           NOT NULL,
    [DescRol]    VARCHAR (100) NULL,
    [IdEstado]   INT           NULL,
    [IdUsuario]  INT           NULL,
    [Modificado] DATETIME      NULL,
    [Creado]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdRol] ASC)
);

