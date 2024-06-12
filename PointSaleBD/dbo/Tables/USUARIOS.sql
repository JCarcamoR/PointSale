CREATE TABLE [dbo].[USUARIOS] (
    [IdUsuario]   INT          NOT NULL,
    [Clave]       VARCHAR (20) NULL,
    [Contrasenia] VARCHAR (20) NULL,
    [Firma]       VARCHAR (20) NULL,
    [IdUusario]   INT          NULL,
    [IdRol]       INT          NULL,
    [IdPerfil]    INT          NULL,
    [IdPersona]   INT          NULL,
    [IdEstado]    INT          NULL,
    [Modificado]  DATETIME     NULL,
    [Creado]      DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

