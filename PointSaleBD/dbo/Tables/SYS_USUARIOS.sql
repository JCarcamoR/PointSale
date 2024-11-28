CREATE TABLE [dbo].[SYS_USUARIOS] (
    [SUO_PK_ID]       INT          IDENTITY (1, 1) NOT NULL,
    [SMN_PK_ID]       INT          NULL,
    [SEO_PK_ID]       INT          NULL,
    [CPA_PK_ID]       INT          NULL,
    [SUO_DS_CLAVE]    VARCHAR (10) NULL,
    [SUO_DS_PWORD]    VARCHAR (20) NULL,
    [SUO_DS_FIRMA]    VARCHAR (10) NULL,
    [SUO_FE_UACCESO]  DATE         NULL,
    [SUO_HR_UACCESO]  TIME (7)     NULL,
    [SUO_FE_REGISTRO] DATETIME     NULL
);

