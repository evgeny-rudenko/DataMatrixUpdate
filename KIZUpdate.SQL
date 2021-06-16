declare @cnt int
set @cnt = (select count (*) from kiz where BARCODE = @DatamatrixBase64)

if @cnt =0 
begin 
update KIZ
	set BARCODE=@DatamatrixBase64, GTIN_SGTIN = @GTIN_SGTIN , SGTIN = @SGTIN, GTIN = @GTIN
	where ID_KIZ_GLOBAL = @ID_KIZ_GLOBAL
end
