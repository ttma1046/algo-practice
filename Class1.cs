using System;
using System.Linq;

class Program
{
    static void SetString1(ref string value)
    {
        if (value == "cat") // Test parameter value
        {
            Console.WriteLine("Is cat");
        }
        value = "dog"; // Assign parameter to new value
    }

    static void SetString2(int number, out string value)
    {
        if (number == 1) // Check int parameter
        {
            value = "one"; // Assign out parameter
        }
        else
        {
            value = "carrot"; // Assign out parameter
        }
    }

    static void Test()
    {
        /*
        int[] array = { 1, 2, 3, 4, 5 };
        int result = array.Aggregate((a, b) => b + a);
        // 1 + 2 = 3
        // 3 + 3 = 6
        // 6 + 4 = 10
        // 10 + 5 = 15
        Console.WriteLine(result);

        result = array.Aggregate((a, b) => b * a);
        // 1 * 2 = 2
        // 2 * 3 = 6
        // 6 * 4 = 24
        // 24 * 5 = 120
        Console.WriteLine(result);
        */
        string value1 = "cat"; // Assign string value
        SetString1(ref value1); // Pass as reference parameter
        Console.WriteLine(value1); // Write result

        string value2; // Unassigned string
        SetString2(1, out value2); // Pass as out parameter
        Console.WriteLine(value2); // Write result

    }
}