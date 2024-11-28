CREATE TABLE [dbo].[SYS_MENUS] (
    [SMU_PK_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [SMN_PK_ID]     INT           NULL,
    [SEO_PK_ID]     INT           NULL,
    [SOO_PK_ID]     INT           NULL,
    [SCR_PK_ID]     INT           NULL,
    [SMO_PK_ID]     INT           NULL,
    [SMU_CVE_PADRE] INT           NULL,
    [SMU_CVE_ORDEN] INT           NULL,
    [SMU_DS_TITULO] VARCHAR (200) NULL,
    [SMU_DS_ICONO]  VARCHAR (200) NULL
);

