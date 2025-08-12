using System;

class Q2
{
    static void Main()
    {
        // i) Calculator app
        int a = 10, b = 5;
        Console.WriteLine("Total apples: " + (a + b));
        Console.WriteLine("Difference of pencils: " + (a - b));
        Console.WriteLine("Total pages: " + (a * b));
        Console.WriteLine("Chocolates per kid: " + (a / b));
        Console.WriteLine("Leftover candies: " + (a % b));

        // ii) Player score comparison
        int playerA = 20, playerB = 15;
        Console.WriteLine("A > B: " + (playerA > playerB));
        Console.WriteLine("A == B: " + (playerA == playerB));
        Console.WriteLine("A <= B: " + (playerA <= playerB));

        // iii) Login system
        string username = "admin", password = "1234";
        Console.Write("Enter username: ");
        string u = Console.ReadLine();
        Console.Write("Enter password: ");
        string p = Console.ReadLine();

        if (u == username && p == password)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("At least one correct: " + (u == username || p == password));
        Console.WriteLine("Negation example: " + !(u == username));

        // iv) Quiz scoring
        int score = 50;
        score += 10;
        Console.WriteLine("After correct answer: " + score);
        score -= 5;
        Console.WriteLine("After wrong answer: " + score);
        score *= 2;
        Console.WriteLine("After bonus round: " + score);
        score /= 5;
        Console.WriteLine("After penalty: " + score);

        // v) Election booth loop for 5 people
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age: ");
            int personAge = int.Parse(Console.ReadLine());
            if (personAge >= 18)
                Console.WriteLine("Eligible to Vote");
            else
                Console.WriteLine("Not Eligible");
        }
    }
}
