namespace Leaning_5;

public class ThirdTask
{
    public void Multiplication()
    {
        Console.WriteLine("Please insert the number you want to multiply : ");
        int firstInputedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Plase type in the number for the multiplication of power : ");
        int secondInputedNumber = int.Parse(Console.ReadLine());

        int result = 1;
        
        for (int i = 0; i < secondInputedNumber; i++)
        {
            result = result * firstInputedNumber;
        }
        
        Console.WriteLine(result);
    }
}