string message = "(What if)I am (only interested) in the last (set of parentheses)?";

while (true)
{
    int openingPosition = message.LastIndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;

    int closingPosition = message.LastIndexOf(')');
    int lenght = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, lenght));

    // Note the overload of the Subtring to return only the remaining
    // unprocessed message:
    message = message.Substring(closingPosition =1);
}



