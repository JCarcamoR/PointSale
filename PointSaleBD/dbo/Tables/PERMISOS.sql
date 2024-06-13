CREATE TABLE [dbo].[PERMISOS] (
    [IdPermiso]  INT      NOT NULL,
    [IdMenu]     INT      NULL,
    [IdPerfil]   INT      NULL,
    [Estatus]    BIT      NULL,
    [IdEstado]   INT      NULL,
    [Modificado] DATETIME NULL,
    [Creado]     DATETIME NULL,
    PRIMARY KEY CLUSTERED ([IdPermiso] ASC)
);

