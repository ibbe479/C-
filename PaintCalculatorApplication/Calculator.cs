using System;

namespace PaintCalculatorApplication;

public class Calculator
{
    string paint;
    int height; 
    int witdh;
    

    public void calculatePrice()
    {
        
        Console.WriteLine("what color do you need? "); 
        paint = Console.ReadLine();

        Console.WriteLine("how high is the surface ? ");
        height= int.Parse(Console.ReadLine());

        Console.WriteLine("how wide is the area? ");
        witdh = int.Parse(Console.ReadLine());

        double surface=height * witdh;

        double oneCoat = surface * 0.1;

        double towCoats = oneCoat *2;


        Console.WriteLine($"for one coat you need {oneCoat}L ");
        Console.WriteLine();
        Console.WriteLine($"for two coats you will need {towCoats}L ");

        if (oneCoat <= 3)
        {
            Console.WriteLine($"you need 3L can ");
        }
        else if (oneCoat <= 5)
        { 
            Console.WriteLine($"you need 5L can ");
        }
        else
        {
             Console.WriteLine($"you need 10L can ");
        }
    }
}
