//CRUD
//Create
using System.Text;

var petFish = "puffer fish";

//Create - Conatentation
petFish = "porcupine " + petFish;

//Create - Template Literal
Console.WriteLine($"In my salt water aquarium, I will have a {petFish}");

//Create - @ Literal
var pathName = @"C:\Users\teddy\OneDrive";

//READ
Console.WriteLine(petFish);

//Update
//petFish[0] = "p" (this is not possible)
Console.WriteLine(petFish.Replace("porcupine", "blue dot"));


//Delete (Not technically a delete but when you are worried about memory do this)
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("red lobster");
Console.WriteLine(newCrustacean);
newCrustacean.Replace("red", "blue");
Console.WriteLine(newCrustacean);








