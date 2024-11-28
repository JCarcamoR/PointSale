-- =============================================
-- Author:		<Juan Carlos Carcamo Riveros>
-- Create date: <24/11/2024>
-- Description:	<Obtiene el menu configurado para cada perfil.>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Sel_01_Menus]
	@CPL_DS_PERFIL VARCHAR(50)
AS
BEGIN
	DECLARE @CPL_PK_ID INT = (SELECT	CPL_PK_ID
							  FROM		CAT_PERFILES
							  WHERE		CPL_DS_PERFIL = @CPL_DS_PERFIL)

	SELECT	A.SMU_PK_ID,
			A.SOO_PK_ID,
			A.SMU_CVE_PADRE,
			A.SMU_CVE_ORDEN,
			A.SMU_DS_TITULO,
			A.SMU_DS_ICONO,
			C.SCR_DS_CONTROLADOR,
			D.SMO_DS_METODO
	FROM	SYS_MENUS A
	INNER
	JOIN	SYS_MENUS_PERFILES B
	ON		B.SMU_PK_ID = A.SMU_PK_ID
	INNER
	JOIN	SYS_CONTROLADORES C
	ON		C.SCR_PK_ID = A.SCR_PK_ID
	INNER
	JOIN	SYS_METODOS D
	ON		D.SMO_PK_ID = A.SMO_PK_ID
	WHERE	B.CPL_PK_ID = @CPL_PK_ID AND
			A.SEO_PK_ID = 1 
	ORDER
	BY		A.SMU_CVE_PADRE,
			A.SMU_CVE_ORDEN
END