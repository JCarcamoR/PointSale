CREATE TABLE [dbo].[EMAIL] (
    [IdEmail]    INT IDENTITY(1,1)  NOT NULL,
    [Email]      VARCHAR (100)      NULL,
    [PwdEmail]   VARCHAR (100)      NULL,
    [EmailDef]   BIT                NULL,
    [IdPersona]  INT                NULL,
    [IdEstado]   INT                NULL,
    [Modificado] DATETIME           NULL,
    [Creado]     DATETIME           NULL,
    PRIMARY KEY CLUSTERED ([IdEmail] ASC)
);

