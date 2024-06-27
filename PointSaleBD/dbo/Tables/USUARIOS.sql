CREATE TABLE [dbo].[USUARIOS] (
    [IdUsuario]   INT IDENTITY(1,1) NOT NULL,
    [Clave]       VARCHAR (20)      NULL,
    [Contrasenia] VARCHAR (20)      NULL,
    [Firma]       VARCHAR (20)      NULL,
    [IdPerfil]    INT               NULL,
    [IdPersona]   INT               NULL,
    [IdEstado]    INT               NULL,
    [IdUusario]   INT               NULL,
    [Modificado]  DATETIME          NULL,
    [Creado]      DATETIME          NULL,
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

