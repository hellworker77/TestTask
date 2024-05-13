PrintMultiplicationTable(5);
static void PrintMultiplicationTable(int size)
{
    Console.Write("  "); 
    for (int i = 1; i <= size; i++)
    {
        Console.Write($"{i,3} "); 
    }
    Console.WriteLine();
    for (int i = 1; i <= size; i++)
    { 
        Console.Write($"{i,2}");
        for (int j = 1; j <= size; j++)
        {
            Console.Write($"{i * j,3} ");
        }
        Console.WriteLine();
    }
}