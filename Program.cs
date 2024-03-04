// if(true)
// {
//     Console.WriteLine("This is true");
// }

// var aquariumFish = "porcupine puffer fish";
// var aquariumFish2 = "clown fish";

// if(aquariumFish.ToLower() == "puffer fish")
// {
//     Console.WriteLine("Buy fish");
// } 
// else if(aquariumFish.ToLower() == "clown fish")
// {
//     Console.WriteLine("Buy fish");
// }
// else
// {
//     Console.WriteLine("Do not buy fish");
// }


var aquariumFish = "porcupine puffer fish";
var fishTankPrice = 1000;

if((aquariumFish == "porcupine puffer fish") && (aquariumFish == "clown fish"))
{
    Console.WriteLine("Buy fish");
}

if(fishTankPrice <= 1000)
{
    Console.WriteLine("Buy tank");
}

if(aquariumFish is string)
{
    Console.WriteLine("aquariumFish is a string");
}
