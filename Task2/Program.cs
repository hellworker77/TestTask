int[] numbers = { 42, 12, 18 };
int[] commonDivisors = FindCommonDivisors(numbers);

Console.WriteLine("Общие делители:");
foreach (int divisor in commonDivisors)
{
    Console.WriteLine(divisor);
}
static int[] FindCommonDivisors(int[] numbers)
{
    var commonDivisors = new List<int>();
    
    commonDivisors.AddRange(GetDivisors(numbers[0]));
    
    for (int i = 1; i < numbers.Length; i++)
    {
        var divisors = GetDivisors(numbers[i]);
        commonDivisors = commonDivisors.Intersect(divisors).ToList();
    }
    return commonDivisors.ToArray();
}

static List<int> GetDivisors(int number)
{
    var divisors = new List<int>();
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0 && i != 1)
        {
            divisors.Add(i);
        }
    }
    return divisors;
}