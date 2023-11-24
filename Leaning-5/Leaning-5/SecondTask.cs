namespace Leaning_5;

public class SecondTask
{

    public void SpaceCounter()
    {
        string test = Console.ReadLine();
        int jumlahSpasi = 0;
        foreach (char character in test)
            if (character == ' ')
                jumlahSpasi++;
        Console.WriteLine("Jumlah spasi nya ada " + jumlahSpasi);
    }
}