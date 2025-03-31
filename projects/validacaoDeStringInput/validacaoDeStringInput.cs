/*
string? readResult;
Console.WriteLine("Enter a string: ");

do
{
    readResult = Console.ReadLine();
} while (readResult == null || readResult.
*/

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three caracaters: ");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Please enter a string containing at least three characters: ");
        }
    }
} while (validEntry == false);