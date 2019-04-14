CREATE PROCEDURE SpDeleteData (@EmpId int)
AS BEGIN
DELETE FROM Emp where EmpId=@EmpId
END