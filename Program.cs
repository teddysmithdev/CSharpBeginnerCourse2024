var preHistoricFish = "Cockerellites";

switch (preHistoricFish) 
{
    case "Heliobatis":
        Console.WriteLine("Heliobatis");
        break;
    case "Cockerellites":
        Console.WriteLine("Cockerellites");
        break;
    default:
        Console.WriteLine("This is a default");
        break;
}


var preHistoricFishTwo = "Cockerellites";

var result = preHistoricFishTwo switch
{
    "Heliobatis" => "Heliobatis",
    "Cockerellites" => "Cockerellites",
    _ => "This is a default",
};

Console.WriteLine(result);