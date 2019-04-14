CREATE PROCEDURE spInsertData(@EmpId int, @EmpName varchar(50),@EmpSalary money)
AS BEGIN
INSERT INTO  Emp VALUES(@EmpId,@EmpName,@EmpSalary)
END
