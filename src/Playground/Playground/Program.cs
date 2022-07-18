// See https://aka.ms/new-console-template for more information



using Playground;

Console.WriteLine("Bitte erste Zahl eingeben:");
var a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Bitte zweite Zahl eingeben:");
var b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Bitte dritte Zahl eingeben:");
var c = int.Parse(Console.ReadLine() ?? "0");

var max = FindBiggestInteger.GetMax_2(a, b, c);
Console.WriteLine($"Die größte Zahl lautet {max}.");





//var itemCount = 7;
//var liste = new int[itemCount];




//liste[0] = a;
//liste[1] = b;
//liste[2] = c;