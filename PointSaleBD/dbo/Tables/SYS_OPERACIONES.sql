CREATE TABLE [dbo].[SYS_OPERACIONES] (
    [OPE_PK_CVE]        INT          IDENTITY (1, 1) NOT NULL,
    [PRM_PK_CVE]        INT          NULL,
    [ACC_PK_CVE]        INT          NULL,
    [EST_PK_CVE]        INT          NULL,
    [OPE_US_MODIFICADO] VARCHAR (20) NULL,
    [OPE_FE_ULT_MOD]    DATETIME     NULL,
    [OPE_FE_CREADO]     DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([OPE_PK_CVE] ASC)
);

