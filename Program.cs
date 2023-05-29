//Task 64 

    Console.WriteLine("Add digit n: ");
    int n = int.Parse(Console.ReadLine());
        
    Console.WriteLine("Add digit m: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine($"n={n}, m={m}");

    if (m > n)
        PrintNumbersRecursive(n, m);
       else
        PrintNumbersRecursive(m, n);

        Console.ReadLine();
    

    static void PrintNumbersRecursive(int start, int end)
    {
        Console.WriteLine(start);
    if (start < end)
        PrintNumbersRecursive(start + 1, end);
    }


// Task 66

    int m = InputInt("Add M:");
        int n = InputInt("Add N:");
        Console.WriteLine($"Sum {m} and {n} = {CountNaturalSum(m, n)}");

        Console.ReadLine();
    

    static int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    static int CountNaturalSum(int m, int n)
    {
        if (m == n)
            return n;
        return m + CountNaturalSum(m + 1, n);
    }

    