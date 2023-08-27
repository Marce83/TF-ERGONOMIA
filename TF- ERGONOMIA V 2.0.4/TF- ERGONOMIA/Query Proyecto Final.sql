select * from usuarios
order by 1

exec SP_Login 'DSATURNO','Acb123'

SELECT * FROM RulaTablaA
WHERE brazo = 2
AND Antebrazo = 1
AND Muñeca = 3
AND Giro = 2


SELECT COUNT(*) FROM RulaTablaA
WHERE brazo = 2
AND antebrazo = 1

DELETE FROM rulatablaA
WHERE brazo = 2
AND  antebrazo = 1
AND Muñeca = 1
 
ALTER TABLE rulatablaA DROP COLUMN Muneca2Giro2
ALTER TABLE rulatablaA DROP COLUMN Muneca3Giro1
ALTER TABLE rulatablaA DROP COLUMN Muneca3Giro2
ALTER TABLE rulatablaA DROP COLUMN Muneca4Giro1
ALTER TABLE rulatablaA DROP COLUMN Muneca4Giro2

EXEC sys.sp_rename @objname = N'RulaTablaA.Muneca1Giro1',  -- nvarchar(1035)
                   @newname = 'Muñeca', -- sysname
                   @objtype = 'COLUMN'    -- varchar(13)

EXEC sys.sp_rename @objname = N'RulaTablaA.Muneca1Giro2',  -- nvarchar(1035)
                   @newname = 'Giro', -- sysname
                   @objtype = 'COLUMN'    -- varchar(13)

EXEC sys.sp_rename @objname = N'RulaTablaA.Muneca2Giro1',  -- nvarchar(1035)
                   @newname = 'Valor', -- sysname
                   @objtype = 'COLUMN'    -- varchar(13)


SELECT * FROM RulaTablaB

DROP TABLE RulaTablaC

SELECT * FROM RulaTablaC
WHERE tablab = 5
AND tablaa = 5;


