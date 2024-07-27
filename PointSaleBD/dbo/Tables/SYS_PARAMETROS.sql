﻿CREATE TABLE [dbo].[SYS_PARAMETROS] (
    [PAR_PK_CVE]        INT           IDENTITY (1, 1) NOT NULL,
    [PAR_DS_NOMBRE]     VARCHAR (100) NULL,
    [PAR_DS_VALOR]      VARCHAR (100) NULL,
    [PAR_PAR_PADRE]     INT           NULL,
    [EST_PK_CVE]        INT           NULL,
    [PAR_US_MODIFICADO] VARCHAR (20)  NULL,
    [PAR_FE_ULT_MOD]    DATETIME      NULL,
    [PAR_FE_CREADO]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([PAR_PK_CVE] ASC)
);
