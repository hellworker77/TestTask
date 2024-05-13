int start = 10;
int end = 20;
var primesInRange = FindPrimesInRange(start, end);
PrintPrimes(start, end, primesInRange);
static HashSet<int> FindPrimesInRange(int start, int end)
{
    bool[] primes = new bool[end + 1];
    for (int i = 2; i <= end; i++)
    {
        primes[i] = true;
    }
    for (int p = 2; p * p <= end; p++)
    {
        if (primes[p] == true)
        {
            for (int i = p * p; i <= end; i += p)
            {
                primes[i] = false;
            }
        }
    }

    var primesInRange = new HashSet<int>();
    
    for (int i = Math.Max(start, 2); i <= end; i++)
    {
        if (primes[i])
        {
            primesInRange.Add(i);
        }
    }

    return primesInRange;
}

static void PrintPrimes(int start, int end, HashSet<int> primesInRange)
{
    if (primesInRange.Count == 0)
    {
        Console.WriteLine($"Простых чисел в диапазоне [{start};{end}] нет :(");
        return;
    }

    Console.WriteLine($"Простые числа в диапазоне [{start};{end}] ({string.Join(", ",primesInRange)})");
}