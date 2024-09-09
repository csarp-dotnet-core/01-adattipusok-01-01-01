// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

// Egész adattípus
int a = 1, b = 2;
int x; // deklaráció
// hibás: unassigned local variable: Console.WriteLine($"x={x}");
x = 10; // definíció
Console.WriteLine($"x={x}");

//Egyéb egész típusok: byte, sbyte, short, ushort, int, uint, long, ulong
// Byte típus
byte bájt = 250; // Előjel nélküli 8 bites egész szám(0..255)

// Karakter típus
char letter = 'A';             // Egyetlen karakter
char number = '1';             // Karakterként értelmezett szám
char symbol = '#';             // Speciális szimbólum
char unicodeChar = '\u03A9';   // Unicode karakter (Ω)

Console.WriteLine("Betű: " + letter);        // Kimenet: Betű: A
Console.WriteLine("Szám: " + number);        // Kimenet: Szám: 1
Console.WriteLine("Szimbólum: " + symbol);   // Kimenet: Szimbólum: #
Console.WriteLine("Unicode karakter: " + unicodeChar);  // Kimenet: Unicode karakter: Ω

// Valós típusok
float flóath = 6 / 2.3f; // f jelzi, hogy float típus
flóath = (float) 5 / 4; // csak 7 számjegyig képes pontosan számolni.

double dábül = 6 / 2.3; 
dábül = 6 / 2.3D; // 15-17 számjegyig képes pontosan számolni.

decimal decimál = 6 / 2.3M; 
decimál = Convert.ToDecimal(6 / 2.3); // 25-29 számjegyig képes pontosan számolni. 
decimal price = 99.99m;  // m jelzi, hogy decimal típus

// Műveletek egész számokkal
a = 12;
b = 5;

int sum = a + b;         // Összeadás: 15
int difference = a - b;  // Kivonás: 5
int product = a * b;     // Szorzás: 50
int quotient = a / b;    // Osztás: 2
double remainder = a % b;
Console.WriteLine();
Console.WriteLine("Összeg: " + sum);
Console.WriteLine("Különbség: " + difference);
Console.WriteLine("Szorzat: " + product);
Console.WriteLine("Hányados: " + quotient);
Console.WriteLine("Maradék: " + remainder);

// Műveletek valós számokkal
double num1 = 5.5;
double num2 = 3.2;
double s = num1 + num2;
double diff = num1 - num2;
double prod = num1 * num2;
double quot = num1 / num2;
double rem = num1 % num2;
Console.WriteLine();
Console.WriteLine("Összeg: " + s);
Console.WriteLine("Különbség: " + diff);
Console.WriteLine("Szorzat: " + prod);
Console.WriteLine("Hányados: " + quot);
Console.WriteLine("Maradék: " + rem);

string sztring = "szöveg"; //Unicode karakterek összefűzve