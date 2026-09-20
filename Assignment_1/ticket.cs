using System;

namespace  Assignment_1;

public class ticket
{
    int name;
    double price = 99.90;
    int numOfAdults;
    int numOfChildren;
    double amountToPay;


    public void setInfo()
    {
        Console.WriteLine("Press enter to start the ticket function");
        Console.ReadLine();

        Console.WriteLine("How many adults are attending? ");
        numOfAdults = int.Parse(Console.ReadLine());

        Console.WriteLine("How many children are attending? ");
        numOfChildren = int.Parse(Console.ReadLine());

        amountToPay = (numOfAdults * price) + (numOfChildren * (price * 0.25));
    }

    public void showInfo()
    {
        Console.WriteLine($"Number of adults: {numOfAdults}");
        Console.WriteLine($"Number of children: {numOfChildren}");
        Console.WriteLine($"Total amount to pay: {amountToPay}");
    }
}
