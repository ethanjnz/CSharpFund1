// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// loop that prints 1 to 255
for (int i = 1; i <= 255; i++)
{
    // Console.WriteLine(i);
}


//loop that prints a random num 5 times
// Random rand = new();
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(rand.Next(10, 20));
// }


// modified loop
Random rand = new();
int sum = 0;
for (int j = 0; j < 5; j++)
{
    sum += rand.Next(10, 20);
}
// Console.WriteLine(sum);

// prints all values from 1 to 100
for (int k = 0; k <= 100; k++)
{
    if (k % 3 == 0 || k % 5 == 0)
    {
        if (k % 3 == 0)
        {
            // Console.WriteLine(k);
        }
        else
        {
            // Console.WriteLine(k);
        }
    }
}


// modified loop
for (int l = 0; l <= 100; l++)
{
    if (l % 3 == 0 || l % 5 == 0)
    {
        if (l % 3 == 0)
        {
            // Console.WriteLine("fizz");
        }
        else
        {
            // Console.WriteLine("buzz");
        }
    }
}

// another modified loop 
for (int m = 1; m <= 100; m++)
{
    if (m % 3 == 0 && m % 5 == 0)
    {
        Console.WriteLine($"FizzBuzz {m}");
    }
    else if (m % 3 == 0 || m % 5 == 0)
    {
        if (m % 3 == 0)
        {
            Console.WriteLine($"fizz {m}");
        }
        else
        {
            Console.WriteLine($"buzz {m}");
        }
    }

}



