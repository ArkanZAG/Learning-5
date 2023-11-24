namespace Leaning_5;

public class FirstTask
{
    private string userName;
    public void Greetings()
    {
        Console.WriteLine("Please insert your name : ");
        userName = Console.ReadLine();
        Console.WriteLine("Welcome " + userName+"!");
        Console.WriteLine("Have a nice day!");
    }
}