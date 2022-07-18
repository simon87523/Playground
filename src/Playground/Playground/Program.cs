using Playground;




// var <Name> = new <Klassenname>();

var loopDetails = new LoopConfig();
loopDetails.StartValue = 5;
loopDetails.EndValue = 15;

// for (<start>; <bedingung>; <nachbehandlung>)
for (var i = loopDetails.StartValue; i <= loopDetails.EndValue; i++)
{
    Console.WriteLine(i);
}