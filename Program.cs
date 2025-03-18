namespace Format_alphanumeric_data_for_presentation;

class Program
{
    static void Main(string[] args)
    {
        string first = "Nei";
        string second = "takk";
        Console.WriteLine("{0} {1}!", first, second);
        Console.WriteLine("{0} {0} {0}!", first, second);

        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
    }

}
