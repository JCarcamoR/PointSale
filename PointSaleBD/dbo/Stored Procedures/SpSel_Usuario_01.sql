
CREATE PROCEDURE SpSel_Usuario_01
	@Usuario	VARCHAR(20),
	@Password	VARCHAR(255)
AS
BEGIN
	-- ===========================================
	-- JCCR:07/11/24: SE CREA SP PAR AUTORIZAR EL INICIO DE SESION
	-- =============================================
	SELECT @Usuario AS UserName ,@Password AS UserPassword

END