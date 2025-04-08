using System;
using System.Collections.Generic;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en_US");

/*
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
Console.WriteLine();

decimal price1 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price1:C} (Save {discount:C})");
Console.WriteLine();

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");
Console.WriteLine();

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
Console.WriteLine();
*/

decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; // inserted
Console.WriteLine(yourDiscount);






