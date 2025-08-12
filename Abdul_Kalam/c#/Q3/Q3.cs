using System;
using System.Text.RegularExpressions;

class Q3
{
    static void Main()
    {
        // i) ATM PIN
        int pin = 1234, tries = 0;
        bool granted = false;
        while (tries < 3)
        {
            Console.Write("Enter PIN: ");
            int entered = int.Parse(Console.ReadLine());
            if (entered == pin)
            {
                Console.WriteLine("Access Granted");
                granted = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                tries++;
            }
        }
        if (!granted) Console.WriteLine("Card Blocked");

        // ii) Multiplication table
        string choice;
        do
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
            Console.Write("Try another? (Y/N): ");
            choice = Console.ReadLine().ToUpper();
        } while (choice == "Y");

        // Electricity bill
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine());
        double bill = 0;
        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = (100 * 2) + ((units - 100) * 3);
        else
            bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);
        Console.WriteLine("Total Bill: ₹" + bill);

        // iii) Student score average
        int[] marks = new int[5];
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter mark {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
            sum += marks[i];
        }
        double avg = sum / 5.0;
        Console.WriteLine("Average: " + avg);
        if (avg >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");

        // iv) Name validation
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (Regex.IsMatch(name, @"^[A-Za-z\s]+$"))
            Console.WriteLine("Valid Name");
        else
            Console.WriteLine("Invalid Name");
    }
}
