List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}

// Modify list contents
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names[2..4])
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
Console.WriteLine(names[names.Count - 1]);
Console.WriteLine(names[^2]);

Console.WriteLine($"The list has {names.Count} people in it");

// Search and sort lists
var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}

Console.WriteLine();

// Lists of other types
List<int> fibonacciNumbers = [1, 1];

// var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
// Console.WriteLine(previous);
// var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
// Console.WriteLine(previous2);

// fibonacciNumbers.Add(previous + previous2);
// Console.WriteLine(fibonacciNumbers);

// foreach (var item in fibonacciNumbers)
// {
//     Console.WriteLine(item);
// }

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

var numbers = new List<int> {45, 56, 99, 48, 67, 78};

// not yet sorting
Console.WriteLine();
Console.WriteLine("Not yet sort");
foreach (var number in numbers)
{
    Console.WriteLine($"{number}");
}
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");

Console.WriteLine();
// has done sort
numbers.Sort();
Console.WriteLine("Has done sort");
foreach (var number in numbers)
{
    Console.WriteLine($"{number}");
}
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");