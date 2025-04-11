string message = "(What if) I have [diffent symbols] but every {open Symbol} needs a [matching close symbol]?";

/*
    The IndexOfAny() helper method requires a char array of characters.
    You want to look for:
*/

char[] openSymbols = { '[', '{', '(' };

/*
    You'll see a slightly diffent technique for interating through
    the characters in the strings. This time m using the closing
    position of the previous iteration as the starting index for the
    next open symbol. Sou, you need to initialize the closingPosition
    variable to zero;
*/

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    /*
        To find the closingPosition, use an overload of the IndexOf method to specify
        that the search  for the matchingSymbol should start at the openingPosition in the
        string:
    */

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally , use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

}