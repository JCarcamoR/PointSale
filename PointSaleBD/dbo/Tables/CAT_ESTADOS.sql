﻿CREATE TABLE [dbo].[CAT_ESTADOS] (
    [EST_PK_CVE]          INT           IDENTITY (1, 1) NOT NULL,
    [EST_DS_NOMBRE]       VARCHAR (100) NULL,
    [EST_ST_REGISTRO]     BIT           NULL,
    [EST_US_MODIFICACION] VARCHAR (20)  NULL,
    [EST_FE_ULT_MOD]      DATETIME      NULL,
    [EST_FE_CREADO]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([EST_PK_CVE] ASC)
);

