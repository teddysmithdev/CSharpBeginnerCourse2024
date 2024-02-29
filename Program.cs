//Array CRUD

//Create
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

//Read
//Console.WriteLine(favoriteRats);
// foreach(var rat in favoriteRats) 
// {
//     Console.WriteLine(rat);
// }

//Update
//favoriteRats[0] = "Fancy Rat";
// LINQ - "update array linq"

var newFavoriteRats = favoriteRats.Where((e) => e.StartsWith("b"));

foreach(var rat in newFavoriteRats) 
{
    Console.WriteLine(rat);
}

//Delete
//gimme
