while (true)
{
    int maximumNumber, currentNumber = 0, flag = 0, primeCounter = 0;
    Console.Write("Find prime numbers up to what number? ");
    maximumNumber = int.Parse(Console.ReadLine());
    for (currentNumber = 2; currentNumber <= maximumNumber; currentNumber++)
    {
        for (var i = 2; i < currentNumber; i++)
        {
            if (currentNumber % i == 0)
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine(currentNumber);
            primeCounter++;
        }
        flag = 0;
    }
    Console.WriteLine($"Total prime numbers: {primeCounter}");
}