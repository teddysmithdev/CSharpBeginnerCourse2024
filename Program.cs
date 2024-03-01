//Counter
for(var i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

string[] favoriteHairMetalBands = ["Van Halen", "Dokken", "Great White"];

for(var i = 0; i < favoriteHairMetalBands.Length; i++)
{
    Console.WriteLine(favoriteHairMetalBands[i]);
}

foreach(var band in favoriteHairMetalBands)
{
    Console.WriteLine(band);
}

favoriteHairMetalBands.ToList().ForEach((i) => {
    Console.WriteLine("ForEach: " + i);
});

Array.ForEach(favoriteHairMetalBands, e => Console.WriteLine("Array.ForEach: " + e));
