using System;

namespace Assignment_1;

public class pet
{
    private string name;
    private int age;
    private bool isFemale;

    public void setInfo()
    {
        Console.WriteLine("what is your pet name? ");
        name = Console.ReadLine();

        Console.WriteLine("how old is your pet? ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("is your pet female? (true/false) ");
        isFemale = bool.Parse(Console.ReadLine());
    }
    
    public void showInfo()
    {
        Console.WriteLine($"your pet name is {name} ");
        Console.WriteLine($"your pet age is {age} ");
        if (isFemale)
        {
            Console.WriteLine($"your pet is female ");
        }
        else
        {
            Console.WriteLine($"your pet is male ");
        }
    }

}
