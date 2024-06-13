CREATE TABLE [dbo].[DOMICILIOS] (
    [IdDomicilio]   INT           NOT NULL,
    [DescDomicilio] VARCHAR (500) NULL,
    [IdCodPostal]   INT           NULL,
    [IdColonia]     INT           NULL,
    [IdPais]        INT           NULL,
    [IdPersona]     INT           NULL,
    [IdUsuario]     INT           NULL,
    [IdEstado]      INT           NULL,
    [Modificado]    INT           NULL,
    [Creado]        INT           NULL,
    PRIMARY KEY CLUSTERED ([IdDomicilio] ASC)
);

