decimal balance = 1000m;
bool isRunning = true;


Console.WriteLine($"Welcome to BankOfAmerica!!");
while (isRunning)
{

    displayMenu();
    string? choice = Console.ReadLine();
    string? input;
    string output;



    switch (choice)
    {
        case "1":
            Console.WriteLine($"Balance is ${balance:F2}");
            break;
        case "2":
            Console.WriteLine($"Deposit selected");
            input = Console.ReadLine();
            output=depositMoney(input,ref balance);
            Console.WriteLine(output);

            break;
        case "3":
            Console.WriteLine($"Withdrawal selected");
            input = Console.ReadLine();
            output = WithdrawMoney(input,ref balance);
            Console.WriteLine(output);
            break;
        case "4":
            Console.WriteLine($"Thank you for using ATM");
            isRunning = false;
            break;
        default:
            Console.WriteLine($"Invalid option");
            break;
    }


}

static void displayMenu()
{
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Deposit Money");
    Console.WriteLine("3. Withdraw Money");
    Console.WriteLine("4. Exit");
}

static string depositMoney(string? input,ref decimal balance)
    {
        if (decimal.TryParse(input, out decimal depositvalue) && depositvalue > 0)
        {
            balance += depositvalue;
            return $"UpdatedBalance is ${balance:F2}";

        }
        else
        {
        return $" Invalid deposit amount.";


        }

}

static string WithdrawMoney(string? input, ref decimal balance)
{
    if (decimal.TryParse(input, out decimal withdrwamt) && withdrwamt > 0 && (balance >= withdrwamt))
    {
        balance -= withdrwamt;
        return $"UpdatedBalance is ${balance:F2}";

    }
    else
    {
        return $" Invalid withdrawal amount or insufficient funds..";


    }
}