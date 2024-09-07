namespace SquareBetweenTwoNumbers;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Lower Bound");
        int lowerBound = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Upper Bound");
        int upperBound = Convert.ToInt32(Console.ReadLine());

        int start = (int)Math.Ceiling(Math.Sqrt(lowerBound));
        int end = (int)Math.Floor(Math.Sqrt(upperBound));
  
        for (int i = start; i <= end; i++)
            Console.WriteLine($"Squre of {i} is {i * i}");

        Console.ReadLine();
    }
}
