Random random = new Random();
string[]  ordersIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < ordersIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix
    ordersIDs[i] = prefix + suffix;
}

// Print out each orderID
foreach (var orderID in ordersIDs)
{
    Console.WriteLine(orderID);
}