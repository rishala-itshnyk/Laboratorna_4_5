using System;

class Program
{
    static void Main()
    {
        double R, x, y;

        Console.Write("R = ");
        R = double.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 0; i++)
        {
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());

            if ((x + R) * (x + R) + (y - R) * (y - R) <= R * R ||
                (x >= -R && x <= 0 && y >= 0 && y <= R - x) ||
                (x >= 0 && x <= R && y >= 0 && y <= R) ||
                (x >= -R && x <= 0 && y >= -R && y <= 0))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        
        Random random = new Random();
        
        for (int i = 0; i < 10; i++)
        { 
            x = (random.NextDouble() * 2 - 1) * R;
            y = (random.NextDouble() * 2 - 1) * R;

            if ((x + R) * (x + R) + (y - R) * (y - R) <= R * R ||
                (x >= -R && x <= 0 && y >= 0 && y <= R - x) ||
                (x >= 0 && x <= R && y >= 0 && y <= R) ||
                (x >= -R && x <= 0 && y >= -R && y <= 0))
            {
                Console.WriteLine($"({x}, {y}): yes");
            }
            else
            {
                Console.WriteLine($"({x}, {y}): no");
            }
        }
        
        Console.ReadLine();
    }
}