string employeeName = "John";
decimal hourlyRate = 35.50m;
int hoursWorked = 45;
decimal deductionRate = 0.15m;

// Step 1: Calculate gross salary
decimal grossSalary = Math.Round(hourlyRate * hoursWorked,2,MidpointRounding.AwayFromZero);


// Step 2: Calculate deduction amount

decimal deductionAmount = Math.Round(grossSalary * deductionRate,2,MidpointRounding.AwayFromZero);
// Step 3: Calculate net salary

decimal netSalary = Math.Round(grossSalary - deductionAmount,2,MidpointRounding.AwayFromZero);
// Step 4: Display employee name,
// gross salary, deduction, and net salary
Console.WriteLine($"employee name : {employeeName}");
Console.WriteLine($"Grosssalary: {grossSalary:F2}");
Console.WriteLine($"Deductionamount :{deductionAmount:F2}");
Console.WriteLine($"Netsalary :{netSalary:F2}");