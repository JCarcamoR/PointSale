CREATE TABLE [dbo].[MENU] (
    [IdMenu]     INT           NOT NULL,
    [DesMenu]    VARCHAR (100) NULL,
    [MenIcono]   VARCHAR (50)  NULL,
    [UrlMenu]    VARCHAR (300) NULL,
    [MenPadre]   INT           NULL,
    [MenOrden]   INT           NULL,
    [MenNivel]   INT           NULL,
    [MenTipo]    INT           NULL,
    [IdUsuario]  INT           NULL,
    [IdEstado]   INT           NULL,
    [Modificado] DATETIME      NULL,
    [Creado]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdMenu] ASC)
);

