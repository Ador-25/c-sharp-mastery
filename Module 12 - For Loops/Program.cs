﻿// cant edit in a foreach loop


string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);


// fizzbuzz problem

for(int i = 1; i <= 100; i++)
{
    if(i%3 == 0 && i%5 == 0)
    {
        Console.WriteLine(i+" - FizzBuzz");
    }
    else if ( i%5 is 0)
    {
        Console.WriteLine(i+" - Buzz");
    }
    else if(i%3 is 0)
    {
        Console.WriteLine(i+" - Fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}