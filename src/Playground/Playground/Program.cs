using Playground;


var loopDetails = new LoopConfig();
loopDetails.StartValue = 5;
loopDetails.EndValue = 15;
int i = 0;


for (int c = 1; c <= 100; c++)
{
    i += c;
    Console.WriteLine(i);
}
