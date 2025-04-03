    string[] myStrings = new string[2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
    int stringsCount = myStrings.Length;

    string myString = "";
    int periodLocation = 0;

    for (int i = 0; i < stringsCount; i++)
    {
        myString = myStrings[i];
        periodLocation = myString.IndexOf(".");

        string mySentece;

        // extract senteces from each string and display them one at a time
        while (periodLocation != -1)
        {
            // first sentence of the string value to the left of the period location
            mySentece = myString.Remove(periodLocation);

            // the remainder of myString is the string value to the right of the location
            myString = myString.Substring(periodLocation + 1);

            // remove any leading white-space from myString
            myString = myString.TrimStart();

            // update the commma location and increment the counter
            periodLocation = myString.IndexOf(".");

            Console.WriteLine(mySentece);
        }

        mySentece = myString.Trim();
        Console.WriteLine(mySentece);
        
    }