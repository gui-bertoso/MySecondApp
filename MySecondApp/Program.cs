namespace MySecondApp;

public class MySecondApp
{
    static void Header(string [] args)
    {
        Console.Clear();
        Console.WriteLine("Loading");
        Task.Delay(1000).Wait();
        Console.Clear();
        Console.WriteLine("Loading.");
        Task.Delay(1000).Wait();
        Console.Clear();
        Console.WriteLine("Loading..");
        Task.Delay(1000).Wait();
        Console.Clear();
        Console.WriteLine("Loading...");
        Task.Delay(1000).Wait();
        Console.Clear();
    }
    static void Main(string[] args)
    {
        Header(args);
        Console.WriteLine("Hello user!");
        Console.WriteLine("Select the option: \n [1] It's par?");
        Console.Write("R: ");
        string j = Console.ReadLine();
        Console.Clear();
        
        if (j == "1")
        {
            while (1 > 0)
            {
                Console.Write("Insert number: ");
                string i = Console.ReadLine();
                if (i != "exit")
                {
                    if (int.Parse(i) % 2 == 0)
                    {
                        Console.WriteLine($"the number {i} it's par");
                    }
                    else
                    {
                        Console.WriteLine($"the number {i} it's impar");
                    }

                    Task.Delay(1000).Wait();
                    Console.Clear();
                }
                else
                {
                    Main(args);
                }
            }
        }
    }
}
