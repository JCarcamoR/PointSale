CREATE TABLE [dbo].[METODOS_PAGO] (
    [IdMetPago]  INT IDENTITY(1,1)  NOT NULL,
    [DescMetPag] VARCHAR (200)      NULL,
    [IdUsuario]  INT                NULL,
    [IdEstado]   INT                NULL,
    [Modificado] DATETIME           NULL,
    [Created]    DATETIME           NULL,
    PRIMARY KEY CLUSTERED ([IdMetPago] ASC)
);

