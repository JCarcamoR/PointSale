CREATE TABLE [dbo].[CAT_PERSONAS] (
    [CPA_PK_ID]      INT           IDENTITY (1, 1) NOT NULL,
    [SMN_PK_ID]      INT           NULL,
    [SEO_PK_ID]      INT           NULL,
    [CPL_PK_ID]      INT           NULL,
    [CPA_DS_NOMBRE]  VARCHAR (200) NULL,
    [CPA_DS_APE_PAT] VARCHAR (200) NULL,
    [CPA_DS_APE_MAT] VARCHAR (200) NULL,
    [CPA_FE_NAC]     DATE          NULL,
    [CPA_DS_RFC]     VARCHAR (20)  NULL
);

