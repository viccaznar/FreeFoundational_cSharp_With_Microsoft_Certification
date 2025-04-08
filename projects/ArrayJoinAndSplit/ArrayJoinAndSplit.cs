using System;
using System.Collections.Generic;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}