namespace IceCreamApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Icecream dessert = new Icecream();
        Icecream fika = new Icecream();

        dessert.calculatePrice();
        
    }
}
