﻿CREATE TABLE [dbo].[SYS_ACCIONES] (
    [ACC_PK_CVE]        INT          IDENTITY (1, 1) NOT NULL,
    [ACC_DS_NOMBRE]     VARCHAR (50) NULL,
    [EST_PK_CVE]        INT          NULL,
    [ACC_US_MODIFICADO] VARCHAR (20) NULL,
    [ACC_FE_ULT_MOD]    DATETIME     NULL,
    [ACC_FE_CREADO]     DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([ACC_PK_CVE] ASC)
);

