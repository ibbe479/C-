namespace Assignment_2;

/// <summary>
/// Calculates the total cost of a purchase with quantity discounts.
/// </summary>
public class CostCalculator
{
    private double unitPrice;
    private int quantity;
    private double discount;
    private double originalTotal;
    private double finalTotal;

    /// <summary>
    /// Runs the calculator until the user presses N och enter.
    /// </summary>
    public void Run()
    {
        string answer = "y";

        while (answer == "y")
        {
            ReadPrice();
            ReadQuantity();
            CalculateDiscount();
            CalculateTotal();
            ShowResult();

            Console.WriteLine("Do you want to calculate again? (y/N)");
            answer = Console.ReadLine();
        }
    }

    /// <summary>
    /// Reads the price per unit. Asks again until it is greater than 0.
    /// </summary>
    private void ReadPrice()
    {
        Console.WriteLine("Enter the price per unit: ");
        bool ok = double.TryParse(Console.ReadLine(), out unitPrice);

        while (ok == false || unitPrice <= 0)
        {
            Console.WriteLine("Invalid price. It must be a number greater than 0. Try again: ");
            ok = double.TryParse(Console.ReadLine(), out unitPrice);
        }
    }

    /// <summary>
    /// Reads the number of units. Asks again until it is greater than 0.
    /// </summary>
    private void ReadQuantity()
    {
        Console.WriteLine("Enter the number of units: ");
        bool ok = int.TryParse(Console.ReadLine(), out quantity);

        while (ok == false || quantity <= 0)
        {
            Console.WriteLine("Invalid quantity. It must be a whole number greater than 0. Try again: ");
            ok = int.TryParse(Console.ReadLine(), out quantity);
        }
    }

    /// <summary>
    /// Decides the discount percentage based on the quantity.
    /// </summary>
    private void CalculateDiscount()
    {
        if (quantity >= 100)
        {
            discount = 50;
        }
        else if (quantity >= 50)
        {
            discount = 40;
        }
        else if (quantity >= 20)
        {
            discount = 30;
        }
        else if (quantity >= 10)
        {
            discount = 20;
        }
        else
        {
            discount = 0;
        }
    }

    /// <summary>
    /// Calculates the total cost before and after the discount.
    /// </summary>
    private void CalculateTotal()
    {
        originalTotal = unitPrice * quantity;
        finalTotal = originalTotal - (originalTotal * discount / 100);
    }

    /// <summary>
    /// Shows the original total, the discount and the final total.
    /// </summary>
    private void ShowResult()
    {
        Console.WriteLine($"Original total: {originalTotal}");
        Console.WriteLine($"Discount: {discount}%");
        Console.WriteLine($"Final total: {finalTotal}");
    }
}