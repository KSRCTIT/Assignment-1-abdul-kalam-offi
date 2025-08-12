using System;

class Q1
{
    static void Main()
    {
        // i) Temperature check using float literal
        float temperature = 36.6f;
        if (temperature > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");

        // ii) Age eligibility check using int literal
        int age = 18;
        if (age >= 18)
            Console.WriteLine("Eligible to Vote");
        else
            Console.WriteLine("Not Eligible");

        // iii) Gender using char literal
        char gender = 'M';
        if (gender == 'M')
            Console.WriteLine("Male");
        else if (gender == 'F')
            Console.WriteLine("Female");
        else
            Console.WriteLine("Other");

        // iv) Price and discount calculation using double literal
        double price = 1000.0;
        double discount = 10.0; // percentage
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);

        // v) Login success using bool literal
        bool loginSuccess = true;
        if (loginSuccess)
            Console.WriteLine("Login successful");
        else
            Console.WriteLine("Access denied");

        // vi) Declaring various literals & printing type
        int myAge = 25;
        float temp = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine($"{myAge} is of type {myAge.GetType()}");
        Console.WriteLine($"{temp} is of type {temp.GetType()}");
        Console.WriteLine($"{grade} is of type {grade.GetType()}");
        Console.WriteLine($"{isPassed} is of type {isPassed.GetType()}");
    }
}
