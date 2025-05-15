try
{
    Process1();
}
catch
{
    Console.WriteLine("An excepiton has occurred.");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine("float1 / float2 = " + (float1 / float2));
        Console.WriteLine("number1 / number2 = " + (number1 / number2));
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
    {
        try
        {
            smallNumber = (byte)number1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Overflow exception caught: {ex.Message}");
        }

    }
}