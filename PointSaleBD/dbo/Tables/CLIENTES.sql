CREATE TABLE [dbo].[CLIENTES] (
    [IdCliente]   INT           NOT NULL,
    [Nombre]      VARCHAR (200) NULL,
    [RazonSocial] VARCHAR (200) NULL,
    [IdPersona]   INT           NULL,
    [IdUsuario]   INT           NULL,
    [IdEstado]    INT           NULL,
    [Modificado]  DATETIME      NULL,
    [Created]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdCliente] ASC)
);

