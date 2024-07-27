CREATE TABLE [dbo].[SYS_MENUS] (
    [MEN_PK_CVE]        INT           IDENTITY (1, 1) NOT NULL,
    [MEN_DS_TITULO]     VARCHAR (200) NULL,
    [MEN_DS_ICONO]      VARCHAR (500) NULL,
    [MEN_DS_RUTA]       VARCHAR (MAX) NULL,
    [MEN_NUM_NIVEL]     INT           NULL,
    [MEN_CVE_PADRE]     INT           NULL,
    [MEN_NUM_ORDEN]     INT           NULL,
    [EST_PK_CVE]        INT           NULL,
    [MEN_US_MODIFICADO] VARCHAR (20)  NULL,
    [MEN_FE_ULT_MOD]    DATETIME      NULL,
    [MEN_FE_CREADO]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([MEN_PK_CVE] ASC)
);

