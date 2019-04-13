CREATE PROCEDURE spInsertData(@EmpId INT,@EmpName VARCHAR(50),@Empsalary MONEY)
AS BEGIN
INSERT INTO Emp VALUES(@EmpId,@EmpName,@Empsalary)
END
