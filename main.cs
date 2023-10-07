using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Number of hours: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Number of miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        
        const double BASE_RATE = 200.0;
        const double HOURLY_RATE = 150.0;
        const double MILE_RATE = 2.0;

        
        double totalFee = BASE_RATE + (hours * HOURLY_RATE) + (miles * MILE_RATE);

        
        Console.WriteLine($"Total moving fee: ${totalFee:F2}");
    }
}