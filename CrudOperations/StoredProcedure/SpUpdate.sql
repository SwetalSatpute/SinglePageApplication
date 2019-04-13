CREATE PROCEDURE SpUpdate(@EmpId int, @EmpName varchar(50), @Empsalary money)
AS BEGIN
UPDATE Emp SET EmpName=@EmpName,Empsalary=@Empsalary
WHERE EmpId=@EmpId
END
