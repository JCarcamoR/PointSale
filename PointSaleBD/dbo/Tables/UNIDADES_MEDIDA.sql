CREATE TABLE [dbo].[UNIDADES_MEDIDA] (
    [IdUmedida]  INT IDENTITY(1,1)  NOT NULL,
    [DesUmedida] VARCHAR (150)      NULL,
    [DesSimbolo] VARCHAR (20)       NULL,
    [IdEstado]   INT                NULL,
    [Modificado] DATETIME           NULL,
    [Creado]     DATETIME           NULL,
    PRIMARY KEY CLUSTERED ([IdUmedida] ASC)
);

