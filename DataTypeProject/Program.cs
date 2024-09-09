// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Egész adattípus
int a = 1, b = 2;
int x; // deklaráció
// hibás: unassigned local variable: Console.WriteLine($"x={x}");
x = 10; // definíció
Console.WriteLine($"x={x}");