int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);


int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = {{-1, -1}, {-1, -1}, {-1, -1}, {-1, -1}, {-1, -1}};
    int count =0;

    for (int curr= 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++
            }
            if (count == result.GetLength(0))
            {
                return result;    
            }
            
        }
    }
    return (count == 0) ? new int[0,0] : result;
}

if(result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}