// int a = 5;
// int b = 6;
// if (a + b > 10)
//     Console.WriteLine("The answer is greater than 10.");

// // Make if and else work together
// a = 5;
// b = 3;
// if (a + b > 10)
//     Console.WriteLine("The answer is greater than 10");
// else
//     Console.WriteLine("The answer is not greater than 10");

// a = 5;
// b = 3;
// int c = 4;
// if ((a + b + c > 10) && (a == b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// }

// if ((a + b + c > 10) || (a == b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("Or the first number is greater than the second");
// }
// else
// {
//     Console.WriteLine("The answer is not greater than 10");
//     Console.WriteLine("And the first number is not greater than the second");
// }


void ExploreIf()
{
    int a = 5;
    int
    b = 3;
    int c = 4;
    if ((a + b + c > 10) && (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }

    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}

// ExploreIf();

// Use loops to repeat operations

// while loop
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter} using While Loops");
    counter++;
}

// to do while loop
counter = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter} using Do While Loops");
    counter++;
} while (counter < 10);

// Work with the for loop
for (counter = 0; counter < 10; counter++)
{
    Console.WriteLine($"Hello World! The counter is {counter} using For Loops");
}

// Created nested loops
for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}

for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
}

// Finally, nest the columns loop inside the rows to form pairs:
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

Console.WriteLine("The numbers are divisible by 3:");
int sum = 0;
for (int number = 1; number < 20; number++)
{
    if (number % 3 == 0)
    {
        Console.WriteLine(number);
        sum += number;
    }
}

Console.WriteLine($"The sum is {sum}");