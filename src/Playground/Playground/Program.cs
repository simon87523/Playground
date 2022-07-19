
using Playground;

//Console.WriteLine("Bitte erste Zahl eingeben:");
//var a = int.Parse(Console.ReadLine() ?? "0");

//Console.WriteLine("Bitte zweite Zahl eingeben:");
//var b = int.Parse(Console.ReadLine() ?? "0");

//Console.WriteLine("Bitte dritte Zahl eingeben:");
//var c = int.Parse(Console.ReadLine() ?? "0");

//var max = FindBiggestInteger.GetMax_2(a, b, c);
//Console.WriteLine($"Die größte Zahl lautet {max}.");



var itemCount = 7;
var liste = new int[itemCount];




//liste[0] = a;
//liste[1] = b;
//liste[2] = c;


//Input
for (int i = 0; i < itemCount; i++)
{
    Console.WriteLine("Bitte Zahl eingeben :");
    int c = int.Parse(Console.ReadLine() ?? "0");
    liste[i] = c;
}

//Output
Console.WriteLine("Liste:");
for (int i = 0; i < itemCount; i++)
{
    Console.WriteLine(liste[i]);
}

var max = FindBiggestInteger.GetMax_3(liste);
Console.WriteLine($"Die größte Zahl lautet {max}.");