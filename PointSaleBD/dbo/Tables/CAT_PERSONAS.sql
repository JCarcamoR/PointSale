﻿CREATE TABLE [dbo].[CAT_PERSONAS] (
    [PER_PK_CVE]          INT           IDENTITY (1, 1) NOT NULL,
    [PER_DS_NOMBRE]       VARCHAR (100) NULL,
    [PER_DS_NOMBRE2]      VARCHAR (100) NULL,
    [PER_DS_APE_PAT]      VARCHAR (100) NULL,
    [PER_DS_APE_MAT]      VARCHAR (100) NULL,
    [PER_FE_NACIMIENTO]   DATE          NULL,
    [EST_PK_CVE]          INT           NULL,
    [PER_US_MODIFICACION] VARCHAR (20)  NULL,
    [PER_FE_ULT_MOD]      DATETIME      NULL,
    [PER_FE_CREADO]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([PER_PK_CVE] ASC)
);
