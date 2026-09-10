namespace IceCreamApp;
internal class Icecream
{
    private string flavor = "vanila" ;//cherry
    private int numOfScoops = 2;
    private double pricePerScoop = 35.99;

    //operations ---> methods 

    public void calculatePrice()
    {
        double totalPrice = numOfScoops * pricePerScoop;
        Console.WriteLine("The total price is " + totalPrice);
    }

    // read input
    //calculation 
    // show output
}
