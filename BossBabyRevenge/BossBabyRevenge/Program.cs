public class BossBabyRevenge
{
    public static void Main(string[] args)
    {
        // To get input from keyboard
        Console.Write("Type you input here (S,R): ");
        string input = Console.ReadLine();
        Console.WriteLine($"Your input is: {input}");

        // To validate and show output result
        Console.Write("Your output will be: ");
        Console.WriteLine(IsGoodBoy(input));
    }

    public static string IsGoodBoy(string events)
    {
        int shots = 0;
        int revenge = 0;

        foreach (char c in events)
        {
            if (c == 'S' || c == 's')
            {
                shots++;
            }
            else if (c == 'R' || c == 'r')
            {
                if (shots == 0)
                {
                    return "Bad boy";
                }
                revenge++;
            }

            if (revenge > shots)
            {
                revenge = shots;
            }
        }

        return shots <= revenge ? "Good boy" : "Bad boy";
    }
}
