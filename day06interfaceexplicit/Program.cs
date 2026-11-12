IWorker worker1 = new Developer();
IWorker worker2 = new Tester();

worker1.Work();
worker2.Work();
if(worker1 is Developer dev)
{
    dev.Debug();
}
try
{
    Developer dev1= (Developer)worker2;
}
catch(Exception InvalidCastException)
{
    Console.WriteLine(" Cannot convert Tester to Developer");
}

Console.WriteLine(" Program completed");
public interface IWorker
{
    void Work();
}

public class Developer : IWorker
{
    public void Work()
    { 
        Console.WriteLine("Developer is coding");
    }
    public void Debug()
    {
        Console.WriteLine("Developer is debugging");
    }
}

public class Tester : IWorker
{
    public void Work()
    {
        Console.WriteLine("Tester is testing");
    }
}