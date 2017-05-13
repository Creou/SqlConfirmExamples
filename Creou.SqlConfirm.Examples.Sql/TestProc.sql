CREATE PROCEDURE [dbo].[TestProc]
	@startId int,
	@endId int
AS
	SELECT Id, TestString, TestInteger, TestNumeric 
	FROM TestTable
	WHERE 
			Id >= @startId 
		AND Id <= @endId

RETURN 0
