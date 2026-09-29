// // Explore integer math
// int a = 18;
// int b = 6;
// int c = a + b;
// Console.WriteLine(c);

// // substraction
// c = a - b;
// Console.WriteLine(c);

// // multiplication
// c = a * b;
// Console.WriteLine(c);

// // division
// c = a / b;
// Console.WriteLine(c);

// // mixing variables and multiple mathematics operations in the same line
// c = a + b - 12 * 17;
// Console.WriteLine(c);

// WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // substraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

// // Explore order of operations
// a = 5;
// b = 4;
// c = 2;
// int d = a + b * c;
// Console.WriteLine(d);

// d = (a + b) * c;
// Console.WriteLine(d);

// d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// Console.WriteLine(d);

// int e = 7;
// int f = 4;
// int g = 3;
// int h = (e + f) / g;
// Console.WriteLine(h);

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

// Explore integer precision and limits
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int intMax = int.MaxValue;
int intMin = int.MinValue;
Console.WriteLine($"The range of integers is {intMin} to {intMax}");

int what = intMax + 3;
Console.WriteLine($"An example of overflow: {what}");

// Work with the double type
double f = 5;
double g = 4;
double h = 2;
double i = (f + g) / h;
Console.WriteLine(i);

f = 19;
g = 23;
h = 8;
i = (f + g) / h;
Console.WriteLine(i);

double doubleMax = double.MaxValue;
double doubleMin = double.MinValue;
Console.WriteLine($"The range of double is {doubleMin} to {doubleMax}");

double third = 1.0 / 3.0;
Console.WriteLine(third);


// Work with decimal types
decimal decimalMin = decimal.MinValue;
decimal decimalMax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decimalMin} to {decimalMax}");

double angka1 = 1.0;
double angka2 = 3.0;
Console.WriteLine(angka1 / angka2);

decimal angka3 = 1.0M;
decimal angka4 = 3.0M;
Console.WriteLine(angka3 / angka4);

double mathPI = 3.14;
double radius = 2.50;
Console.WriteLine(mathPI * radius * radius);

double area = Math.PI * radius * radius;
Console.WriteLine(area);