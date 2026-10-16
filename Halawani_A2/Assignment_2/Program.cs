namespace Assignment_2;

class Program
{
    static void Main(string[] args)
    {
        CostCalculator myCalculator = new CostCalculator();
        GuessTheNumber myGame = new GuessTheNumber();
        
        Console.WriteLine("CostCalculator");
        myCalculator.Run();
        Console.WriteLine();
        Console.WriteLine("GuessTheNumber");
        myGame.Run();
       
    }
}