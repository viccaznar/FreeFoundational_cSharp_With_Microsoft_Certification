Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((coin.Next(0, 2) == 0) ? "Heads" : "Tails");