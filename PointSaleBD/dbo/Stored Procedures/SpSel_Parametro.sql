-- =============================================
-- Author:		<Juan Carlos Carcamo Riveros>
-- Create date: <17/06/2024>
-- Description:	<Obtiene todos los parametros con los que coincide el id>
-- =============================================
CREATE PROCEDURE SpSel_Parametro
	@IdParametro INT
AS
BEGIN

	SELECT  IdParametro
			,NomParametro
			,DescParametro
			,ParValor
			,IdUsuario
			,IdEstado
			,ISNULL(Modificado,'')
			,Creado
	FROM	PARAMETROS
	WHERE	IdParametro = @IdParametro
	
END