CREATE TABLE [dbo].[TELEFONO] (
    [IdTelefono] INT IDENTITY(1,1)  NOT NULL,
    [Telefono]   INT                NULL,
    [IdPersona]  INT                NULL,
    [IdUsuario]  INT                NULL,
    [IdEstado]   INT                NULL,
    [Modificado] INT                NULL,
    [Creado]     INT                NULL,
    PRIMARY KEY CLUSTERED ([IdTelefono] ASC)
);

