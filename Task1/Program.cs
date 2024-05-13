for (byte number = byte.MinValue; number < byte.MaxValue; number++)
{
    Console.WriteLine(GetComputerString(number));
}
static string GetComputerString(uint number)
{
    var lastDigit = number % 10;
    var penultimateDigit = (number / 10) % 10;
    if (penultimateDigit != 1)
    {
        switch (lastDigit)
        {
            case 1:
                return $"{number} компьютер";
            case 2:
            case 3:
            case 4:
                return $"{number} компьютера";
        }
    }
    return $"{number} компьютеров";
}