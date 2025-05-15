using System;

checked
{ 

    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Error: The number is too large to be represented as an integer. {ex.Message}");
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine($"String length: {length}");
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Error: The reference is null. {ex.Message}");
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine($"Number at index 5: {numbers[5]}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Error: Index out of range. {ex.Message}");
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine($"Result: {result2}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: Division by zero. {ex.Message}");
}

Console.WriteLine("End of program.");
