CREATE TABLE [dbo].[SYS_PERMISOS] (
    [PRM_PK_CVE]        INT          IDENTITY (1, 1) NOT NULL,
    [PER_PK_CVE]        INT          NULL,
    [MEN_PK_CVE]        INT          NULL,
    [EST_PK_CVE]        INT          NULL,
    [PRM_US_MODIFICADO] VARCHAR (20) NULL,
    [PRM_FE_ULT_MOD]    DATETIME     NULL,
    [PRM_FE_CREADO]     DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([PRM_PK_CVE] ASC)
);



