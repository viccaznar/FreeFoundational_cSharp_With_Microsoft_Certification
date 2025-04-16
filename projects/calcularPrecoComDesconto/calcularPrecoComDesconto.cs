using System;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

double total =  0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00; 

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountPrice(int itemIdex)
{
    // Calculate th discounted pice of the item
    return items[itemIdex] * (1 - discounts[itemIdex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);

}