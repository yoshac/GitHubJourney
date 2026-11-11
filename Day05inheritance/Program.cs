
BankAccount account1 = new BankAccount("Alice", 1000m);
BankAccount account2 = new SavingsAccount("Bob", 2000m);
BankAccount account3 = new CheckingAccount("Charlie", 3000m);
account1.DisplayAccountType();
account2.DisplayAccountType();  
account3.DisplayAccountType();
account2.Deposit(500m);
account3.Deposit(200m);

Console.WriteLine($"HolderNames1  {account1.HolderName},and balance :{account1.Balance:F2}");
Console.WriteLine($"HolderNames1  {account2.HolderName},and balance :{account2.Balance:F2}");

Console.WriteLine($"HolderNames1  {account3.HolderName},and balance :{account3.Balance:F2}");
public class BankAccount
{
    public string HolderName { get; private set; }
    public decimal Balance { get;private set; }
    public BankAccount(string name, decimal bal)
    {
        Console.WriteLine("base constructor");
        HolderName = name;
        Balance = bal;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount;
    }
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("This is a bank Account");
    }
}

public class SavingsAccount: BankAccount
{
    public SavingsAccount(string holdername, decimal blan) : base(holdername,blan)
    {
        Console.WriteLine("SavingsAccount constructor");
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Savings Account");
    }
}
public class CheckingAccount : BankAccount
{
    public CheckingAccount(string holdername, decimal blan) : base(holdername, blan)
    {
        Console.WriteLine("CheckingAccount constructor");
    }
    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a CheckingAccount");
    }
}

