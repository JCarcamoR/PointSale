﻿CREATE TABLE [dbo].[SYS_USUARIOS] (
    [USR_PK_CVE]        INT           IDENTITY (1, 1) NOT NULL,
    [USR_UK_USUARIO]    VARCHAR (20)  NULL,
    [USR_DS_PASSWORD]   VARCHAR (100) NULL,
    [USR_DS_FIRMA]      VARCHAR (20)  NULL,
    [USR_FE_ULT_ACCESO] DATETIME      NULL,
    [USR_FE_CBO_PWD]    DATETIME      NULL,
    [USR_FE_CBO_FIRMA]  DATETIME      NULL,
    [PER_PK_CVE]        INT           NULL,
    [EST_PK_CVE]        INT           NULL,
    [USR_US_MODIFICADO] VARCHAR (20)  NULL,
    [USR_FE_ULT_MOD]    DATETIME      NULL,
    [USR_FE_CREADO]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([USR_PK_CVE] ASC)
);

