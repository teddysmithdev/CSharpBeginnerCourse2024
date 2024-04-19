Person person1 = new("Teddy", "Smith");
Person person2 = new("Teddy", "Smith");

//Shallow Immutabiility
//person1.LastName = "smith";
//person1.PhoneNumbers[0] = "222-2222";

//Equality
//Value - 1. Check the type 2. Check the contents
//Referential - 2. By memory (hex code)
Console.WriteLine(person1 == person2);

//Non-destructive Mutation (Copy)
Person person3 = person2 with { LastName = "Brewski" };
Console.WriteLine(person3.ToString());


public record Person(string FirstName, string LastName);
