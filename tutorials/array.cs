var names = new string[] {"Scott", "Ana", "Felipe"};

// names.Add("Damian"); // List<T>

names = [..names, "Damian"];

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}