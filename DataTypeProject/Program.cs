// See https://aka.ms/new-console-template for more information
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