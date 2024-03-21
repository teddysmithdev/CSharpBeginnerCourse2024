int? value = null;

string? value2 = "lll";

if (value2 is not null)
{
    Console.WriteLine(value2.Length);
}

Console.WriteLine(value2 ?? "No value!");

Console.WriteLine(value2 is not null ? "Has value!" : "No value");


