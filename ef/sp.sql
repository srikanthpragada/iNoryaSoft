Create PROCEDURE [dbo].[SalaryRange]
	@highest int output,
	@lowest int output
AS
	SELECT @highest = max(salary), @lowest = min(salary)
	from employees;

RETURN 0
